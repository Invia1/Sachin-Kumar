using System;
using System.Collections;
using System.Text.RegularExpressions;
using System.Xml.Linq;
//using EmpAllDetails.BLL;

namespace EmpAllDetails.BLL
{
    internal class HR
    {
       // ArrayList empData= new ArrayList();
        //void AddEmp(Employee e)
        //{
        //    empData.Add(e);
        //}
        public bool IsValidInt(string s)
        {
            int num;
            return int.TryParse(s, out num);
           
        }
        public bool IsValidString(string s)
        {
            string pattern = @"^[A-Za-z\s]+$";

            Regex regex = new Regex(pattern);

            return regex.IsMatch(s);
        }
        public void DisplayDetails()
        {
            //Employee e1 = new Employee(101, "sam", "cse", 21);
            //Employee e2 = new Employee(102, "sam", "cse", 21);
            //Employee e3 = new Employee(103, "sam", "cse", 21);
            //Employee e4 = new Employee(104, "sam", "cse", 21);
            //AddEmp(e1);
            //AddEmp(e2);
            //AddEmp(e3);
            //AddEmp(e4);
            //foreach (var e in empData) { Console.WriteLine(e); }

            Employee e1 = new Employee();
            Console.WriteLine("\n\t\tEnter Employee Id");
            e1.EmpId = Console.ReadLine();
            Console.WriteLine("\n\t\tEnter Employee Name");
            e1.EmpName = Console.ReadLine();
            Console.WriteLine("\n\t\tEnter Employee Age");
            e1.age = Console.ReadLine();

            Console.WriteLine($"\n\t\tEmployee id={e1.EmpId}, \n\t\tEmployee Name ={e1.EmpName},\n\t\tEmployee age={e1.age}");

            Console.ReadLine(); 
        }
    }
}
