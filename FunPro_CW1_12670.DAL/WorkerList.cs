using System;
using System.Collections.Generic;
using System.Linq;

namespace FunPro_CW1_12670.DAL
{
    public class WorkerList
    {
        public List<Worker> GetAllWorkers()
        {
            return new WorkerManager().GetAll();

            //Calling a GetAll() from manager class
        }


        public List<Worker> Sort(ByAttribute attribute)
        {
            switch (attribute)
            {
                case ByAttribute.Hours:
                    return GetAllWorkers().OrderBy(a => a.Hours).ToList();
            }

            //When something went wrong
            return null;

            //Sorting Workers by Region
        }


        public List<Worker> Search(string value, ByAttribute attribute)
        {
            switch (attribute)
            {
                case ByAttribute.Name:
                    return GetAllWorkers().Where(a => a.Name.ToUpper().Contains(value.ToUpper())).ToList();
            }

            //When something went wrong
            return null;

            //Searching Workers by Name
        }
    }
}


