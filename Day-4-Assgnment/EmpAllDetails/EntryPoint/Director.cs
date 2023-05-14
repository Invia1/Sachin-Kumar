using EmpAllDetails.BLL;
using System;
using System.Collections.Generic;


namespace EmpAllDetails.EntryPoint
{
    internal class Director
    {
        public static void Main(string[] args)
        {
            HR hR = new HR();
            hR.DisplayDetails();
            Console.WriteLine("Here is Director");
        }
    }
}
