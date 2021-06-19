using KurshachKorepi4.Classes;
using KurshachKorepi4.utils.database_api;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KurshachKorepi4.forms
{
    public partial class AddVehicle : Form
    {
        public AddVehicle()
        {
            InitializeComponent();
        }

        private void AddVehicle_Load(object sender, EventArgs e)
        {
            transmissionVan_Lable.Visible = false;
            transmissionVan_TB.Visible = false;
            transmissionTractor_Lable.Visible = false;
            transmissionTractor_TB.Visible = false;
            classification_Label.Visible = false;
            classification_TB.Visible = false;
            sleepingBagAmount_Label.Visible = false;
            sleepingBagAmount_TB.Visible = false;
            liftingAxle_Label.Visible = false;
            liftingAxle_TB.Visible = false;
            suspension_Lable.Visible = false;
            suspension_TB.Visible = false;
        }

        private void tractor_RB_CheckedChanged(object sender, EventArgs e)
        {
            transmissionTractor_Lable.Visible = true;
            transmissionTractor_TB.Visible = true;
            sleepingBagAmount_Label.Visible = true;
            sleepingBagAmount_TB.Visible = true;

            transmissionVan_Lable.Visible = false;
            transmissionVan_TB.Visible = false;
            classification_Label.Visible = false;
            classification_TB.Visible = false;
            liftingAxle_Label.Visible = false;
            liftingAxle_TB.Visible = false;
            suspension_Lable.Visible = false;
            suspension_TB.Visible = false;
        }

        private void trailer_RB_CheckedChanged(object sender, EventArgs e)
        {
            transmissionTractor_Lable.Visible = false;
            transmissionTractor_TB.Visible = false;
            sleepingBagAmount_Label.Visible = false;
            sleepingBagAmount_TB.Visible = false;
            transmissionVan_Lable.Visible = false;
            transmissionVan_TB.Visible = false;

            classification_Label.Visible = true;
            classification_TB.Visible = true;
            liftingAxle_Label.Visible = true;
            liftingAxle_TB.Visible = true;
            suspension_Lable.Visible = true;
            suspension_TB.Visible = true;
        }
        private void van_RB_CheckedChanged(object sender, EventArgs e)
        {
            transmissionVan_Lable.Visible = true;
            transmissionVan_TB.Visible = true;

            transmissionTractor_Lable.Visible = false;
            transmissionTractor_TB.Visible = false;
            classification_Label.Visible = false;
            classification_TB.Visible = false;
            sleepingBagAmount_Label.Visible = false;
            sleepingBagAmount_TB.Visible = false;
            liftingAxle_Label.Visible = false;
            liftingAxle_TB.Visible = false;
            suspension_Lable.Visible = false;
            suspension_TB.Visible = false;
        }

        private void addVehicle_BT_Click(object sender, EventArgs e)
        {
            if(vinNumber_TB.TextLength==0||mileage_TB.TextLength== 0||color_TB.TextLength==0
                || axlesAmount_TB.TextLength==0 || carCondition_TB.Text=="" || 
                (van_RB.Checked || tractor_RB.Checked || trailer_RB.Checked) == false)
            {
                MessageBox.Show("Вы заполнили не все данные!!!");
            }
            else
            {
                try
                {
                    string vinNumber = vinNumber_TB.Text;
                    int mileage = Int32.Parse(mileage_TB.Text);
                    string color = color_TB.Text;
                    int axlesAmount = Int32.Parse(axlesAmount_TB.Text);
                    string carCondition = carCondition_TB.Text;
                    DateTime maintenanceDate = maintenanceDate_TB.Value;

                    if (vinNumber_TB.TextLength !=0
                        && (Int32.Parse(axlesAmount_TB.Text) > 1 && Int32.Parse(axlesAmount_TB.Text) < 6))
                    {
                        if (van_RB.Checked)
                        {
                            if (transmissionVan_TB.Text == "")
                            {
                                MessageBox.Show("Вы заполнили не все данные!!!");
                            }
                            else
                            {
                                string transmissionVan = transmissionVan_TB.Text;

                                Database_commands db_commands = new Database_commands();
                                db_commands.AddVehicleVan(vinNumber, mileage, color, axlesAmount, maintenanceDate, carCondition, transmissionVan);

                                Close();
                            }
                        }
                        if (tractor_RB.Checked)
                        {
                            if (transmissionTractor_TB.Text == "" || sleepingBagAmount_TB.Text == "")
                            {
                                MessageBox.Show("Вы заполнили не все данные!!!");
                            }
                            else
                            {
                                string transmissionTractor = transmissionTractor_TB.Text;
                                int sleepingBagAmount = Int32.Parse(sleepingBagAmount_TB.Text);

                                Database_commands db_commands = new Database_commands();
                                db_commands.AddVehicleTractor(vinNumber, mileage, color, axlesAmount, maintenanceDate, carCondition
                                    , transmissionTractor, sleepingBagAmount);

                                Close();
                            }
                        }
                        if (trailer_RB.Checked)
                        {
                            if (classification_TB.Text == "" || liftingAxle_TB.Text == "" || suspension_TB.Text == "")
                            {
                                MessageBox.Show("Вы заполнили не все данные!!!");
                            }
                            else
                            {
                                string classification = classification_TB.Text;
                                string liftingAxle = liftingAxle_TB.Text;
                                string suspension = suspension_TB.Text;

                                Database_commands db_commands = new Database_commands();
                                db_commands.AddVehicleTrailer(vinNumber, mileage, color, axlesAmount, maintenanceDate, carCondition, classification,
                                    liftingAxle, suspension);

                                Close();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Неккоректные данные!!!");
                    }
                }
                catch(Exception er)
                {
                    MessageBox.Show("Неккоректные данные!!!" + er);
                }
            }
        }
    }
}
