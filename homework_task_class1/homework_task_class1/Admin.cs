using System;
using System.Collections.Generic;
using System.Text;

namespace homework_task_class1
{
    class Admin : User
    {
        public bool isAdmin;
        string section;



        public Admin(string username, string password, bool isaAdminN, string section_) : base(username, password)
        {
            _Username = username;
            _Password = password;
            isAdmin = isaAdminN;
            section = section_;
        }

         public void getInfo()
        {
            
            Console.WriteLine($"Username: {_Username}, Password: {_Password}, Section: {section}, {(isAdmin ? "This admin is super admin" : "This admin is not super admin")}");
        }



    }
}
