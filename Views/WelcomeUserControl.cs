using System;
using System.Windows.Forms;

namespace filmhub.Views
{
    public partial class WelcomeUserControl : UserControl
    {
        #region Constructor

        public WelcomeUserControl()
        {
            InitializeComponent();
            InitializeColors();
        }

        #endregion
        
        #region Methods

        private void InitializeColors()
        {
            joinButton.BackColor = Program.Colors.AccentColor;
            joinButton.FlatAppearance.BorderColor = Program.Colors.AccentColor;
            signInButton.BackColor = Program.Colors.AccentColor;
            signInButton.FlatAppearance.BorderColor = Program.Colors.AccentColor;
        }

        #endregion

        #region Events

        private void joinButton_Click(object sender, EventArgs e)
        {
            Program.MainForm.UserControlSelector(new SignUpUserControl(), false);
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            Program.MainForm.UserControlSelector(new SignInUserControl(), false);
        }

        #endregion
    }
}