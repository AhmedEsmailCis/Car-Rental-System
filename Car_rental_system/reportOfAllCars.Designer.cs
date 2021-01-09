namespace Car_rental_system
{
    partial class reportOfAllCars
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reportOfAllCars));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.button2 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetForCars = new Car_rental_system.DataSetForCars();
            this.TypesOfCarsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TypesOfCarsTableAdapter = new Car_rental_system.DataSetForCarsTableAdapters.TypesOfCarsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetForCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypesOfCarsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(355, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 34);
            this.button2.TabIndex = 15;
            this.button2.Text = "Cancle";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TypesOfCarsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Car_rental_system.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(793, 366);
            this.reportViewer1.TabIndex = 16;
            // 
            // DataSetForCars
            // 
            this.DataSetForCars.DataSetName = "DataSetForCars";
            this.DataSetForCars.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TypesOfCarsBindingSource
            // 
            this.TypesOfCarsBindingSource.DataMember = "TypesOfCars";
            this.TypesOfCarsBindingSource.DataSource = this.DataSetForCars;
            // 
            // TypesOfCarsTableAdapter
            // 
            this.TypesOfCarsTableAdapter.ClearBeforeFill = true;
            // 
            // reportOfAllCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(817, 430);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "reportOfAllCars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "reportOfAllCars";
            this.Load += new System.EventHandler(this.reportOfAllCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetForCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypesOfCarsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TypesOfCarsBindingSource;
        private DataSetForCars DataSetForCars;
        private DataSetForCarsTableAdapters.TypesOfCarsTableAdapter TypesOfCarsTableAdapter;
    }
}