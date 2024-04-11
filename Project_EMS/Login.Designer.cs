namespace Project_EMS
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.LoginPassTextBox = new Project_EMS.UC.AppTextBox();
            this.LoginAccTextBox = new Project_EMS.UC.AppTextBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.UsernameTextBox = new Project_EMS.UC.AppTextBox();
            this.PasswordTextBox = new Project_EMS.UC.AppTextBox();
            this.AccountTextBox = new Project_EMS.UC.AppTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.metroPanel1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroTabControl1);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.label1);
            this.metroPanel1.Controls.Add(this.pictureBox1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(431, 590);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(14, 207);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(358, 351);
            this.metroTabControl1.TabIndex = 6;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroButton1);
            this.metroTabPage1.Controls.Add(this.LoginPassTextBox);
            this.metroTabPage1.Controls.Add(this.LoginAccTextBox);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(350, 309);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Login";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroButton1
            // 
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.Location = new System.Drawing.Point(108, 180);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(157, 59);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Login";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // LoginPassTextBox
            // 
            this.LoginPassTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.LoginPassTextBox.BorderColor = System.Drawing.Color.DimGray;
            this.LoginPassTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.LoginPassTextBox.BorderRadius = 0;
            this.LoginPassTextBox.BorderSize = 2;
            this.LoginPassTextBox.Location = new System.Drawing.Point(-4, 107);
            this.LoginPassTextBox.Multiline = false;
            this.LoginPassTextBox.Name = "LoginPassTextBox";
            this.LoginPassTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.LoginPassTextBox.PasswordChar = false;
            this.LoginPassTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.LoginPassTextBox.PlaceholderText = "password";
            this.LoginPassTextBox.Size = new System.Drawing.Size(358, 31);
            this.LoginPassTextBox.TabIndex = 3;
            this.LoginPassTextBox.Texts = "";
            this.LoginPassTextBox.UnderlinedStyle = true;
            // 
            // LoginAccTextBox
            // 
            this.LoginAccTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.LoginAccTextBox.BorderColor = System.Drawing.Color.DimGray;
            this.LoginAccTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.LoginAccTextBox.BorderRadius = 0;
            this.LoginAccTextBox.BorderSize = 2;
            this.LoginAccTextBox.Location = new System.Drawing.Point(0, 31);
            this.LoginAccTextBox.Multiline = false;
            this.LoginAccTextBox.Name = "LoginAccTextBox";
            this.LoginAccTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.LoginAccTextBox.PasswordChar = false;
            this.LoginAccTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.LoginAccTextBox.PlaceholderText = "Account";
            this.LoginAccTextBox.Size = new System.Drawing.Size(347, 31);
            this.LoginAccTextBox.TabIndex = 2;
            this.LoginAccTextBox.Texts = "";
            this.LoginAccTextBox.UnderlinedStyle = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroButton2);
            this.metroTabPage2.Controls.Add(this.UsernameTextBox);
            this.metroTabPage2.Controls.Add(this.PasswordTextBox);
            this.metroTabPage2.Controls.Add(this.AccountTextBox);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(350, 309);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Register";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroButton2
            // 
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton2.Location = new System.Drawing.Point(91, 228);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(157, 59);
            this.metroButton2.TabIndex = 7;
            this.metroButton2.Text = "Register";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.UsernameTextBox.BorderColor = System.Drawing.Color.DimGray;
            this.UsernameTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.UsernameTextBox.BorderRadius = 0;
            this.UsernameTextBox.BorderSize = 2;
            this.UsernameTextBox.Location = new System.Drawing.Point(-4, 175);
            this.UsernameTextBox.Multiline = false;
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.UsernameTextBox.PasswordChar = false;
            this.UsernameTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.UsernameTextBox.PlaceholderText = "User Name";
            this.UsernameTextBox.Size = new System.Drawing.Size(358, 31);
            this.UsernameTextBox.TabIndex = 6;
            this.UsernameTextBox.Texts = "";
            this.UsernameTextBox.UnderlinedStyle = true;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.PasswordTextBox.BorderColor = System.Drawing.Color.DimGray;
            this.PasswordTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.PasswordTextBox.BorderRadius = 0;
            this.PasswordTextBox.BorderSize = 2;
            this.PasswordTextBox.Location = new System.Drawing.Point(-4, 107);
            this.PasswordTextBox.Multiline = false;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.PasswordTextBox.PasswordChar = false;
            this.PasswordTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.PasswordTextBox.PlaceholderText = "password";
            this.PasswordTextBox.Size = new System.Drawing.Size(358, 31);
            this.PasswordTextBox.TabIndex = 5;
            this.PasswordTextBox.Texts = "";
            this.PasswordTextBox.UnderlinedStyle = true;
            // 
            // AccountTextBox
            // 
            this.AccountTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.AccountTextBox.BorderColor = System.Drawing.Color.DimGray;
            this.AccountTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.AccountTextBox.BorderRadius = 0;
            this.AccountTextBox.BorderSize = 2;
            this.AccountTextBox.Location = new System.Drawing.Point(0, 31);
            this.AccountTextBox.Multiline = false;
            this.AccountTextBox.Name = "AccountTextBox";
            this.AccountTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.AccountTextBox.PasswordChar = false;
            this.AccountTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.AccountTextBox.PlaceholderText = "Account";
            this.AccountTextBox.Size = new System.Drawing.Size(354, 31);
            this.AccountTextBox.TabIndex = 4;
            this.AccountTextBox.Texts = "";
            this.AccountTextBox.UnderlinedStyle = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(65, 191);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(0, 0);
            this.metroLabel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(51, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enrollment management System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Project_EMS.Properties.Resources.logo_Uef;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(431, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.pictureBox2);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(392, 60);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(1008, 590);
            this.metroPanel2.TabIndex = 1;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::Project_EMS.Properties.Resources.login_bg;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1008, 590);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 650);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private UC.AppTextBox LoginPassTextBox;
        private UC.AppTextBox LoginAccTextBox;
        private UC.AppTextBox UsernameTextBox;
        private UC.AppTextBox PasswordTextBox;
        private UC.AppTextBox AccountTextBox;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}

