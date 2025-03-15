using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

namespace StudentRegister2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentRegister studentRegister = new StudentRegister();
            studentRegister.MainMenu();
            //Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Students2; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False
        }
    }
}
