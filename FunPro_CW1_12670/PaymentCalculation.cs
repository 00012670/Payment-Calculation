using FunPro_CW1_12670.DAL;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FunPro_CW1_12670
{
    public partial class PaymentCalculation : Form
    {
        public Payment Payment { get; private set; }

        public PaymentCalculation()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            dgvPayment.DataMember = "";
            dgvPayment.DataSource = null;
            dgvPayment.DataSource = new WorkerList().Search(nudRegion.Value.ToString(), ByAttribute.Region);

        }

        private void NewPayment_Load(object sender, EventArgs e)
        {
            MdiParent = MyForms.GetForm<ParentForm>();
            Payment = new Payment();
            dtpMonth.Format = DateTimePickerFormat.Custom;
            dtpMonth.CustomFormat = "yyyy-MM-dd";
            Payment.Date = new DateTime(dtpMonth.Value.Year, dtpMonth.Value.Month, 1);
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            {
                var workers = new WorkerManager().GetAll().Where(t => t.Region == nudRegion.Value).ToList();

                dgvPayment.DataSource = workers;
                decimal hours = 0;
                int NumberOfElements = dgvPayment.Rows.Count;
                int[] sum = new int[NumberOfElements];

                for (int i = 0; i < dgvPayment.Rows.Count; i++)
                {
                    hours += Convert.ToDecimal(dgvPayment.Rows[i].Cells[3].Value);
                    sum[i] = (Convert.ToInt32(hours));
                }

                lblTotalHours.Text = hours.ToString(); //Counting the total number of hours


                var hoursPaid = 0;

                for (var i = 0; i < dgvPayment.Rows.Count; i++)
                {
                    hoursPaid = Convert.ToInt32(Convert.ToDecimal(dgvPayment.Rows[i].Cells[3].Value) * (nudLimit.Value / hours));
                    dgvPayment.Rows[i].Cells[4].Value = hoursPaid;

                    //Calculation of paid hours for each employee
                }

                var extraHours = 0;

                for (var i = 0; i < dgvPayment.Rows.Count; i++)
                {
                    extraHours = Convert.ToInt32(Convert.ToDecimal(dgvPayment.Rows[i].Cells[3].Value) - (Convert.ToDecimal(dgvPayment.Rows[i].Cells[4].Value)));
                    dgvPayment.Rows[i].Cells[5].Value = extraHours;

                    //Calculation of extra hours for each worker
                }

                var totalHoursPaid = 0;

                for (var i = 0; i < dgvPayment.Rows.Count; i++)
                {
                    totalHoursPaid += Convert.ToInt32(dgvPayment.Rows[i].Cells[4].Value);
                    sum[i] = (Convert.ToInt32(totalHoursPaid));
                }

                lblToalHoursPaid.Text = totalHoursPaid.ToString(); //Counting the total number of paid hours
            }
        }

        public void UpdatingWorkers()
        {
            for (int i = 0; i < dgvPayment.Rows.Count; i++)
            {

                dgvPayment.Rows[i].Cells[3].Value = dgvPayment.Rows[i].Cells[5].Value;
                dgvPayment.Rows[i].Cells[4].Value = 0;
                dgvPayment.Rows[i].Cells[5].Value = 0;
                var c = (Worker)dgvPayment.Rows[i].DataBoundItem;
                new WorkerEditForm().UpdateWorker(c);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ValidatingMessage();
            var manager = new PaymentManager();
            manager.Create(Payment);
            UpdatingWorkers();
            Close();

            //Save data
        }

        private void ValidatingMessage()
        {
            var payments = new PaymentList().GetAllPayments().Where(p => p.Region == nudRegion.Value).ToList();
            foreach (Payment p in payments)
            {
                if (p.Date.Month == dtpMonth.Value.Month && p.Date.Year == dtpMonth.Value.Year)
                {
                    MessageBox.Show("In this month you already have payment for this region");
                    return;
                }
            }

            //Validalidation for duplicate region and month 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}



 


