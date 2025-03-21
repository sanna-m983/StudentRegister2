﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegister2
{
    internal class StudentRegister
    {
        public void MainMenu() 
        {
            int userChoice = 0;
            do
            {
                Console.WriteLine("Välj ett av följande alternativ:");
                Console.WriteLine("================================");
                Console.WriteLine("1. Registrera ny student");
                Console.WriteLine("2. Lista alla studenter");
                Console.WriteLine("3. Ändra student");
                Console.WriteLine("4. Avsluta");
                Console.WriteLine("================================");
                userChoice = int.Parse(Console.ReadLine());
                
                switch (userChoice)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        ShowAllStudents();
                        break;
                    case 3:
                        UpdateStudent();
                        break;
                    case 4:
                        Console.WriteLine("Avslutar programmet...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Ogiltigt val. Försök igen");
                        MainMenu();
                        break;
                }
            } while (userChoice != 4);
        }
        public void AddStudent()
        {
            StudentDbContext std = new StudentDbContext();
            Student student = new Student();
            Console.WriteLine("Ange förnamn:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Ange efternamn:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Ange stad");
            string city = Console.ReadLine();
            student.FirstName = firstName;
            student.LastName = lastName;
            student.City = city;
            std.Students.Add(student);
            std.SaveChanges();
        }

        public void ShowAllStudents()
        {
            StudentDbContext std = new StudentDbContext();
            foreach (var student in std.Students)
            {
                Console.WriteLine(student.StudentId + " " + student.FirstName + " " + student.LastName + " " + student.City);
            }
        }

        public void UpdateStudent() 
        {
            StudentDbContext std = new StudentDbContext();

            Console.Write("Ange studentens ID: ");
            if (int.TryParse(Console.ReadLine(), out int studentId))
            {

                var student = std.Students.FirstOrDefault(s => s.StudentId == studentId);

                if (student != null)
                {
                    Console.Write("Ange nytt förnamn: ");
                    student.FirstName = Console.ReadLine();
                    Console.Write("Ange nytt efternamn: ");
                    student.LastName = Console.ReadLine();
                    Console.Write("Ange ny stad: ");
                    student.City = Console.ReadLine();

                    std.SaveChanges();

                    Console.WriteLine("Uppdatering lyckades.");
                }
                else
                {
                    Console.WriteLine("Student hittades inte.");
                }
            }
            else
            {
                Console.WriteLine("Felaktigt student ID.");
            }
        }
    }
}
