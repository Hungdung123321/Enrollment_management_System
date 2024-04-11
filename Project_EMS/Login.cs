using Hanssens.Net;
using Newtonsoft.Json.Linq;
using Project_EMS.EMS_System_Forms;
using Project_EMS.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_EMS
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {

        List<Account> Accounts = new List<Account>();

        public Login()
        {
            InitializeComponent();
        }
                    
        private void Form1_Load(object sender, EventArgs e)
        {
            Accounts.Add(new Account()
            {
                Acc = "admin1",
                Pass = "123",
                Username = "Admin1",
                Role = Global.Role.admin
            });
            Accounts.Add(new Account()
            {
                Acc = "student1",
                Pass = "123",
                Username = "Dung",
                Role = Global.Role.student
            });
            Accounts.Add(new Account()
            {
                Acc = "admission1",
                Pass = "123",
                Username = "admission1",
                Role = Global.Role.admission
            });
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void appTextBox1__TextChanged(object sender, EventArgs e)
        {
           
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
             if (UsernameTextBox.Texts != "" ||
                 AccountTextBox.Texts != "" ||
                 PasswordTextBox.Texts != "")
            {
                if (!Accounts.Any(prod => prod.Acc == AccountTextBox.Texts && prod.Pass == PasswordTextBox.Texts))
                {
                    Accounts.Add(new Account()
                    {
                        Acc = AccountTextBox.Texts,
                        Pass = PasswordTextBox.Texts,
                        Username = UsernameTextBox.Texts,
                        Role = Global.Role.student
                    });
                    MessageBox.Show("Register success");
                }
                else
                {
                    MessageBox.Show("Register fail");
                }
                
            }
            else if (UsernameTextBox.Texts == "")
            {
                MessageBox.Show("pls fill user name");
            }
            else if (AccountTextBox.Texts == "")
            {
                MessageBox.Show("pls fill Account");
            }
            else if (PasswordTextBox.Texts == "")
            {
                MessageBox.Show("pls fill password");
            }
        }
        private void metroButton1_Click(object sender, EventArgs e)    
        {
            Account account = Accounts.Find(prod => prod.Acc == LoginAccTextBox.Texts && prod.Pass == LoginPassTextBox.Texts);
            if (account != null)
            {
                switch (account.Role)
                {
                    case Global.Role.admission:
                        ESM_Home_Form AdmissionForm = new ESM_Home_Form();
                        AdmissionForm.Show();
                        Hide();
                        break;
                    case Global.Role.admin:
                        ESM_Home_Form_Admin AdminForm = new ESM_Home_Form_Admin();
                        AdminForm.Show();
                        Hide();
                        break;
                    case Global.Role.student:
                        ESM_Home_Form_Student StudentForm = new ESM_Home_Form_Student();
                        StudentForm.Show();
                        Hide();
                        break;
                }
            }
            else
            {
                MessageBox.Show("invail account");
            }
        }
    }
}
