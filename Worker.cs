using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTesk
{
    class Worker:User
    {
        public int salary;
        public string position;
        public Worker(string name, int birthYear, string email,int salary, string position) : base(name, birthYear, email)
        {
            this.salary = salary;
            this.position = position;
        }
        public Worker() { }
        protected override string Print()
        {
        return $"{base.Print()}SALARY:{this.salary} POSITION:{this.position}";
        }
        public void GetDetails()
        {
            Console.WriteLine(Print());
        }
    }
}
