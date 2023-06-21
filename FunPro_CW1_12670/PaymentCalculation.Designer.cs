
namespace FunPro_CW1_12670
{
    partial class PaymentCalculation
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
            this.components = new System.ComponentModel.Container();
            this.lblRegion = new System.Windows.Forms.Label();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.nudRegion = new System.Windows.Forms.NumericUpDown();
            this.nudLimit = new System.Windows.Forms.NumericUpDown();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblPaid = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblToalHoursPaid = new System.Windows.Forms.Label();
            this.dgvPayment = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoursPaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpMonth = new System.Windows.Forms.DateTimePicker();
            this.lblTotalHours = new System.Windows.Forms.Label();
            this.lblHous = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudRegion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(50, 28);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(120, 20);
            this.lblRegion.TabIndex = 0;
            this.lblRegion.Text = "Region Number";
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(43, 137);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(331, 41);
            this.btnLoadData.TabIndex = 1;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // nudRegion
            // 
            this.nudRegion.Location = new System.Drawing.Point(176, 22);
            this.nudRegion.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudRegion.Name = "nudRegion";
            this.nudRegion.Size = new System.Drawing.Size(200, 26);
            this.nudRegion.TabIndex = 3;
            // 
            // nudLimit
            // 
            this.nudLimit.Location = new System.Drawing.Point(174, 99);
            this.nudLimit.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudLimit.Name = "nudLimit";
            this.nudLimit.Size = new System.Drawing.Size(200, 26);
            this.nudLimit.TabIndex = 5;
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(50, 99);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(89, 20);
            this.lblHours.TabIndex = 4;
            this.lblHours.Text = "Hours Limit";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(50, 65);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(54, 20);
            this.lblMonth.TabIndex = 7;
            this.lblMonth.Text = "Month";
            // 
            // lblPaid
            // 
            this.lblPaid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPaid.AutoSize = true;
            this.lblPaid.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaid.Location = new System.Drawing.Point(37, 561);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(216, 31);
            this.lblPaid.TabIndex = 8;
            this.lblPaid.Text = "Total Hours Paid :";
            this.lblPaid.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(789, 555);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 37);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(907, 555);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 37);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblToalHoursPaid
            // 
            this.lblToalHoursPaid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblToalHoursPaid.AutoSize = true;
            this.lblToalHoursPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblToalHoursPaid.Location = new System.Drawing.Point(253, 563);
            this.lblToalHoursPaid.Name = "lblToalHoursPaid";
            this.lblToalHoursPaid.Size = new System.Drawing.Size(0, 29);
            this.lblToalHoursPaid.TabIndex = 11;
            this.lblToalHoursPaid.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // dgvPayment
            // 
            this.dgvPayment.AllowUserToAddRows = false;
            this.dgvPayment.AllowUserToDeleteRows = false;
            this.dgvPayment.AutoGenerateColumns = false;
            this.dgvPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.regionDataGridViewTextBoxColumn,
            this.hoursDataGridViewTextBoxColumn,
            this.hoursPaidDataGridViewTextBoxColumn,
            this.extraHoursDataGridViewTextBoxColumn});
            this.dgvPayment.DataSource = this.workerBindingSource;
            this.dgvPayment.Location = new System.Drawing.Point(43, 207);
            this.dgvPayment.Name = "dgvPayment";
            this.dgvPayment.ReadOnly = true;
            this.dgvPayment.RowHeadersWidth = 62;
            this.dgvPayment.RowTemplate.Height = 28;
            this.dgvPayment.Size = new System.Drawing.Size(964, 256);
            this.dgvPayment.TabIndex = 12;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // regionDataGridViewTextBoxColumn
            // 
            this.regionDataGridViewTextBoxColumn.DataPropertyName = "Region";
            this.regionDataGridViewTextBoxColumn.HeaderText = "Region";
            this.regionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.regionDataGridViewTextBoxColumn.Name = "regionDataGridViewTextBoxColumn";
            this.regionDataGridViewTextBoxColumn.ReadOnly = true;
            this.regionDataGridViewTextBoxColumn.Width = 150;
            // 
            // hoursDataGridViewTextBoxColumn
            // 
            this.hoursDataGridViewTextBoxColumn.DataPropertyName = "Hours";
            this.hoursDataGridViewTextBoxColumn.HeaderText = "Hours";
            this.hoursDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hoursDataGridViewTextBoxColumn.Name = "hoursDataGridViewTextBoxColumn";
            this.hoursDataGridViewTextBoxColumn.ReadOnly = true;
            this.hoursDataGridViewTextBoxColumn.Width = 150;
            // 
            // hoursPaidDataGridViewTextBoxColumn
            // 
            this.hoursPaidDataGridViewTextBoxColumn.DataPropertyName = "HoursPaid";
            this.hoursPaidDataGridViewTextBoxColumn.HeaderText = "Hours Paid";
            this.hoursPaidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hoursPaidDataGridViewTextBoxColumn.Name = "hoursPaidDataGridViewTextBoxColumn";
            this.hoursPaidDataGridViewTextBoxColumn.ReadOnly = true;
            this.hoursPaidDataGridViewTextBoxColumn.Width = 150;
            // 
            // extraHoursDataGridViewTextBoxColumn
            // 
            this.extraHoursDataGridViewTextBoxColumn.DataPropertyName = "ExtraHours";
            this.extraHoursDataGridViewTextBoxColumn.HeaderText = "Extra Hours";
            this.extraHoursDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.extraHoursDataGridViewTextBoxColumn.Name = "extraHoursDataGridViewTextBoxColumn";
            this.extraHoursDataGridViewTextBoxColumn.ReadOnly = true;
            this.extraHoursDataGridViewTextBoxColumn.Width = 150;
            // 
            // workerBindingSource
            // 
            this.workerBindingSource.DataSource = typeof(FunPro_CW1_12670.DAL.Worker);
            // 
            // dtpMonth
            // 
            this.dtpMonth.Location = new System.Drawing.Point(174, 60);
            this.dtpMonth.Name = "dtpMonth";
            this.dtpMonth.Size = new System.Drawing.Size(200, 26);
            this.dtpMonth.TabIndex = 13;
            // 
            // lblTotalHours
            // 
            this.lblTotalHours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalHours.AutoSize = true;
            this.lblTotalHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalHours.Location = new System.Drawing.Point(197, 515);
            this.lblTotalHours.Name = "lblTotalHours";
            this.lblTotalHours.Size = new System.Drawing.Size(0, 29);
            this.lblTotalHours.TabIndex = 15;
            this.lblTotalHours.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblHous
            // 
            this.lblHous.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHous.AutoSize = true;
            this.lblHous.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHous.Location = new System.Drawing.Point(37, 515);
            this.lblHous.Name = "lblHous";
            this.lblHous.Size = new System.Drawing.Size(160, 31);
            this.lblHous.TabIndex = 14;
            this.lblHous.Text = "Total Hours :";
            this.lblHous.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(548, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 16;
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // PaymentCalculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 615);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotalHours);
            this.Controls.Add(this.lblHous);
            this.Controls.Add(this.dtpMonth);
            this.Controls.Add(this.dgvPayment);
            this.Controls.Add(this.lblToalHoursPaid);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblPaid);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.nudLimit);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.nudRegion);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.lblRegion);
            this.Name = "PaymentCalculation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payments";
            this.Load += new System.EventHandler(this.NewPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudRegion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.NumericUpDown nudRegion;
        private System.Windows.Forms.NumericUpDown nudLimit;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblToalHoursPaid;
        private System.Windows.Forms.DataGridView dgvPayment;
        private System.Windows.Forms.BindingSource workerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoursPaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dtpMonth;
        private System.Windows.Forms.Label lblTotalHours;
        private System.Windows.Forms.Label lblHous;
        private System.Windows.Forms.Label label1;
    }
}