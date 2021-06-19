namespace KurshachKorepi4.forms
{
    partial class AddVehicle
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
            this.vinNumber_TB = new System.Windows.Forms.TextBox();
            this.mileage_TB = new System.Windows.Forms.TextBox();
            this.color_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.axlesAmount_TB = new System.Windows.Forms.TextBox();
            this.maintenanceDate_TB = new System.Windows.Forms.DateTimePicker();
            this.carCondition_TB = new System.Windows.Forms.ComboBox();
            this.van_RB = new System.Windows.Forms.RadioButton();
            this.trailer_RB = new System.Windows.Forms.RadioButton();
            this.tractor_RB = new System.Windows.Forms.RadioButton();
            this.transmissionVan_Lable = new System.Windows.Forms.Label();
            this.transmissionVan_TB = new System.Windows.Forms.ComboBox();
            this.transmissionTractor_TB = new System.Windows.Forms.ComboBox();
            this.transmissionTractor_Lable = new System.Windows.Forms.Label();
            this.classification_Label = new System.Windows.Forms.Label();
            this.suspension_Lable = new System.Windows.Forms.Label();
            this.liftingAxle_Label = new System.Windows.Forms.Label();
            this.classification_TB = new System.Windows.Forms.ComboBox();
            this.sleepingBagAmount_Label = new System.Windows.Forms.Label();
            this.sleepingBagAmount_TB = new System.Windows.Forms.TextBox();
            this.liftingAxle_TB = new System.Windows.Forms.ComboBox();
            this.addVehicle_BT = new System.Windows.Forms.Button();
            this.suspension_TB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // vinNumber_TB
            // 
            this.vinNumber_TB.Location = new System.Drawing.Point(57, 12);
            this.vinNumber_TB.Name = "vinNumber_TB";
            this.vinNumber_TB.Size = new System.Drawing.Size(100, 20);
            this.vinNumber_TB.TabIndex = 0;
            // 
            // mileage_TB
            // 
            this.mileage_TB.Location = new System.Drawing.Point(57, 38);
            this.mileage_TB.Name = "mileage_TB";
            this.mileage_TB.Size = new System.Drawing.Size(100, 20);
            this.mileage_TB.TabIndex = 1;
            // 
            // color_TB
            // 
            this.color_TB.Location = new System.Drawing.Point(57, 64);
            this.color_TB.Name = "color_TB";
            this.color_TB.Size = new System.Drawing.Size(100, 20);
            this.color_TB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "VIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пробег";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Цвет";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Состояние";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(355, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Тех осмотр";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(355, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Кол-во осей";
            // 
            // axlesAmount_TB
            // 
            this.axlesAmount_TB.Location = new System.Drawing.Point(429, 12);
            this.axlesAmount_TB.Name = "axlesAmount_TB";
            this.axlesAmount_TB.Size = new System.Drawing.Size(100, 20);
            this.axlesAmount_TB.TabIndex = 6;
            // 
            // maintenanceDate_TB
            // 
            this.maintenanceDate_TB.Location = new System.Drawing.Point(429, 38);
            this.maintenanceDate_TB.Name = "maintenanceDate_TB";
            this.maintenanceDate_TB.Size = new System.Drawing.Size(100, 20);
            this.maintenanceDate_TB.TabIndex = 12;
            // 
            // carCondition_TB
            // 
            this.carCondition_TB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carCondition_TB.FormattingEnabled = true;
            this.carCondition_TB.Items.AddRange(new object[] {
            "в гараже",
            "на ремонте",
            "в пути"});
            this.carCondition_TB.Location = new System.Drawing.Point(429, 64);
            this.carCondition_TB.Name = "carCondition_TB";
            this.carCondition_TB.Size = new System.Drawing.Size(100, 21);
            this.carCondition_TB.TabIndex = 13;
            // 
            // van_RB
            // 
            this.van_RB.AutoSize = true;
            this.van_RB.Location = new System.Drawing.Point(227, 15);
            this.van_RB.Name = "van_RB";
            this.van_RB.Size = new System.Drawing.Size(64, 17);
            this.van_RB.TabIndex = 14;
            this.van_RB.Text = "Фургон";
            this.van_RB.UseVisualStyleBackColor = true;
            this.van_RB.CheckedChanged += new System.EventHandler(this.van_RB_CheckedChanged);
            // 
            // trailer_RB
            // 
            this.trailer_RB.AutoSize = true;
            this.trailer_RB.Location = new System.Drawing.Point(227, 64);
            this.trailer_RB.Name = "trailer_RB";
            this.trailer_RB.Size = new System.Drawing.Size(63, 17);
            this.trailer_RB.TabIndex = 15;
            this.trailer_RB.Text = "Прицеп";
            this.trailer_RB.UseVisualStyleBackColor = true;
            this.trailer_RB.CheckedChanged += new System.EventHandler(this.trailer_RB_CheckedChanged);
            // 
            // tractor_RB
            // 
            this.tractor_RB.AutoSize = true;
            this.tractor_RB.Location = new System.Drawing.Point(227, 38);
            this.tractor_RB.Name = "tractor_RB";
            this.tractor_RB.Size = new System.Drawing.Size(54, 17);
            this.tractor_RB.TabIndex = 16;
            this.tractor_RB.Text = "Тягач";
            this.tractor_RB.UseVisualStyleBackColor = true;
            this.tractor_RB.CheckedChanged += new System.EventHandler(this.tractor_RB_CheckedChanged);
            // 
            // transmissionVan_Lable
            // 
            this.transmissionVan_Lable.AutoSize = true;
            this.transmissionVan_Lable.Location = new System.Drawing.Point(6, 99);
            this.transmissionVan_Lable.Name = "transmissionVan_Lable";
            this.transmissionVan_Lable.Size = new System.Drawing.Size(45, 13);
            this.transmissionVan_Lable.TabIndex = 20;
            this.transmissionVan_Lable.Text = "Привод";
            // 
            // transmissionVan_TB
            // 
            this.transmissionVan_TB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.transmissionVan_TB.FormattingEnabled = true;
            this.transmissionVan_TB.Items.AddRange(new object[] {
            "полный",
            "задний",
            "передний"});
            this.transmissionVan_TB.Location = new System.Drawing.Point(57, 96);
            this.transmissionVan_TB.Name = "transmissionVan_TB";
            this.transmissionVan_TB.Size = new System.Drawing.Size(100, 21);
            this.transmissionVan_TB.TabIndex = 23;
            // 
            // transmissionTractor_TB
            // 
            this.transmissionTractor_TB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.transmissionTractor_TB.FormattingEnabled = true;
            this.transmissionTractor_TB.Items.AddRange(new object[] {
            "6*6",
            "6*4",
            "6*2",
            "4*2"});
            this.transmissionTractor_TB.Location = new System.Drawing.Point(57, 96);
            this.transmissionTractor_TB.Name = "transmissionTractor_TB";
            this.transmissionTractor_TB.Size = new System.Drawing.Size(100, 21);
            this.transmissionTractor_TB.TabIndex = 25;
            // 
            // transmissionTractor_Lable
            // 
            this.transmissionTractor_Lable.AutoSize = true;
            this.transmissionTractor_Lable.Location = new System.Drawing.Point(6, 99);
            this.transmissionTractor_Lable.Name = "transmissionTractor_Lable";
            this.transmissionTractor_Lable.Size = new System.Drawing.Size(45, 13);
            this.transmissionTractor_Lable.TabIndex = 24;
            this.transmissionTractor_Lable.Text = "Привод";
            // 
            // classification_Label
            // 
            this.classification_Label.AutoSize = true;
            this.classification_Label.Location = new System.Drawing.Point(9, 99);
            this.classification_Label.Name = "classification_Label";
            this.classification_Label.Size = new System.Drawing.Size(38, 13);
            this.classification_Label.TabIndex = 27;
            this.classification_Label.Text = "Класс";
            // 
            // suspension_Lable
            // 
            this.suspension_Lable.AutoSize = true;
            this.suspension_Lable.Location = new System.Drawing.Point(366, 99);
            this.suspension_Lable.Name = "suspension_Lable";
            this.suspension_Lable.Size = new System.Drawing.Size(57, 13);
            this.suspension_Lable.TabIndex = 31;
            this.suspension_Lable.Text = "Подвеска";
            // 
            // liftingAxle_Label
            // 
            this.liftingAxle_Label.AutoSize = true;
            this.liftingAxle_Label.Location = new System.Drawing.Point(165, 99);
            this.liftingAxle_Label.Name = "liftingAxle_Label";
            this.liftingAxle_Label.Size = new System.Drawing.Size(89, 13);
            this.liftingAxle_Label.TabIndex = 30;
            this.liftingAxle_Label.Text = "Подъемные оси";
            // 
            // classification_TB
            // 
            this.classification_TB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classification_TB.FormattingEnabled = true;
            this.classification_TB.Items.AddRange(new object[] {
            "тентованный",
            "изотермический",
            "рефрижератор",
            "бортовой",
            "сортиментовоз",
            "цистерна",
            "автовоз"});
            this.classification_TB.Location = new System.Drawing.Point(57, 96);
            this.classification_TB.Name = "classification_TB";
            this.classification_TB.Size = new System.Drawing.Size(100, 21);
            this.classification_TB.TabIndex = 32;
            // 
            // sleepingBagAmount_Label
            // 
            this.sleepingBagAmount_Label.AutoSize = true;
            this.sleepingBagAmount_Label.Location = new System.Drawing.Point(169, 99);
            this.sleepingBagAmount_Label.Name = "sleepingBagAmount_Label";
            this.sleepingBagAmount_Label.Size = new System.Drawing.Size(85, 13);
            this.sleepingBagAmount_Label.TabIndex = 34;
            this.sleepingBagAmount_Label.Text = "Спальных мест";
            // 
            // sleepingBagAmount_TB
            // 
            this.sleepingBagAmount_TB.Location = new System.Drawing.Point(260, 96);
            this.sleepingBagAmount_TB.Name = "sleepingBagAmount_TB";
            this.sleepingBagAmount_TB.Size = new System.Drawing.Size(100, 20);
            this.sleepingBagAmount_TB.TabIndex = 33;
            // 
            // liftingAxle_TB
            // 
            this.liftingAxle_TB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.liftingAxle_TB.FormattingEnabled = true;
            this.liftingAxle_TB.Items.AddRange(new object[] {
            "да",
            "нет"});
            this.liftingAxle_TB.Location = new System.Drawing.Point(260, 95);
            this.liftingAxle_TB.Name = "liftingAxle_TB";
            this.liftingAxle_TB.Size = new System.Drawing.Size(100, 21);
            this.liftingAxle_TB.TabIndex = 35;
            // 
            // addVehicle_BT
            // 
            this.addVehicle_BT.Location = new System.Drawing.Point(172, 145);
            this.addVehicle_BT.Name = "addVehicle_BT";
            this.addVehicle_BT.Size = new System.Drawing.Size(192, 23);
            this.addVehicle_BT.TabIndex = 36;
            this.addVehicle_BT.Text = "Добавить ТС";
            this.addVehicle_BT.UseVisualStyleBackColor = true;
            this.addVehicle_BT.Click += new System.EventHandler(this.addVehicle_BT_Click);
            // 
            // suspension_TB
            // 
            this.suspension_TB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.suspension_TB.FormattingEnabled = true;
            this.suspension_TB.Items.AddRange(new object[] {
            "пневма",
            "рессора"});
            this.suspension_TB.Location = new System.Drawing.Point(429, 96);
            this.suspension_TB.Name = "suspension_TB";
            this.suspension_TB.Size = new System.Drawing.Size(100, 21);
            this.suspension_TB.TabIndex = 37;
            // 
            // AddVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 180);
            this.Controls.Add(this.suspension_TB);
            this.Controls.Add(this.addVehicle_BT);
            this.Controls.Add(this.liftingAxle_TB);
            this.Controls.Add(this.sleepingBagAmount_Label);
            this.Controls.Add(this.sleepingBagAmount_TB);
            this.Controls.Add(this.classification_TB);
            this.Controls.Add(this.suspension_Lable);
            this.Controls.Add(this.liftingAxle_Label);
            this.Controls.Add(this.classification_Label);
            this.Controls.Add(this.transmissionTractor_TB);
            this.Controls.Add(this.transmissionTractor_Lable);
            this.Controls.Add(this.transmissionVan_TB);
            this.Controls.Add(this.transmissionVan_Lable);
            this.Controls.Add(this.tractor_RB);
            this.Controls.Add(this.trailer_RB);
            this.Controls.Add(this.van_RB);
            this.Controls.Add(this.carCondition_TB);
            this.Controls.Add(this.maintenanceDate_TB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.axlesAmount_TB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.color_TB);
            this.Controls.Add(this.mileage_TB);
            this.Controls.Add(this.vinNumber_TB);
            this.Name = "AddVehicle";
            this.Text = "AddVehicle";
            this.Load += new System.EventHandler(this.AddVehicle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox vinNumber_TB;
        private System.Windows.Forms.TextBox mileage_TB;
        private System.Windows.Forms.TextBox color_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox axlesAmount_TB;
        private System.Windows.Forms.DateTimePicker maintenanceDate_TB;
        private System.Windows.Forms.ComboBox carCondition_TB;
        private System.Windows.Forms.RadioButton van_RB;
        private System.Windows.Forms.RadioButton tractor_RB;
        private System.Windows.Forms.Label transmissionVan_Lable;
        private System.Windows.Forms.ComboBox transmissionVan_TB;
        private System.Windows.Forms.Label transmissionTractor_Lable;
        private System.Windows.Forms.Label classification_Label;
        private System.Windows.Forms.Label suspension_Lable;
        private System.Windows.Forms.Label liftingAxle_Label;
        private System.Windows.Forms.ComboBox classification_TB;
        private System.Windows.Forms.Label sleepingBagAmount_Label;
        private System.Windows.Forms.TextBox sleepingBagAmount_TB;
        private System.Windows.Forms.ComboBox liftingAxle_TB;
        private System.Windows.Forms.ComboBox transmissionTractor_TB;
        private System.Windows.Forms.Button addVehicle_BT;
        private System.Windows.Forms.RadioButton trailer_RB;
        private System.Windows.Forms.ComboBox suspension_TB;
    }
}