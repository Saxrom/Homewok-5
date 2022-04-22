using System;
namespace Access_modifiers
{
    public class Admin:User
    {
        public string Section;
        public bool isSupperAdmin;


        public Admin(string username,string password,string section,bool issupper):base(username,password)
        {
            Section = section;
            isSupperAdmin = issupper;
        }

        public void getInfo()
        {
            Console.WriteLine( $"username: {username}, Password: {password}, Section: {Section}, {(isSupperAdmin ? "This admin is super admin" : "This admin is not super admin")}");
        }
    }
}
