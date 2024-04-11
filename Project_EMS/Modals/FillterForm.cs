using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_EMS.Modals
{
    public partial class FillterForm : MetroFramework.Forms.MetroForm
    {   
        public FillterForm()
        {
            InitializeComponent();
        }

        private void FillterForm_Load(object sender, EventArgs e)
        {
           PlaceOfBirthComboBox.DataSource =  new List<string>()
           {
               "Hồ Chí Minh",
               "Hà Nội",
           };
           GraduationYearCombobox.DataSource = new List<string>()
           {
               "2012",
               "2013",
               "2014",
               "2015",
               "2016",
               "2017",
               "2018",
               "2019",
               "2020",
               "2021",
               "2022",
               "2023",
               "2024",
           };
        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
