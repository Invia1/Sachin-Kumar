using Hospital_Management_System.Models;
using System;
using Hospital_Management_System.Services;
using Hospital_Management_System.Functionality;

namespace Hospital_Management_System.UI
{
    internal class Hopital
    {
        public static void Main()
        {
            void display() // Aadhar no...to check duplicate data 
            {
                
                Console.WriteLine("\n\t\t\t....Welcome to RIM Hospital...");
                Console.WriteLine("\n\t\t ------------------------------------------");
                Console.WriteLine("\t\t Options : \n");

                Console.WriteLine("\t\t click 1: Display All Patients Data");
                Console.WriteLine("\t\t click 2: Register New Patient");
                Console.WriteLine("\t\t click 3: Search Patient Data");
                
                Console.Write(" \t\t Enter Your Choice...");
                Console.WriteLine("\n\t\t ------------------------------------------");
                Console.Write("\t\t");
            }

            IPatientServices p1 = new PatientServices();

            bool check = true;
            while (check)
            {
                display();
                int n = int.Parse(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        p1.DisplayData(); Console.Clear();
                        break;
                    case 2:
                        p1.RegisterPatient(); Console.Clear();
                        break;
                    case 3:p1.EnterPatient(); Console.Clear();
                        break;
                   
                    case 5: check = false; break;
                    default:
                        Console.WriteLine("wrong enter");
                        break;

                }

            }

        }
    }
}
