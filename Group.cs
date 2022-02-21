using System;
using System.Collections.Generic;
using System.Text;

namespace Hometask1
{
    internal class Group:Student
    {
        public string GroupNum;
        public string Limit;
       
            
        public string Students;
        public string AddStudent;
        public string GetStudent;


        public Group(string name , string surname , string groupnum, string limit, string students, string addstudent, string getstudent):base(name,surname)
        {
            //Memnu=memnu;
            //Limit=limit;    
        }
       public string Getinfo() 
        {
            return $"Name: {Name} Surname: {Surname} GroupNum: {GroupNum} Limit: {Limit} Students: {Students} AddStudent: {AddStudent} GetStudent: {GetStudent} ";
        }
    }
}
