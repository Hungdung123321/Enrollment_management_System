namespace Project_EMS.Modals
{
    partial class AddAdmissionsPeriodForm
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
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PlaceOfBirthComboBox = new MetroFramework.Controls.MetroComboBox();
            this.appTextBox2 = new Project_EMS.UC.AppTextBox();
            this.appTextBox1 = new Project_EMS.UC.AppTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.metroButton2.ForeColor = System.Drawing.Color.White;
            this.metroButton2.Location = new System.Drawing.Point(570, 301);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(108, 40);
            this.metroButton2.TabIndex = 31;
            this.metroButton2.Text = "+Add";
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseCustomForeColor = true;
            this.metroButton2.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(440, 301);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(108, 40);
            this.metroButton1.TabIndex = 30;
            this.metroButton1.Text = "Close";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.label5.Location = new System.Drawing.Point(176, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Number of enrollment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.label3.Location = new System.Drawing.Point(424, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Place of birth";
            // 
            // PlaceOfBirthComboBox
            // 
            this.PlaceOfBirthComboBox.FormattingEnabled = true;
            this.PlaceOfBirthComboBox.ItemHeight = 24;
            this.PlaceOfBirthComboBox.Location = new System.Drawing.Point(429, 173);
            this.PlaceOfBirthComboBox.Name = "PlaceOfBirthComboBox";
            this.PlaceOfBirthComboBox.Size = new System.Drawing.Size(200, 30);
            this.PlaceOfBirthComboBox.TabIndex = 20;
            this.PlaceOfBirthComboBox.UseSelectable = true;
            // 
            // appTextBox2
            // 
            this.appTextBox2.BackColor = System.Drawing.SystemColors.Control;
            this.appTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.appTextBox2.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.appTextBox2.BorderRadius = 8;
            this.appTextBox2.BorderSize = 2;
            this.appTextBox2.Location = new System.Drawing.Point(181, 173);
            this.appTextBox2.Multiline = false;
            this.appTextBox2.Name = "appTextBox2";
            this.appTextBox2.Padding = new System.Windows.Forms.Padding(7);
            this.appTextBox2.PasswordChar = false;
            this.appTextBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.appTextBox2.PlaceholderText = "fill Number of enrollment";
            this.appTextBox2.Size = new System.Drawing.Size(211, 31);
            this.appTextBox2.TabIndex = 24;
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
            this.appTextBox1.Location = new System.Drawing.Point(181, 301);
            this.appTextBox1.Multiline = false;
            this.appTextBox1.Name = "appTextBox1";
            this.appTextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.appTextBox1.PasswordChar = false;
            this.appTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.appTextBox1.PlaceholderText = "fill Benmark";
            this.appTextBox1.Size = new System.Drawing.Size(211, 31);
            this.appTextBox1.TabIndex = 22;
            this.appTextBox1.Texts = "";
            this.appTextBox1.UnderlinedStyle = false;
            this.appTextBox1.Load += new System.EventHandler(this.appTextBox1_Load);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.label4.Location = new System.Drawing.Point(176, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Benmark";
            // 
            // AddAdmissionsPeriodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 452);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.appTextBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.appTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PlaceOfBirthComboBox);
            this.Name = "AddAdmissionsPeriodForm";
            this.Text = "Add period";
            this.Load += new System.EventHandler(this.AddAdmissionsPeriodForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.Label label5;
        private UC.AppTextBox appTextBox2;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroComboBox PlaceOfBirthComboBox;
        private UC.AppTextBox appTextBox1;
        private System.Windows.Forms.Label label4;
    }
}