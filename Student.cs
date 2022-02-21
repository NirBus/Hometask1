using System;
using System.Collections.Generic;
using System.Text;

namespace Hometask1
{
    internal class Student
    {
        public string Name;
        public string Surname;

        public Student(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
        public string getinfo()
        {
            return $"\nName: {Name} \nSurname: {Surname}"; 
        }

        
    }
}
