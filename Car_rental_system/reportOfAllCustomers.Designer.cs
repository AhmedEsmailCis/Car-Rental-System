namespace Car_rental_system
{
    partial class reportOfAllCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reportOfAllCustomers));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.UsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetForCustomer = new Car_rental_system.DataSetForCustomer();
            this.button2 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.UsersTableAdapter = new Car_rental_system.DataSetForCustomerTableAdapters.UsersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.UsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetForCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // UsersBindingSource
            // 
            this.UsersBindingSource.DataMember = "Users";
            this.UsersBindingSource.DataSource = this.DataSetForCustomer;
            // 
            // DataSetForCustomer
            // 
            this.DataSetForCustomer.DataSetName = "DataSetForCustomer";
            this.DataSetForCustomer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(362, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 34);
            this.button2.TabIndex = 14;
            this.button2.Text = "Cancle";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.UsersBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Car_rental_system.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(793, 366);
            this.reportViewer1.TabIndex = 15;
            // 
            // UsersTableAdapter
            // 
            this.UsersTableAdapter.ClearBeforeFill = true;
            // 
            // reportOfAllCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(817, 430);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "reportOfAllCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "reportOfAllCustomers";
            this.Load += new System.EventHandler(this.reportOfAllCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetForCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource UsersBindingSource;
        private DataSetForCustomer DataSetForCustomer;
        private DataSetForCustomerTableAdapters.UsersTableAdapter UsersTableAdapter;
    }
}