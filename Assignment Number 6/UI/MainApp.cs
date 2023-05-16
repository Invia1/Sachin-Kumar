using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using day8SmallEmployeeApp.models;
using day8SmallEmployeeApp.Services;

namespace day8SmallEmployeeApp.UI
{
    internal class MainApp
    {
        public static void Main(string[] args)
        {
            EmpServices c1 = new EmpServices();

            //es.AddEmp(new Employee(1, "Sam1", 21));
            //es.AddEmp(new Employee(2, "Sam2", 22));
            //es.AddEmp(new Employee(3, "Sam3", 23));
            //es.AddEmp(new Employee(4, "Sam4", 24));
            //es.AddEmp(new Employee(5, "Sam5", 25));
            //es.AddEmp(new Employee(6, "Sam6", 26));
            //es.AddEmp(new Employee(7, "Sam7", 27));
            //es.AddEmp(new Employee(8, "Sam8", 28));
            //es.AddEmp(new Employee(9, "Sam9", 29));

            // es.FetchAlldata();

            void display()
            {
                Console.WriteLine("\n\t\t.....Welcome to Employee Data operations.....\n");
                Console.WriteLine(" \t\tpress 1. to Add Data");
                Console.WriteLine(" \t\tpress 2. to Remove Data");
                Console.WriteLine(" \t\tpress 3. to search Data");
                Console.WriteLine(" \t\tpress 4. to fetch Data");
                Console.WriteLine(" \t\tpress 5. to update Data");
                Console.WriteLine(" \t\tpress 6. to to exit");
                Console.Write("\n\t\t");
            }
           

            bool check = true;
            while (check)
            {
                display();
                int n = int.Parse(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        c1.AddEmp(); Console.Clear();
                        break;
                    case 2:
                        c1.DeleteEmp(); Console.Clear();
                        break;
                    case 3:
                        c1.seachEmployee(); Console.Clear();
                        break;
                    case 4:
                        c1.FetchAlldata(); Console.Clear();
                        break;
                    case 5:
                        c1.UpdateEmp(); Console.Clear();
                        break;
                    case 6: check = false; break;
                    default:
                        Console.WriteLine("\n\t\t Wrong value enters.....");
                        break;
                }

            }

        }

    }

}

