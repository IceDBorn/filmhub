﻿using System;
using System.Drawing;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using filmhub.Controllers;
using filmhub.Controls;
using filmhub.Models;
using filmhub.Properties;

namespace filmhub.Views
{
    public partial class MainPageUserControl : UserControl
    {
        #region Fields

        private int[] _featuredMovies;
        private readonly PictureBox[] _featuredBoxes;
        private readonly PictureBox[] _comingSoonBoxes;
        private int[] _comingSoonMovies;

        private Image _menu;
        private Image _menuHover;
        
        private Image _addMovie;
        private Image _addMovieHover;

        #endregion

        #region Constructor

        public MainPageUserControl()
        {
            InitializeComponent();
            InitializeColors();
            InitializeImages();
            categoriesPanel.Controls.Clear();
            categoriesPanel.Controls.Add(new CategoriesUserControl());
            _featuredBoxes = new[] {featuredImage1, featuredImage2, featuredImage3, featuredImage4, featuredImage5};
            _comingSoonBoxes = new[]
                {comingSoonImage1, comingSoonImage2, comingSoonImage3, comingSoonImage4, comingSoonImage5};
            categoriesPanel.BringToFront();

            var thread = new Thread(LoadMovies);
            thread.Start();
            
            if (Account.GetAccountInstance().Admin)
            {
                addPictureBox.Visible = true;
            }
        }

        #endregion

        #region Methods

        private void InitializeColors()
        {
            featured.ForeColor = Program.Colors.ForeColor;
            comingSoon.ForeColor = Program.Colors.ForeColor;
            BackColor = Program.Colors.BackgroundColor;
            menu.BackColor = Program.Colors.BackgroundColor;
            featuredImage1.BackColor = Program.Colors.BackgroundColor;
            featuredImage2.BackColor = Program.Colors.BackgroundColor;
            featuredImage3.BackColor = Program.Colors.BackgroundColor;
            featuredImage4.BackColor = Program.Colors.BackgroundColor;
            featuredImage5.BackColor = Program.Colors.BackgroundColor;
            comingSoonImage1.BackColor = Program.Colors.BackgroundColor;
            comingSoonImage2.BackColor = Program.Colors.BackgroundColor;
            comingSoonImage3.BackColor = Program.Colors.BackgroundColor;
            comingSoonImage4.BackColor = Program.Colors.BackgroundColor;
            comingSoonImage5.BackColor = Program.Colors.BackgroundColor;
            loadingLabel.ForeColor = Program.Colors.AccentColor;
            loadingLabel.BackColor = Program.Colors.BackgroundColor;
            loadingLabel2.ForeColor = Program.Colors.AccentColor;
            loadingLabel2.BackColor = Program.Colors.BackgroundColor;
        }

        private void InitializeImages()
        {
            _menu = Settings.Default.Theme == 0 ? Resources.menu : Resources.menu_black;
            menu.Image = _menu;
            _menuHover = Resources.menu_hover;

            _addMovie = Settings.Default.Theme == 0 ? Resources.add : Resources.add_black;
            addPictureBox.Image = _addMovie;
            _addMovieHover = Resources.add_hover;
        }

        private void LoadMovies()
        {
            FeaturedMovieSelector();
            ComingSoonMovieSelector();
            InitializePictureBoxTags();
        }

        private static Image DownloadImageFromUrl(string imageUrl)
        {
            Image image;

            try
            {
                var webRequest = (HttpWebRequest) WebRequest.Create(imageUrl);
                webRequest.AllowWriteStreamBuffering = true;
                webRequest.Timeout = 30000;

                var webResponse = webRequest.GetResponse();

                var stream = webResponse.GetResponseStream();

                image = Image.FromStream(stream ?? throw new InvalidOperationException());

                webResponse.Close();
            }
            catch
            {
                return null;
            }

            return image;
        }

        private void FillPictureBoxes(MovieController.Section section, PictureBox[] pictureBoxes)
        {
            if (pictureBoxes == null) throw new ArgumentNullException(nameof(pictureBoxes));
            try
            {
                moviesList.Images.Clear();
                var movies = MovieController.MainPageMovieQuery(section);

                if (section == MovieController.Section.Featured)
                {
                    _featuredMovies = new int[5];
                }
                else
                {
                    _comingSoonMovies = new int[5];
                }

                for (var i = 0; i < movies.Count; i++)
                {
                    if (section == MovieController.Section.Featured)
                    {
                        _featuredMovies[i] = movies[i].Id;
                    }
                    else
                    {
                        _comingSoonMovies[i] = movies[i].Id;
                    }
                    moviesList.Images.Add(DownloadImageFromUrl(movies[i].Picture));
                }

                for (var i = 0; i < moviesList.Images.Count; i++)
                {
                    pictureBoxes[i].Image = moviesList.Images[i];
                    pictureBoxes[i].Tag = 1;
                }
            }
            catch
            {
                CustomMessageBox.Show(@"Something went wrong.");
            }
        }

        private void FeaturedMovieSelector()
        {
            FillPictureBoxes(MovieController.Section.Featured, _featuredBoxes);
            loadingLabel.Visible = false;
        }

        private void ComingSoonMovieSelector()
        {
            FillPictureBoxes(MovieController.Section.ComingSoon, _comingSoonBoxes);
            loadingLabel2.Visible = false;
        }

        private void InitializePictureBoxTags()
        {
            foreach (var tag in _featuredBoxes)
            {
                if (int.Parse(tag.Tag.ToString()) == 0) tag.Cursor = Cursors.Default;
            }

            foreach (var tag in _comingSoonBoxes)
            {
                if (int.Parse(tag.Tag.ToString()) == 0) tag.Cursor = Cursors.Default;
            }
        }

        #endregion

        #region Events

        private void menu_Click(object sender, EventArgs e)
        {
            categoriesPanel.Visible = true;
            Program.MainForm.HideDropDown();
        }

        private void MainPageUserControl_Click(object sender, EventArgs e)
        {
            categoriesPanel.Visible = false;
            Program.MainForm.HideDropDown();
        }


        private void menu_MouseHover(object sender, EventArgs e)
        {
            menu.Image = _menuHover;
            Program.MainForm.HideDropDown();
        }

        private void menu_MouseLeave(object sender, EventArgs e)
        {
            menu.Image = _menu;
            GC.Collect();
        }

        private void featuredImage1_MouseClick(object sender, MouseEventArgs e)
        {
            if (loadingLabel.Visible) return;
            if (_featuredMovies[0] == 0) return;
            Program.MainForm.UserControlSelector(new MovieViewerUserControl(featuredImage1.Image, _featuredMovies[0]),
                true);
            Program.MainForm.HideDropDown();
        }

        private void featuredImage2_MouseClick(object sender, MouseEventArgs e)
        {
            if (loadingLabel.Visible) return;
            if (_featuredMovies[1] == 0) return;
            Program.MainForm.UserControlSelector(new MovieViewerUserControl(featuredImage2.Image, _featuredMovies[1]),
                true);
            Program.MainForm.HideDropDown();
        }

        private void featuredImage3_MouseClick(object sender, MouseEventArgs e)
        {
            if (loadingLabel.Visible) return;
            if (_featuredMovies[2] == 0) return;
            Program.MainForm.UserControlSelector(new MovieViewerUserControl(featuredImage3.Image, _featuredMovies[2]),
                true);
            Program.MainForm.HideDropDown();
        }

        private void featuredImage4_MouseClick(object sender, MouseEventArgs e)
        {
            if (loadingLabel.Visible) return;
            if (_featuredMovies[3] == 0) return;
            Program.MainForm.UserControlSelector(new MovieViewerUserControl(featuredImage4.Image, _featuredMovies[3]),
                true);
            Program.MainForm.HideDropDown();
        }

        private void featuredImage5_MouseClick(object sender, MouseEventArgs e)
        {
            if (loadingLabel.Visible) return;
            if (_featuredMovies[4] == 0) return;
            Program.MainForm.UserControlSelector(new MovieViewerUserControl(featuredImage5.Image, _featuredMovies[4]),
                true);
            Program.MainForm.HideDropDown();
        }

        private void comingSoonImage1_MouseClick(object sender, MouseEventArgs e)
        {
            if (loadingLabel2.Visible) return;
            if (_comingSoonMovies[0] == 0) return;
            Program.MainForm.UserControlSelector(
                new MovieViewerUserControl(comingSoonImage1.Image, _comingSoonMovies[0]),
                true);
            Program.MainForm.HideDropDown();
        }

        private void comingSoonImage2_MouseClick(object sender, MouseEventArgs e)
        {
            if (loadingLabel2.Visible) return;
            if (_comingSoonMovies[1] == 0) return;
            Program.MainForm.UserControlSelector(
                new MovieViewerUserControl(comingSoonImage2.Image, _comingSoonMovies[1]),
                true);
            Program.MainForm.HideDropDown();
        }

        private void comingSoonImage3_MouseClick(object sender, MouseEventArgs e)
        {
            if (loadingLabel2.Visible) return;
            if (_comingSoonMovies[2] == 0) return;
            Program.MainForm.UserControlSelector(
                new MovieViewerUserControl(comingSoonImage3.Image, _comingSoonMovies[2]),
                true);
            Program.MainForm.HideDropDown();
        }

        private void comingSoonImage4_MouseClick(object sender, MouseEventArgs e)
        {
            if (loadingLabel2.Visible) return;
            if (_comingSoonMovies[3] == 0) return;
            Program.MainForm.UserControlSelector(
                new MovieViewerUserControl(comingSoonImage4.Image, _comingSoonMovies[3]),
                true);
            Program.MainForm.HideDropDown();
        }

        private void comingSoonImage5_MouseClick(object sender, MouseEventArgs e)
        {
            if (loadingLabel2.Visible) return;
            if (_comingSoonMovies[4] == 0) return;
            Program.MainForm.UserControlSelector(
                new MovieViewerUserControl(comingSoonImage5.Image, _comingSoonMovies[4]),
                true);
            Program.MainForm.HideDropDown();
        }
        
        private void addPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            Program.MainForm.UserControlSelector(new MovieEditorUserControl(), true);
        }
        
        private void addPictureBox_MouseHover(object sender, EventArgs e)
        {
            addPictureBox.Image = _addMovieHover;
        }

        private void addPictureBox_MouseLeave(object sender, EventArgs e)
        {
            addPictureBox.Image = _addMovie;
        }
        
        private void MainPageUserControl_MouseHover(object sender, EventArgs e)
        {
            Program.MainForm.HideDropDown();
        }

        #endregion
    }
}