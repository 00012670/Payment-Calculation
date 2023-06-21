using FunPro_CW1_12670.DAL;
using System;
using System.Windows.Forms;

namespace FunPro_CW1_12670
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
