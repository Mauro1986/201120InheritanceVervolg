using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201120InheritanceVervolg.Models
{
    public class Staff : Person
    {
        public string JobTitle { get; set; }
        public double Salaray { get; set; }
    }
}
