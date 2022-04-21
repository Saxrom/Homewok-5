using System;
namespace Access_modifiers
{
    public class User
    {
        private string _Username;
        private string _Password;

        public string username
        {
            get
            {
        
                return username;
            }
            set
            {
                if (username.Length > 6)
                {
                    Console.WriteLine(username);
                }

                else
                {
                    Console.WriteLine("Zehmet olmasasa adinizi yeniden daxil edin");
                }

            }
        }

        public object MyProperty
        {
            get
            {
                return _Password;

            }
            set
            {
                if (_Password.Length>1)
                {
                    for (int i = 0; i < _Password.Length; i++)
                    {
                        if (char.IsUpper(_Password[i]))
                        {
                            username = _Username;
                        }
                    }
                }

                else
                {
                    Console.WriteLine("Zehmet olmasa passwordu yeniden daxil edin");
                }
            }
        }



        

        public User(string username,string password)
        {
            _Username = username;
            _Password = password;
        }
    }
}
