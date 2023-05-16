using day8SmallEmployeeApp.models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Security.Policy;

namespace day8SmallEmployeeApp.Services
{
    internal class EmpServices
    {
        List<Employee> ls=new List<Employee>();

        public List<Employee> GetALlEmp() { return ls; }
        public int GetEmpCount(Employee e) {return ls.Count; }
        public void UpdateEmp() 
        {
            Console.WriteLine("\n\t\tplease enter Employee Id to Update...");
            int id = int.Parse(Console.ReadLine());

            foreach (var i in ls)
            {
                if (i.EmpId == id)
                {
                    Console.WriteLine("\n\t\tPlease enter Employee Id No.");
                    int n = int.Parse(Console.ReadLine());
                    Console.WriteLine("\t\tplease enter Employee Name");
                    string n1 = Console.ReadLine();
                    Console.WriteLine("\t\tplease enter Employee Age");
                    int n2 = int.Parse(Console.ReadLine());

                    i.EmpId = n;
                    i.Name = n1;    
                    i.Age = n2; 

                    Console.WriteLine("\n\t\tCongratulations !! Data Successfully Updated...");
                }
            }
            Console.WriteLine("Id is Not present ");
        }
        public void DeleteEmp()
        {
            Console.WriteLine("\n\t\tplease enter Employee Id to delete...");
            int id = int.Parse(Console.ReadLine());

            foreach (var i in ls)
            {
                if (i.EmpId == id)
                {
                    ls.Remove(i);
                    Console.WriteLine("\n\t\tdata is Deleted"); return;
                }
            }
            Console.WriteLine("\n\t\tId is Not present.... ");

        }

        // Add data
        public void AddEmp()
        {
            Console.WriteLine("\n\t\tPlease give some details of Employee....");
            Console.Write("\n\t\tplease enter Updated Employee Id No.-");
            int n=int.Parse(Console.ReadLine());
            Console.Write("\t\tplease enter Updated Employee Name-");
            string n1=Console.ReadLine();
            Console.Write("\t\tplease enter Updated Employee Age-");
            int n2=int.Parse(Console.ReadLine());

            ls.Add(new Employee(n,n1,n2));

            Console.WriteLine("\n\t\tCongratulations !! Data Successfully Added...");

            Console.WriteLine("\n\t\t ....Want to Add more Data Press 1\t else press 2...");

            int n3=int.Parse(Console.ReadLine());

            if (n3 == 2) return;
            else if(n3 == 1) { AddEmp();}
            else { Console.WriteLine("\t\tWorng Number pressing..."); }
        }
        public void seachEmployee() 
        {
            Console.WriteLine("\n\t\tPlease Enter Employee Id....");
            int id=int.Parse(Console.ReadLine());
            foreach(var i in ls)
            {
                if (i.EmpId == id) Console.WriteLine("\n\t\tYes data is Present....");
                Console.ReadLine(); 
                return;
            }
            Console.WriteLine("\n\t\tId is Not present.... "); 
            Console.ReadLine();
        }

        // fetch All data
        public void FetchAlldata() 
        {
            Console.WriteLine("\n\t\tId | Name  | age ");
            foreach(Employee e in ls)
            {
                Console.WriteLine("\n\t\t"+e.EmpId+"  | "+e.Name+"  | "+e.Age);
            }
            Console.ReadLine();
        }

    }
}
