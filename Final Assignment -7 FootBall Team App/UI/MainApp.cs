using day9.Foot_Ball_Team_App.Fuctionality;
using System;
using System.Collections.Generic;
using day9.Foot_Ball_Team_App.Services;

namespace day9.Foot_Ball_Team_App.UI
{
    internal class MainApp
    {
       


        public static void Main(string[] args) {

            void display()
            {
                Console.WriteLine("\n\t\tWelcome to Foot BAll Team App...");
                Console.WriteLine("\n\t\t-------------------------------------------");
                Console.WriteLine("\t\t\t\t_____Choices_____\n");

                Console.WriteLine(" \t\tclick 1. to Add Player");
                Console.WriteLine(" \t\tclick 2. to Display All Data");
                Console.WriteLine(" \t\tclick 3. to search Player Data");
                Console.WriteLine(" \t\tclick 4. to Remove Player Data");
                Console.WriteLine(" \t\tclick 5. to update Player Data");
                Console.WriteLine(" \t\tclick 6. to to exit");
                Console.Write(" \t\tEnter Your Choice...");
                Console.WriteLine("\n\t\t-------------------------------------------");
                Console.Write("\t\t");
            }

            IPlayerServices c1 =new PlayerServices();

            bool check = true;
            while (check)
            {
                display();
                int n = int.Parse(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        c1.AddPlayer();
                        break;
                    case 2:
                        c1.ReadPlayer();
                        break;
                    case 3:
                        c1.SearchPlayer();
                        break;
                    case 4:
                        c1.RemovePlayer();
                        break;
                    case 5:
                        c1.updatePlayer();  //c1.RemovePlayer();
                        break;
                    case 6:c1.GetPlayerCount();
                        break;

                    case 7: check = false; break;
                    default:
                        Console.WriteLine("wrong enter");
                        break;

                }

            }


        }
          
             
    }

}



