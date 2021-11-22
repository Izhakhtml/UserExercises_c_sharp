using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTesk
{
    class Manager
    {
        int salary;
        int numberOfWorkers;
        string nameOfClass;
        public int Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }
        public int NumberOfWorkers
        {
            get { return this.numberOfWorkers; }
            set { this.numberOfWorkers = value; }
        }
        public string NameOfClass
        {
            get { return this.nameOfClass; }
            set { this.nameOfClass = value; }
        }
    }
}
