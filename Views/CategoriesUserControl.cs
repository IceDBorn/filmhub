﻿using System;
using System.Windows.Forms;

namespace filmhub.Views
{
    public partial class CategoriesUserControl : UserControl
    {
        public CategoriesUserControl()
        {
            InitializeComponent();
            InitializeColors();
        }

        #region Methods

        private void InitializeColors()
        {
            BackColor = Program.Colors.BackgroundColor;
            categoriesPanel.BackColor = Program.Colors.PopOutBackgroundColor;
            categoriesLabel.ForeColor = Program.Colors.ForeColor;
            actionLabel.ForeColor = Program.Colors.ForeColor;
            comedyLabel.ForeColor = Program.Colors.ForeColor;
            crimeLabel.ForeColor = Program.Colors.ForeColor;
            documentaryLabel.ForeColor = Program.Colors.ForeColor;
            dramaLabel.ForeColor = Program.Colors.ForeColor;
            fantasyLabel.ForeColor = Program.Colors.ForeColor;
            horrorLabel.ForeColor = Program.Colors.ForeColor;
            mysteryLabel.ForeColor = Program.Colors.ForeColor;
            romanceLabel.ForeColor = Program.Colors.ForeColor;
            scifiLabel.ForeColor = Program.Colors.ForeColor;
            westernLabel.ForeColor = Program.Colors.ForeColor;
        }

        #endregion

        #region Events

        private void actionLabel_MouseHover(object sender, EventArgs e)
        {
            actionLabel.ForeColor = Program.Colors.AccentColor;
        }

        private void actionLabel_MouseLeave(object sender, EventArgs e)
        {
            actionLabel.ForeColor = Program.Colors.ForeColor;
        }

        private void actionLabel_Click(object sender, EventArgs e)
        {
            Program.MainForm.UserControlSelector(
                new ListUserControl(actionLabel.Text, true, 1, "No action movies found"), true);
        }

        private void comedyLabel_MouseHover(object sender, EventArgs e)
        {
            comedyLabel.ForeColor = Program.Colors.AccentColor;
        }

        private void comedyLabel_MouseLeave(object sender, EventArgs e)
        {
            comedyLabel.ForeColor = Program.Colors.ForeColor;
        }

        private void comedyLabel_Click(object sender, EventArgs e)
        {
            Program.MainForm.UserControlSelector(
                new ListUserControl(comedyLabel.Text, true, 2, "No comedy movies found"), true);
        }

        private void crimeLabel_MouseHover(object sender, EventArgs e)
        {
            crimeLabel.ForeColor = Program.Colors.AccentColor;
        }

        private void crimeLabel_MouseLeave(object sender, EventArgs e)
        {
            crimeLabel.ForeColor = Program.Colors.ForeColor;
        }

        private void crimeLabel_Click(object sender, EventArgs e)
        {
            Program.MainForm.UserControlSelector(
                new ListUserControl(crimeLabel.Text, true, 3, "No crime movies found"), true);
        }

        private void documentaryLabel_MouseHover(object sender, EventArgs e)
        {
            documentaryLabel.ForeColor = Program.Colors.AccentColor;
        }

        private void documentaryLabel_MouseLeave(object sender, EventArgs e)
        {
            documentaryLabel.ForeColor = Program.Colors.ForeColor;
        }

        private void documentaryLabel_Click(object sender, EventArgs e)
        {
            Program.MainForm.UserControlSelector(
                new ListUserControl(documentaryLabel.Text, true, 4, "No documentaries found"), true);
        }

        private void dramaLabel_MouseHover(object sender, EventArgs e)
        {
            dramaLabel.ForeColor = Program.Colors.AccentColor;
        }

        private void dramaLabel_MouseLeave(object sender, EventArgs e)
        {
            dramaLabel.ForeColor = Program.Colors.ForeColor;
        }

        private void dramaLabel_Click(object sender, EventArgs e)
        {
            Program.MainForm.UserControlSelector(
                new ListUserControl(dramaLabel.Text, true, 5, "No drama movies found"), true);
        }

        private void fantasyLabel_MouseHover(object sender, EventArgs e)
        {
            fantasyLabel.ForeColor = Program.Colors.AccentColor;
        }

        private void fantasyLabel_MouseLeave(object sender, EventArgs e)
        {
            fantasyLabel.ForeColor = Program.Colors.ForeColor;
        }

        private void fantasyLabel_Click(object sender, EventArgs e)
        {
            Program.MainForm.UserControlSelector(
                new ListUserControl(fantasyLabel.Text, true, 6, "No fantasy movies found"), true);
        }

        private void horrorLabel_MouseHover(object sender, EventArgs e)
        {
            horrorLabel.ForeColor = Program.Colors.AccentColor;
        }

        private void horrorLabel_MouseLeave(object sender, EventArgs e)
        {
            horrorLabel.ForeColor = Program.Colors.ForeColor;
        }

        private void horrorLabel_Click(object sender, EventArgs e)
        {
            Program.MainForm.UserControlSelector(
                new ListUserControl(horrorLabel.Text, true, 7, "No horror movies found"), true);
        }

        private void mysteryLabel_MouseHover(object sender, EventArgs e)
        {
            mysteryLabel.ForeColor = Program.Colors.AccentColor;
        }

        private void mysteryLabel_MouseLeave(object sender, EventArgs e)
        {
            mysteryLabel.ForeColor = Program.Colors.ForeColor;
        }

        private void mysteryLabel_Click(object sender, EventArgs e)
        {
            Program.MainForm.UserControlSelector(
                new ListUserControl(mysteryLabel.Text, true, 8, "No mystery movies found"), true);
        }

        private void romanceLabel_MouseHover(object sender, EventArgs e)
        {
            romanceLabel.ForeColor = Program.Colors.AccentColor;
        }

        private void romanceLabel_MouseLeave(object sender, EventArgs e)
        {
            romanceLabel.ForeColor = Program.Colors.ForeColor;
        }

        private void romanceLabel_Click(object sender, EventArgs e)
        {
            Program.MainForm.UserControlSelector(
                new ListUserControl(romanceLabel.Text, true, 9, "No romance movies found"), true);
        }

        private void scifiLabel_MouseHover(object sender, EventArgs e)
        {
            scifiLabel.ForeColor = Program.Colors.AccentColor;
        }

        private void scifiLabel_MouseLeave(object sender, EventArgs e)
        {
            scifiLabel.ForeColor = Program.Colors.ForeColor;
        }

        private void scifiLabel_Click(object sender, EventArgs e)
        {
            Program.MainForm.UserControlSelector(
                new ListUserControl(scifiLabel.Text, true, 10, "No sci-fi movies found"), true);
        }

        private void westernLabel_MouseHover(object sender, EventArgs e)
        {
            westernLabel.ForeColor = Program.Colors.AccentColor;
        }

        private void westernLabel_MouseLeave(object sender, EventArgs e)
        {
            westernLabel.ForeColor = Program.Colors.ForeColor;
        }

        private void westernLabel_Click(object sender, EventArgs e)
        {
            Program.MainForm.UserControlSelector(
                new ListUserControl(westernLabel.Text, true, 11, "No western movies found"), true);
        }
        
        private void categoriesPanel_MouseHover(object sender, EventArgs e)
        {
            Program.MainForm.HideDropDown();
        }

        #endregion
    }
}