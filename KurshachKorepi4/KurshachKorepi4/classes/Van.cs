using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurshachKorepi4.Classes
{
    class Van : Vehicle
    {
        private string transmission;

        public Van()
        {
            transmission = "";
        }
        public Van(string vinNumber_, int mileage_, string color_, int axlesAmount_, DateTime maintenanceDate_, string carCondition_
            ,string transmission_)
            :base(vinNumber_, mileage_, color_, axlesAmount_, maintenanceDate_, carCondition_)
        {
            transmission = transmission_;
        }
        public string getTransmission()
        {
            return transmission;
        }
        public bool setTransmission(string transmission_)
        {
            if(transmission_=="полный" || transmission_=="задний" || transmission_=="передний")
            {
                transmission = transmission_;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
