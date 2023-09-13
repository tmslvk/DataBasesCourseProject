namespace kursovayaBD
{
    partial class AdvertiseAgencyResult
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
            this.advertiseKursovayaDataSet = new kursovayaBD.advertiseKursovayaDataSet();
            this.agencyResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agencyResultTableAdapter = new kursovayaBD.advertiseKursovayaDataSetTableAdapters.agencyResultTableAdapter();
            this.tableAdapterManager = new kursovayaBD.advertiseKursovayaDataSetTableAdapters.TableAdapterManager();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.advertiseKursovayaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agencyResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // advertiseKursovayaDataSet
            // 
            this.advertiseKursovayaDataSet.DataSetName = "advertiseKursovayaDataSet";
            this.advertiseKursovayaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agencyResultBindingSource
            // 
            this.agencyResultBindingSource.DataMember = "agencyResult";
            this.agencyResultBindingSource.DataSource = this.advertiseKursovayaDataSet;
            // 
            // agencyResultTableAdapter
            // 
            this.agencyResultTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.adServicesTableAdapter = null;
            this.tableAdapterManager.audit_logTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.customerTableAdapter = null;
            this.tableAdapterManager.managerTableAdapter = null;
            this.tableAdapterManager.ordersTableAdapter = null;
            this.tableAdapterManager.placeOfAdvertisementTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = kursovayaBD.advertiseKursovayaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "kursovayaBD.AgencyRerport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1085, 629);
            this.reportViewer1.TabIndex = 0;
            // 
            // AdvertiseAgencyResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 653);
            this.Controls.Add(this.reportViewer1);
            this.Name = "AdvertiseAgencyResult";
            this.Text = "AdvertiseAgencyResult";
            this.Load += new System.EventHandler(this.AdvertiseAgencyResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.advertiseKursovayaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agencyResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private advertiseKursovayaDataSet advertiseKursovayaDataSet;
        private System.Windows.Forms.BindingSource agencyResultBindingSource;
        private advertiseKursovayaDataSetTableAdapters.agencyResultTableAdapter agencyResultTableAdapter;
        private advertiseKursovayaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}