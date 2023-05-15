using System;
using System.Collections.Generic;


namespace Day7_Generics
{/*
    List Operations 1. add , 2.delete , 3.update, 4.search. 5. fecth all data. 
 */
    class Contacts
    {
        List<string> ls=new List<string>();

        public void AddCon()
        {
            Console.WriteLine("Enter Contact Name data");
            string str=Console.ReadLine();  
            ls.Add(str);
        }
        public void RemoveCon()
        {

            Console.WriteLine("\n\t\tPlease Enter options\n\t\t 1. Delete All data \n\t\t 2.Delete Specified Contact");
            int n = int.Parse(Console.ReadLine());
            if (n == 1) ls.Clear();
            else if (n == 2)
            {
                Console.WriteLine("\n\t\tWhich index of contact wanna delete...");
                foreach (var i in ls) { Console.WriteLine(i); }
                int a = int.Parse(Console.ReadLine());
                ls.RemoveAt(a);
                Console.WriteLine("\n\t\tSuccessfully deleted...");
            }
        }
        public void updateCon() {
            int n = 0;
            Console.WriteLine("\n\t\tWhich index of contact wanna update...");
            foreach (var i in ls) { Console.WriteLine($"{n++}->{i}"); }
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("\n\t\tEnter Contact Name...");
            string st = Console.ReadLine();
            ls[a] = st;
            return;
        }
        public void SearchCon() {
            Console.WriteLine("Please Enter Contact Data want to Search");
            string str = Console.ReadLine();

            foreach (var i in ls)
            {
                if (i.Equals(str)) { Console.WriteLine("yes present"); return; }
            }
            Console.WriteLine("not Found"); Console.ReadLine();
        }
        public void ReadCon()
        {
            foreach (var i in ls) { Console.WriteLine(i); } Console.ReadLine();
        }
        
    }


    internal class List
    {
        public static void Main()
        {

            void display() {
                Console.WriteLine("\n\t\tWelcome to List<string> operations");
                Console.WriteLine(" press 1. to Add Data");
                Console.WriteLine(" press 2. to Remove Data");
                Console.WriteLine(" press 3. to search Data");
                Console.WriteLine(" press 4. to fetch Data");
                Console.WriteLine(" press 5. to update Data");
                Console.WriteLine(" press 6. to to exit");
            }

            Contacts c1= new Contacts();

            bool check = true;
            while (check)
            {
              display();
              int n=int.Parse(Console.ReadLine());
                
                switch(n)
                {
                        case 1: c1.AddCon();
                        break;
                        case 2: c1.RemoveCon();
                        break;
                        case 3: c1.SearchCon();
                        break;
                        case 4: c1.ReadCon();
                        break;
                        case 5: c1.updateCon();
                        break;
                        case 6: check= false; break;
                        default : Console.WriteLine("wrong enter");
                        break;

                }

            }

        }
    }
}
