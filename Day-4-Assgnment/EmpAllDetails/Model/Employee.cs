using System;
using System.Collections.Generic;

namespace EmpAllDetails.BLL {

    internal class Employee
    {
        // this class containg all private State -->encapsulate in unit or wrapping the data via properties;
        string _EmpId;
        string _EmpName;
        string _EmpType;
        string _age;
        public string EmpId
        {

            get { return _EmpId; }
            set
            {
                HR hR = new HR();
                if (hR.IsValidInt(value)) { _EmpId = value; }
                else
                {
                    bool check = true;
                    while (check)
                    {   
                        Console.WriteLine("\n\t\tPlease Enter Valid No. ");
                        string str = Console.ReadLine();
                        if (hR.IsValidInt(str)) { _EmpId = str; check = false; }

                    }
                }
            }
        }

        // age........
        public string age
        {

            get { return _age; }
            set
            {
                HR hR = new HR();
                if (hR.IsValidInt(value)) { _age = value; }
                else
                {
                    bool check = true;
                    while (check)
                    {
                        
                        Console.WriteLine("\n\t\tPlease Enter Valid age. ");
                        string str = Console.ReadLine();
                        if (hR.IsValidInt(str)) { _age = str; check = false; }

                    }
                }
            }
        }

        // string enter name...
        public string EmpName
        {
             
            get { return _EmpName; }
            set
            { HR hR = new HR();
                if (hR.IsValidString(value)) { _EmpName = value; }
                else
                {
                    bool check = true;
                    while (check)
                    {

                        Console.WriteLine("\n\t\tPlease Enter Valid Name. ");
                        string str = Console.ReadLine();
                        if (hR.IsValidString(str)) { _EmpName = str; check = false; }
                    }
                }
            }
        }                        


        //public string EmpName { get; set; }
        public string EmpType { get; set; }
        //public int age { get; set; } // this are properties / auto generated properties...

        public Employee() { }
        //public Employee(string EmpId, string EmpName, string Emptype, int age)
        //{
        //    this.EmpName = EmpName;
        //    this.EmpType = EmpType;
        //    this.age = age;
        //    this.EmpId = EmpId;
        //}

        //static void Main(string[] args){}
    } }
