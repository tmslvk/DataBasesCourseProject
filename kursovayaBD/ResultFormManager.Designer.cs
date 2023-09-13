namespace kursovayaBD
{
    partial class ResultFormManager
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.advertiseKursovayaDataSet = new kursovayaBD.advertiseKursovayaDataSet();
            this.resultOfWorkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resultOfWorkTableAdapter = new kursovayaBD.advertiseKursovayaDataSetTableAdapters.resultOfWorkTableAdapter();
            this.tableAdapterManager = new kursovayaBD.advertiseKursovayaDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.advertiseKursovayaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultOfWorkBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "kursovayaBD.ReportOfWork.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1094, 619);
            this.reportViewer1.TabIndex = 5;
            // 
            // advertiseKursovayaDataSet
            // 
            this.advertiseKursovayaDataSet.DataSetName = "advertiseKursovayaDataSet";
            this.advertiseKursovayaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resultOfWorkBindingSource
            // 
            this.resultOfWorkBindingSource.DataMember = "resultOfWork";
            this.resultOfWorkBindingSource.DataSource = this.advertiseKursovayaDataSet;
            // 
            // resultOfWorkTableAdapter
            // 
            this.resultOfWorkTableAdapter.ClearBeforeFill = true;
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
            // ResultFormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 651);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ResultFormManager";
            this.Text = "ResultFormManager";
            this.Load += new System.EventHandler(this.ResultFormManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.advertiseKursovayaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultOfWorkBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private advertiseKursovayaDataSet advertiseKursovayaDataSet;
        private System.Windows.Forms.BindingSource resultOfWorkBindingSource;
        private advertiseKursovayaDataSetTableAdapters.resultOfWorkTableAdapter resultOfWorkTableAdapter;
        private advertiseKursovayaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}