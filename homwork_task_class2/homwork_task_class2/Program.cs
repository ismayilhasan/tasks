using System;

namespace homwork_task_class2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please add name of student");
            string name = Console.ReadLine();
            Console.WriteLine("Please add surname of student");
            string surname = Console.ReadLine();
            int limit = 10;
            string[] student_list = new string[limit];

            

            Student student1 = new Student(name, surname, "p324", student_list);

            student1.addStudent(student1);
            


            
        }
    }
}
