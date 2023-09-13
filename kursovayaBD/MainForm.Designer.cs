namespace kursovayaBD
{
    partial class MainForm
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
            this.goBackButton = new System.Windows.Forms.Button();
            this.getOrderButton = new System.Windows.Forms.Button();
            this.makeOrderButton = new System.Windows.Forms.Button();
            this.addServiceButton = new System.Windows.Forms.Button();
            this.addPlaceOfAdButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.serviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adServicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.advertiseKursovayaDataSet1 = new kursovayaBD.advertiseKursovayaDataSet();
            this.greetingsLabel = new System.Windows.Forms.Label();
            this.getOrderGroupBox = new System.Windows.Forms.GroupBox();
            this.ChangeDataGroupBox = new System.Windows.Forms.GroupBox();
            this.changeAllDataCheckBox = new System.Windows.Forms.CheckBox();
            this.changeOnlyPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.changeOnlyMailCheckBox = new System.Windows.Forms.CheckBox();
            this.changesInfoListBox = new System.Windows.Forms.ListBox();
            this.submitChangesButton = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.newEmailTextBox = new System.Windows.Forms.TextBox();
            this.oldPasswordTextBox = new System.Windows.Forms.TextBox();
            this.oldEmailTextBox = new System.Windows.Forms.TextBox();
            this.filterByDateGroupbox = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.serviceCheckBox = new System.Windows.Forms.CheckBox();
            this.dateCheckBox = new System.Windows.Forms.CheckBox();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.filterBoxByService = new System.Windows.Forms.ComboBox();
            this.filterButtonForCustomers = new System.Windows.Forms.Button();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.filterButtonForManagers = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.reportOrderForManagersButton = new System.Windows.Forms.Button();
            this.viewGetOrderForCustomersDataGridView = new System.Windows.Forms.DataGridView();
            this.managerLastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerFirstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerMiddlenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeOfAdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAdFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAdToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentPriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewGetOrderForCustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewGetOrderForManagersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewGetOrderForManagersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.showByServicesGetOrders = new System.Windows.Forms.Button();
            this.addServiceGroupBox = new System.Windows.Forms.GroupBox();
            this.firstAdServiceButton = new System.Windows.Forms.Button();
            this.previousAdServiceButton = new System.Windows.Forms.Button();
            this.nextAdServiceButton = new System.Windows.Forms.Button();
            this.lastAdServiceButton = new System.Windows.Forms.Button();
            this.cancelAdServiceButton = new System.Windows.Forms.Button();
            this.saveAdServiceButton = new System.Windows.Forms.Button();
            this.deleteAdServiceButton = new System.Windows.Forms.Button();
            this.addAdServiceButton = new System.Windows.Forms.Button();
            this.addAPlaceOfAdGroupBox = new System.Windows.Forms.GroupBox();
            this.rentGetFirstButton = new System.Windows.Forms.Button();
            this.rentGetPreviousButton = new System.Windows.Forms.Button();
            this.rentGetNextButton = new System.Windows.Forms.Button();
            this.rentGetLastButton = new System.Windows.Forms.Button();
            this.rentCancelButton = new System.Windows.Forms.Button();
            this.rentSaveButton = new System.Windows.Forms.Button();
            this.rentDeleteButton = new System.Windows.Forms.Button();
            this.rentAddButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.rentPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeOfAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeOfAdvertisementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.makeAnOrderGroupBox = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.fullPriceLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comleteOrderButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.checkOfOrderTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dropDownMenuRent = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dropDownMenuService = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dropDownMenuManager = new System.Windows.Forms.ComboBox();
            this.reportOrderFromCustomers = new System.Windows.Forms.Button();
            this.editOrdersButton = new System.Windows.Forms.Button();
            this.EditOrderGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteLabel = new System.Windows.Forms.Label();
            this.deleteOrderButton = new System.Windows.Forms.Button();
            this.completeChangesLabel = new System.Windows.Forms.Label();
            this.editTypeOfAdButton = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.orderIDEditOrder = new System.Windows.Forms.ComboBox();
            this.labelNameOfCustomer = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.updateOrderButton = new System.Windows.Forms.Button();
            this.editedFullPrice = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDownEditOrder = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rentPlaceEditOrder = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.serviceEditOrder = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.managerEditOrder = new System.Windows.Forms.ComboBox();
            this.execReportOfResultsButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.viewGetOrderForCustomersTableAdapter1 = new kursovayaBD.advertiseKursovayaDataSetTableAdapters.viewGetOrderForCustomersTableAdapter();
            this.viewGetOrderForManagersTableAdapter1 = new kursovayaBD.advertiseKursovayaDataSetTableAdapters.viewGetOrderForManagersTableAdapter();
            this.getServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getServiceTableAdapter = new kursovayaBD.advertiseKursovayaDataSetTableAdapters.getServiceTableAdapter();
            this.adServicesTableAdapter = new kursovayaBD.advertiseKursovayaDataSetTableAdapters.adServicesTableAdapter();
            this.tableAdapterManager = new kursovayaBD.advertiseKursovayaDataSetTableAdapters.TableAdapterManager();
            this.placeOfAdvertisementTableAdapter = new kursovayaBD.advertiseKursovayaDataSetTableAdapters.placeOfAdvertisementTableAdapter();
            this.label21 = new System.Windows.Forms.Label();
            this.managerFilterComboBox = new System.Windows.Forms.ComboBox();
            this.filterManagerCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adServicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advertiseKursovayaDataSet1)).BeginInit();
            this.getOrderGroupBox.SuspendLayout();
            this.ChangeDataGroupBox.SuspendLayout();
            this.filterByDateGroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewGetOrderForCustomersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewGetOrderForCustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewGetOrderForManagersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewGetOrderForManagersBindingSource)).BeginInit();
            this.addServiceGroupBox.SuspendLayout();
            this.addAPlaceOfAdGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeOfAdvertisementBindingSource)).BeginInit();
            this.makeAnOrderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.EditOrderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEditOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getServiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // goBackButton
            // 
            this.goBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.goBackButton.Location = new System.Drawing.Point(12, 12);
            this.goBackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(169, 84);
            this.goBackButton.TabIndex = 0;
            this.goBackButton.Text = "<- Назад";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // getOrderButton
            // 
            this.getOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.getOrderButton.Location = new System.Drawing.Point(12, 357);
            this.getOrderButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.getOrderButton.Name = "getOrderButton";
            this.getOrderButton.Size = new System.Drawing.Size(169, 84);
            this.getOrderButton.TabIndex = 1;
            this.getOrderButton.Text = "Просмотр заказов";
            this.getOrderButton.UseVisualStyleBackColor = true;
            this.getOrderButton.Click += new System.EventHandler(this.getOrderButton_Click);
            // 
            // makeOrderButton
            // 
            this.makeOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.makeOrderButton.Location = new System.Drawing.Point(12, 192);
            this.makeOrderButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.makeOrderButton.Name = "makeOrderButton";
            this.makeOrderButton.Size = new System.Drawing.Size(169, 84);
            this.makeOrderButton.TabIndex = 3;
            this.makeOrderButton.Text = "Сделать заказ";
            this.makeOrderButton.UseVisualStyleBackColor = true;
            this.makeOrderButton.Click += new System.EventHandler(this.makeAnOrderButton_Click);
            // 
            // addServiceButton
            // 
            this.addServiceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.addServiceButton.Location = new System.Drawing.Point(12, 447);
            this.addServiceButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addServiceButton.Name = "addServiceButton";
            this.addServiceButton.Size = new System.Drawing.Size(169, 84);
            this.addServiceButton.TabIndex = 2;
            this.addServiceButton.Text = "Добавить услугу";
            this.addServiceButton.UseVisualStyleBackColor = true;
            this.addServiceButton.Click += new System.EventHandler(this.addServiceButton_Click);
            // 
            // addPlaceOfAdButton
            // 
            this.addPlaceOfAdButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.addPlaceOfAdButton.Location = new System.Drawing.Point(12, 537);
            this.addPlaceOfAdButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addPlaceOfAdButton.Name = "addPlaceOfAdButton";
            this.addPlaceOfAdButton.Size = new System.Drawing.Size(169, 84);
            this.addPlaceOfAdButton.TabIndex = 4;
            this.addPlaceOfAdButton.Text = "Добавить место для рекламы";
            this.addPlaceOfAdButton.UseVisualStyleBackColor = true;
            this.addPlaceOfAdButton.Click += new System.EventHandler(this.addPlaceOfAdButton_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serviceDataGridViewTextBoxColumn,
            this.serviceIDDataGridViewTextBoxColumn,
            this.serviceDescriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.adServicesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(11, 34);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(440, 240);
            this.dataGridView1.TabIndex = 5;
            // 
            // serviceDataGridViewTextBoxColumn
            // 
            this.serviceDataGridViewTextBoxColumn.DataPropertyName = "service";
            this.serviceDataGridViewTextBoxColumn.HeaderText = "service";
            this.serviceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serviceDataGridViewTextBoxColumn.Name = "serviceDataGridViewTextBoxColumn";
            this.serviceDataGridViewTextBoxColumn.Width = 125;
            // 
            // serviceIDDataGridViewTextBoxColumn
            // 
            this.serviceIDDataGridViewTextBoxColumn.DataPropertyName = "serviceID";
            this.serviceIDDataGridViewTextBoxColumn.HeaderText = "serviceID";
            this.serviceIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serviceIDDataGridViewTextBoxColumn.Name = "serviceIDDataGridViewTextBoxColumn";
            this.serviceIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.serviceIDDataGridViewTextBoxColumn.Visible = false;
            this.serviceIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // serviceDescriptionDataGridViewTextBoxColumn
            // 
            this.serviceDescriptionDataGridViewTextBoxColumn.DataPropertyName = "serviceDescription";
            this.serviceDescriptionDataGridViewTextBoxColumn.HeaderText = "serviceDescription";
            this.serviceDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serviceDescriptionDataGridViewTextBoxColumn.Name = "serviceDescriptionDataGridViewTextBoxColumn";
            this.serviceDescriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // adServicesBindingSource
            // 
            this.adServicesBindingSource.DataMember = "adServices";
            this.adServicesBindingSource.DataSource = this.advertiseKursovayaDataSet1;
            // 
            // advertiseKursovayaDataSet1
            // 
            this.advertiseKursovayaDataSet1.DataSetName = "advertiseKursovayaDataSet";
            this.advertiseKursovayaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // greetingsLabel
            // 
            this.greetingsLabel.AutoSize = true;
            this.greetingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.greetingsLabel.Location = new System.Drawing.Point(194, 22);
            this.greetingsLabel.Name = "greetingsLabel";
            this.greetingsLabel.Size = new System.Drawing.Size(0, 22);
            this.greetingsLabel.TabIndex = 6;
            // 
            // getOrderGroupBox
            // 
            this.getOrderGroupBox.Controls.Add(this.ChangeDataGroupBox);
            this.getOrderGroupBox.Controls.Add(this.filterByDateGroupbox);
            this.getOrderGroupBox.Controls.Add(this.reportOrderForManagersButton);
            this.getOrderGroupBox.Controls.Add(this.viewGetOrderForCustomersDataGridView);
            this.getOrderGroupBox.Controls.Add(this.viewGetOrderForManagersDataGridView);
            this.getOrderGroupBox.Controls.Add(this.showByServicesGetOrders);
            this.getOrderGroupBox.Location = new System.Drawing.Point(187, 64);
            this.getOrderGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.getOrderGroupBox.Name = "getOrderGroupBox";
            this.getOrderGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.getOrderGroupBox.Size = new System.Drawing.Size(903, 558);
            this.getOrderGroupBox.TabIndex = 7;
            this.getOrderGroupBox.TabStop = false;
            this.getOrderGroupBox.Text = "Просмотр заказов";
            // 
            // ChangeDataGroupBox
            // 
            this.ChangeDataGroupBox.Controls.Add(this.changeAllDataCheckBox);
            this.ChangeDataGroupBox.Controls.Add(this.changeOnlyPasswordCheckBox);
            this.ChangeDataGroupBox.Controls.Add(this.changeOnlyMailCheckBox);
            this.ChangeDataGroupBox.Controls.Add(this.changesInfoListBox);
            this.ChangeDataGroupBox.Controls.Add(this.submitChangesButton);
            this.ChangeDataGroupBox.Controls.Add(this.label19);
            this.ChangeDataGroupBox.Controls.Add(this.label20);
            this.ChangeDataGroupBox.Controls.Add(this.label18);
            this.ChangeDataGroupBox.Controls.Add(this.label17);
            this.ChangeDataGroupBox.Controls.Add(this.newPasswordTextBox);
            this.ChangeDataGroupBox.Controls.Add(this.newEmailTextBox);
            this.ChangeDataGroupBox.Controls.Add(this.oldPasswordTextBox);
            this.ChangeDataGroupBox.Controls.Add(this.oldEmailTextBox);
            this.ChangeDataGroupBox.Location = new System.Drawing.Point(868, 65);
            this.ChangeDataGroupBox.Name = "ChangeDataGroupBox";
            this.ChangeDataGroupBox.Size = new System.Drawing.Size(903, 558);
            this.ChangeDataGroupBox.TabIndex = 21;
            this.ChangeDataGroupBox.TabStop = false;
            this.ChangeDataGroupBox.Text = "Изменить данные";
            // 
            // changeAllDataCheckBox
            // 
            this.changeAllDataCheckBox.AutoSize = true;
            this.changeAllDataCheckBox.Location = new System.Drawing.Point(449, 97);
            this.changeAllDataCheckBox.Name = "changeAllDataCheckBox";
            this.changeAllDataCheckBox.Size = new System.Drawing.Size(172, 20);
            this.changeAllDataCheckBox.TabIndex = 12;
            this.changeAllDataCheckBox.Text = "Изменить все данные";
            this.changeAllDataCheckBox.UseVisualStyleBackColor = true;
            this.changeAllDataCheckBox.Click += new System.EventHandler(this.changeAllDataCheckBox_Click);
            // 
            // changeOnlyPasswordCheckBox
            // 
            this.changeOnlyPasswordCheckBox.AutoSize = true;
            this.changeOnlyPasswordCheckBox.Location = new System.Drawing.Point(449, 148);
            this.changeOnlyPasswordCheckBox.Name = "changeOnlyPasswordCheckBox";
            this.changeOnlyPasswordCheckBox.Size = new System.Drawing.Size(191, 20);
            this.changeOnlyPasswordCheckBox.TabIndex = 11;
            this.changeOnlyPasswordCheckBox.Text = "Изменять только пароль";
            this.changeOnlyPasswordCheckBox.UseVisualStyleBackColor = true;
            this.changeOnlyPasswordCheckBox.Click += new System.EventHandler(this.changeOnlyPasswordCheckBox_Click);
            // 
            // changeOnlyMailCheckBox
            // 
            this.changeOnlyMailCheckBox.AutoSize = true;
            this.changeOnlyMailCheckBox.Location = new System.Drawing.Point(449, 123);
            this.changeOnlyMailCheckBox.Name = "changeOnlyMailCheckBox";
            this.changeOnlyMailCheckBox.Size = new System.Drawing.Size(183, 20);
            this.changeOnlyMailCheckBox.TabIndex = 10;
            this.changeOnlyMailCheckBox.Text = "Изменять только почту";
            this.changeOnlyMailCheckBox.UseVisualStyleBackColor = true;
            this.changeOnlyMailCheckBox.Click += new System.EventHandler(this.changeOnlyMailCheckBox_Click);
            // 
            // changesInfoListBox
            // 
            this.changesInfoListBox.FormattingEnabled = true;
            this.changesInfoListBox.ItemHeight = 16;
            this.changesInfoListBox.Location = new System.Drawing.Point(239, 395);
            this.changesInfoListBox.Name = "changesInfoListBox";
            this.changesInfoListBox.Size = new System.Drawing.Size(400, 84);
            this.changesInfoListBox.TabIndex = 9;
            // 
            // submitChangesButton
            // 
            this.submitChangesButton.Location = new System.Drawing.Point(360, 266);
            this.submitChangesButton.Name = "submitChangesButton";
            this.submitChangesButton.Size = new System.Drawing.Size(153, 47);
            this.submitChangesButton.TabIndex = 8;
            this.submitChangesButton.Text = "Подтвердить изменения";
            this.submitChangesButton.UseVisualStyleBackColor = true;
            this.submitChangesButton.Click += new System.EventHandler(this.submitChangesButton_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(30, 149);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(157, 16);
            this.label19.TabIndex = 7;
            this.label19.Text = "Введите новый пароль";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(36, 124);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(150, 16);
            this.label20.TabIndex = 6;
            this.label20.Text = "Введите новую почту";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(78, 54);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(106, 16);
            this.label18.TabIndex = 5;
            this.label18.Text = "Старый пароль";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(88, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 16);
            this.label17.TabIndex = 4;
            this.label17.Text = "Старая почта";
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Location = new System.Drawing.Point(193, 146);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.Size = new System.Drawing.Size(246, 22);
            this.newPasswordTextBox.TabIndex = 3;
            // 
            // newEmailTextBox
            // 
            this.newEmailTextBox.Location = new System.Drawing.Point(193, 121);
            this.newEmailTextBox.Name = "newEmailTextBox";
            this.newEmailTextBox.Size = new System.Drawing.Size(246, 22);
            this.newEmailTextBox.TabIndex = 2;
            // 
            // oldPasswordTextBox
            // 
            this.oldPasswordTextBox.Location = new System.Drawing.Point(193, 51);
            this.oldPasswordTextBox.Name = "oldPasswordTextBox";
            this.oldPasswordTextBox.ReadOnly = true;
            this.oldPasswordTextBox.Size = new System.Drawing.Size(246, 22);
            this.oldPasswordTextBox.TabIndex = 1;
            // 
            // oldEmailTextBox
            // 
            this.oldEmailTextBox.Location = new System.Drawing.Point(193, 22);
            this.oldEmailTextBox.Name = "oldEmailTextBox";
            this.oldEmailTextBox.ReadOnly = true;
            this.oldEmailTextBox.Size = new System.Drawing.Size(246, 22);
            this.oldEmailTextBox.TabIndex = 0;
            // 
            // filterByDateGroupbox
            // 
            this.filterByDateGroupbox.Controls.Add(this.filterManagerCheckBox);
            this.filterByDateGroupbox.Controls.Add(this.label21);
            this.filterByDateGroupbox.Controls.Add(this.managerFilterComboBox);
            this.filterByDateGroupbox.Controls.Add(this.button3);
            this.filterByDateGroupbox.Controls.Add(this.label16);
            this.filterByDateGroupbox.Controls.Add(this.serviceCheckBox);
            this.filterByDateGroupbox.Controls.Add(this.dateCheckBox);
            this.filterByDateGroupbox.Controls.Add(this.dateTimePickerTo);
            this.filterByDateGroupbox.Controls.Add(this.filterBoxByService);
            this.filterByDateGroupbox.Controls.Add(this.filterButtonForCustomers);
            this.filterByDateGroupbox.Controls.Add(this.dateTimePickerFrom);
            this.filterByDateGroupbox.Controls.Add(this.filterButtonForManagers);
            this.filterByDateGroupbox.Controls.Add(this.label14);
            this.filterByDateGroupbox.Controls.Add(this.label11);
            this.filterByDateGroupbox.Location = new System.Drawing.Point(5, 431);
            this.filterByDateGroupbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filterByDateGroupbox.Name = "filterByDateGroupbox";
            this.filterByDateGroupbox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filterByDateGroupbox.Size = new System.Drawing.Size(892, 122);
            this.filterByDateGroupbox.TabIndex = 24;
            this.filterByDateGroupbox.TabStop = false;
            this.filterByDateGroupbox.Text = "Фильтрация";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(740, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 53);
            this.button3.TabIndex = 28;
            this.button3.Text = "Учет работы предприятия";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.agencyReportButton_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(168, 59);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(121, 16);
            this.label16.TabIndex = 27;
            this.label16.Text = "Выберите сервис";
            // 
            // serviceCheckBox
            // 
            this.serviceCheckBox.AutoSize = true;
            this.serviceCheckBox.Location = new System.Drawing.Point(493, 58);
            this.serviceCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.serviceCheckBox.Name = "serviceCheckBox";
            this.serviceCheckBox.Size = new System.Drawing.Size(200, 20);
            this.serviceCheckBox.TabIndex = 26;
            this.serviceCheckBox.Text = "Отфильтровать по услуге";
            this.serviceCheckBox.UseVisualStyleBackColor = true;
            // 
            // dateCheckBox
            // 
            this.dateCheckBox.AutoSize = true;
            this.dateCheckBox.Location = new System.Drawing.Point(493, 21);
            this.dateCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.dateCheckBox.Name = "dateCheckBox";
            this.dateCheckBox.Size = new System.Drawing.Size(186, 20);
            this.dateCheckBox.TabIndex = 24;
            this.dateCheckBox.Text = "Отфильтровать по дате";
            this.dateCheckBox.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(281, 21);
            this.dateTimePickerTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerTo.TabIndex = 20;
            // 
            // filterBoxByService
            // 
            this.filterBoxByService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterBoxByService.FormattingEnabled = true;
            this.filterBoxByService.Location = new System.Drawing.Point(296, 56);
            this.filterBoxByService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filterBoxByService.Name = "filterBoxByService";
            this.filterBoxByService.Size = new System.Drawing.Size(185, 24);
            this.filterBoxByService.TabIndex = 7;
            this.filterBoxByService.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // filterButtonForCustomers
            // 
            this.filterButtonForCustomers.Location = new System.Drawing.Point(740, 10);
            this.filterButtonForCustomers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filterButtonForCustomers.Name = "filterButtonForCustomers";
            this.filterButtonForCustomers.Size = new System.Drawing.Size(152, 46);
            this.filterButtonForCustomers.TabIndex = 5;
            this.filterButtonForCustomers.Text = "Отфильтровать";
            this.filterButtonForCustomers.UseVisualStyleBackColor = true;
            this.filterButtonForCustomers.Visible = false;
            this.filterButtonForCustomers.Click += new System.EventHandler(this.filterButtonForCustomers_Click);
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(41, 21);
            this.dateTimePickerFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerFrom.TabIndex = 19;
            // 
            // filterButtonForManagers
            // 
            this.filterButtonForManagers.Location = new System.Drawing.Point(740, 10);
            this.filterButtonForManagers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filterButtonForManagers.Name = "filterButtonForManagers";
            this.filterButtonForManagers.Size = new System.Drawing.Size(152, 46);
            this.filterButtonForManagers.TabIndex = 6;
            this.filterButtonForManagers.Text = "Отфильтровать";
            this.filterButtonForManagers.UseVisualStyleBackColor = true;
            this.filterButtonForManagers.Click += new System.EventHandler(this.filterButtonForManagers_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 16);
            this.label14.TabIndex = 21;
            this.label14.Text = "От:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(248, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "До:";
            // 
            // reportOrderForManagersButton
            // 
            this.reportOrderForManagersButton.Location = new System.Drawing.Point(772, 16);
            this.reportOrderForManagersButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportOrderForManagersButton.Name = "reportOrderForManagersButton";
            this.reportOrderForManagersButton.Size = new System.Drawing.Size(125, 44);
            this.reportOrderForManagersButton.TabIndex = 4;
            this.reportOrderForManagersButton.Text = "Отчет";
            this.reportOrderForManagersButton.UseVisualStyleBackColor = true;
            this.reportOrderForManagersButton.Click += new System.EventHandler(this.GetOrderForManagersButton_Click);
            // 
            // viewGetOrderForCustomersDataGridView
            // 
            this.viewGetOrderForCustomersDataGridView.AutoGenerateColumns = false;
            this.viewGetOrderForCustomersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewGetOrderForCustomersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.managerLastnameDataGridViewTextBoxColumn,
            this.orderIDDataGridViewTextBoxColumn,
            this.managerFirstnameDataGridViewTextBoxColumn,
            this.managerMiddlenameDataGridViewTextBoxColumn,
            this.managerEmailDataGridViewTextBoxColumn,
            this.serviceDataGridViewTextBoxColumn1,
            this.typeOfAdDataGridViewTextBoxColumn1,
            this.userIDDataGridViewTextBoxColumn,
            this.dateAdFromDataGridViewTextBoxColumn,
            this.dateAdToDataGridViewTextBoxColumn,
            this.rentPriceDataGridViewTextBoxColumn1});
            this.viewGetOrderForCustomersDataGridView.DataSource = this.viewGetOrderForCustomersBindingSource;
            this.viewGetOrderForCustomersDataGridView.Location = new System.Drawing.Point(21, 68);
            this.viewGetOrderForCustomersDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewGetOrderForCustomersDataGridView.Name = "viewGetOrderForCustomersDataGridView";
            this.viewGetOrderForCustomersDataGridView.RowHeadersWidth = 51;
            this.viewGetOrderForCustomersDataGridView.RowTemplate.Height = 24;
            this.viewGetOrderForCustomersDataGridView.Size = new System.Drawing.Size(876, 358);
            this.viewGetOrderForCustomersDataGridView.TabIndex = 3;
            // 
            // managerLastnameDataGridViewTextBoxColumn
            // 
            this.managerLastnameDataGridViewTextBoxColumn.DataPropertyName = "managerLastname";
            this.managerLastnameDataGridViewTextBoxColumn.HeaderText = "managerLastname";
            this.managerLastnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.managerLastnameDataGridViewTextBoxColumn.Name = "managerLastnameDataGridViewTextBoxColumn";
            this.managerLastnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "orderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "orderID";
            this.orderIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.Visible = false;
            this.orderIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // managerFirstnameDataGridViewTextBoxColumn
            // 
            this.managerFirstnameDataGridViewTextBoxColumn.DataPropertyName = "managerFirstname";
            this.managerFirstnameDataGridViewTextBoxColumn.HeaderText = "managerFirstname";
            this.managerFirstnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.managerFirstnameDataGridViewTextBoxColumn.Name = "managerFirstnameDataGridViewTextBoxColumn";
            this.managerFirstnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // managerMiddlenameDataGridViewTextBoxColumn
            // 
            this.managerMiddlenameDataGridViewTextBoxColumn.DataPropertyName = "managerMiddlename";
            this.managerMiddlenameDataGridViewTextBoxColumn.HeaderText = "managerMiddlename";
            this.managerMiddlenameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.managerMiddlenameDataGridViewTextBoxColumn.Name = "managerMiddlenameDataGridViewTextBoxColumn";
            this.managerMiddlenameDataGridViewTextBoxColumn.Width = 125;
            // 
            // managerEmailDataGridViewTextBoxColumn
            // 
            this.managerEmailDataGridViewTextBoxColumn.DataPropertyName = "managerEmail";
            this.managerEmailDataGridViewTextBoxColumn.HeaderText = "managerEmail";
            this.managerEmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.managerEmailDataGridViewTextBoxColumn.Name = "managerEmailDataGridViewTextBoxColumn";
            this.managerEmailDataGridViewTextBoxColumn.Width = 125;
            // 
            // serviceDataGridViewTextBoxColumn1
            // 
            this.serviceDataGridViewTextBoxColumn1.DataPropertyName = "service";
            this.serviceDataGridViewTextBoxColumn1.HeaderText = "service";
            this.serviceDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.serviceDataGridViewTextBoxColumn1.Name = "serviceDataGridViewTextBoxColumn1";
            this.serviceDataGridViewTextBoxColumn1.Width = 125;
            // 
            // typeOfAdDataGridViewTextBoxColumn1
            // 
            this.typeOfAdDataGridViewTextBoxColumn1.DataPropertyName = "typeOfAd";
            this.typeOfAdDataGridViewTextBoxColumn1.HeaderText = "typeOfAd";
            this.typeOfAdDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.typeOfAdDataGridViewTextBoxColumn1.Name = "typeOfAdDataGridViewTextBoxColumn1";
            this.typeOfAdDataGridViewTextBoxColumn1.Width = 125;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "userID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "userID";
            this.userIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.Visible = false;
            this.userIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateAdFromDataGridViewTextBoxColumn
            // 
            this.dateAdFromDataGridViewTextBoxColumn.DataPropertyName = "dateAdFrom";
            this.dateAdFromDataGridViewTextBoxColumn.HeaderText = "dateAdFrom";
            this.dateAdFromDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateAdFromDataGridViewTextBoxColumn.Name = "dateAdFromDataGridViewTextBoxColumn";
            this.dateAdFromDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateAdToDataGridViewTextBoxColumn
            // 
            this.dateAdToDataGridViewTextBoxColumn.DataPropertyName = "dateAdTo";
            this.dateAdToDataGridViewTextBoxColumn.HeaderText = "dateAdTo";
            this.dateAdToDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateAdToDataGridViewTextBoxColumn.Name = "dateAdToDataGridViewTextBoxColumn";
            this.dateAdToDataGridViewTextBoxColumn.Width = 125;
            // 
            // rentPriceDataGridViewTextBoxColumn1
            // 
            this.rentPriceDataGridViewTextBoxColumn1.DataPropertyName = "rentPrice";
            this.rentPriceDataGridViewTextBoxColumn1.HeaderText = "rentPrice";
            this.rentPriceDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.rentPriceDataGridViewTextBoxColumn1.Name = "rentPriceDataGridViewTextBoxColumn1";
            this.rentPriceDataGridViewTextBoxColumn1.Width = 125;
            // 
            // viewGetOrderForCustomersBindingSource
            // 
            this.viewGetOrderForCustomersBindingSource.DataMember = "viewGetOrderForCustomers";
            this.viewGetOrderForCustomersBindingSource.DataSource = this.advertiseKursovayaDataSet1;
            // 
            // viewGetOrderForManagersDataGridView
            // 
            this.viewGetOrderForManagersDataGridView.AutoGenerateColumns = false;
            this.viewGetOrderForManagersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewGetOrderForManagersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.viewGetOrderForManagersDataGridView.DataSource = this.viewGetOrderForManagersBindingSource;
            this.viewGetOrderForManagersDataGridView.Location = new System.Drawing.Point(21, 66);
            this.viewGetOrderForManagersDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewGetOrderForManagersDataGridView.Name = "viewGetOrderForManagersDataGridView";
            this.viewGetOrderForManagersDataGridView.RowHeadersWidth = 51;
            this.viewGetOrderForManagersDataGridView.RowTemplate.Height = 24;
            this.viewGetOrderForManagersDataGridView.Size = new System.Drawing.Size(820, 340);
            this.viewGetOrderForManagersDataGridView.TabIndex = 2;
            this.viewGetOrderForManagersDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "customersLastname";
            this.dataGridViewTextBoxColumn2.HeaderText = "customersLastname";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "orderID";
            this.dataGridViewTextBoxColumn1.HeaderText = "orderID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "customersFirstname";
            this.dataGridViewTextBoxColumn3.HeaderText = "customersFirstname";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "customersMiddlename";
            this.dataGridViewTextBoxColumn4.HeaderText = "customersMiddlename";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "customerEmail";
            this.dataGridViewTextBoxColumn5.HeaderText = "customerEmail";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "service";
            this.dataGridViewTextBoxColumn6.HeaderText = "service";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "typeOfAd";
            this.dataGridViewTextBoxColumn7.HeaderText = "typeOfAd";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "managerID";
            this.dataGridViewTextBoxColumn8.HeaderText = "managerID";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "dateAdFrom";
            this.dataGridViewTextBoxColumn9.HeaderText = "dateAdFrom";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "dateAdTo";
            this.dataGridViewTextBoxColumn10.HeaderText = "dateAdTo";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // viewGetOrderForManagersBindingSource
            // 
            this.viewGetOrderForManagersBindingSource.DataMember = "viewGetOrderForManagers";
            this.viewGetOrderForManagersBindingSource.DataSource = this.advertiseKursovayaDataSet1;
            this.viewGetOrderForManagersBindingSource.CurrentChanged += new System.EventHandler(this.viewGetOrderForManagersBindingSource_CurrentChanged);
            // 
            // showByServicesGetOrders
            // 
            this.showByServicesGetOrders.Location = new System.Drawing.Point(531, 16);
            this.showByServicesGetOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showByServicesGetOrders.Name = "showByServicesGetOrders";
            this.showByServicesGetOrders.Size = new System.Drawing.Size(233, 46);
            this.showByServicesGetOrders.TabIndex = 1;
            this.showByServicesGetOrders.Text = "Просмотреть свои заказы";
            this.showByServicesGetOrders.UseVisualStyleBackColor = true;
            this.showByServicesGetOrders.Click += new System.EventHandler(this.showByServicesGetOrders_Click);
            // 
            // addServiceGroupBox
            // 
            this.addServiceGroupBox.Controls.Add(this.firstAdServiceButton);
            this.addServiceGroupBox.Controls.Add(this.previousAdServiceButton);
            this.addServiceGroupBox.Controls.Add(this.nextAdServiceButton);
            this.addServiceGroupBox.Controls.Add(this.lastAdServiceButton);
            this.addServiceGroupBox.Controls.Add(this.cancelAdServiceButton);
            this.addServiceGroupBox.Controls.Add(this.saveAdServiceButton);
            this.addServiceGroupBox.Controls.Add(this.deleteAdServiceButton);
            this.addServiceGroupBox.Controls.Add(this.addAdServiceButton);
            this.addServiceGroupBox.Controls.Add(this.dataGridView1);
            this.addServiceGroupBox.Location = new System.Drawing.Point(187, 64);
            this.addServiceGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addServiceGroupBox.Name = "addServiceGroupBox";
            this.addServiceGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addServiceGroupBox.Size = new System.Drawing.Size(903, 558);
            this.addServiceGroupBox.TabIndex = 8;
            this.addServiceGroupBox.TabStop = false;
            this.addServiceGroupBox.Text = "Добавить услугу";
            // 
            // firstAdServiceButton
            // 
            this.firstAdServiceButton.Location = new System.Drawing.Point(11, 281);
            this.firstAdServiceButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstAdServiceButton.Name = "firstAdServiceButton";
            this.firstAdServiceButton.Size = new System.Drawing.Size(105, 55);
            this.firstAdServiceButton.TabIndex = 13;
            this.firstAdServiceButton.Text = "Первый";
            this.firstAdServiceButton.UseVisualStyleBackColor = true;
            this.firstAdServiceButton.Click += new System.EventHandler(this.firstAdServiceButton_Click);
            // 
            // previousAdServiceButton
            // 
            this.previousAdServiceButton.Location = new System.Drawing.Point(123, 281);
            this.previousAdServiceButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.previousAdServiceButton.Name = "previousAdServiceButton";
            this.previousAdServiceButton.Size = new System.Drawing.Size(105, 55);
            this.previousAdServiceButton.TabIndex = 12;
            this.previousAdServiceButton.Text = "Предыдущий";
            this.previousAdServiceButton.UseVisualStyleBackColor = true;
            this.previousAdServiceButton.Click += new System.EventHandler(this.previousAdServiceButton_Click);
            // 
            // nextAdServiceButton
            // 
            this.nextAdServiceButton.Location = new System.Drawing.Point(233, 281);
            this.nextAdServiceButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nextAdServiceButton.Name = "nextAdServiceButton";
            this.nextAdServiceButton.Size = new System.Drawing.Size(105, 55);
            this.nextAdServiceButton.TabIndex = 11;
            this.nextAdServiceButton.Text = "Следующий";
            this.nextAdServiceButton.UseVisualStyleBackColor = true;
            this.nextAdServiceButton.Click += new System.EventHandler(this.nextAdServiceButton_Click);
            // 
            // lastAdServiceButton
            // 
            this.lastAdServiceButton.Location = new System.Drawing.Point(347, 281);
            this.lastAdServiceButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastAdServiceButton.Name = "lastAdServiceButton";
            this.lastAdServiceButton.Size = new System.Drawing.Size(105, 55);
            this.lastAdServiceButton.TabIndex = 10;
            this.lastAdServiceButton.Text = "Последний";
            this.lastAdServiceButton.UseVisualStyleBackColor = true;
            this.lastAdServiceButton.Click += new System.EventHandler(this.lastAdServiceButton_Click);
            // 
            // cancelAdServiceButton
            // 
            this.cancelAdServiceButton.Location = new System.Drawing.Point(457, 218);
            this.cancelAdServiceButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelAdServiceButton.Name = "cancelAdServiceButton";
            this.cancelAdServiceButton.Size = new System.Drawing.Size(105, 55);
            this.cancelAdServiceButton.TabIndex = 9;
            this.cancelAdServiceButton.Text = "Отмена";
            this.cancelAdServiceButton.UseVisualStyleBackColor = true;
            this.cancelAdServiceButton.Click += new System.EventHandler(this.cancelAdServiceButton_Click);
            // 
            // saveAdServiceButton
            // 
            this.saveAdServiceButton.Location = new System.Drawing.Point(457, 158);
            this.saveAdServiceButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveAdServiceButton.Name = "saveAdServiceButton";
            this.saveAdServiceButton.Size = new System.Drawing.Size(105, 55);
            this.saveAdServiceButton.TabIndex = 8;
            this.saveAdServiceButton.Text = "Сохранить";
            this.saveAdServiceButton.UseVisualStyleBackColor = true;
            this.saveAdServiceButton.Click += new System.EventHandler(this.saveAdServiceButton_Click);
            // 
            // deleteAdServiceButton
            // 
            this.deleteAdServiceButton.Location = new System.Drawing.Point(457, 96);
            this.deleteAdServiceButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteAdServiceButton.Name = "deleteAdServiceButton";
            this.deleteAdServiceButton.Size = new System.Drawing.Size(105, 55);
            this.deleteAdServiceButton.TabIndex = 7;
            this.deleteAdServiceButton.Text = "Удалить";
            this.deleteAdServiceButton.UseVisualStyleBackColor = true;
            this.deleteAdServiceButton.Click += new System.EventHandler(this.deleteAdServiceButton_Click);
            // 
            // addAdServiceButton
            // 
            this.addAdServiceButton.Location = new System.Drawing.Point(457, 34);
            this.addAdServiceButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addAdServiceButton.Name = "addAdServiceButton";
            this.addAdServiceButton.Size = new System.Drawing.Size(105, 55);
            this.addAdServiceButton.TabIndex = 6;
            this.addAdServiceButton.Text = "Добавить";
            this.addAdServiceButton.UseVisualStyleBackColor = true;
            this.addAdServiceButton.Click += new System.EventHandler(this.addAdServiceButton_Click);
            // 
            // addAPlaceOfAdGroupBox
            // 
            this.addAPlaceOfAdGroupBox.Controls.Add(this.rentGetFirstButton);
            this.addAPlaceOfAdGroupBox.Controls.Add(this.rentGetPreviousButton);
            this.addAPlaceOfAdGroupBox.Controls.Add(this.rentGetNextButton);
            this.addAPlaceOfAdGroupBox.Controls.Add(this.rentGetLastButton);
            this.addAPlaceOfAdGroupBox.Controls.Add(this.rentCancelButton);
            this.addAPlaceOfAdGroupBox.Controls.Add(this.rentSaveButton);
            this.addAPlaceOfAdGroupBox.Controls.Add(this.rentDeleteButton);
            this.addAPlaceOfAdGroupBox.Controls.Add(this.rentAddButton);
            this.addAPlaceOfAdGroupBox.Controls.Add(this.dataGridView2);
            this.addAPlaceOfAdGroupBox.Location = new System.Drawing.Point(187, 64);
            this.addAPlaceOfAdGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addAPlaceOfAdGroupBox.Name = "addAPlaceOfAdGroupBox";
            this.addAPlaceOfAdGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addAPlaceOfAdGroupBox.Size = new System.Drawing.Size(903, 558);
            this.addAPlaceOfAdGroupBox.TabIndex = 8;
            this.addAPlaceOfAdGroupBox.TabStop = false;
            this.addAPlaceOfAdGroupBox.Text = "Добавить место для рекламы";
            // 
            // rentGetFirstButton
            // 
            this.rentGetFirstButton.Location = new System.Drawing.Point(5, 274);
            this.rentGetFirstButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rentGetFirstButton.Name = "rentGetFirstButton";
            this.rentGetFirstButton.Size = new System.Drawing.Size(105, 55);
            this.rentGetFirstButton.TabIndex = 17;
            this.rentGetFirstButton.Text = "Первый";
            this.rentGetFirstButton.UseVisualStyleBackColor = true;
            this.rentGetFirstButton.Click += new System.EventHandler(this.rentGetFirstButton_Click);
            // 
            // rentGetPreviousButton
            // 
            this.rentGetPreviousButton.Location = new System.Drawing.Point(117, 274);
            this.rentGetPreviousButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rentGetPreviousButton.Name = "rentGetPreviousButton";
            this.rentGetPreviousButton.Size = new System.Drawing.Size(105, 55);
            this.rentGetPreviousButton.TabIndex = 16;
            this.rentGetPreviousButton.Text = "Предыдущий";
            this.rentGetPreviousButton.UseVisualStyleBackColor = true;
            this.rentGetPreviousButton.Click += new System.EventHandler(this.rentGetPreviousButton_Click);
            // 
            // rentGetNextButton
            // 
            this.rentGetNextButton.Location = new System.Drawing.Point(228, 274);
            this.rentGetNextButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rentGetNextButton.Name = "rentGetNextButton";
            this.rentGetNextButton.Size = new System.Drawing.Size(105, 55);
            this.rentGetNextButton.TabIndex = 15;
            this.rentGetNextButton.Text = "Следующий";
            this.rentGetNextButton.UseVisualStyleBackColor = true;
            this.rentGetNextButton.Click += new System.EventHandler(this.rentGetNextButton_Click);
            // 
            // rentGetLastButton
            // 
            this.rentGetLastButton.Location = new System.Drawing.Point(341, 274);
            this.rentGetLastButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rentGetLastButton.Name = "rentGetLastButton";
            this.rentGetLastButton.Size = new System.Drawing.Size(105, 55);
            this.rentGetLastButton.TabIndex = 14;
            this.rentGetLastButton.Text = "Последний";
            this.rentGetLastButton.UseVisualStyleBackColor = true;
            this.rentGetLastButton.Click += new System.EventHandler(this.rentGetLastButton_Click);
            // 
            // rentCancelButton
            // 
            this.rentCancelButton.Location = new System.Drawing.Point(452, 212);
            this.rentCancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rentCancelButton.Name = "rentCancelButton";
            this.rentCancelButton.Size = new System.Drawing.Size(105, 55);
            this.rentCancelButton.TabIndex = 13;
            this.rentCancelButton.Text = "Отмена";
            this.rentCancelButton.UseVisualStyleBackColor = true;
            this.rentCancelButton.Click += new System.EventHandler(this.rentCancelButton_Click);
            // 
            // rentSaveButton
            // 
            this.rentSaveButton.Location = new System.Drawing.Point(452, 151);
            this.rentSaveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rentSaveButton.Name = "rentSaveButton";
            this.rentSaveButton.Size = new System.Drawing.Size(105, 55);
            this.rentSaveButton.TabIndex = 12;
            this.rentSaveButton.Text = "Сохранить";
            this.rentSaveButton.UseVisualStyleBackColor = true;
            this.rentSaveButton.Click += new System.EventHandler(this.rentSaveButton_Click);
            // 
            // rentDeleteButton
            // 
            this.rentDeleteButton.Location = new System.Drawing.Point(452, 90);
            this.rentDeleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rentDeleteButton.Name = "rentDeleteButton";
            this.rentDeleteButton.Size = new System.Drawing.Size(105, 55);
            this.rentDeleteButton.TabIndex = 11;
            this.rentDeleteButton.Text = "Удалить";
            this.rentDeleteButton.UseVisualStyleBackColor = true;
            this.rentDeleteButton.Click += new System.EventHandler(this.rentDeleteButton_Click);
            // 
            // rentAddButton
            // 
            this.rentAddButton.Location = new System.Drawing.Point(452, 30);
            this.rentAddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rentAddButton.Name = "rentAddButton";
            this.rentAddButton.Size = new System.Drawing.Size(105, 55);
            this.rentAddButton.TabIndex = 10;
            this.rentAddButton.Text = "Добавить";
            this.rentAddButton.UseVisualStyleBackColor = true;
            this.rentAddButton.Click += new System.EventHandler(this.rentAddButton_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rentPriceDataGridViewTextBoxColumn,
            this.placeIDDataGridViewTextBoxColumn,
            this.typeOfAdDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.placeOfAdvertisementBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(5, 30);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(440, 240);
            this.dataGridView2.TabIndex = 0;
            // 
            // rentPriceDataGridViewTextBoxColumn
            // 
            this.rentPriceDataGridViewTextBoxColumn.DataPropertyName = "rentPrice";
            this.rentPriceDataGridViewTextBoxColumn.HeaderText = "rentPrice";
            this.rentPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rentPriceDataGridViewTextBoxColumn.Name = "rentPriceDataGridViewTextBoxColumn";
            this.rentPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // placeIDDataGridViewTextBoxColumn
            // 
            this.placeIDDataGridViewTextBoxColumn.DataPropertyName = "placeID";
            this.placeIDDataGridViewTextBoxColumn.HeaderText = "placeID";
            this.placeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.placeIDDataGridViewTextBoxColumn.Name = "placeIDDataGridViewTextBoxColumn";
            this.placeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.placeIDDataGridViewTextBoxColumn.Visible = false;
            this.placeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // typeOfAdDataGridViewTextBoxColumn
            // 
            this.typeOfAdDataGridViewTextBoxColumn.DataPropertyName = "typeOfAd";
            this.typeOfAdDataGridViewTextBoxColumn.HeaderText = "typeOfAd";
            this.typeOfAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeOfAdDataGridViewTextBoxColumn.Name = "typeOfAdDataGridViewTextBoxColumn";
            this.typeOfAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // placeOfAdvertisementBindingSource
            // 
            this.placeOfAdvertisementBindingSource.DataMember = "placeOfAdvertisement";
            this.placeOfAdvertisementBindingSource.DataSource = this.advertiseKursovayaDataSet1;
            // 
            // makeAnOrderGroupBox
            // 
            this.makeAnOrderGroupBox.Controls.Add(this.numericUpDown1);
            this.makeAnOrderGroupBox.Controls.Add(this.fullPriceLabel);
            this.makeAnOrderGroupBox.Controls.Add(this.label6);
            this.makeAnOrderGroupBox.Controls.Add(this.label5);
            this.makeAnOrderGroupBox.Controls.Add(this.comleteOrderButton);
            this.makeAnOrderGroupBox.Controls.Add(this.label4);
            this.makeAnOrderGroupBox.Controls.Add(this.checkOfOrderTextBox);
            this.makeAnOrderGroupBox.Controls.Add(this.label3);
            this.makeAnOrderGroupBox.Controls.Add(this.dropDownMenuRent);
            this.makeAnOrderGroupBox.Controls.Add(this.label2);
            this.makeAnOrderGroupBox.Controls.Add(this.dropDownMenuService);
            this.makeAnOrderGroupBox.Controls.Add(this.label1);
            this.makeAnOrderGroupBox.Controls.Add(this.dropDownMenuManager);
            this.makeAnOrderGroupBox.Location = new System.Drawing.Point(187, 64);
            this.makeAnOrderGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.makeAnOrderGroupBox.Name = "makeAnOrderGroupBox";
            this.makeAnOrderGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.makeAnOrderGroupBox.Size = new System.Drawing.Size(903, 558);
            this.makeAnOrderGroupBox.TabIndex = 8;
            this.makeAnOrderGroupBox.TabStop = false;
            this.makeAnOrderGroupBox.Text = "Сделать заказ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.numericUpDown1.Location = new System.Drawing.Point(311, 169);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(325, 28);
            this.numericUpDown1.TabIndex = 16;
            this.numericUpDown1.ThousandsSeparator = true;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // fullPriceLabel
            // 
            this.fullPriceLabel.AutoSize = true;
            this.fullPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.fullPriceLabel.Location = new System.Drawing.Point(477, 222);
            this.fullPriceLabel.Name = "fullPriceLabel";
            this.fullPriceLabel.Size = new System.Drawing.Size(0, 26);
            this.fullPriceLabel.TabIndex = 13;
            this.fullPriceLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label6.Location = new System.Drawing.Point(232, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 26);
            this.label6.TabIndex = 12;
            this.label6.Text = "Полная цена аренды";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.label5.Location = new System.Drawing.Point(231, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 31);
            this.label5.TabIndex = 11;
            this.label5.Text = "Чек";
            // 
            // comleteOrderButton
            // 
            this.comleteOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.comleteOrderButton.Location = new System.Drawing.Point(519, 311);
            this.comleteOrderButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comleteOrderButton.Name = "comleteOrderButton";
            this.comleteOrderButton.Size = new System.Drawing.Size(179, 79);
            this.comleteOrderButton.TabIndex = 10;
            this.comleteOrderButton.Text = "Сделать заказ";
            this.comleteOrderButton.UseVisualStyleBackColor = true;
            this.comleteOrderButton.Click += new System.EventHandler(this.comleteOrderButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label4.Location = new System.Drawing.Point(11, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(293, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Выбрать срок аренды(в месяцах)";
            // 
            // checkOfOrderTextBox
            // 
            this.checkOfOrderTextBox.Location = new System.Drawing.Point(13, 311);
            this.checkOfOrderTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkOfOrderTextBox.Multiline = true;
            this.checkOfOrderTextBox.Name = "checkOfOrderTextBox";
            this.checkOfOrderTextBox.Size = new System.Drawing.Size(489, 222);
            this.checkOfOrderTextBox.TabIndex = 6;
            this.checkOfOrderTextBox.TextChanged += new System.EventHandler(this.checkOfOrderTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label3.Location = new System.Drawing.Point(145, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Выбрать аренду";
            // 
            // dropDownMenuRent
            // 
            this.dropDownMenuRent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDownMenuRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.dropDownMenuRent.FormattingEnabled = true;
            this.dropDownMenuRent.Location = new System.Drawing.Point(311, 126);
            this.dropDownMenuRent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dropDownMenuRent.Name = "dropDownMenuRent";
            this.dropDownMenuRent.Size = new System.Drawing.Size(325, 30);
            this.dropDownMenuRent.TabIndex = 4;
            this.dropDownMenuRent.SelectedIndexChanged += new System.EventHandler(this.dropDownMenuRent_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label2.Location = new System.Drawing.Point(152, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выбрать услугу";
            // 
            // dropDownMenuService
            // 
            this.dropDownMenuService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDownMenuService.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.dropDownMenuService.FormattingEnabled = true;
            this.dropDownMenuService.Location = new System.Drawing.Point(311, 78);
            this.dropDownMenuService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dropDownMenuService.Name = "dropDownMenuService";
            this.dropDownMenuService.Size = new System.Drawing.Size(325, 30);
            this.dropDownMenuService.TabIndex = 2;
            this.dropDownMenuService.SelectedIndexChanged += new System.EventHandler(this.dropDownMenuService_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.Location = new System.Drawing.Point(107, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выбрать менеджера";
            // 
            // dropDownMenuManager
            // 
            this.dropDownMenuManager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDownMenuManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.dropDownMenuManager.FormattingEnabled = true;
            this.dropDownMenuManager.Location = new System.Drawing.Point(311, 23);
            this.dropDownMenuManager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dropDownMenuManager.Name = "dropDownMenuManager";
            this.dropDownMenuManager.Size = new System.Drawing.Size(325, 30);
            this.dropDownMenuManager.TabIndex = 0;
            this.dropDownMenuManager.SelectedIndexChanged += new System.EventHandler(this.dropDownMenuManager_SelectedIndexChanged);
            // 
            // reportOrderFromCustomers
            // 
            this.reportOrderFromCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.reportOrderFromCustomers.Location = new System.Drawing.Point(12, 282);
            this.reportOrderFromCustomers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportOrderFromCustomers.Name = "reportOrderFromCustomers";
            this.reportOrderFromCustomers.Size = new System.Drawing.Size(169, 69);
            this.reportOrderFromCustomers.TabIndex = 9;
            this.reportOrderFromCustomers.Text = "Отчет о заказах";
            this.reportOrderFromCustomers.UseVisualStyleBackColor = true;
            this.reportOrderFromCustomers.Click += new System.EventHandler(this.reportOrderForCustomers_Click);
            // 
            // editOrdersButton
            // 
            this.editOrdersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.editOrdersButton.Location = new System.Drawing.Point(12, 102);
            this.editOrdersButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editOrdersButton.Name = "editOrdersButton";
            this.editOrdersButton.Size = new System.Drawing.Size(169, 84);
            this.editOrdersButton.TabIndex = 10;
            this.editOrdersButton.Text = "Редактировать заказы";
            this.editOrdersButton.UseVisualStyleBackColor = true;
            this.editOrdersButton.Click += new System.EventHandler(this.editOrdersButton_Click);
            // 
            // EditOrderGroupBox
            // 
            this.EditOrderGroupBox.Controls.Add(this.deleteLabel);
            this.EditOrderGroupBox.Controls.Add(this.deleteOrderButton);
            this.EditOrderGroupBox.Controls.Add(this.completeChangesLabel);
            this.EditOrderGroupBox.Controls.Add(this.editTypeOfAdButton);
            this.EditOrderGroupBox.Controls.Add(this.label15);
            this.EditOrderGroupBox.Controls.Add(this.orderIDEditOrder);
            this.EditOrderGroupBox.Controls.Add(this.labelNameOfCustomer);
            this.EditOrderGroupBox.Controls.Add(this.label13);
            this.EditOrderGroupBox.Controls.Add(this.updateOrderButton);
            this.EditOrderGroupBox.Controls.Add(this.editedFullPrice);
            this.EditOrderGroupBox.Controls.Add(this.label12);
            this.EditOrderGroupBox.Controls.Add(this.button2);
            this.EditOrderGroupBox.Controls.Add(this.numericUpDownEditOrder);
            this.EditOrderGroupBox.Controls.Add(this.label7);
            this.EditOrderGroupBox.Controls.Add(this.label8);
            this.EditOrderGroupBox.Controls.Add(this.rentPlaceEditOrder);
            this.EditOrderGroupBox.Controls.Add(this.label9);
            this.EditOrderGroupBox.Controls.Add(this.serviceEditOrder);
            this.EditOrderGroupBox.Controls.Add(this.label10);
            this.EditOrderGroupBox.Controls.Add(this.managerEditOrder);
            this.EditOrderGroupBox.Location = new System.Drawing.Point(187, 64);
            this.EditOrderGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditOrderGroupBox.Name = "EditOrderGroupBox";
            this.EditOrderGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditOrderGroupBox.Size = new System.Drawing.Size(903, 558);
            this.EditOrderGroupBox.TabIndex = 18;
            this.EditOrderGroupBox.TabStop = false;
            this.EditOrderGroupBox.Text = "Редактировать заказы";
            this.EditOrderGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // deleteLabel
            // 
            this.deleteLabel.AutoSize = true;
            this.deleteLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.deleteLabel.Location = new System.Drawing.Point(508, 436);
            this.deleteLabel.Name = "deleteLabel";
            this.deleteLabel.Size = new System.Drawing.Size(0, 16);
            this.deleteLabel.TabIndex = 37;
            // 
            // deleteOrderButton
            // 
            this.deleteOrderButton.Location = new System.Drawing.Point(455, 466);
            this.deleteOrderButton.Name = "deleteOrderButton";
            this.deleteOrderButton.Size = new System.Drawing.Size(181, 81);
            this.deleteOrderButton.TabIndex = 36;
            this.deleteOrderButton.Text = "Аннулировать заказ";
            this.deleteOrderButton.UseVisualStyleBackColor = true;
            this.deleteOrderButton.Click += new System.EventHandler(this.deleteOrderButton_Click);
            // 
            // completeChangesLabel
            // 
            this.completeChangesLabel.AutoSize = true;
            this.completeChangesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.completeChangesLabel.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.completeChangesLabel.Location = new System.Drawing.Point(240, 36);
            this.completeChangesLabel.Name = "completeChangesLabel";
            this.completeChangesLabel.Size = new System.Drawing.Size(380, 22);
            this.completeChangesLabel.TabIndex = 35;
            this.completeChangesLabel.Text = "Поздравляю, вы успешно обновили данные";
            this.completeChangesLabel.Visible = false;
            // 
            // editTypeOfAdButton
            // 
            this.editTypeOfAdButton.Location = new System.Drawing.Point(627, 283);
            this.editTypeOfAdButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editTypeOfAdButton.Name = "editTypeOfAdButton";
            this.editTypeOfAdButton.Size = new System.Drawing.Size(137, 25);
            this.editTypeOfAdButton.TabIndex = 34;
            this.editTypeOfAdButton.Text = "Редактировать";
            this.editTypeOfAdButton.UseVisualStyleBackColor = true;
            this.editTypeOfAdButton.Click += new System.EventHandler(this.editTypeOfAdButton_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label15.Location = new System.Drawing.Point(100, 94);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(202, 22);
            this.label15.TabIndex = 33;
            this.label15.Text = "Выбрать номер заказа";
            // 
            // orderIDEditOrder
            // 
            this.orderIDEditOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orderIDEditOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.orderIDEditOrder.FormattingEnabled = true;
            this.orderIDEditOrder.Location = new System.Drawing.Point(324, 90);
            this.orderIDEditOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderIDEditOrder.Name = "orderIDEditOrder";
            this.orderIDEditOrder.Size = new System.Drawing.Size(296, 30);
            this.orderIDEditOrder.TabIndex = 32;
            this.orderIDEditOrder.SelectedIndexChanged += new System.EventHandler(this.orderIDEditOrder_SelectedIndexChanged);
            this.orderIDEditOrder.Click += new System.EventHandler(this.orderIDEditOrder_Click);
            // 
            // labelNameOfCustomer
            // 
            this.labelNameOfCustomer.AutoSize = true;
            this.labelNameOfCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.labelNameOfCustomer.Location = new System.Drawing.Point(320, 142);
            this.labelNameOfCustomer.Name = "labelNameOfCustomer";
            this.labelNameOfCustomer.Size = new System.Drawing.Size(43, 22);
            this.labelNameOfCustomer.TabIndex = 31;
            this.labelNameOfCustomer.Text = "имя";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label13.Location = new System.Drawing.Point(165, 142);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(137, 22);
            this.label13.TabIndex = 30;
            this.label13.Text = "Имя заказчика";
            // 
            // updateOrderButton
            // 
            this.updateOrderButton.Location = new System.Drawing.Point(52, 466);
            this.updateOrderButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateOrderButton.Name = "updateOrderButton";
            this.updateOrderButton.Size = new System.Drawing.Size(181, 81);
            this.updateOrderButton.TabIndex = 29;
            this.updateOrderButton.Text = "Подтвердить изменение заказа";
            this.updateOrderButton.UseVisualStyleBackColor = true;
            this.updateOrderButton.Click += new System.EventHandler(this.updateOrderButton_Click);
            // 
            // editedFullPrice
            // 
            this.editedFullPrice.AutoSize = true;
            this.editedFullPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.editedFullPrice.Location = new System.Drawing.Point(252, 426);
            this.editedFullPrice.Name = "editedFullPrice";
            this.editedFullPrice.Size = new System.Drawing.Size(0, 26);
            this.editedFullPrice.TabIndex = 28;
            this.editedFullPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label12.Location = new System.Drawing.Point(6, 426);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(227, 26);
            this.label12.TabIndex = 27;
            this.label12.Text = "Полная цена аренды";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(627, 234);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 25);
            this.button2.TabIndex = 26;
            this.button2.Text = "Редактировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericUpDownEditOrder
            // 
            this.numericUpDownEditOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.numericUpDownEditOrder.Location = new System.Drawing.Point(324, 326);
            this.numericUpDownEditOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownEditOrder.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownEditOrder.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownEditOrder.Name = "numericUpDownEditOrder";
            this.numericUpDownEditOrder.ReadOnly = true;
            this.numericUpDownEditOrder.Size = new System.Drawing.Size(296, 28);
            this.numericUpDownEditOrder.TabIndex = 25;
            this.numericUpDownEditOrder.ThousandsSeparator = true;
            this.numericUpDownEditOrder.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownEditOrder.ValueChanged += new System.EventHandler(this.numericUpDownEditOrder_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label7.Location = new System.Drawing.Point(9, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(293, 22);
            this.label7.TabIndex = 24;
            this.label7.Text = "Выбрать срок аренды(в месяцах)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label8.Location = new System.Drawing.Point(155, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 22);
            this.label8.TabIndex = 23;
            this.label8.Text = "Выбрать аренду";
            // 
            // rentPlaceEditOrder
            // 
            this.rentPlaceEditOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rentPlaceEditOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.rentPlaceEditOrder.FormattingEnabled = true;
            this.rentPlaceEditOrder.Location = new System.Drawing.Point(324, 283);
            this.rentPlaceEditOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rentPlaceEditOrder.Name = "rentPlaceEditOrder";
            this.rentPlaceEditOrder.Size = new System.Drawing.Size(296, 30);
            this.rentPlaceEditOrder.TabIndex = 22;
            this.rentPlaceEditOrder.SelectedIndexChanged += new System.EventHandler(this.rentPlaceEditOrder_SelectedIndexChanged);
            this.rentPlaceEditOrder.Click += new System.EventHandler(this.rentPlaceEditOrder_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label9.Location = new System.Drawing.Point(163, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 22);
            this.label9.TabIndex = 21;
            this.label9.Text = "Выбрать услугу";
            // 
            // serviceEditOrder
            // 
            this.serviceEditOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serviceEditOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.serviceEditOrder.FormattingEnabled = true;
            this.serviceEditOrder.Location = new System.Drawing.Point(324, 234);
            this.serviceEditOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.serviceEditOrder.Name = "serviceEditOrder";
            this.serviceEditOrder.Size = new System.Drawing.Size(296, 30);
            this.serviceEditOrder.TabIndex = 20;
            this.serviceEditOrder.SelectedIndexChanged += new System.EventHandler(this.serviceEditOrder_SelectedIndexChanged);
            this.serviceEditOrder.Click += new System.EventHandler(this.serviceEditOrder_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label10.Location = new System.Drawing.Point(117, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(185, 22);
            this.label10.TabIndex = 19;
            this.label10.Text = "Выбрать менеджера";
            // 
            // managerEditOrder
            // 
            this.managerEditOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.managerEditOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.managerEditOrder.FormattingEnabled = true;
            this.managerEditOrder.Location = new System.Drawing.Point(324, 180);
            this.managerEditOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.managerEditOrder.Name = "managerEditOrder";
            this.managerEditOrder.Size = new System.Drawing.Size(296, 30);
            this.managerEditOrder.TabIndex = 18;
            // 
            // execReportOfResultsButton
            // 
            this.execReportOfResultsButton.Location = new System.Drawing.Point(916, 11);
            this.execReportOfResultsButton.Name = "execReportOfResultsButton";
            this.execReportOfResultsButton.Size = new System.Drawing.Size(168, 48);
            this.execReportOfResultsButton.TabIndex = 19;
            this.execReportOfResultsButton.Text = "Результаты работы";
            this.execReportOfResultsButton.UseVisualStyleBackColor = true;
            this.execReportOfResultsButton.Visible = false;
            this.execReportOfResultsButton.Click += new System.EventHandler(this.execReportOfResultsButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(742, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 48);
            this.button1.TabIndex = 20;
            this.button1.Text = "Изменить данные профиля";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // viewGetOrderForCustomersTableAdapter1
            // 
            this.viewGetOrderForCustomersTableAdapter1.ClearBeforeFill = true;
            // 
            // viewGetOrderForManagersTableAdapter1
            // 
            this.viewGetOrderForManagersTableAdapter1.ClearBeforeFill = true;
            // 
            // getServiceBindingSource
            // 
            this.getServiceBindingSource.DataMember = "getService";
            this.getServiceBindingSource.DataSource = this.advertiseKursovayaDataSet1;
            // 
            // getServiceTableAdapter
            // 
            this.getServiceTableAdapter.ClearBeforeFill = true;
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
            // placeOfAdvertisementTableAdapter
            // 
            this.placeOfAdvertisementTableAdapter.ClearBeforeFill = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(140, 92);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(149, 16);
            this.label21.TabIndex = 30;
            this.label21.Text = "Выберите менеджера";
            // 
            // managerFilterComboBox
            // 
            this.managerFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.managerFilterComboBox.FormattingEnabled = true;
            this.managerFilterComboBox.Location = new System.Drawing.Point(296, 89);
            this.managerFilterComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.managerFilterComboBox.Name = "managerFilterComboBox";
            this.managerFilterComboBox.Size = new System.Drawing.Size(185, 24);
            this.managerFilterComboBox.TabIndex = 29;
            this.managerFilterComboBox.SelectedIndexChanged += new System.EventHandler(this.managerFilterComboBox_SelectedIndexChanged);
            // 
            // filterManagerCheckBox
            // 
            this.filterManagerCheckBox.AutoSize = true;
            this.filterManagerCheckBox.Location = new System.Drawing.Point(493, 91);
            this.filterManagerCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.filterManagerCheckBox.Name = "filterManagerCheckBox";
            this.filterManagerCheckBox.Size = new System.Drawing.Size(229, 20);
            this.filterManagerCheckBox.TabIndex = 31;
            this.filterManagerCheckBox.Text = "Отфильтровать по менеджеру";
            this.filterManagerCheckBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1101, 645);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.execReportOfResultsButton);
            this.Controls.Add(this.getOrderGroupBox);
            this.Controls.Add(this.addServiceGroupBox);
            this.Controls.Add(this.editOrdersButton);
            this.Controls.Add(this.reportOrderFromCustomers);
            this.Controls.Add(this.addAPlaceOfAdGroupBox);
            this.Controls.Add(this.greetingsLabel);
            this.Controls.Add(this.addPlaceOfAdButton);
            this.Controls.Add(this.EditOrderGroupBox);
            this.Controls.Add(this.makeOrderButton);
            this.Controls.Add(this.addServiceButton);
            this.Controls.Add(this.getOrderButton);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.makeAnOrderGroupBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adServicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advertiseKursovayaDataSet1)).EndInit();
            this.getOrderGroupBox.ResumeLayout(false);
            this.ChangeDataGroupBox.ResumeLayout(false);
            this.ChangeDataGroupBox.PerformLayout();
            this.filterByDateGroupbox.ResumeLayout(false);
            this.filterByDateGroupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewGetOrderForCustomersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewGetOrderForCustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewGetOrderForManagersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewGetOrderForManagersBindingSource)).EndInit();
            this.addServiceGroupBox.ResumeLayout(false);
            this.addAPlaceOfAdGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeOfAdvertisementBindingSource)).EndInit();
            this.makeAnOrderGroupBox.ResumeLayout(false);
            this.makeAnOrderGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.EditOrderGroupBox.ResumeLayout(false);
            this.EditOrderGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEditOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getServiceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Button getOrderButton;
        private System.Windows.Forms.Button makeOrderButton;
        private System.Windows.Forms.Button addServiceButton;
        private System.Windows.Forms.Button addPlaceOfAdButton;
        private advertiseKursovayaDataSet advertiseKursovayaDataSet1;
        private advertiseKursovayaDataSetTableAdapters.viewGetOrderForCustomersTableAdapter viewGetOrderForCustomersTableAdapter1;
        private advertiseKursovayaDataSetTableAdapters.viewGetOrderForManagersTableAdapter viewGetOrderForManagersTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource getServiceBindingSource;
        private advertiseKursovayaDataSetTableAdapters.getServiceTableAdapter getServiceTableAdapter;
        private System.Windows.Forms.BindingSource adServicesBindingSource;
        private advertiseKursovayaDataSetTableAdapters.adServicesTableAdapter adServicesTableAdapter;
        private System.Windows.Forms.Label greetingsLabel;
        private System.Windows.Forms.GroupBox getOrderGroupBox;
        private System.Windows.Forms.GroupBox makeAnOrderGroupBox;
        private System.Windows.Forms.GroupBox addServiceGroupBox;
        private System.Windows.Forms.Button firstAdServiceButton;
        private System.Windows.Forms.Button previousAdServiceButton;
        private System.Windows.Forms.Button nextAdServiceButton;
        private System.Windows.Forms.Button lastAdServiceButton;
        private System.Windows.Forms.Button cancelAdServiceButton;
        private System.Windows.Forms.Button saveAdServiceButton;
        private System.Windows.Forms.Button deleteAdServiceButton;
        private System.Windows.Forms.Button addAdServiceButton;
        private System.Windows.Forms.BindingSource viewGetOrderForCustomersBindingSource;
        private System.Windows.Forms.Button showByServicesGetOrders;
        private advertiseKursovayaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView viewGetOrderForManagersDataGridView;
        private System.Windows.Forms.BindingSource viewGetOrderForManagersBindingSource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button comleteOrderButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox checkOfOrderTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource placeOfAdvertisementBindingSource;
        private advertiseKursovayaDataSetTableAdapters.placeOfAdvertisementTableAdapter placeOfAdvertisementTableAdapter;
        private System.Windows.Forms.DataGridView viewGetOrderForCustomersDataGridView;
        private System.Windows.Forms.Button reportOrderForManagersButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.ComboBox filterBoxByService;
        private System.Windows.Forms.Button filterButtonForManagers;
        private System.Windows.Forms.Button filterButtonForCustomers;
        private System.Windows.Forms.GroupBox addAPlaceOfAdGroupBox;
        private System.Windows.Forms.Button rentGetFirstButton;
        private System.Windows.Forms.Button rentGetPreviousButton;
        private System.Windows.Forms.Button rentGetNextButton;
        private System.Windows.Forms.Button rentGetLastButton;
        private System.Windows.Forms.Button rentCancelButton;
        private System.Windows.Forms.Button rentSaveButton;
        private System.Windows.Forms.Button rentDeleteButton;
        private System.Windows.Forms.Button rentAddButton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeOfAdDataGridViewTextBoxColumn;
        public System.Windows.Forms.NumericUpDown numericUpDown1;
        public System.Windows.Forms.ComboBox dropDownMenuRent;
        public System.Windows.Forms.ComboBox dropDownMenuService;
        public System.Windows.Forms.ComboBox dropDownMenuManager;
        public System.Windows.Forms.Label fullPriceLabel;
        private System.Windows.Forms.Button reportOrderFromCustomers;
        private System.Windows.Forms.Button editOrdersButton;
        private System.Windows.Forms.GroupBox EditOrderGroupBox;
        private System.Windows.Forms.Button updateOrderButton;
        public System.Windows.Forms.Label editedFullPrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.NumericUpDown numericUpDownEditOrder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox rentPlaceEditOrder;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.ComboBox serviceEditOrder;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox managerEditOrder;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.ComboBox orderIDEditOrder;
        private System.Windows.Forms.Label labelNameOfCustomer;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button editTypeOfAdButton;
        private System.Windows.Forms.Label completeChangesLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerLastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerFirstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerMiddlenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeOfAdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAdFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAdToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentPriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.GroupBox filterByDateGroupbox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox serviceCheckBox;
        private System.Windows.Forms.CheckBox dateCheckBox;
        private System.Windows.Forms.Button execReportOfResultsButton;
        private System.Windows.Forms.Button deleteOrderButton;
        private System.Windows.Forms.Label deleteLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox ChangeDataGroupBox;
        private System.Windows.Forms.Button submitChangesButton;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox newPasswordTextBox;
        private System.Windows.Forms.TextBox newEmailTextBox;
        private System.Windows.Forms.TextBox oldPasswordTextBox;
        private System.Windows.Forms.TextBox oldEmailTextBox;
        private System.Windows.Forms.ListBox changesInfoListBox;
        private System.Windows.Forms.CheckBox changeOnlyPasswordCheckBox;
        private System.Windows.Forms.CheckBox changeOnlyMailCheckBox;
        private System.Windows.Forms.CheckBox changeAllDataCheckBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox filterManagerCheckBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox managerFilterComboBox;
    }
}