using FunPro_CW1_12670.DAL;
using System;
using System.Windows.Forms;

namespace FunPro_CW1_12670
{
    public partial class WorkerEditForm : Form
    {
        public WorkerEditForm()
        {
            InitializeComponent();
        }

        public Worker Worker { get; set; }

        public FormMode Mode { get; set; }

        public void CreateNewWorker()
        {
            Mode = FormMode.CreateNew;
            Worker = new Worker();
            InitializeControls();
            MdiParent = MyForms.GetForm<ParentForm>();
            Show();
        }

        public void UpdateWorker(Worker worker)
        {
            Mode = FormMode.Update;
            Worker = worker;
            InitializeControls();
            ShowWorkerInControls();
            MdiParent = MyForms.GetForm<ParentForm>();
            Show();
        }

        private void InitializeControls()
        {
        }

        private void ShowWorkerInControls()
        {
            tbxName.Text = Worker.Name;
            nudRegion.Value = Worker.Region;
            nudHours.Value = Worker.Hours;
            //nudRate.DecimalPlaces = Worker.Rate;
        }

        private void GrabUserInput()
        {
            Worker.Name = tbxName.Text;
            Worker.Region = (Int32)nudRegion.Value;
            Worker.Hours = (Int32)nudHours.Value;
            //Worker.Rate = nudRate.DecimalPlaces;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {           
            Close();

            //Closing the form
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                GrabUserInput();
                var manager = new WorkerManager();
                if (Mode == FormMode.CreateNew)
                    manager.Create(Worker);
                else
                    manager.Update(Worker);

                MyForms.GetForm<WorkerListForm>().LoadData();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Save data
        }
    }
}
