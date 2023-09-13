namespace kursovayaBD
{
    partial class EditServiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditServiceForm));
            this.advertiseKursovayaDataSet = new kursovayaBD.advertiseKursovayaDataSet();
            this.adServicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adServicesTableAdapter = new kursovayaBD.advertiseKursovayaDataSetTableAdapters.adServicesTableAdapter();
            this.tableAdapterManager = new kursovayaBD.advertiseKursovayaDataSetTableAdapters.TableAdapterManager();
            this.adServicesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.adServicesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.adServicesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.cancelChangesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.advertiseKursovayaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adServicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adServicesBindingNavigator)).BeginInit();
            this.adServicesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adServicesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // advertiseKursovayaDataSet
            // 
            this.advertiseKursovayaDataSet.DataSetName = "advertiseKursovayaDataSet";
            this.advertiseKursovayaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adServicesBindingSource
            // 
            this.adServicesBindingSource.DataMember = "adServices";
            this.adServicesBindingSource.DataSource = this.advertiseKursovayaDataSet;
            // 
            // adServicesTableAdapter
            // 
            this.adServicesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.adServicesTableAdapter = this.adServicesTableAdapter;
            this.tableAdapterManager.audit_logTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.customerTableAdapter = null;
            this.tableAdapterManager.managerTableAdapter = null;
            this.tableAdapterManager.ordersTableAdapter = null;
            this.tableAdapterManager.placeOfAdvertisementTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = kursovayaBD.advertiseKursovayaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // adServicesBindingNavigator
            // 
            this.adServicesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.adServicesBindingNavigator.BindingSource = this.adServicesBindingSource;
            this.adServicesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.adServicesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.adServicesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.adServicesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.adServicesBindingNavigatorSaveItem});
            this.adServicesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.adServicesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.adServicesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.adServicesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.adServicesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.adServicesBindingNavigator.Name = "adServicesBindingNavigator";
            this.adServicesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.adServicesBindingNavigator.Size = new System.Drawing.Size(349, 31);
            this.adServicesBindingNavigator.TabIndex = 0;
            this.adServicesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // adServicesBindingNavigatorSaveItem
            // 
            this.adServicesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.adServicesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("adServicesBindingNavigatorSaveItem.Image")));
            this.adServicesBindingNavigatorSaveItem.Name = "adServicesBindingNavigatorSaveItem";
            this.adServicesBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.adServicesBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.adServicesBindingNavigatorSaveItem.Click += new System.EventHandler(this.adServicesBindingNavigatorSaveItem_Click);
            // 
            // adServicesDataGridView
            // 
            this.adServicesDataGridView.AutoGenerateColumns = false;
            this.adServicesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adServicesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3});
            this.adServicesDataGridView.DataSource = this.adServicesBindingSource;
            this.adServicesDataGridView.Location = new System.Drawing.Point(29, 30);
            this.adServicesDataGridView.Name = "adServicesDataGridView";
            this.adServicesDataGridView.RowHeadersWidth = 51;
            this.adServicesDataGridView.RowTemplate.Height = 24;
            this.adServicesDataGridView.Size = new System.Drawing.Size(296, 226);
            this.adServicesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "service";
            this.dataGridViewTextBoxColumn2.HeaderText = "service";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "serviceID";
            this.dataGridViewTextBoxColumn1.HeaderText = "serviceID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "serviceDescription";
            this.dataGridViewTextBoxColumn3.HeaderText = "serviceDescription";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Location = new System.Drawing.Point(29, 262);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(114, 43);
            this.saveChangesButton.TabIndex = 2;
            this.saveChangesButton.Text = "Сохранить";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // cancelChangesButton
            // 
            this.cancelChangesButton.Location = new System.Drawing.Point(211, 262);
            this.cancelChangesButton.Name = "cancelChangesButton";
            this.cancelChangesButton.Size = new System.Drawing.Size(114, 43);
            this.cancelChangesButton.TabIndex = 3;
            this.cancelChangesButton.Text = "Отменить";
            this.cancelChangesButton.UseVisualStyleBackColor = true;
            this.cancelChangesButton.Click += new System.EventHandler(this.cancelChangesButton_Click);
            // 
            // EditServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 336);
            this.Controls.Add(this.cancelChangesButton);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.adServicesDataGridView);
            this.Controls.Add(this.adServicesBindingNavigator);
            this.Name = "EditServiceForm";
            this.Text = "EditServiceForm";
            this.Load += new System.EventHandler(this.EditServiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.advertiseKursovayaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adServicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adServicesBindingNavigator)).EndInit();
            this.adServicesBindingNavigator.ResumeLayout(false);
            this.adServicesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adServicesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private advertiseKursovayaDataSet advertiseKursovayaDataSet;
        private System.Windows.Forms.BindingSource adServicesBindingSource;
        private advertiseKursovayaDataSetTableAdapters.adServicesTableAdapter adServicesTableAdapter;
        private advertiseKursovayaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator adServicesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton adServicesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView adServicesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.Button cancelChangesButton;
    }
}