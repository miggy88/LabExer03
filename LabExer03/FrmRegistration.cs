using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabExer03
{
    public partial class FrmRegistration: Form
    {

        private string _FullName;
        private int _Age;
        private long _ContactNo;
        private long _StudentNo;

        public object ListOfPrograms { get; private set; }

        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void OrganizationProfile_Load(object sender, EventArgs e)
        {
            string[] ListOfProgram = new string[]
            {

                "BS Information Technology",
                "BS Computer Science",
                "BS in Accountancy",
                "BS in Hospitality Management",
                "BS in Tourism Management",
                "BS in Information System"
            };





                for (int i = 0; i < 6; i++)
            {
                cbPrograms.Items.Add(ListOfProgram[i].ToString());
            }

        }







        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
