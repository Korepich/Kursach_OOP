namespace KurshachKorepi4.forms
{
    partial class SearchVehicle
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
            this.label1 = new System.Windows.Forms.Label();
            this.vinNumber_TB = new System.Windows.Forms.TextBox();
            this.SearchVehicle_BT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "VIN";
            // 
            // vinNumber_TB
            // 
            this.vinNumber_TB.Location = new System.Drawing.Point(40, 12);
            this.vinNumber_TB.Name = "vinNumber_TB";
            this.vinNumber_TB.Size = new System.Drawing.Size(162, 20);
            this.vinNumber_TB.TabIndex = 4;
            // 
            // SearchVehicle_BT
            // 
            this.SearchVehicle_BT.Location = new System.Drawing.Point(53, 38);
            this.SearchVehicle_BT.Name = "SearchVehicle_BT";
            this.SearchVehicle_BT.Size = new System.Drawing.Size(126, 23);
            this.SearchVehicle_BT.TabIndex = 20;
            this.SearchVehicle_BT.Text = "Поиск ТС";
            this.SearchVehicle_BT.UseVisualStyleBackColor = true;
            this.SearchVehicle_BT.Click += new System.EventHandler(this.SearchVehicle_BT_Click);
            // 
            // SearchVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 69);
            this.Controls.Add(this.SearchVehicle_BT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vinNumber_TB);
            this.Name = "SearchVehicle";
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox vinNumber_TB;
        private System.Windows.Forms.Button SearchVehicle_BT;
    }
}