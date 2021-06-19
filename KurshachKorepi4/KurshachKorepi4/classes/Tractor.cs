using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurshachKorepi4.Classes
{
    class Tractor : Vehicle
    {
        private string transmission;
        private int sleepingBagAmount;

        public Tractor()
        {
            transmission="";
            sleepingBagAmount = 0;
        }
        public Tractor(string vinNumber_, int mileage_, string color_, int axlesAmount_, DateTime maintenanceDate_, string carCondition_
            ,string transmission_, int sleepingBagAmount_)
            : base(vinNumber_, mileage_, color_, axlesAmount_, maintenanceDate_, carCondition_)
        {
            transmission = transmission_;
            sleepingBagAmount = sleepingBagAmount_;
        }
        
        public string getTransmission()
        {
            return transmission;
        }
        public int getSleepingBagAmount()
        {
            return sleepingBagAmount;
        }
        public bool setTransmission(string transmission_)
        {
            if(transmission_=="6*6" || transmission_=="6*4"|| transmission_=="6*2" || transmission_=="4*2")
            {
                transmission = transmission_;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool setSleepingBagAmount(int sleepingBagAmount_)
        {
            if(sleepingBagAmount>=0)
            {
                sleepingBagAmount = sleepingBagAmount_;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
