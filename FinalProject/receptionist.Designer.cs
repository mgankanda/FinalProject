namespace FinalProject
{
    partial class Receptionist
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
            this.textSearch = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.applicantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.passport_dbDataSet = new FinalProject.passport_dbDataSet();
            this.applicantTableAdapter = new FinalProject.passport_dbDataSetTableAdapters.ApplicantTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.passport_dbDataSet4 = new FinalProject.passport_dbDataSet4();
            this.applicantBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.applicantTableAdapter1 = new FinalProject.passport_dbDataSet4TableAdapters.ApplicantTableAdapter();
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
            this.applicantBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.passport_dbDataSet5 = new FinalProject.passport_dbDataSet5();
            this.applicantTableAdapter2 = new FinalProject.passport_dbDataSet5TableAdapters.ApplicantTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.applicantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passport_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passport_dbDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicantBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicantBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passport_dbDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(934, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(12, 72);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(192, 26);
            this.textSearch.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(241, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Search Applicant";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // applicantBindingSource
            // 
            this.applicantBindingSource.DataMember = "Applicant";
            this.applicantBindingSource.DataSource = this.passport_dbDataSet;
            // 
            // passport_dbDataSet
            // 
            this.passport_dbDataSet.DataSetName = "passport_dbDataSet";
            this.passport_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // applicantTableAdapter
            // 
            this.applicantTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(494, 69);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 33);
            this.button3.TabIndex = 4;
            this.button3.Text = "View All Appoitment";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // passport_dbDataSet4
            // 
            this.passport_dbDataSet4.DataSetName = "passport_dbDataSet4";
            this.passport_dbDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // applicantBindingSource1
            // 
            this.applicantBindingSource1.DataMember = "Applicant";
            this.applicantBindingSource1.DataSource = this.passport_dbDataSet4;
            // 
            // applicantTableAdapter1
            // 
            this.applicantTableAdapter1.ClearBeforeFill = true;
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
            this.dataGridView1.DataSource = this.applicantBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(41, 236);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1010, 352);
            this.dataGridView1.TabIndex = 5;
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
            // applicantBindingSource2
            // 
            this.applicantBindingSource2.DataMember = "Applicant";
            this.applicantBindingSource2.DataSource = this.passport_dbDataSet5;
            // 
            // passport_dbDataSet5
            // 
            this.passport_dbDataSet5.DataSetName = "passport_dbDataSet5";
            this.passport_dbDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // applicantTableAdapter2
            // 
            this.applicantTableAdapter2.ClearBeforeFill = true;
            // 
            // Receptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 627);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.button1);
            this.Name = "Receptionist";
            this.Text = "receptionist";
            this.Load += new System.EventHandler(this.Receptionist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.applicantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passport_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passport_dbDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicantBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicantBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passport_dbDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button button2;
        private passport_dbDataSet passport_dbDataSet;
        private System.Windows.Forms.BindingSource applicantBindingSource;
        private passport_dbDataSetTableAdapters.ApplicantTableAdapter applicantTableAdapter;
        private System.Windows.Forms.Button button3;
        private passport_dbDataSet4 passport_dbDataSet4;
        private System.Windows.Forms.BindingSource applicantBindingSource1;
        private passport_dbDataSet4TableAdapters.ApplicantTableAdapter applicantTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private passport_dbDataSet5 passport_dbDataSet5;
        private System.Windows.Forms.BindingSource applicantBindingSource2;
        private passport_dbDataSet5TableAdapters.ApplicantTableAdapter applicantTableAdapter2;
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
    }
}