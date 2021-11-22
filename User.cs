using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTesk
{
    class User:IComparable
    {
        public string name;
        public int birthYear;
        public string email;
        public User(string name,int birthYear,string email)
        {
            this.name = name;
            this.birthYear = birthYear;
            this.email = email;
        }
        public User() { }
        public void Print()
        {
            Console.WriteLine($"NAME:{this.name} BIRTHYEAR:{this.birthYear} EMAIL:{this.email}");
        }
        public int CompareTo(object obj) 
        {
            User user = (User)obj;
            if (this.birthYear < user.birthYear)
            {
                return -1;
            }
            if(this.birthYear > user.birthYear)
            {
                return 1;
            }
            return 0;
        }
    }
}
