using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _201120InheritanceVervolg.Models;   // Dit niet vergeten!

namespace _201120InheritanceVervolg
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;

            Student student = new Student();        // van Parent klas
            student.Id = 2658;
            student.Name = "Mauro";
            student.Address = "Zondernaamstraat";
            student.Phone = "0477123456";

            student.Fees = 250.05;              // van Student klas
            student.Marks = 9;
            student.ClassName = "C#";

            Console.WriteLine(student.ToString());
            Console.WriteLine(x);

            Console.WriteLine();

            Teaching teaching = new Teaching();
            teaching.Id = 007;
            teaching.Name = "Kanon";
            teaching.Address = "Whateverstraat";
            teaching.Phone = "0486987654312";
            

            Console.WriteLine(teaching.ToString());

            NonTeaching nonteaching = new NonTeaching();
            nonteaching.Id = 456;
            nonteaching.Name = "Donnel";
            nonteaching.Address = "blablastraat";
            nonteaching.Phone = "003212456";
            nonteaching.Salaray = 2000.45;
            nonteaching.JobTitle = "secretaris";
            nonteaching.ManagerName = "manager7";
            nonteaching.ManagerId = 8910;                

            Console.WriteLine(nonteaching.ToString());

        }
    }
}
