using System.ComponentModel;
using filmhub.Controls;

namespace filmhub.Views
{
    partial class SignInUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuPanel = new System.Windows.Forms.Panel();
            this.rememberMeCheckBox = new System.Windows.Forms.CheckBox();
            this.backButton = new System.Windows.Forms.PictureBox();
            this.signUpLabel = new System.Windows.Forms.Label();
            this.newLabel = new System.Windows.Forms.Label();
            this.signInButton = new filmhub.Controls.RoundButton();
            this.passwordTextBox = new filmhub.Controls.RoundTextBox();
            this.usernameTextBox = new filmhub.Controls.RoundTextBox();
            this.signInLabel = new System.Windows.Forms.Label();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.backButton)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuPanel.Controls.Add(this.rememberMeCheckBox);
            this.menuPanel.Controls.Add(this.backButton);
            this.menuPanel.Controls.Add(this.signUpLabel);
            this.menuPanel.Controls.Add(this.newLabel);
            this.menuPanel.Controls.Add(this.signInButton);
            this.menuPanel.Controls.Add(this.passwordTextBox);
            this.menuPanel.Controls.Add(this.usernameTextBox);
            this.menuPanel.Controls.Add(this.signInLabel);
            this.menuPanel.Location = new System.Drawing.Point(376, 38);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(532, 522);
            this.menuPanel.TabIndex = 0;
            // 
            // rememberMeCheckBox
            // 
            this.rememberMeCheckBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.rememberMeCheckBox.ForeColor = System.Drawing.Color.White;
            this.rememberMeCheckBox.Location = new System.Drawing.Point(55, 384);
            this.rememberMeCheckBox.Name = "rememberMeCheckBox";
            this.rememberMeCheckBox.Size = new System.Drawing.Size(170, 50);
            this.rememberMeCheckBox.TabIndex = 12;
            this.rememberMeCheckBox.Text = "Remember me";
            this.rememberMeCheckBox.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.Image = global::filmhub.Properties.Resources.back;
            this.backButton.Location = new System.Drawing.Point(55, 49);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(27, 47);
            this.backButton.TabIndex = 11;
            this.backButton.TabStop = false;
            this.backButton.Click += new System.EventHandler(this.homeButton_Click);
            this.backButton.MouseLeave += new System.EventHandler(this.backButton_MouseLeave);
            this.backButton.MouseHover += new System.EventHandler(this.backButton_MouseHover);
            // 
            // signUpLabel
            // 
            this.signUpLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.signUpLabel.ForeColor = System.Drawing.Color.White;
            this.signUpLabel.Location = new System.Drawing.Point(274, 449);
            this.signUpLabel.Name = "signUpLabel";
            this.signUpLabel.Size = new System.Drawing.Size(130, 33);
            this.signUpLabel.TabIndex = 6;
            this.signUpLabel.Text = "Sign up now";
            this.signUpLabel.Click += new System.EventHandler(this.signUpLabel_Click);
            this.signUpLabel.MouseLeave += new System.EventHandler(this.signUpLabel_MouseLeave);
            this.signUpLabel.MouseHover += new System.EventHandler(this.signUpLabel_MouseHover);
            // 
            // newLabel
            // 
            this.newLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.newLabel.Location = new System.Drawing.Point(115, 449);
            this.newLabel.Name = "newLabel";
            this.newLabel.Size = new System.Drawing.Size(172, 33);
            this.newLabel.TabIndex = 5;
            this.newLabel.Text = "New to FilmHub?";
            // 
            // signInButton
            // 
            this.signInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signInButton.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.signInButton.ForeColor = System.Drawing.Color.White;
            this.signInButton.Location = new System.Drawing.Point(55, 305);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(413, 56);
            this.signInButton.TabIndex = 3;
            this.signInButton.TabStop = false;
            this.signInButton.Text = "Sign in";
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.passwordTextBox.Location = new System.Drawing.Point(55, 220);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(413, 43);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.TabStop = false;
            this.passwordTextBox.Text = " Password";
            this.passwordTextBox.Enter += new System.EventHandler(this.passwordTextBox_Enter);
            this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTextBox_KeyDown);
            this.passwordTextBox.Leave += new System.EventHandler(this.passwordTextBox_Leave);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameTextBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.usernameTextBox.Location = new System.Drawing.Point(55, 149);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(413, 43);
            this.usernameTextBox.TabIndex = 1;
            this.usernameTextBox.TabStop = false;
            this.usernameTextBox.Text = " Username";
            this.usernameTextBox.Enter += new System.EventHandler(this.usernameTextBox_Enter);
            this.usernameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.usernameTextBox_KeyDown);
            this.usernameTextBox.Leave += new System.EventHandler(this.usernameTextBox_Leave);
            // 
            // signInLabel
            // 
            this.signInLabel.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.signInLabel.ForeColor = System.Drawing.Color.White;
            this.signInLabel.Location = new System.Drawing.Point(0, 38);
            this.signInLabel.Name = "signInLabel";
            this.signInLabel.Size = new System.Drawing.Size(532, 58);
            this.signInLabel.TabIndex = 0;
            this.signInLabel.Text = "Sign In";
            this.signInLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SignInUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::filmhub.Properties.Resources.background;
            this.Controls.Add(this.menuPanel);
            this.DoubleBuffered = true;
            this.Name = "SignInUserControl";
            this.Size = new System.Drawing.Size(1264, 595);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.backButton)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.CheckBox rememberMeCheckBox;

        private System.Windows.Forms.PictureBox backButton;

        private RoundTextBox passwordTextBox;

        private System.Windows.Forms.Label signUpLabel;

        private System.Windows.Forms.Label newLabel;
        
        private RoundButton signInButton;

        private RoundTextBox usernameTextBox;

        private System.Windows.Forms.Label signInLabel;
        
        private System.Windows.Forms.Panel menuPanel;

        #endregion
    }
}