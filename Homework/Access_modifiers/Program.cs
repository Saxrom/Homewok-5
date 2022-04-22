using System;

namespace Access_modifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            string username;

            do
            {
                Console.WriteLine("Zehmet olmasa adinizi daxil edin");

                username = Console.ReadLine();

            } while (username.Length < 6);


            string password;

            do
            {
                Console.WriteLine("Zehmet olmasa shifrenizi daxil edin");

                password = Console.ReadLine();

            } while (!CheckPassword(password));


            Console.WriteLine("Zehmet olmasa sectio'nu daxil edin");

            string section = Console.ReadLine();

            Console.WriteLine("Siz supper adminsiz? y/n");

            string isSupperstr = Console.ReadLine();

            bool isSupper = false;

            if (isSupperstr.ToLower().Trim()=="y")
            {
                isSupper = true;
            }

            Admin admin = new Admin(username, password, section, isSupper);

            admin.getInfo();

            User user = new User("Test123", "Test123");
            Console.WriteLine();


        }

        public static bool CheckPassword(string password)
        {
            if (password.Length >= 8)
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
