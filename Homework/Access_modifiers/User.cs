using System;
namespace Access_modifiers
{
    public class User
    {
        private string _Username;
        private string _Password;


        public User(string username, string password)
        {
            _Username = username;
            _Password = password;
        }

        public string username
        {
            get
            {
                return _Username;
            }
            set
            {
                if (value.Length > 6)
                {
                    _Username = value;
                }

                else
                {
                    Console.WriteLine("Istifadeci adi minimim 7eded daxil etmelidir");
                }
            }
        }


        public string password
        {
            get
            {
                return _Password;
            }
            set
            {

                if (CheckPassword(value))
                {
                    _Password = value;
                }

                else
                {
                    Console.WriteLine("Zehmet olmasa parol");
                }
            }
        }


        public  bool  CheckPassword(string password)
        {
            if (password.Length>8)
            {
                bool isUpper = false;
                bool isLower = false;
                bool isDigit = false;

                foreach (var letter in password)
                {
                    if (char.IsDigit(letter))
                    {
                        isDigit = true;
                    }

                    else if (char.IsLower(letter))
                    {
                        isLower = true;
                    }

                    else if (char.IsUpper(letter))
                    {
                        isUpper = true;
                    }

                    bool result = isUpper && isLower && isDigit;

                    return result;   
                }
            }
                 return false;
        }
    }
}