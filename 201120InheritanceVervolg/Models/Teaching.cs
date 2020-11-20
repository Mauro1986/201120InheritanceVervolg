using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201120InheritanceVervolg.Models
{
    public class Teaching : Staff
    {
        //public override string ToString()
        //{
        //    string b = $"Id:{Id} Name {Name} Adress {Address} Phone {Phone}";
        //    return b;
        //}

        public string Qualification { get; set; }
            public string Subject { get; set; }
    }
}
