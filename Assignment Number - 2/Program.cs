using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace SwitchOptions
{
    internal class Program
    {


        // display 
        static void Main(string[] args)
        {
            // Creating switch case options between 1. factorial | 2. fibonacci | 3. Prime No.

            //.......Factorials........

            void Factorial()
            {
                Console.WriteLine("\n\t......1. Welcome to Factorial program........\n");
                Console.WriteLine("Please Enter the Number of What the factorial you Want...");
                int num=int.Parse(Console.ReadLine());
                int fact = 1;
                if(num== 0) { Console.WriteLine(" Your Factrial Numbers is --> {0}", fact); return; }
                for(int i = 1; i <= num; i++)
                {
                    fact *= i;
                }
                Console.WriteLine("\t\tYour Factrial Numbers is --> {0} \n", fact);


            }
            
            // ........Fibonacci function.........
            void Fibonacci()
            {
                Console.WriteLine("\n\t......1. Welcome to Fibonacci Series program........\n");
                Console.WriteLine("Please Enter the Number of What the Fibonacci No. you Want...");
                int num = int.Parse(Console.ReadLine());

                int f1=0; if (num == f1) { Console.WriteLine(" Your Fibo.. Numbers is --> {0}", f1); return; }
                int f2=1; if(num==f2){ Console.WriteLine(" Your Fibo.. Numbers is --> {0}", f2); return; }
                int f3=0;

                for(int i = 2; i <= num; i++)
                {
                    f3 = f1 + f2;
                    f2 = f3;
                    f1 = f2;
                }

                Console.WriteLine(" Your ith Fibo.. Numbers is --> {0}", f3);

            }

//  ---------prime No.........
             void PrimeNumber()
            {
                Console.WriteLine("\n\t......1. Welcome to Prime Number program........\n");
                Console.WriteLine("Please Enter the Number to Check Number is Prime or Not...");
                int num = int.Parse(Console.ReadLine());

                for(int i=2; i<num; i++)
                {
                    if(num%i == 0) { Console.WriteLine("\n\t\tYour Number is Not Prime...."); return; }
                }
                
                Console.WriteLine("\n\t\t{0} Number is Prime.....",num);
            }


            void display()
            {
                Console.WriteLine("\n\n\t\t\t\tWelcome To Coding New-Era Options\n");
                Console.WriteLine("\t\t.......Please Choose the options are following....... \n");
                Console.WriteLine("\t1. Want to Play With Factorial Program...\n");
                Console.WriteLine("\t2. Want to Play With Fibonacci Program...\n");
                Console.WriteLine("\t3. Want to Play With Prime Numbers Program...\n \r");
                Console.WriteLine("\t4. Press for Exit \n");
            }

            while (true)
            {
               display();

                var option= int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:// Console.WriteLine("\n\t......1. Factorial program........"); 
                        Factorial();
                        break;
                    case 2: //Console.WriteLine("\n\t......2. Fibonacci Series program........"); 
                        Fibonacci();
                        break;

                    case 3: //Console.WriteLine("\n\t......1.Prime Number program........"); 
                        PrimeNumber();
                        break;
                    case 4: Console.WriteLine("4");
                        break;

                    default: Console.WriteLine("Sorry you have Enter Wrong Option....");
                        break;

                }

                if (option == 4) break;
                Console.WriteLine("\n\tWant Continue press 1...\n ");
                Console.WriteLine("\tWant Exit press 0... ");
                int n = int.Parse(Console.ReadLine());
                if (n == 0) break;
                else continue;

            }

        }
    }
}
