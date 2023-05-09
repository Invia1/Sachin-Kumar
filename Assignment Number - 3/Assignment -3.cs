using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

   /*
             this program is Constains the Many Concepts Like Encapsulation and We also called the properties which is used to wraping the private variables of a paerticular class 
             and this machanism 
   */

namespace Day_4_Project_1
{

    class PersonBankDetails
    {
        int accountBalance;
        string personName;
        Person p=new Person();
        public int P_AccountBalance
        {
            get
            {
                return accountBalance;
            }

            set { 
                accountBalance = value;
                if (accountBalance < 10000) { p.cancelShopping(); }
                else { p.readyShop(); }
            }
        }
        public string P_PersonName
        {
            get { return personName; }
            set { personName = value; }
        }

        class Person
        {
            // public member---function to access personBankDetails class


            public void readyShop()
            {
                Console.WriteLine("\n\t\tAmount is sufficient, your are now Ready for shopping  \n\n");
            }
            public void cancelShopping() {
                Console.WriteLine("\n\t\tSorry this Amount is not sufficient for shopping Please Credit More than 10$  ");
            }

            public void PersonDetails()
            {
                var bankObj = new PersonBankDetails();

                Console.WriteLine("\n\t\tWelCome To Shoping World ....Please Enter Your Name ....\n");
                Console.Write("\t\t");
                bankObj.P_PersonName = Console.ReadLine();

                Console.Clear();

                Console.WriteLine("\n\t\tWelcome \"{0}\" Credit your Account for shoping \n", bankObj.P_PersonName);

                Console.Write("\t\tPlease Enter Amouont ");
                bankObj.P_AccountBalance = int.Parse(Console.ReadLine());



            }

        }

        class Shopping // .........
        {
            public static void Main(string[] args)
            {
                // person wants some shoping....
                var shopObj = new Person();
                shopObj.PersonDetails();

                Console.ReadKey();
            }
        }


    }
}
