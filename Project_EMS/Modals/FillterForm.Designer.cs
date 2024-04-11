namespace Project_EMS.Modals
{
    partial class FillterForm
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
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton2 = new MetroFramework.Controls.MetroRadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.PlaceOfBirthComboBox = new MetroFramework.Controls.MetroComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GraduationYearCombobox = new MetroFramework.Controls.MetroComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.label2 = new System.Windows.Forms.Label();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.appTextBox2 = new Project_EMS.UC.AppTextBox();
            this.appTextBox1 = new Project_EMS.UC.AppTextBox();
            this.SuspendLayout();
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.AutoSize = true;
            this.metroRadioButton1.Location = new System.Drawing.Point(507, 167);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(53, 17);
            this.metroRadioButton1.TabIndex = 0;
            this.metroRadioButton1.Text = "Male";
            this.metroRadioButton1.UseSelectable = true;
            // 
            // metroRadioButton2
            // 
            this.metroRadioButton2.AutoSize = true;
            this.metroRadioButton2.Location = new System.Drawing.Point(507, 203);
            this.metroRadioButton2.Name = "metroRadioButton2";
            this.metroRadioButton2.Size = new System.Drawing.Size(65, 17);
            this.metroRadioButton2.TabIndex = 1;
            this.metroRadioButton2.Text = "Female";
            this.metroRadioButton2.UseSelectable = true;
            this.metroRadioButton2.CheckedChanged += new System.EventHandler(this.metroRadioButton2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.label1.Location = new System.Drawing.Point(502, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Genre";
            // 
            // PlaceOfBirthComboBox
            // 
            this.PlaceOfBirthComboBox.FormattingEnabled = true;
            this.PlaceOfBirthComboBox.ItemHeight = 24;
            this.PlaceOfBirthComboBox.Location = new System.Drawing.Point(260, 166);
            this.PlaceOfBirthComboBox.Name = "PlaceOfBirthComboBox";
            this.PlaceOfBirthComboBox.Size = new System.Drawing.Size(200, 30);
            this.PlaceOfBirthComboBox.TabIndex = 5;
            this.PlaceOfBirthComboBox.UseSelectable = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.label3.Location = new System.Drawing.Point(255, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Place of birth";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.label4.Location = new System.Drawing.Point(7, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Contract Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.label6.Location = new System.Drawing.Point(255, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Graduation year";
            // 
            // GraduationYearCombobox
            // 
            this.GraduationYearCombobox.FormattingEnabled = true;
            this.GraduationYearCombobox.ItemHeight = 24;
            this.GraduationYearCombobox.Location = new System.Drawing.Point(260, 295);
            this.GraduationYearCombobox.Name = "GraduationYearCombobox";
            this.GraduationYearCombobox.Size = new System.Drawing.Size(200, 30);
            this.GraduationYearCombobox.TabIndex = 11;
            this.GraduationYearCombobox.UseSelectable = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.label5.Location = new System.Drawing.Point(7, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Address";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(13, 405);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 30);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(447, 30);
            this.metroDateTime1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.label2.Location = new System.Drawing.Point(8, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Birthday";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(335, 522);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(108, 40);
            this.metroButton1.TabIndex = 15;
            this.metroButton1.Text = "Close";
            this.metroButton1.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.metroButton2.ForeColor = System.Drawing.Color.White;
            this.metroButton2.Location = new System.Drawing.Point(465, 522);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(108, 40);
            this.metroButton2.TabIndex = 16;
            this.metroButton2.Text = "Fillter";
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseCustomForeColor = true;
            this.metroButton2.UseSelectable = true;
            // 
            // appTextBox2
            // 
            this.appTextBox2.BackColor = System.Drawing.SystemColors.Control;
            this.appTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.appTextBox2.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.appTextBox2.BorderRadius = 8;
            this.appTextBox2.BorderSize = 2;
            this.appTextBox2.Location = new System.Drawing.Point(12, 166);
            this.appTextBox2.Multiline = false;
            this.appTextBox2.Name = "appTextBox2";
            this.appTextBox2.Padding = new System.Windows.Forms.Padding(7);
            this.appTextBox2.PasswordChar = false;
            this.appTextBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.appTextBox2.PlaceholderText = "fill Address";
            this.appTextBox2.Size = new System.Drawing.Size(211, 31);
            this.appTextBox2.TabIndex = 9;
            this.appTextBox2.Texts = "";
            this.appTextBox2.UnderlinedStyle = false;
            // 
            // appTextBox1
            // 
            this.appTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.appTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.appTextBox1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.appTextBox1.BorderRadius = 8;
            this.appTextBox1.BorderSize = 2;
            this.appTextBox1.Location = new System.Drawing.Point(12, 294);
            this.appTextBox1.Multiline = false;
            this.appTextBox1.Name = "appTextBox1";
            this.appTextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.appTextBox1.PasswordChar = false;
            this.appTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.appTextBox1.PlaceholderText = "fill phone number";
            this.appTextBox1.Size = new System.Drawing.Size(211, 31);
            this.appTextBox1.TabIndex = 7;
            this.appTextBox1.Texts = "";
            this.appTextBox1.UnderlinedStyle = false;
            // 
            // FillterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 585);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.metroRadioButton2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroRadioButton1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GraduationYearCombobox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.appTextBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.appTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PlaceOfBirthComboBox);
            this.Name = "FillterForm";
            this.Text = "Fillter";
            this.Load += new System.EventHandler(this.FillterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox PlaceOfBirthComboBox;
        private System.Windows.Forms.Label label3;
        private UC.AppTextBox appTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroComboBox GraduationYearCombobox;
        private UC.AppTextBox appTextBox2;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}