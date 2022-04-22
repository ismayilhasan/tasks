using System;
using System.Text;

namespace training
{
    class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student("Ismayil","Hasanov",20,"Male",98,true);
            Console.WriteLine(student.getInfo());

            
        }


    }

    class Student
    {
        public string Name;
        public string Surname;
        public byte Age;
        public string Gender;
        public byte Point;
        public bool isGraduated;

        public Student(string name,string surname,byte age,string gender,byte point,bool result )
        {
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
            Point = point;
            isGraduated = result;
        }

        public string getInfo()
        {
            
            
            
                return $"Name : {Name} \nSurname : {Surname} \nAge {Age}   \nGender : {Gender} \nPoint : {Point} \ntelebe mezun olub";
            
           
        }
    }
}
