using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntryContact
{ 
    internal class DataEntryContact
    {
        ArrayList obj = new ArrayList();

        void AddData()
        {
            Console.WriteLine("Enter your Contact Name...");
            string name = Console.ReadLine();
            obj.Add(name);
        }
        void DeleteData()
        {
            Console.WriteLine("\n\t\tPlease Enter options\n\t\t 1. Delete All data \n\t\t 2.Delete Specified Contact");
            int n=int.Parse(Console.ReadLine());
            if (n == 1) obj.Clear();
            else if(n==2)
            {
                Console.WriteLine("\n\t\tWhich index of contact wanna delete...");
                foreach (var i in obj) { Console.WriteLine(i); }
                int a=int.Parse(Console.ReadLine());
                obj.RemoveAt(a);
                Console.WriteLine("\n\t\tSuccessfully deleted...");

            }

            return;
        }
        void UpdateData()
        {
            Console.WriteLine("\n\t\tWhich index of contact wanna update...");
            foreach (var i in obj) { Console.WriteLine(i); }
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("\n\t\tEnter Contact Name...");
            string st=Console.ReadLine();
            obj[a] = st;
            return;
        }
        void ReadData()
        {
            foreach (var i in obj) { Console.WriteLine(i); }

            Console.ReadLine();

        }

        static void Main(string[] args)
        {
            DataEntryContact conObj = new DataEntryContact();
            bool check = true;
            while (check)
            {
                Console.WriteLine("\n\n\t\tEnter following Options...");
                Console.WriteLine("\n\t\t1. Add Contact ...");
                Console.WriteLine("\n\t\t2. Delete Contact ...");
                Console.WriteLine("\n\t\t3. Read All Contact ...");
                Console.WriteLine("\n\t\t4. Remove Contact ...");
                Console.WriteLine("\n\t\t5. To Exit ...");
                Console.Write("\n\t\t");


                int n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1: conObj.AddData();
                        break;
                    case 2:
                        conObj.DeleteData();
                        break;
                    case 3:
                        conObj.ReadData(); 
                        break;
                    case 4:
                        conObj. UpdateData();
                        break;
                    case 5:
                        check = false;
                        break;
                    default:
                        Console.WriteLine("\n\t\tSorry !! ..you enter wrong option...");
                        break;

                }
            }
        }
    }
}
