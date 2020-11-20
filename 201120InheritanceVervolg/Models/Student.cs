using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201120InheritanceVervolg.Models
{
    public class Student : Person
    {
        public string ClassName { get; set; }
        public int Marks { get; set; }
        public double Fees { get; set; }

        public override string ToString()
        {
            string s = $"Id:{Id} Name {Name} Adress {Address} Phone {Phone}\n" +
                $"Classname {ClassName} Marks {Marks} Fees{Fees}";
            return s;
        }
    }
}
