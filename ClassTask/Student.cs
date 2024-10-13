using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask
{
    class Student
    {

        public string Name;
        public string Surname;
        public string Group;
        public byte Point;
        public bool IsGraduated;


        public Student(string name, string surname, string group, byte point, bool IsGraduated)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Point = point;
            IsGraduated = IsGraduated;

        }


        public void GetInfo()
        {

            Console.WriteLine($"Name:{Name},Surname:{Surname},Group:{Group},Point:{Point},isGraduated:{IsGraduated}");
        }

        public void CheckGraduation()
        {
            if (Point < 65)
            {
                IsGraduated = false;
                Console.WriteLine("Mezun olmadi");
            }
            else
            {
                IsGraduated = true;
                Console.WriteLine("Mezun oldu");
            }
        }

        public void GetDiplomaDegree()
        {
            if (Point < 65)
            {
                Console.WriteLine("Diplom ala bilmediniz");
            }
            else if (Point > 65 && Point < 80)
            {
                Console.WriteLine("Diplom aldiniz");
            }
            else if (Point > 80 && Point < 90)
            {
                Console.WriteLine(" Sheref Diplomu aldiniz");
            }
            else if (Point > 90)
            {
                Console.WriteLine(" Yuksek Sheref Diplomu aldiniz");
            }
        }


    }
}
