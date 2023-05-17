using day9.Foot_Ball_Team_App.Fuctionality;
using day9.Foot_Ball_Team_App.Models;
using System;
using System.Collections.Generic;

namespace day9.Foot_Ball_Team_App.Services
{
    internal class PlayerServices:IPlayerServices
    {
        List<Player> ls = new List<Player>();

        public List<Player> GetALlEmp() { return ls; }
        public int GetPlayerCount() { return ls.Count; }
        public void updatePlayer()
        {
            Console.WriteLine("\n\t\tplease enter Player Id to Update...");
            int id = int.Parse(Console.ReadLine());

            foreach (var i in ls)
            {
                if (i.PID==id)
                {
                   // Console.WriteLine("\n\t\tPlease enter Updated Player Id No.");
                   // int n = int.Parse(Console.ReadLine());
                    Console.Write("\t\tplease enter Updated Player Name....");
                    string n1 = Console.ReadLine();
                    Console.Write("\t\tplease enter Updated Player Age....");
                    int n2 = int.Parse(Console.ReadLine());

                   // i.PID = n;
                    i.Pname = n1;
                    i.Age = n2;

                    Console.WriteLine("\n\t\tCongratulations !! Data Successfully Updated..."); return;
                }
            }
            Console.WriteLine("\t\t...Player Id is Not present.... ");
            Console.ReadLine();
        }
        public void RemovePlayer()
        {
            Console.WriteLine("\n\t\tplease enter Player Id to delete...");
            int id = int.Parse(Console.ReadLine());

            foreach (var i in ls)
            {
                if (i.PID == id)
                {
                    ls.Remove(i);
                    Console.WriteLine("\n\t\t...data is Deleted Press any key to Continue...");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("\n\t\tId is Not present.... ");

        }

        // Add data
        public void AddPlayer()
        {
            Console.WriteLine("\n\t\tPlease give some details of Player....");
            Console.Write("\n\t\tplease enter  Player Id No...");
            int n = int.Parse(Console.ReadLine());
            Console.Write("\t\tplease enter  Player Name...");
            string n1 = Console.ReadLine();
            Console.Write("\t\tplease enter Player Age...");
            int n2 = int.Parse(Console.ReadLine());

            ls.Add(new Player(n, n1, n2));

            Console.WriteLine("\n\t\tCongratulations !! Data Successfully Added...");

            Console.WriteLine("\n\t\t ....Want to Add more Data Press 1\t else press 2...");

            int n3 = int.Parse(Console.ReadLine());

            if (n3 == 2) return;
            else if (n3 == 1) { AddPlayer(); }
            else { Console.WriteLine("\t\tWorng Number pressing..."); }
        }
        public void SearchPlayer()
        {
            Console.Write("\n\t\tPlease Enter Player Id....");
            int id = int.Parse(Console.ReadLine());
            foreach (var i in ls)
            {
                if (i.PID == id) Console.WriteLine("\n\t\tYes data is Present....");
                Console.ReadLine();
                return;
            }
            Console.Write("\n\t\tPlayer data Id is Not present Press Any Key to Continue.... ");
            Console.ReadLine();
        }

        // fetch All data
        public void ReadPlayer()
        {
            Console.WriteLine("\n\t\tId | Name  | age ");
            foreach (Player e in ls)
            {
                Console.WriteLine("\n\t\t" + e.PID + "  | " + e.Pname + "  | " + e.Age);
            }
            Console.ReadLine();
        }
    }
}
