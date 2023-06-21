using System;
using System.Windows.Forms;

namespace FunPro_CW1_12670
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new AboutForm();
            form.ShowDialog();
        }

        private void allWorkersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyForms.GetForm<WorkerListForm>().Show();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new WorkerEditForm();
            form.CreateNewWorker();
        }

        private void newPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyForms.GetForm<PaymentCalculation>().Show();
        }
    }
}
