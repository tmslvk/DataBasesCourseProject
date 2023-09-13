namespace kursovayaBD
{
    partial class EditTypeOfAdForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTypeOfAdForm));
            this.advertiseKursovayaDataSet = new kursovayaBD.advertiseKursovayaDataSet();
            this.placeOfAdvertisementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.placeOfAdvertisementTableAdapter = new kursovayaBD.advertiseKursovayaDataSetTableAdapters.placeOfAdvertisementTableAdapter();
            this.tableAdapterManager = new kursovayaBD.advertiseKursovayaDataSetTableAdapters.TableAdapterManager();
            this.placeOfAdvertisementBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.placeOfAdvertisementBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.placeOfAdvertisementDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveChangesTypeOfAdButton = new System.Windows.Forms.Button();
            this.cancelChangesTypeOfAdButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.advertiseKursovayaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeOfAdvertisementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeOfAdvertisementBindingNavigator)).BeginInit();
            this.placeOfAdvertisementBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.placeOfAdvertisementDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // advertiseKursovayaDataSet
            // 
            this.advertiseKursovayaDataSet.DataSetName = "advertiseKursovayaDataSet";
            this.advertiseKursovayaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // placeOfAdvertisementBindingSource
            // 
            this.placeOfAdvertisementBindingSource.DataMember = "placeOfAdvertisement";
            this.placeOfAdvertisementBindingSource.DataSource = this.advertiseKursovayaDataSet;
            // 
            // placeOfAdvertisementTableAdapter
            // 
            this.placeOfAdvertisementTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.adServicesTableAdapter = null;
            this.tableAdapterManager.audit_logTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.customerTableAdapter = null;
            this.tableAdapterManager.managerTableAdapter = null;
            this.tableAdapterManager.ordersTableAdapter = null;
            this.tableAdapterManager.placeOfAdvertisementTableAdapter = this.placeOfAdvertisementTableAdapter;
            this.tableAdapterManager.UpdateOrder = kursovayaBD.advertiseKursovayaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // placeOfAdvertisementBindingNavigator
            // 
            this.placeOfAdvertisementBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.placeOfAdvertisementBindingNavigator.BindingSource = this.placeOfAdvertisementBindingSource;
            this.placeOfAdvertisementBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.placeOfAdvertisementBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.placeOfAdvertisementBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.placeOfAdvertisementBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.placeOfAdvertisementBindingNavigatorSaveItem});
            this.placeOfAdvertisementBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.placeOfAdvertisementBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.placeOfAdvertisementBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.placeOfAdvertisementBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.placeOfAdvertisementBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.placeOfAdvertisementBindingNavigator.Name = "placeOfAdvertisementBindingNavigator";
            this.placeOfAdvertisementBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.placeOfAdvertisementBindingNavigator.Size = new System.Drawing.Size(349, 31);
            this.placeOfAdvertisementBindingNavigator.TabIndex = 0;
            this.placeOfAdvertisementBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(49, 27);
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
            // placeOfAdvertisementBindingNavigatorSaveItem
            // 
            this.placeOfAdvertisementBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.placeOfAdvertisementBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("placeOfAdvertisementBindingNavigatorSaveItem.Image")));
            this.placeOfAdvertisementBindingNavigatorSaveItem.Name = "placeOfAdvertisementBindingNavigatorSaveItem";
            this.placeOfAdvertisementBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.placeOfAdvertisementBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.placeOfAdvertisementBindingNavigatorSaveItem.Click += new System.EventHandler(this.placeOfAdvertisementBindingNavigatorSaveItem_Click);
            // 
            // placeOfAdvertisementDataGridView
            // 
            this.placeOfAdvertisementDataGridView.AutoGenerateColumns = false;
            this.placeOfAdvertisementDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.placeOfAdvertisementDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3});
            this.placeOfAdvertisementDataGridView.DataSource = this.placeOfAdvertisementBindingSource;
            this.placeOfAdvertisementDataGridView.Location = new System.Drawing.Point(23, 30);
            this.placeOfAdvertisementDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.placeOfAdvertisementDataGridView.Name = "placeOfAdvertisementDataGridView";
            this.placeOfAdvertisementDataGridView.RowHeadersWidth = 51;
            this.placeOfAdvertisementDataGridView.RowTemplate.Height = 24;
            this.placeOfAdvertisementDataGridView.Size = new System.Drawing.Size(304, 223);
            this.placeOfAdvertisementDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "rentPrice";
            this.dataGridViewTextBoxColumn2.HeaderText = "rentPrice";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "placeID";
            this.dataGridViewTextBoxColumn1.HeaderText = "placeID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "typeOfAd";
            this.dataGridViewTextBoxColumn3.HeaderText = "typeOfAd";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // saveChangesTypeOfAdButton
            // 
            this.saveChangesTypeOfAdButton.Location = new System.Drawing.Point(23, 258);
            this.saveChangesTypeOfAdButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveChangesTypeOfAdButton.Name = "saveChangesTypeOfAdButton";
            this.saveChangesTypeOfAdButton.Size = new System.Drawing.Size(119, 57);
            this.saveChangesTypeOfAdButton.TabIndex = 2;
            this.saveChangesTypeOfAdButton.Text = "Сохранить";
            this.saveChangesTypeOfAdButton.UseVisualStyleBackColor = true;
            this.saveChangesTypeOfAdButton.Click += new System.EventHandler(this.saveChangesTypeOfAdButton_Click);
            // 
            // cancelChangesTypeOfAdButton
            // 
            this.cancelChangesTypeOfAdButton.Location = new System.Drawing.Point(208, 258);
            this.cancelChangesTypeOfAdButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelChangesTypeOfAdButton.Name = "cancelChangesTypeOfAdButton";
            this.cancelChangesTypeOfAdButton.Size = new System.Drawing.Size(119, 57);
            this.cancelChangesTypeOfAdButton.TabIndex = 3;
            this.cancelChangesTypeOfAdButton.Text = "Отменить";
            this.cancelChangesTypeOfAdButton.UseVisualStyleBackColor = true;
            this.cancelChangesTypeOfAdButton.Click += new System.EventHandler(this.cancelChangesTypeOfAdButton_Click);
            // 
            // EditTypeOfAdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 336);
            this.Controls.Add(this.cancelChangesTypeOfAdButton);
            this.Controls.Add(this.saveChangesTypeOfAdButton);
            this.Controls.Add(this.placeOfAdvertisementDataGridView);
            this.Controls.Add(this.placeOfAdvertisementBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EditTypeOfAdForm";
            this.Text = "EditTypeOfAdForm";
            this.Load += new System.EventHandler(this.EditTypeOfAdForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.advertiseKursovayaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeOfAdvertisementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeOfAdvertisementBindingNavigator)).EndInit();
            this.placeOfAdvertisementBindingNavigator.ResumeLayout(false);
            this.placeOfAdvertisementBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.placeOfAdvertisementDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private advertiseKursovayaDataSet advertiseKursovayaDataSet;
        private System.Windows.Forms.BindingSource placeOfAdvertisementBindingSource;
        private advertiseKursovayaDataSetTableAdapters.placeOfAdvertisementTableAdapter placeOfAdvertisementTableAdapter;
        private advertiseKursovayaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator placeOfAdvertisementBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton placeOfAdvertisementBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView placeOfAdvertisementDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button saveChangesTypeOfAdButton;
        private System.Windows.Forms.Button cancelChangesTypeOfAdButton;
    }
}