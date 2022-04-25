using System;
using System.Collections.Generic;
using System.Text;

namespace homework_task_class1
{
    class User
    {
        protected string _Username;
        protected string _Password;

        public User(string username,string password)
        {
            _Username = username;
            _Password = password;   
        }
        public User()
        {

        }




        public string analizePassword
        {
            get
            {
                return _Password;
            }
            set
            {

                if(checkPassword(value) == true)
                {
                    _Password = value;
                }
                else
                {
                    Console.WriteLine("Password is incorrect");
                }
            }

        }

        public bool checkPassword(string password)
        {

            if (password.Length > 8)
            {
                bool isDigit = false;
                bool isUpper = false;
                bool isLower = false;

                foreach (char letter in password)
                {

                    if (Char.IsDigit(letter))
                    {
                        isDigit = true;
                        continue;
                    }
                    else if (Char.IsUpper(letter))
                    {
                        isUpper = true;
                        continue;
                    }

                    else if (char.IsLower(letter))
                    {
                        isLower = true;
                        continue;
                    }
                  
                    
                }
                bool result = isDigit && isUpper && isLower;

                return result;
            }
            return false;

        }
          
           
    }
}
