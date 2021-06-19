using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurshachKorepi4
{
    class Vehicle
    {
        private string vinNumber;
        private int mileage;
        private string color;
        private int axlesAmount;
        private DateTime maintenanceDate;
        private string carCondition;

        public Vehicle()
        {
            vinNumber = "";
            mileage = 0;
            color = "";
            axlesAmount = 0;
            maintenanceDate = DateTime.MinValue;
            carCondition = "";
        }

        public Vehicle(string vinNumber_, int mileage_, string color_, int axlesAmount_, 
            DateTime maintenanceDate_, string carCondition_)
        {
            vinNumber = vinNumber_;
            mileage = mileage_;
            color = color_;
            axlesAmount = axlesAmount_;
            maintenanceDate = maintenanceDate_;
            carCondition = carCondition_;
        }

        public string getVinNumber()
        {
            return vinNumber;
        }
        public int getMileage()
        {
            return mileage;
        }
        public string getColor()
        {
            return color;
        }
        public int getAxlesAmount()
        {
            return axlesAmount;
        }
        public DateTime getMaintenanceDate()
        {
            return maintenanceDate;
        }
        public string getCarCondition()
        {
            return carCondition;
        }

        public bool setVinNumber(string vinNumber_)
        {
            if (vinNumber_.Length == 17)
            {
                vinNumber = vinNumber_;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool setMileage(int mileage_)
        {
            mileage = mileage_;
            return true;
        }
        public bool setColor(string color_)
        {
            color = color_;
            return true;
        }
        public bool setAxlesAmount(int axlesAmount_)
        {
            if(axlesAmount_ > 1 && axlesAmount_ < 6)
            {
                axlesAmount = axlesAmount_;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool setMaintenanceDate(DateTime maintenanceDate_)
        {
            maintenanceDate = maintenanceDate_;
            return true;
        }
        public bool setCarCondition(string carCondition_)
        {
            if (carCondition_ == "в пути" || carCondition_ == "на ремонте" || carCondition_ == "в гараже")
            {
                carCondition = carCondition_;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
