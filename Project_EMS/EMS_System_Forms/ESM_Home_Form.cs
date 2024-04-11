using MetroFramework;
using Project_EMS.Modals;
using Project_EMS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_EMS.EMS_System_Forms
{
    public partial class ESM_Home_Form : MetroFramework.Forms.MetroForm
    {
        List<Profile> list_Student = new List<Profile>();
        public ESM_Home_Form()
        {
            InitializeComponent();
        }

        private void ESM_Home_Form_Load(object sender, EventArgs e)
        {
            YearComboBox.DataSource = new List<string>()
            {
                "2018",
                "2019",
                "2020",
                "2021",
                "2022",
                "2023",
            };
            //list_Student.Add();
            ListProfileGrid.DataSource = list_Student;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTile7_Click(object sender, EventArgs e)
        {

        }

        private void metroTabPage3_Click(object sender, EventArgs e)
        {

        }

        private void metroGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void YearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            AddProfile addProfileForm = new AddProfile();
            addProfileForm.ShowDialog();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
           
        }

        private void metroButton5_Click_1(object sender, EventArgs e)
        {
            AddAdmissionsPeriodForm addAdmissionsForm = new AddAdmissionsPeriodForm();
            addAdmissionsForm.ShowDialog();
        }
    }
}
