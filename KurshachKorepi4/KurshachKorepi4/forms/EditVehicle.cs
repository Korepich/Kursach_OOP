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

namespace KurshachKorepi4.forms
{
    public partial class EditVehicle : Form
    {
        public int id_vehicle;
        public int vehicle_type; //1-фургоны 2-прицепы 3-тягачи
        public EditVehicle()
        {
            InitializeComponent();
        }

        private void EditVehicle_Shown(object sender, EventArgs e)
        {
            if (vehicle_type == 1)
            {
                van_RB.Checked = true;
                Full_TB_Van();
            }
            else
            {
                if (vehicle_type == 2)
                {
                    trailer_RB.Checked = true;
                    Full_TB_Trailer();
                }
                else
                {
                    tractor_RB.Checked = true;
                    Full_TB_Tractor();
                }
            }
        }
        private void Full_TB_Van()
        {
            Database_commands db_commands = new Database_commands();
            List<string> vehicle = db_commands.getVehicleByIdVan(id_vehicle);
            vinNumber_TB.Text = vehicle[0];
            mileage_TB.Text = vehicle[1];
            color_TB.Text = vehicle[2];
            axlesAmount_TB.Text = vehicle[3];
            maintenanceDate_TB.Text = vehicle[4];
            carCondition_TB.Text = vehicle[5];
            transmissionVan_TB.Text = vehicle[6];
        }
        private void Full_TB_Tractor()
        {
            Database_commands db_commands = new Database_commands();
            List<string> vehicle = db_commands.getVehicleByIdTractor(id_vehicle);
            vinNumber_TB.Text = vehicle[0];
            mileage_TB.Text = vehicle[1];
            color_TB.Text = vehicle[2];
            axlesAmount_TB.Text = vehicle[3];
            maintenanceDate_TB.Text = vehicle[4];
            carCondition_TB.Text = vehicle[5];
            transmissionTractor_TB.Text = vehicle[6];
            sleepingBagAmount_TB.Text = vehicle[7];
        }
        private void Full_TB_Trailer()
        {
            Database_commands db_commands = new Database_commands();
            List<string> vehicle = db_commands.getVehicleByIdTrailer(id_vehicle);
            vinNumber_TB.Text = vehicle[0];
            mileage_TB.Text = vehicle[1];
            color_TB.Text = vehicle[2];
            axlesAmount_TB.Text = vehicle[3];
            maintenanceDate_TB.Text = vehicle[4];
            carCondition_TB.Text = vehicle[5];
            classification_TB.Text = vehicle[6];
            liftingAxle_TB.Text = vehicle[7];
            suspension_TB.Text = vehicle[8];
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

            trailer_RB.Visible = false;
            van_RB.Visible = false;
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

            tractor_RB.Visible = false;
            van_RB.Visible = false;
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

            tractor_RB.Visible = false;
            trailer_RB.Visible = false;
        }

        private void editVehicle_BT_Click(object sender, EventArgs e)
        {
            if (vinNumber_TB.TextLength == 0 || mileage_TB.TextLength == 0 || color_TB.TextLength == 0
                || axlesAmount_TB.TextLength == 0 || carCondition_TB.Text == "" ||
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

                    if (vinNumber_TB.TextLength != 0
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

                                db_commands.UpdateVehicleVan(id_vehicle, vinNumber, mileage, color, axlesAmount, maintenanceDate, carCondition, transmissionVan);

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
                                db_commands.UpdateVehicleTractor(id_vehicle, vinNumber, mileage, color, axlesAmount, maintenanceDate, carCondition
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
                                db_commands.UpdateVehicleTrailer(id_vehicle, vinNumber, mileage, color, axlesAmount, maintenanceDate, carCondition, classification,
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
                catch (Exception er)
                {
                    MessageBox.Show("Неккоректные данные!!!" + er);
                }
            }
        }

        private void deleteVehicle_BT_Click(object sender, EventArgs e)
        {
            if(vehicle_type==1)
            {
                Database_commands db_commands = new Database_commands();
                db_commands.DeleteVehickeById("Van",id_vehicle.ToString());
                Close();
            }
            else
            {
                if(vehicle_type==2)
                {
                    Database_commands db_commands = new Database_commands();
                    db_commands.DeleteVehickeById("Trailer", id_vehicle.ToString());
                    Close();
                }
                else
                {
                    Database_commands db_commands = new Database_commands();
                    db_commands.DeleteVehickeById("Tractor", id_vehicle.ToString());
                    Close();
                }
            }
        }
    }
}
