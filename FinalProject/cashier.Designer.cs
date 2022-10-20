namespace FinalProject
{
    partial class cashier
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.applicantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.passport_dbDataSet1 = new FinalProject.passport_dbDataSet1();
            this.applicantTableAdapter = new FinalProject.passport_dbDataSet1TableAdapters.ApplicantTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nicnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.districtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicetypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.haspaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicantBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.passport_dbDataSet6 = new FinalProject.passport_dbDataSet6();
            this.applicantTableAdapter1 = new FinalProject.passport_dbDataSet6TableAdapters.ApplicantTableAdapter();
            this.btnViewUnpaidApplicants = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblIDNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.applicantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passport_dbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicantBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passport_dbDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(658, 21);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "LogOut";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 21);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(191, 8);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 27);
            this.button2.TabIndex = 2;
            this.button2.Text = "search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // applicantBindingSource
            // 
            this.applicantBindingSource.DataMember = "Applicant";
            this.applicantBindingSource.DataSource = this.passport_dbDataSet1;
            // 
            // passport_dbDataSet1
            // 
            this.passport_dbDataSet1.DataSetName = "passport_dbDataSet1";
            this.passport_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // applicantTableAdapter
            // 
            this.applicantTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 51);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "View All Applicant ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nicnumberDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.phonenumberDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.districtDataGridViewTextBoxColumn,
            this.servicetypeDataGridViewTextBoxColumn,
            this.haspaidDataGridViewTextBoxColumn,
            this.receiptnumberDataGridViewTextBoxColumn,
            this.appointmentdateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.applicantBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(45, 141);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(641, 207);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // nicnumberDataGridViewTextBoxColumn
            // 
            this.nicnumberDataGridViewTextBoxColumn.DataPropertyName = "nic_number";
            this.nicnumberDataGridViewTextBoxColumn.HeaderText = "nic_number";
            this.nicnumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nicnumberDataGridViewTextBoxColumn.Name = "nicnumberDataGridViewTextBoxColumn";
            this.nicnumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            this.phonenumberDataGridViewTextBoxColumn.DataPropertyName = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.HeaderText = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            this.phonenumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address ";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address ";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 150;
            // 
            // districtDataGridViewTextBoxColumn
            // 
            this.districtDataGridViewTextBoxColumn.DataPropertyName = "district";
            this.districtDataGridViewTextBoxColumn.HeaderText = "district";
            this.districtDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.districtDataGridViewTextBoxColumn.Name = "districtDataGridViewTextBoxColumn";
            this.districtDataGridViewTextBoxColumn.Width = 150;
            // 
            // servicetypeDataGridViewTextBoxColumn
            // 
            this.servicetypeDataGridViewTextBoxColumn.DataPropertyName = "service_type";
            this.servicetypeDataGridViewTextBoxColumn.HeaderText = "service_type";
            this.servicetypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.servicetypeDataGridViewTextBoxColumn.Name = "servicetypeDataGridViewTextBoxColumn";
            this.servicetypeDataGridViewTextBoxColumn.Width = 150;
            // 
            // haspaidDataGridViewTextBoxColumn
            // 
            this.haspaidDataGridViewTextBoxColumn.DataPropertyName = "has_paid";
            this.haspaidDataGridViewTextBoxColumn.HeaderText = "has_paid";
            this.haspaidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.haspaidDataGridViewTextBoxColumn.Name = "haspaidDataGridViewTextBoxColumn";
            this.haspaidDataGridViewTextBoxColumn.Width = 150;
            // 
            // receiptnumberDataGridViewTextBoxColumn
            // 
            this.receiptnumberDataGridViewTextBoxColumn.DataPropertyName = "receipt_number";
            this.receiptnumberDataGridViewTextBoxColumn.HeaderText = "receipt_number";
            this.receiptnumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.receiptnumberDataGridViewTextBoxColumn.Name = "receiptnumberDataGridViewTextBoxColumn";
            this.receiptnumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // appointmentdateDataGridViewTextBoxColumn
            // 
            this.appointmentdateDataGridViewTextBoxColumn.DataPropertyName = "appointment_date";
            this.appointmentdateDataGridViewTextBoxColumn.HeaderText = "appointment_date";
            this.appointmentdateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.appointmentdateDataGridViewTextBoxColumn.Name = "appointmentdateDataGridViewTextBoxColumn";
            this.appointmentdateDataGridViewTextBoxColumn.Width = 150;
            // 
            // applicantBindingSource1
            // 
            this.applicantBindingSource1.DataMember = "Applicant";
            this.applicantBindingSource1.DataSource = this.passport_dbDataSet6;
            // 
            // passport_dbDataSet6
            // 
            this.passport_dbDataSet6.DataSetName = "passport_dbDataSet6";
            this.passport_dbDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // applicantTableAdapter1
            // 
            this.applicantTableAdapter1.ClearBeforeFill = true;
            // 
            // btnViewUnpaidApplicants
            // 
            this.btnViewUnpaidApplicants.Location = new System.Drawing.Point(160, 49);
            this.btnViewUnpaidApplicants.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewUnpaidApplicants.Name = "btnViewUnpaidApplicants";
            this.btnViewUnpaidApplicants.Size = new System.Drawing.Size(134, 25);
            this.btnViewUnpaidApplicants.TabIndex = 7;
            this.btnViewUnpaidApplicants.Text = "View Unpaid Applicants";
            this.btnViewUnpaidApplicants.UseVisualStyleBackColor = true;
            this.btnViewUnpaidApplicants.Click += new System.EventHandler(this.btnViewUnpaidApplicants_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(543, 103);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(90, 25);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Mark as Paid";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblIDNumber
            // 
            this.lblIDNumber.AutoSize = true;
            this.lblIDNumber.Location = new System.Drawing.Point(448, 103);
            this.lblIDNumber.Name = "lblIDNumber";
            this.lblIDNumber.Size = new System.Drawing.Size(0, 13);
            this.lblIDNumber.TabIndex = 10;
            // 
            // cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 384);
            this.Controls.Add(this.lblIDNumber);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnViewUnpaidApplicants);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "cashier";
            this.Text = "cashier";
            this.Load += new System.EventHandler(this.cashier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.applicantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passport_dbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicantBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passport_dbDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private passport_dbDataSet1 passport_dbDataSet1;
        private System.Windows.Forms.BindingSource applicantBindingSource;
        private passport_dbDataSet1TableAdapters.ApplicantTableAdapter applicantTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private passport_dbDataSet6 passport_dbDataSet6;
        private System.Windows.Forms.BindingSource applicantBindingSource1;
        private passport_dbDataSet6TableAdapters.ApplicantTableAdapter applicantTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nicnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn districtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicetypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn haspaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiptnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnViewUnpaidApplicants;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblIDNumber;
    }
}