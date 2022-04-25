using System;
using System.Collections.Generic;
using System.Text;

namespace homwork_task_class2
{
    class Student : Group
    {
        public string Name;
        public string Surname;

        public Student(string name, string surname, string groupno, string[] students) : base(groupno, students)
        {
            Name = name;
            Surname = surname;
            Group_No = groupno;
            Students = students;

        }


        public void addStudent(Student student)
        {
            Array.Resize(ref Students, Students.Length+1);
            Students[Students.Length - 1] = string.Concat(student.Name + " " + student.Surname);

              foreach(string person in Students)
              {
              
                Console.WriteLine(person);
              }
        }

    }



 
}
