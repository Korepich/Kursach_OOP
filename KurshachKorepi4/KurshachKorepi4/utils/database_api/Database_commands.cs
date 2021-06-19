using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using KurshachKorepi4.Classes;
using System.Windows.Forms;

namespace KurshachKorepi4.utils.database_api
{
    class Database_commands
    {
        Database db = new Database();

        public async void AddVehicleVan(string vinNumber_, int mileage_, string color_, int axlesAmount_,
            DateTime maintenanceDate_, string carCondition_, string transmission_)
        {
            Van van = new Van(vinNumber_, mileage_, color_, axlesAmount_, maintenanceDate_, carCondition_, transmission_);
            Database db = new Database();
            db.ConnectSql();
            await db.sqlConnection.OpenAsync();
            SqlCommand command = new SqlCommand("INSERT INTO [Van] (vinNumber, mileage, " +
                "color, axlesAmount, maintenanceDate, carCondition, transmission)" +
                "VALUES(@vinNumber, @mileage, " +
                "@color, @axlesAmount, @maintenanceDate, @carCondition, @transmission)", db.sqlConnection);

            command.Parameters.AddWithValue("vinNumber", van.getVinNumber());
            command.Parameters.AddWithValue("mileage", van.getMileage());
            command.Parameters.AddWithValue("color", van.getColor());
            command.Parameters.AddWithValue("axlesAmount", van.getAxlesAmount());
            command.Parameters.AddWithValue("maintenanceDate", van.getMaintenanceDate());
            command.Parameters.AddWithValue("carCondition", van.getCarCondition());
            command.Parameters.AddWithValue("transmission", van.getTransmission());

            await command.ExecuteNonQueryAsync();
            db.sqlConnection.Close();
        }
        public List<string> getVehicleByIdVan(int id_vehicle)
        {
            Database db = new Database();
            db.ConnectSql();
            db.sqlConnection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Van WHERE id=@id", db.sqlConnection);

            command.Parameters.AddWithValue("id", id_vehicle);

            SqlDataReader res = command.ExecuteReader();

            List<string> vehical = new List<string>();

            while (res.Read())
            {
                vehical.Add(res["vinNumber"].ToString());
                vehical.Add(res["mileage"].ToString());
                vehical.Add(res["color"].ToString());
                vehical.Add(res["axlesAmount"].ToString());
                vehical.Add(res["maintenanceDate"].ToString());
                vehical.Add(res["carCondition"].ToString());
                vehical.Add(res["transmission"].ToString());
            }

            return vehical;
        }
        public async void UpdateVehicleVan(int id, string vinNumber_, int mileage_, string color_, int axlesAmount_,
            DateTime maintenanceDate_, string carCondition_, string transmission_)
        {
            Van van = new Van(vinNumber_, mileage_, color_, axlesAmount_, maintenanceDate_, carCondition_, transmission_);
            Database db = new Database();
            db.ConnectSql();
            await db.sqlConnection.OpenAsync();
            SqlCommand command = new SqlCommand("UPDATE [Van] SET vinNumber=@vinNumber, mileage=@mileage, " +
                "color=@color, axlesAmount=@axlesAmount, maintenanceDate=@maintenanceDate, carCondition=@carCondition, transmission=@transmission " +
                "WHERE id=@id", db.sqlConnection);

            command.Parameters.AddWithValue("id", id);
            command.Parameters.AddWithValue("vinNumber", van.getVinNumber());
            command.Parameters.AddWithValue("mileage", van.getMileage());
            command.Parameters.AddWithValue("color", van.getColor());
            command.Parameters.AddWithValue("axlesAmount", van.getAxlesAmount());
            command.Parameters.AddWithValue("maintenanceDate", van.getMaintenanceDate());
            command.Parameters.AddWithValue("carCondition", van.getCarCondition());
            command.Parameters.AddWithValue("transmission", van.getTransmission());

            await command.ExecuteNonQueryAsync();
            db.sqlConnection.Close();
        }
        public async void AddVehicleTractor(string vinNumber_, int mileage_, string color_, int axlesAmount_, DateTime maintenanceDate_, string carCondition_
            , string transmission_, int sleepingBagAmount_)
        {
            Tractor tractor = new Tractor(vinNumber_, mileage_, color_, axlesAmount_, maintenanceDate_, carCondition_
                                    , transmission_, sleepingBagAmount_);

            Database db = new Database();
            db.ConnectSql();
            await db.sqlConnection.OpenAsync();
            SqlCommand command = new SqlCommand("INSERT INTO [Tractor] (vinNumber, mileage, " +
                "color, axlesAmount, maintenanceDate, carCondition, transmission, sleepingBagAmount)" +
                "VALUES(@vinNumber, @mileage, " +
                "@color, @axlesAmount, @maintenanceDate, @carCondition, @transmission, @sleepingBagAmount)", db.sqlConnection);

            command.Parameters.AddWithValue("vinNumber", tractor.getVinNumber());
            command.Parameters.AddWithValue("mileage", tractor.getMileage());
            command.Parameters.AddWithValue("color", tractor.getColor());
            command.Parameters.AddWithValue("axlesAmount", tractor.getAxlesAmount());
            command.Parameters.AddWithValue("maintenanceDate", tractor.getMaintenanceDate());
            command.Parameters.AddWithValue("carCondition", tractor.getCarCondition());
            command.Parameters.AddWithValue("transmission", tractor.getTransmission());
            command.Parameters.AddWithValue("sleepingBagAmount", tractor.getSleepingBagAmount());

            await command.ExecuteNonQueryAsync();
            db.sqlConnection.Close();
        }
        public List<string> getVehicleByIdTractor(int id_vehicle)
        {
            Database db = new Database();
            db.ConnectSql();
            db.sqlConnection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Tractor WHERE id=@id", db.sqlConnection);

            command.Parameters.AddWithValue("id", id_vehicle);

            SqlDataReader res = command.ExecuteReader();

            List<string> vehical = new List<string>();

            while (res.Read())
            {
                vehical.Add(res["vinNumber"].ToString());
                vehical.Add(res["mileage"].ToString());
                vehical.Add(res["color"].ToString());
                vehical.Add(res["axlesAmount"].ToString());
                vehical.Add(res["maintenanceDate"].ToString());
                vehical.Add(res["carCondition"].ToString());
                vehical.Add(res["transmission"].ToString());
                vehical.Add(res["sleepingBagAmount"].ToString());
            }

            return vehical;
        }
        public async void UpdateVehicleTractor(int id, string vinNumber_, int mileage_, string color_, int axlesAmount_,
            DateTime maintenanceDate_, string carCondition_, string transmission_, int sleepingBagAmount_)
        {
            Tractor tractor = new Tractor(vinNumber_, mileage_, color_, axlesAmount_, maintenanceDate_, carCondition_
                                    , transmission_, sleepingBagAmount_);
            Database db = new Database();
            db.ConnectSql();
            await db.sqlConnection.OpenAsync();
            SqlCommand command = new SqlCommand("UPDATE [Tractor] SET vinNumber=@vinNumber, mileage=@mileage, " +
                "color=@color, axlesAmount=@axlesAmount, maintenanceDate=@maintenanceDate, carCondition=@carCondition, transmission=@transmission, " +
                "sleepingBagAmount=@sleepingBagAmount WHERE id=@id", db.sqlConnection);

            command.Parameters.AddWithValue("id", id);
            command.Parameters.AddWithValue("vinNumber", tractor.getVinNumber());
            command.Parameters.AddWithValue("mileage", tractor.getMileage());
            command.Parameters.AddWithValue("color", tractor.getColor());
            command.Parameters.AddWithValue("axlesAmount", tractor.getAxlesAmount());
            command.Parameters.AddWithValue("maintenanceDate", tractor.getMaintenanceDate());
            command.Parameters.AddWithValue("carCondition", tractor.getCarCondition());
            command.Parameters.AddWithValue("transmission", tractor.getTransmission());
            command.Parameters.AddWithValue("sleepingBagAmount", tractor.getSleepingBagAmount());

            await command.ExecuteNonQueryAsync();
            db.sqlConnection.Close();
        }
        public async void AddVehicleTrailer(string vinNumber_, int mileage_, string color_, int axlesAmount_, DateTime maintenanceDate_, string carCondition_
            , string classification_, string liftingAxle_, string suspension_)
        {
            Trailer trailer = new Trailer(vinNumber_, mileage_, color_, axlesAmount_, maintenanceDate_, carCondition_
                                    , classification_, liftingAxle_, suspension_);

            Database db = new Database();
            db.ConnectSql();
            await db.sqlConnection.OpenAsync();
            SqlCommand command = new SqlCommand("INSERT INTO [Trailer] (vinNumber, mileage, " +
                "color, axlesAmount, maintenanceDate, carCondition, classification, liftingAxle, suspension)" +
                "VALUES(@vinNumber, @mileage, " +
                "@color, @axlesAmount, @maintenanceDate, @carCondition, @classification, @liftingAxle, @suspension)", db.sqlConnection);

            command.Parameters.AddWithValue("vinNumber", trailer.getVinNumber());
            command.Parameters.AddWithValue("mileage", trailer.getMileage());
            command.Parameters.AddWithValue("color", trailer.getColor());
            command.Parameters.AddWithValue("axlesAmount", trailer.getAxlesAmount());
            command.Parameters.AddWithValue("maintenanceDate", trailer.getMaintenanceDate());
            command.Parameters.AddWithValue("carCondition", trailer.getCarCondition());
            command.Parameters.AddWithValue("classification", trailer.getClassification());
            command.Parameters.AddWithValue("liftingAxle", trailer.getLiftingAxle());
            command.Parameters.AddWithValue("suspension", trailer.getSuspension());

            await command.ExecuteNonQueryAsync();
            db.sqlConnection.Close();
        }
        public List<string> getVehicleByIdTrailer(int id_vehicle)
        {
            Database db = new Database();
            db.ConnectSql();
            db.sqlConnection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Trailer WHERE id=@id", db.sqlConnection);

            command.Parameters.AddWithValue("id", id_vehicle);

            SqlDataReader res = command.ExecuteReader();

            List<string> vehical = new List<string>();

            while (res.Read())
            {
                vehical.Add(res["vinNumber"].ToString());
                vehical.Add(res["mileage"].ToString());
                vehical.Add(res["color"].ToString());
                vehical.Add(res["axlesAmount"].ToString());
                vehical.Add(res["maintenanceDate"].ToString());
                vehical.Add(res["carCondition"].ToString());
                vehical.Add(res["classification"].ToString());
                vehical.Add(res["liftingAxle"].ToString());
                vehical.Add(res["suspension"].ToString());
            }
            db.sqlConnection.Close();
            return vehical;
        }
        public async void UpdateVehicleTrailer(int id, string vinNumber_, int mileage_, string color_, int axlesAmount_,
            DateTime maintenanceDate_, string carCondition_, string classification_, string liftingAxle_, string suspension_)
        {
            Trailer trailer = new Trailer(vinNumber_, mileage_, color_, axlesAmount_, maintenanceDate_, carCondition_
                                    , classification_, liftingAxle_, suspension_);
            Database db = new Database();
            db.ConnectSql();
            await db.sqlConnection.OpenAsync();
            SqlCommand command = new SqlCommand("UPDATE [Trailer] SET vinNumber=@vinNumber, mileage=@mileage, " +
                "color=@color, axlesAmount=@axlesAmount, maintenanceDate=@maintenanceDate, carCondition=@carCondition, classification=@classification, " +
                "liftingAxle=@liftingAxle, suspension=@suspension WHERE id=@id", db.sqlConnection);

            command.Parameters.AddWithValue("id", id);
            command.Parameters.AddWithValue("vinNumber", trailer.getVinNumber());
            command.Parameters.AddWithValue("mileage", trailer.getMileage());
            command.Parameters.AddWithValue("color", trailer.getColor());
            command.Parameters.AddWithValue("axlesAmount", trailer.getAxlesAmount());
            command.Parameters.AddWithValue("maintenanceDate", trailer.getMaintenanceDate());
            command.Parameters.AddWithValue("carCondition", trailer.getCarCondition());
            command.Parameters.AddWithValue("classification", trailer.getClassification());
            command.Parameters.AddWithValue("liftingAxle", trailer.getLiftingAxle());
            command.Parameters.AddWithValue("suspension", trailer.getSuspension());

            await command.ExecuteNonQueryAsync();
            db.sqlConnection.Close();
        }
        public async void DeleteVehickeById(string vehicleType_, string id_)
        {
            Database db = new Database();
            db.ConnectSql();
            await db.sqlConnection.OpenAsync();

            string query = "DELETE FROM ["+ vehicleType_+"] WHERE id = @id";

            SqlCommand command = new SqlCommand(query, db.sqlConnection);

            command.Parameters.AddWithValue("id", id_);

            await command.ExecuteNonQueryAsync();
            db.sqlConnection.Close();
        }
        public List<string> SearchVehickeByVin(string vin_)
        {
            Database db = new Database();
            db.ConnectSql();
            db.sqlConnection.Open();
            bool flag = false;

            List<string> vehicleTypes = new List<string>() { "Van", "Trailer", "Tractor" };

            string query = "";

            SqlCommand command;
            SqlDataReader res;
            List<string> vehical = new List<string>();

            foreach (var vehicleType in vehicleTypes)
            {
                if (flag)
                {
                    break;
                }
                command = new SqlCommand();
                query = "SELECT * FROM [" + vehicleType + "] WHERE vinNumber=@vinNumber";
                command = new SqlCommand(query, db.sqlConnection);
                command.Parameters.AddWithValue("vinNumber", vin_);

                res = command.ExecuteReader();

                while (res.Read())
                {
                    vehical.Add(vehicleType);
                    vehical.Add(res["id"].ToString());
                    flag = true;
                }
                if (!flag)
                {
                    res.Close();
                    command.Dispose();
                }

            }
            if(!flag)
            {
                vehical.Add("404");
            }
            return vehical;
            
        }
    }
}
