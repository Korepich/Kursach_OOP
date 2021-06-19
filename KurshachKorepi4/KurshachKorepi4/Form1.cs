using KurshachKorepi4.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KurshachKorepi4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            добавитьТСToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            обновитьБДToolStripMenuItem.ShortcutKeys = Keys.F5;
            удалитьТСToolStripMenuItem.ShortcutKeys = Keys.Delete;
            изменитьТСToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;
            выходToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
            поискПоVINToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillDB();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            FillDB();
        }

        private void FillDB()
        {
            this.tractorTableAdapter1.Fill(this.vehicleDataSet6.Tractor);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vehicleDataSet5.Trailer". При необходимости она может быть перемещена или удалена.
            this.trailerTableAdapter1.Fill(this.vehicleDataSet5.Trailer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vehicleDataSet4.Tractor". При необходимости она может быть перемещена или удалена.
            this.tractorTableAdapter.Fill(this.vehicleDataSet4.Tractor);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vehicleDataSet3.Trailer". При необходимости она может быть перемещена или удалена.
            this.trailerTableAdapter.Fill(this.vehicleDataSet3.Trailer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vehicleDataSet2.Van". При необходимости она может быть перемещена или удалена.
            this.vanTableAdapter2.Fill(this.vehicleDataSet2.Van);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vehicleDataSet1.Van". При необходимости она может быть перемещена или удалена.
            this.vanTableAdapter1.Fill(this.vehicleDataSet1.Van);
        }

        private void добавитьТСToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddVehicle addVehicle = new AddVehicle();
            addVehicle.Show();
        }

        private void изменитьТСToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditVehicle editVehicle = new EditVehicle();
            string tb_open = tabControl.SelectedTab.Text;
            if(tb_open=="Фургоны")
            {
                int id_van = Int32.Parse(van_DGV.CurrentRow.Cells[0].Value.ToString());
                editVehicle.id_vehicle = id_van;
                editVehicle.vehicle_type = 1;
                editVehicle.Show();
            }
            if (tb_open == "Прицепы")
            {
                int id_van = Int32.Parse(trailer_DGV.CurrentRow.Cells[0].Value.ToString());
                editVehicle.id_vehicle = id_van;
                editVehicle.vehicle_type = 2;
                editVehicle.Show();
            }
            if (tb_open == "Тягачи")
            {
                int id_van = Int32.Parse(tractor_DGV.CurrentRow.Cells[0].Value.ToString());
                editVehicle.id_vehicle = id_van;
                editVehicle.vehicle_type = 3;
                editVehicle.Show();
            }
        }

        private void удалитьТСToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string tb_open = tabControl.SelectedTab.Text;
            if (tb_open == "Фургоны")
            {
                int id_van = Int32.Parse(van_DGV.CurrentRow.Cells[0].Value.ToString());
                ((DataRowView)van_DGV.CurrentRow.DataBoundItem).Delete();
                vanTableAdapter2.Update(vehicleDataSet2.Van);
            }
            if (tb_open == "Прицепы")
            {
                int id_van = Int32.Parse(trailer_DGV.CurrentRow.Cells[0].Value.ToString());
                ((DataRowView)trailer_DGV.CurrentRow.DataBoundItem).Delete();
                trailerTableAdapter.Update(vehicleDataSet3.Trailer);
            }
            if (tb_open == "Тягачи")
            {
                int id_van = Int32.Parse(tractor_DGV.CurrentRow.Cells[0].Value.ToString());
                ((DataRowView)tractor_DGV.CurrentRow.DataBoundItem).Delete();
                tractorTableAdapter1.Update(vehicleDataSet6.Tractor);
            }
            
        }

        private void обновитьБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FillDB();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void поискПоVINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchVehicle searchVehicle = new SearchVehicle();
            searchVehicle.Show();
        }
    }
}
