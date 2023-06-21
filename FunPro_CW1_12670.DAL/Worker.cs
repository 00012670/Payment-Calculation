using System;

namespace FunPro_CW1_12670.DAL
{
    public class Worker
    {
        private string name;
        private int region;
        private int hours;

        public int Id { get; set; }      

        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Name cannot be empty");
                name = value;

                //Validating user name
            }
        }

        public int Region
        {
            get => region;
            set
            {
                if (value < 1 || value > 10)
                    throw new Exception("Region can only be a number from 1 to 10 inclusive");
                region = value;

                //Validating region
            }
        }

        public int Hours
        {
            get => hours;
            set => hours = value;
        }

        public double Rate { get; set; }

        public double HoursPaid { get; set; }

        public double ExtraHours { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
         

