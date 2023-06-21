using FunPro_CW1_12670.DAL;
using System;
using System.Windows.Forms;

namespace FunPro_CW1_12670
{
    public partial class WorkerListForm : Form
    {
        public WorkerListForm()
        {
            InitializeComponent();
        }

        private void WorkerListForm_Load(object sender, EventArgs e)
        {
            MdiParent = MyForms.GetForm<ParentForm>();
            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            dgv.DataMember = "";
            dgv.DataSource = null;
            dgv.DataSource = new WorkerList().GetAllWorkers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new WorkerEditForm().CreateNewWorker();

            //Adding new data
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0) //if no row selected
                MessageBox.Show("Please select a worker");
            else
            {
                var c = (Worker)dgv.SelectedRows[0].DataBoundItem;
                new WorkerEditForm().UpdateWorker(c);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0) //if no row selected
                MessageBox.Show("Please select a worker");
            else
            {
                var c = (Worker)dgv.SelectedRows[0].DataBoundItem;
                new WorkerManager().Delete(c.Id); //deleting the selected row
                LoadData();
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (cbxSort.SelectedIndex < 0)
                MessageBox.Show("Select an attribute to sort by");
            else
            {
                dgv.DataMember = "";
                dgv.DataSource = null;
                dgv.DataSource = new WorkerList().Sort(ByAttribute.Hours);
            }

            //Sorting by hours
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbxSearch.SelectedIndex < 0)
                MessageBox.Show("Select an attribute to search by");
            else if (string.IsNullOrWhiteSpace(tbxSearch.Text))
                MessageBox.Show("Provide the search term");
            else
            {
                var selectedAttribute = cbxSearch.SelectedIndex == 0 ? ByAttribute.Name : ByAttribute.Hours;

                dgv.DataMember = "";
                dgv.DataSource = null;
                dgv.DataSource = new WorkerList().Search(tbxSearch.Text, selectedAttribute);
            }

            //Searching by Name
        }
    }
}