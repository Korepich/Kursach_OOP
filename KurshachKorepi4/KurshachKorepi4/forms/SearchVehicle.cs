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
    public partial class SearchVehicle : Form
    {
        public SearchVehicle()
        {
            InitializeComponent();
        }

        private void SearchVehicle_BT_Click(object sender, EventArgs e)
        {
            string vin = vinNumber_TB.Text;
            if (vin == "")
            {
                MessageBox.Show("Введите VIN!");
            }
            else
            {
                Database_commands db_commands = new Database_commands();
                List<string> vehicle= db_commands.SearchVehickeByVin(vin);
                if (vehicle[0] == "404")
                {
                    MessageBox.Show("ТС с данным VIN не найдено!");
                }
                else
                {
                    int vehicleType = 0;
                    if(vehicle[0]=="Van")
                    {
                        vehicleType = 1;
                    }
                    else
                    {
                        if (vehicle[0] == "Trailer")
                        {
                            vehicleType = 2;
                        }
                        else
                        {
                            if (vehicle[0] == "Tractor")
                            {
                                vehicleType = 3;
                            }
                        }
                    }
                    int id_vehicle_ = Int32.Parse(vehicle[1]);
                    EditVehicle editVehicle = new EditVehicle();
                    editVehicle.id_vehicle = id_vehicle_;
                    editVehicle.vehicle_type = vehicleType;
                    editVehicle.Show();
                }
            }

        }
    }
}
