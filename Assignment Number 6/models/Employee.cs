using System;
using System.Collections.Generic;


namespace day8SmallEmployeeApp.models
{
    internal class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }    
        public int Age { get; set; } 
        
        Employee() { }
        public Employee(int id,string name,int age) 
        { 
            EmpId = id;
            Name = name;    
            Age = age;
        }
    }
}
