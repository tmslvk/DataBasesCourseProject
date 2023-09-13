namespace kursovayaBD
{
    partial class managerReportForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.managerOrderBox = new System.Windows.Forms.ComboBox();
            this.advertiseKursovayaDataSet = new kursovayaBD.advertiseKursovayaDataSet();
            this.viewGetOrderForManagersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewGetOrderForManagersTableAdapter1 = new kursovayaBD.advertiseKursovayaDataSetTableAdapters.viewGetOrderForManagersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.advertiseKursovayaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewGetOrderForManagersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "kursovayaBD.ManagerReportOrder.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(15, 36);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1075, 579);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Просмотреть по номеру заказа";
            // 
            // managerOrderBox
            // 
            this.managerOrderBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.managerOrderBox.FormattingEnabled = true;
            this.managerOrderBox.Location = new System.Drawing.Point(233, 6);
            this.managerOrderBox.Name = "managerOrderBox";
            this.managerOrderBox.Size = new System.Drawing.Size(121, 24);
            this.managerOrderBox.TabIndex = 3;
            this.managerOrderBox.SelectedIndexChanged += new System.EventHandler(this.managerOrderBox_SelectedIndexChanged);
            // 
            // advertiseKursovayaDataSet
            // 
            this.advertiseKursovayaDataSet.DataSetName = "advertiseKursovayaDataSet";
            this.advertiseKursovayaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewGetOrderForManagersBindingSource
            // 
            this.viewGetOrderForManagersBindingSource.DataMember = "viewGetOrderForManagers";
            this.viewGetOrderForManagersBindingSource.DataSource = this.advertiseKursovayaDataSet;
            // 
            // viewGetOrderForManagersTableAdapter1
            // 
            this.viewGetOrderForManagersTableAdapter1.ClearBeforeFill = true;
            // 
            // managerReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 627);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.managerOrderBox);
            this.Controls.Add(this.reportViewer1);
            this.Name = "managerReportForm";
            this.Text = "managerReportForm";
            this.Load += new System.EventHandler(this.managerReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.advertiseKursovayaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewGetOrderForManagersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox managerOrderBox;
        private advertiseKursovayaDataSet advertiseKursovayaDataSet;
        private System.Windows.Forms.BindingSource viewGetOrderForManagersBindingSource;
        private advertiseKursovayaDataSetTableAdapters.viewGetOrderForManagersTableAdapter viewGetOrderForManagersTableAdapter1;
    }
}