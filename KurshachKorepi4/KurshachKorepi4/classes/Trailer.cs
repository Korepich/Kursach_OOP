using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurshachKorepi4.Classes
{
    class Trailer : Vehicle
    {
        private string classification;
        private string liftingAxle;
        private string suspension;

        public Trailer()
        {
            classification="";
            liftingAxle="";
            suspension="";
        }
        public Trailer(string vinNumber_, int mileage_, string color_, int axlesAmount_, DateTime maintenanceDate_, string carCondition_
            , string classification_, string liftingAxle_, string suspension_)
            : base(vinNumber_, mileage_, color_, axlesAmount_, maintenanceDate_, carCondition_)
        {
            classification = classification_;
            liftingAxle = liftingAxle_;
            suspension = suspension_;
        }
        public string getClassification()
        {
            return classification;
        }
        public string getLiftingAxle()
        {
            return liftingAxle;
        }
        public string getSuspension()
        {
            return suspension;
        }

        public bool setClassification(string classification_)
        {
            if (classification_ == "тентованный" || classification_ == "изотермический" || classification_ == "рефрижератор"
                || classification_ == "бортовой" || classification_ == "сортиментовоз" || classification_ == "цистерна" || classification_== "автовоз")
            {
                classification = classification_;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool setLiftingAxle(string liftingAxle_)
        {
            if (liftingAxle_ == "да" || liftingAxle_ == "нет")
            {
                liftingAxle = liftingAxle_;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool setSuspension(string suspension_)
        {
            if (suspension_ == "рессора" || suspension_ == "пневма")
            {
                suspension = suspension_;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
