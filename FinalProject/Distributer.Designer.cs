﻿namespace FinalProject
{
    partial class Distributer
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
            this.applicantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.passport_dbDataSet2 = new FinalProject.passport_dbDataSet2();
            this.applicantTableAdapter = new FinalProject.passport_dbDataSet2TableAdapters.ApplicantTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.applicantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passport_dbDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1010, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "LogOut";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // applicantBindingSource
            // 
            this.applicantBindingSource.DataMember = "Applicant";
            this.applicantBindingSource.DataSource = this.passport_dbDataSet2;
            // 
            // passport_dbDataSet2
            // 
            this.passport_dbDataSet2.DataSetName = "passport_dbDataSet2";
            this.passport_dbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // applicantTableAdapter
            // 
            this.applicantTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 26);
            this.textBox1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(237, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 43);
            this.button2.TabIndex = 3;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(24, 107);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(181, 43);
            this.button3.TabIndex = 4;
            this.button3.Text = "View All Applicant";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(490, 61);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(163, 41);
            this.button4.TabIndex = 5;
            this.button4.Text = "Ready To Ship";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Distributer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 581);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Distributer";
            this.Text = "Distributer";
            this.Load += new System.EventHandler(this.Distributer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.applicantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passport_dbDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private passport_dbDataSet2 passport_dbDataSet2;
        private System.Windows.Forms.BindingSource applicantBindingSource;
        private passport_dbDataSet2TableAdapters.ApplicantTableAdapter applicantTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}