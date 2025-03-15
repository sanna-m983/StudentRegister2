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
        }
    }
}
