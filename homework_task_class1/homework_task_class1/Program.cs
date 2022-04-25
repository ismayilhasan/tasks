using System;

namespace homework_task_class1
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            Console.WriteLine("Please enter username");
            string username = Console.ReadLine();
            Console.WriteLine("Please enter password");
            string password = Console.ReadLine();




           

            while (!user1.checkPassword(password))
            {

                user1.analizePassword = password;
                password = Console.ReadLine();
                Console.WriteLine("please enter your section");
                string section = Console.ReadLine();
                Console.WriteLine("Are you superAdmin?");
                string isSuperadmin = Console.ReadLine();
                bool isSuper = false;
                if (isSuperadmin.ToLower() == "beli")
                {
                    isSuper = true;
                }
                else if(isSuperadmin.ToLower() == "xeyr")
                {
                    isSuper = false;
                }
               

                Admin admin1 = new Admin(username, password, isSuper, section);

                admin1.getInfo();
                
            }






        }
    }
}
