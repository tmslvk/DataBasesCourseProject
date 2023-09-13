namespace kursovayaBD
{
    partial class orderReportForm
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
            this.advertiseKursovayaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewGetOrderForCustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewGetOrderForCustomersTableAdapter = new kursovayaBD.advertiseKursovayaDataSetTableAdapters.viewGetOrderForCustomersTableAdapter();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new kursovayaBD.advertiseKursovayaDataSetTableAdapters.ordersTableAdapter();
            this.orderBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.advertiseKursovayaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advertiseKursovayaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewGetOrderForCustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "kursovayaBD.ReportOrder.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 48);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1078, 567);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // advertiseKursovayaDataSet
            // 
            this.advertiseKursovayaDataSet.DataSetName = "advertiseKursovayaDataSet";
            this.advertiseKursovayaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // advertiseKursovayaDataSetBindingSource
            // 
            this.advertiseKursovayaDataSetBindingSource.DataSource = this.advertiseKursovayaDataSet;
            this.advertiseKursovayaDataSetBindingSource.Position = 0;
            // 
            // viewGetOrderForCustomersBindingSource
            // 
            this.viewGetOrderForCustomersBindingSource.DataMember = "viewGetOrderForCustomers";
            this.viewGetOrderForCustomersBindingSource.DataSource = this.advertiseKursovayaDataSetBindingSource;
            // 
            // viewGetOrderForCustomersTableAdapter
            // 
            this.viewGetOrderForCustomersTableAdapter.ClearBeforeFill = true;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "orders";
            this.ordersBindingSource.DataSource = this.advertiseKursovayaDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // orderBox
            // 
            this.orderBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orderBox.FormattingEnabled = true;
            this.orderBox.Location = new System.Drawing.Point(233, 12);
            this.orderBox.Name = "orderBox";
            this.orderBox.Size = new System.Drawing.Size(121, 24);
            this.orderBox.TabIndex = 1;
            this.orderBox.SelectedIndexChanged += new System.EventHandler(this.orderBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Просмотреть по номеру заказа";
            // 
            // orderReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 627);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderBox);
            this.Controls.Add(this.reportViewer1);
            this.Name = "orderReportForm";
            this.Text = "orderReportForm";
            this.Load += new System.EventHandler(this.orderReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.advertiseKursovayaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advertiseKursovayaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewGetOrderForCustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource advertiseKursovayaDataSetBindingSource;
        private advertiseKursovayaDataSet advertiseKursovayaDataSet;
        private System.Windows.Forms.BindingSource viewGetOrderForCustomersBindingSource;
        private advertiseKursovayaDataSetTableAdapters.viewGetOrderForCustomersTableAdapter viewGetOrderForCustomersTableAdapter;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private advertiseKursovayaDataSetTableAdapters.ordersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.ComboBox orderBox;
        private System.Windows.Forms.Label label1;
    }
}