namespace KurshachKorepi4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.базаДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьТСToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоVINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьТСToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьТСToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.vansPage = new System.Windows.Forms.TabPage();
            this.van_DGV = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vinNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mileageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.axlesAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintenanceDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carConditionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transmissionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vanBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleDataSet2 = new KurshachKorepi4.VehicleDataSet2();
            this.trailersPage = new System.Windows.Forms.TabPage();
            this.trailer_DGV = new System.Windows.Forms.DataGridView();
            this.trailerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleDataSet5 = new KurshachKorepi4.VehicleDataSet5();
            this.tractorsPage = new System.Windows.Forms.TabPage();
            this.tractor_DGV = new System.Windows.Forms.DataGridView();
            this.tractorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleDataSet6 = new KurshachKorepi4.VehicleDataSet6();
            this.vanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleDataSet1 = new KurshachKorepi4.VehicleDataSet1();
            this.vanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleDataSet = new KurshachKorepi4.VehicleDataSet();
            this.vanTableAdapter = new KurshachKorepi4.VehicleDataSetTableAdapters.VanTableAdapter();
            this.vehicleDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vanTableAdapter1 = new KurshachKorepi4.VehicleDataSet1TableAdapters.VanTableAdapter();
            this.vanTableAdapter2 = new KurshachKorepi4.VehicleDataSet2TableAdapters.VanTableAdapter();
            this.vehicleDataSet3 = new KurshachKorepi4.VehicleDataSet3();
            this.trailerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trailerTableAdapter = new KurshachKorepi4.VehicleDataSet3TableAdapters.TrailerTableAdapter();
            this.vehicleDataSet4 = new KurshachKorepi4.VehicleDataSet4();
            this.tractorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tractorTableAdapter = new KurshachKorepi4.VehicleDataSet4TableAdapters.TractorTableAdapter();
            this.trailerTableAdapter1 = new KurshachKorepi4.VehicleDataSet5TableAdapters.TrailerTableAdapter();
            this.tractorTableAdapter1 = new KurshachKorepi4.VehicleDataSet6TableAdapters.TractorTableAdapter();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vinNumberDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mileageDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.axlesAmountDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintenanceDateDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carConditionDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transmissionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sleepingBagAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vinNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mileageDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.axlesAmountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintenanceDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carConditionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.liftingAxleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suspensionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.vansPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.van_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDataSet2)).BeginInit();
            this.trailersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trailer_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trailerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDataSet5)).BeginInit();
            this.tractorsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tractor_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tractorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trailerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tractorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.базаДанныхToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1152, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // базаДанныхToolStripMenuItem
            // 
            this.базаДанныхToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьТСToolStripMenuItem,
            this.поискПоVINToolStripMenuItem,
            this.изменитьТСToolStripMenuItem,
            this.удалитьТСToolStripMenuItem,
            this.обновитьБДToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.базаДанныхToolStripMenuItem.Name = "базаДанныхToolStripMenuItem";
            this.базаДанныхToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.базаДанныхToolStripMenuItem.Text = "База данных";
            // 
            // добавитьТСToolStripMenuItem
            // 
            this.добавитьТСToolStripMenuItem.Name = "добавитьТСToolStripMenuItem";
            this.добавитьТСToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.добавитьТСToolStripMenuItem.Text = "Добавить ТС";
            this.добавитьТСToolStripMenuItem.Click += new System.EventHandler(this.добавитьТСToolStripMenuItem_Click);
            // 
            // поискПоVINToolStripMenuItem
            // 
            this.поискПоVINToolStripMenuItem.Name = "поискПоVINToolStripMenuItem";
            this.поискПоVINToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поискПоVINToolStripMenuItem.Text = "Поиск по VIN";
            this.поискПоVINToolStripMenuItem.Click += new System.EventHandler(this.поискПоVINToolStripMenuItem_Click);
            // 
            // изменитьТСToolStripMenuItem
            // 
            this.изменитьТСToolStripMenuItem.Name = "изменитьТСToolStripMenuItem";
            this.изменитьТСToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.изменитьТСToolStripMenuItem.Text = "Изменить ТС";
            this.изменитьТСToolStripMenuItem.Click += new System.EventHandler(this.изменитьТСToolStripMenuItem_Click);
            // 
            // удалитьТСToolStripMenuItem
            // 
            this.удалитьТСToolStripMenuItem.Name = "удалитьТСToolStripMenuItem";
            this.удалитьТСToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.удалитьТСToolStripMenuItem.Text = "Удалить ТС";
            this.удалитьТСToolStripMenuItem.Click += new System.EventHandler(this.удалитьТСToolStripMenuItem_Click);
            // 
            // обновитьБДToolStripMenuItem
            // 
            this.обновитьБДToolStripMenuItem.Name = "обновитьБДToolStripMenuItem";
            this.обновитьБДToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.обновитьБДToolStripMenuItem.Text = "Обновить БД";
            this.обновитьБДToolStripMenuItem.Click += new System.EventHandler(this.обновитьБДToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.vansPage);
            this.tabControl.Controls.Add(this.trailersPage);
            this.tabControl.Controls.Add(this.tractorsPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1152, 516);
            this.tabControl.TabIndex = 1;
            // 
            // vansPage
            // 
            this.vansPage.Controls.Add(this.van_DGV);
            this.vansPage.Location = new System.Drawing.Point(4, 22);
            this.vansPage.Name = "vansPage";
            this.vansPage.Padding = new System.Windows.Forms.Padding(3);
            this.vansPage.Size = new System.Drawing.Size(1144, 490);
            this.vansPage.TabIndex = 0;
            this.vansPage.Text = "Фургоны";
            this.vansPage.UseVisualStyleBackColor = true;
            // 
            // van_DGV
            // 
            this.van_DGV.AllowUserToAddRows = false;
            this.van_DGV.AllowUserToDeleteRows = false;
            this.van_DGV.AutoGenerateColumns = false;
            this.van_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.van_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.vinNumberDataGridViewTextBoxColumn,
            this.mileageDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.axlesAmountDataGridViewTextBoxColumn,
            this.maintenanceDateDataGridViewTextBoxColumn,
            this.carConditionDataGridViewTextBoxColumn,
            this.transmissionDataGridViewTextBoxColumn});
            this.van_DGV.DataSource = this.vanBindingSource2;
            this.van_DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.van_DGV.Location = new System.Drawing.Point(3, 3);
            this.van_DGV.MultiSelect = false;
            this.van_DGV.Name = "van_DGV";
            this.van_DGV.ReadOnly = true;
            this.van_DGV.RowHeadersVisible = false;
            this.van_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.van_DGV.Size = new System.Drawing.Size(1138, 484);
            this.van_DGV.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vinNumberDataGridViewTextBoxColumn
            // 
            this.vinNumberDataGridViewTextBoxColumn.DataPropertyName = "vinNumber";
            this.vinNumberDataGridViewTextBoxColumn.HeaderText = "VIN ";
            this.vinNumberDataGridViewTextBoxColumn.Name = "vinNumberDataGridViewTextBoxColumn";
            this.vinNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.vinNumberDataGridViewTextBoxColumn.Width = 200;
            // 
            // mileageDataGridViewTextBoxColumn
            // 
            this.mileageDataGridViewTextBoxColumn.DataPropertyName = "mileage";
            this.mileageDataGridViewTextBoxColumn.HeaderText = "Пробег";
            this.mileageDataGridViewTextBoxColumn.Name = "mileageDataGridViewTextBoxColumn";
            this.mileageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Цвет";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // axlesAmountDataGridViewTextBoxColumn
            // 
            this.axlesAmountDataGridViewTextBoxColumn.DataPropertyName = "axlesAmount";
            this.axlesAmountDataGridViewTextBoxColumn.HeaderText = "Количество осей";
            this.axlesAmountDataGridViewTextBoxColumn.Name = "axlesAmountDataGridViewTextBoxColumn";
            this.axlesAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maintenanceDateDataGridViewTextBoxColumn
            // 
            this.maintenanceDateDataGridViewTextBoxColumn.DataPropertyName = "maintenanceDate";
            this.maintenanceDateDataGridViewTextBoxColumn.HeaderText = "Плановое ТО";
            this.maintenanceDateDataGridViewTextBoxColumn.Name = "maintenanceDateDataGridViewTextBoxColumn";
            this.maintenanceDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.maintenanceDateDataGridViewTextBoxColumn.Width = 200;
            // 
            // carConditionDataGridViewTextBoxColumn
            // 
            this.carConditionDataGridViewTextBoxColumn.DataPropertyName = "carCondition";
            this.carConditionDataGridViewTextBoxColumn.HeaderText = "Состояние";
            this.carConditionDataGridViewTextBoxColumn.Name = "carConditionDataGridViewTextBoxColumn";
            this.carConditionDataGridViewTextBoxColumn.ReadOnly = true;
            this.carConditionDataGridViewTextBoxColumn.Width = 150;
            // 
            // transmissionDataGridViewTextBoxColumn
            // 
            this.transmissionDataGridViewTextBoxColumn.DataPropertyName = "transmission";
            this.transmissionDataGridViewTextBoxColumn.HeaderText = "Привод";
            this.transmissionDataGridViewTextBoxColumn.Name = "transmissionDataGridViewTextBoxColumn";
            this.transmissionDataGridViewTextBoxColumn.ReadOnly = true;
            this.transmissionDataGridViewTextBoxColumn.Width = 150;
            // 
            // vanBindingSource2
            // 
            this.vanBindingSource2.DataMember = "Van";
            this.vanBindingSource2.DataSource = this.vehicleDataSet2;
            // 
            // vehicleDataSet2
            // 
            this.vehicleDataSet2.DataSetName = "VehicleDataSet2";
            this.vehicleDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trailersPage
            // 
            this.trailersPage.Controls.Add(this.trailer_DGV);
            this.trailersPage.Location = new System.Drawing.Point(4, 22);
            this.trailersPage.Name = "trailersPage";
            this.trailersPage.Padding = new System.Windows.Forms.Padding(3);
            this.trailersPage.Size = new System.Drawing.Size(1144, 490);
            this.trailersPage.TabIndex = 1;
            this.trailersPage.Text = "Прицепы";
            this.trailersPage.UseVisualStyleBackColor = true;
            // 
            // trailer_DGV
            // 
            this.trailer_DGV.AllowUserToAddRows = false;
            this.trailer_DGV.AllowUserToDeleteRows = false;
            this.trailer_DGV.AutoGenerateColumns = false;
            this.trailer_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trailer_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.vinNumberDataGridViewTextBoxColumn1,
            this.mileageDataGridViewTextBoxColumn1,
            this.colorDataGridViewTextBoxColumn1,
            this.axlesAmountDataGridViewTextBoxColumn1,
            this.maintenanceDateDataGridViewTextBoxColumn1,
            this.carConditionDataGridViewTextBoxColumn1,
            this.classificationDataGridViewTextBoxColumn,
            this.liftingAxleDataGridViewTextBoxColumn,
            this.suspensionDataGridViewTextBoxColumn});
            this.trailer_DGV.DataSource = this.trailerBindingSource1;
            this.trailer_DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trailer_DGV.Location = new System.Drawing.Point(3, 3);
            this.trailer_DGV.MultiSelect = false;
            this.trailer_DGV.Name = "trailer_DGV";
            this.trailer_DGV.ReadOnly = true;
            this.trailer_DGV.RowHeadersVisible = false;
            this.trailer_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.trailer_DGV.Size = new System.Drawing.Size(1138, 484);
            this.trailer_DGV.TabIndex = 0;
            // 
            // trailerBindingSource1
            // 
            this.trailerBindingSource1.DataMember = "Trailer";
            this.trailerBindingSource1.DataSource = this.vehicleDataSet5;
            // 
            // vehicleDataSet5
            // 
            this.vehicleDataSet5.DataSetName = "VehicleDataSet5";
            this.vehicleDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tractorsPage
            // 
            this.tractorsPage.Controls.Add(this.tractor_DGV);
            this.tractorsPage.Location = new System.Drawing.Point(4, 22);
            this.tractorsPage.Name = "tractorsPage";
            this.tractorsPage.Size = new System.Drawing.Size(1144, 490);
            this.tractorsPage.TabIndex = 2;
            this.tractorsPage.Text = "Тягачи";
            this.tractorsPage.UseVisualStyleBackColor = true;
            // 
            // tractor_DGV
            // 
            this.tractor_DGV.AllowUserToAddRows = false;
            this.tractor_DGV.AllowUserToDeleteRows = false;
            this.tractor_DGV.AutoGenerateColumns = false;
            this.tractor_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tractor_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.vinNumberDataGridViewTextBoxColumn2,
            this.mileageDataGridViewTextBoxColumn2,
            this.colorDataGridViewTextBoxColumn2,
            this.axlesAmountDataGridViewTextBoxColumn2,
            this.maintenanceDateDataGridViewTextBoxColumn2,
            this.carConditionDataGridViewTextBoxColumn2,
            this.transmissionDataGridViewTextBoxColumn1,
            this.sleepingBagAmountDataGridViewTextBoxColumn});
            this.tractor_DGV.DataSource = this.tractorBindingSource1;
            this.tractor_DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tractor_DGV.Location = new System.Drawing.Point(0, 0);
            this.tractor_DGV.MultiSelect = false;
            this.tractor_DGV.Name = "tractor_DGV";
            this.tractor_DGV.ReadOnly = true;
            this.tractor_DGV.RowHeadersVisible = false;
            this.tractor_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tractor_DGV.Size = new System.Drawing.Size(1144, 490);
            this.tractor_DGV.TabIndex = 0;
            // 
            // tractorBindingSource1
            // 
            this.tractorBindingSource1.DataMember = "Tractor";
            this.tractorBindingSource1.DataSource = this.vehicleDataSet6;
            // 
            // vehicleDataSet6
            // 
            this.vehicleDataSet6.DataSetName = "VehicleDataSet6";
            this.vehicleDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vanBindingSource1
            // 
            this.vanBindingSource1.DataMember = "Van";
            this.vanBindingSource1.DataSource = this.vehicleDataSet1;
            // 
            // vehicleDataSet1
            // 
            this.vehicleDataSet1.DataSetName = "VehicleDataSet1";
            this.vehicleDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vanBindingSource
            // 
            this.vanBindingSource.DataMember = "Van";
            this.vanBindingSource.DataSource = this.vehicleDataSet;
            // 
            // vehicleDataSet
            // 
            this.vehicleDataSet.DataSetName = "VehicleDataSet";
            this.vehicleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vanTableAdapter
            // 
            this.vanTableAdapter.ClearBeforeFill = true;
            // 
            // vehicleDataSetBindingSource
            // 
            this.vehicleDataSetBindingSource.DataSource = this.vehicleDataSet;
            this.vehicleDataSetBindingSource.Position = 0;
            // 
            // vanTableAdapter1
            // 
            this.vanTableAdapter1.ClearBeforeFill = true;
            // 
            // vanTableAdapter2
            // 
            this.vanTableAdapter2.ClearBeforeFill = true;
            // 
            // vehicleDataSet3
            // 
            this.vehicleDataSet3.DataSetName = "VehicleDataSet3";
            this.vehicleDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trailerBindingSource
            // 
            this.trailerBindingSource.DataMember = "Trailer";
            this.trailerBindingSource.DataSource = this.vehicleDataSet3;
            // 
            // trailerTableAdapter
            // 
            this.trailerTableAdapter.ClearBeforeFill = true;
            // 
            // vehicleDataSet4
            // 
            this.vehicleDataSet4.DataSetName = "VehicleDataSet4";
            this.vehicleDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tractorBindingSource
            // 
            this.tractorBindingSource.DataMember = "Tractor";
            this.tractorBindingSource.DataSource = this.vehicleDataSet4;
            // 
            // tractorTableAdapter
            // 
            this.tractorTableAdapter.ClearBeforeFill = true;
            // 
            // trailerTableAdapter1
            // 
            this.trailerTableAdapter1.ClearBeforeFill = true;
            // 
            // tractorTableAdapter1
            // 
            this.tractorTableAdapter1.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Номер";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // vinNumberDataGridViewTextBoxColumn2
            // 
            this.vinNumberDataGridViewTextBoxColumn2.DataPropertyName = "vinNumber";
            this.vinNumberDataGridViewTextBoxColumn2.HeaderText = "VIN";
            this.vinNumberDataGridViewTextBoxColumn2.Name = "vinNumberDataGridViewTextBoxColumn2";
            this.vinNumberDataGridViewTextBoxColumn2.ReadOnly = true;
            this.vinNumberDataGridViewTextBoxColumn2.Width = 200;
            // 
            // mileageDataGridViewTextBoxColumn2
            // 
            this.mileageDataGridViewTextBoxColumn2.DataPropertyName = "mileage";
            this.mileageDataGridViewTextBoxColumn2.HeaderText = "Пробег";
            this.mileageDataGridViewTextBoxColumn2.Name = "mileageDataGridViewTextBoxColumn2";
            this.mileageDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // colorDataGridViewTextBoxColumn2
            // 
            this.colorDataGridViewTextBoxColumn2.DataPropertyName = "color";
            this.colorDataGridViewTextBoxColumn2.HeaderText = "Цвет";
            this.colorDataGridViewTextBoxColumn2.Name = "colorDataGridViewTextBoxColumn2";
            this.colorDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // axlesAmountDataGridViewTextBoxColumn2
            // 
            this.axlesAmountDataGridViewTextBoxColumn2.DataPropertyName = "axlesAmount";
            this.axlesAmountDataGridViewTextBoxColumn2.HeaderText = "Количество осей";
            this.axlesAmountDataGridViewTextBoxColumn2.Name = "axlesAmountDataGridViewTextBoxColumn2";
            this.axlesAmountDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // maintenanceDateDataGridViewTextBoxColumn2
            // 
            this.maintenanceDateDataGridViewTextBoxColumn2.DataPropertyName = "maintenanceDate";
            this.maintenanceDateDataGridViewTextBoxColumn2.HeaderText = "Плановое ТО";
            this.maintenanceDateDataGridViewTextBoxColumn2.Name = "maintenanceDateDataGridViewTextBoxColumn2";
            this.maintenanceDateDataGridViewTextBoxColumn2.ReadOnly = true;
            this.maintenanceDateDataGridViewTextBoxColumn2.Width = 200;
            // 
            // carConditionDataGridViewTextBoxColumn2
            // 
            this.carConditionDataGridViewTextBoxColumn2.DataPropertyName = "carCondition";
            this.carConditionDataGridViewTextBoxColumn2.HeaderText = "Состояние";
            this.carConditionDataGridViewTextBoxColumn2.Name = "carConditionDataGridViewTextBoxColumn2";
            this.carConditionDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // transmissionDataGridViewTextBoxColumn1
            // 
            this.transmissionDataGridViewTextBoxColumn1.DataPropertyName = "transmission";
            this.transmissionDataGridViewTextBoxColumn1.HeaderText = "Привод";
            this.transmissionDataGridViewTextBoxColumn1.Name = "transmissionDataGridViewTextBoxColumn1";
            this.transmissionDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // sleepingBagAmountDataGridViewTextBoxColumn
            // 
            this.sleepingBagAmountDataGridViewTextBoxColumn.DataPropertyName = "sleepingBagAmount";
            this.sleepingBagAmountDataGridViewTextBoxColumn.HeaderText = "Спальные места";
            this.sleepingBagAmountDataGridViewTextBoxColumn.Name = "sleepingBagAmountDataGridViewTextBoxColumn";
            this.sleepingBagAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Номер";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // vinNumberDataGridViewTextBoxColumn1
            // 
            this.vinNumberDataGridViewTextBoxColumn1.DataPropertyName = "vinNumber";
            this.vinNumberDataGridViewTextBoxColumn1.HeaderText = "VIN";
            this.vinNumberDataGridViewTextBoxColumn1.Name = "vinNumberDataGridViewTextBoxColumn1";
            this.vinNumberDataGridViewTextBoxColumn1.ReadOnly = true;
            this.vinNumberDataGridViewTextBoxColumn1.Width = 200;
            // 
            // mileageDataGridViewTextBoxColumn1
            // 
            this.mileageDataGridViewTextBoxColumn1.DataPropertyName = "mileage";
            this.mileageDataGridViewTextBoxColumn1.HeaderText = "Пробег";
            this.mileageDataGridViewTextBoxColumn1.Name = "mileageDataGridViewTextBoxColumn1";
            this.mileageDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // colorDataGridViewTextBoxColumn1
            // 
            this.colorDataGridViewTextBoxColumn1.DataPropertyName = "color";
            this.colorDataGridViewTextBoxColumn1.HeaderText = "Цвет";
            this.colorDataGridViewTextBoxColumn1.Name = "colorDataGridViewTextBoxColumn1";
            this.colorDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // axlesAmountDataGridViewTextBoxColumn1
            // 
            this.axlesAmountDataGridViewTextBoxColumn1.DataPropertyName = "axlesAmount";
            this.axlesAmountDataGridViewTextBoxColumn1.HeaderText = "Количество осей";
            this.axlesAmountDataGridViewTextBoxColumn1.Name = "axlesAmountDataGridViewTextBoxColumn1";
            this.axlesAmountDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // maintenanceDateDataGridViewTextBoxColumn1
            // 
            this.maintenanceDateDataGridViewTextBoxColumn1.DataPropertyName = "maintenanceDate";
            this.maintenanceDateDataGridViewTextBoxColumn1.HeaderText = "Плановое ТО";
            this.maintenanceDateDataGridViewTextBoxColumn1.Name = "maintenanceDateDataGridViewTextBoxColumn1";
            this.maintenanceDateDataGridViewTextBoxColumn1.ReadOnly = true;
            this.maintenanceDateDataGridViewTextBoxColumn1.Width = 150;
            // 
            // carConditionDataGridViewTextBoxColumn1
            // 
            this.carConditionDataGridViewTextBoxColumn1.DataPropertyName = "carCondition";
            this.carConditionDataGridViewTextBoxColumn1.HeaderText = "Состояние";
            this.carConditionDataGridViewTextBoxColumn1.Name = "carConditionDataGridViewTextBoxColumn1";
            this.carConditionDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // classificationDataGridViewTextBoxColumn
            // 
            this.classificationDataGridViewTextBoxColumn.DataPropertyName = "classification";
            this.classificationDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.classificationDataGridViewTextBoxColumn.Name = "classificationDataGridViewTextBoxColumn";
            this.classificationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // liftingAxleDataGridViewTextBoxColumn
            // 
            this.liftingAxleDataGridViewTextBoxColumn.DataPropertyName = "liftingAxle";
            this.liftingAxleDataGridViewTextBoxColumn.HeaderText = "Подъемные оси";
            this.liftingAxleDataGridViewTextBoxColumn.Name = "liftingAxleDataGridViewTextBoxColumn";
            this.liftingAxleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // suspensionDataGridViewTextBoxColumn
            // 
            this.suspensionDataGridViewTextBoxColumn.DataPropertyName = "suspension";
            this.suspensionDataGridViewTextBoxColumn.HeaderText = "Подвеска";
            this.suspensionDataGridViewTextBoxColumn.Name = "suspensionDataGridViewTextBoxColumn";
            this.suspensionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 540);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Korepanov";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Deactivate += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Enter += new System.EventHandler(this.Form1_Activated);
            this.Leave += new System.EventHandler(this.Form1_Activated);
            this.Validated += new System.EventHandler(this.Form1_Activated);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.vansPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.van_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDataSet2)).EndInit();
            this.trailersPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trailer_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trailerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDataSet5)).EndInit();
            this.tractorsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tractor_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tractorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trailerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tractorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage vansPage;
        private System.Windows.Forms.TabPage trailersPage;
        private System.Windows.Forms.TabPage tractorsPage;
        private VehicleDataSet vehicleDataSet;
        private System.Windows.Forms.BindingSource vanBindingSource;
        private VehicleDataSetTableAdapters.VanTableAdapter vanTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem базаДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьТСToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьТСToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьТСToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.BindingSource vehicleDataSetBindingSource;
        private System.Windows.Forms.DataGridView van_DGV;
        private VehicleDataSet1 vehicleDataSet1;
        private System.Windows.Forms.BindingSource vanBindingSource1;
        private VehicleDataSet1TableAdapters.VanTableAdapter vanTableAdapter1;
        private VehicleDataSet2 vehicleDataSet2;
        private System.Windows.Forms.BindingSource vanBindingSource2;
        private VehicleDataSet2TableAdapters.VanTableAdapter vanTableAdapter2;
        private VehicleDataSet3 vehicleDataSet3;
        private System.Windows.Forms.BindingSource trailerBindingSource;
        private VehicleDataSet3TableAdapters.TrailerTableAdapter trailerTableAdapter;
        private VehicleDataSet4 vehicleDataSet4;
        private System.Windows.Forms.BindingSource tractorBindingSource;
        private VehicleDataSet4TableAdapters.TractorTableAdapter tractorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vinNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mileageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn axlesAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintenanceDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carConditionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transmissionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView trailer_DGV;
        private System.Windows.Forms.DataGridView tractor_DGV;
        private VehicleDataSet5 vehicleDataSet5;
        private System.Windows.Forms.BindingSource trailerBindingSource1;
        private VehicleDataSet5TableAdapters.TrailerTableAdapter trailerTableAdapter1;
        private VehicleDataSet6 vehicleDataSet6;
        private System.Windows.Forms.BindingSource tractorBindingSource1;
        private VehicleDataSet6TableAdapters.TractorTableAdapter tractorTableAdapter1;
        private System.Windows.Forms.ToolStripMenuItem поискПоVINToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vinNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mileageDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn axlesAmountDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintenanceDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn carConditionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn classificationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn liftingAxleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suspensionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn vinNumberDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn mileageDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn axlesAmountDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintenanceDateDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn carConditionDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn transmissionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sleepingBagAmountDataGridViewTextBoxColumn;
    }
}

