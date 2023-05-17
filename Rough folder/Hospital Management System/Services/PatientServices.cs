using System;
using System.Collections.Generic;
using Hospital_Management_System.Models;


namespace Hospital_Management_System.Services
{
    internal class PatientServices
    {
        Patient p1=new Patient();  // new patient object..
        List<Patient> ls = new List<Patient>(); // list for patients... to records

        public List<Patient> GetALlEmp() { return ls; }
        

        bool IsDuplicate(string str)
        {
            foreach (var p in ls)
            {
                if(ls.Count==0) return false;
                p.AadharNumber = str; return true;
            }
            return false;
        }
        public void RegisterPatient()  // To add new Patient ...........
        {
            Console.WriteLine("\n\t\tPlease give some details of Patient....");
            Console.Write("\n\t\tPlease enter  Registration Id No : ");
            int n = int.Parse(Console.ReadLine());
            p1.RegistrationId = n;

            Console.Write("\t\tplease enter  Patient's First Name : ");
            string n1 = Console.ReadLine();
            p1.FirstName = n1; // p1 object helping to add new patient name......


            Console.Write("\t\tplease enter  Patient's Last Name : ");
            string n2 = Console.ReadLine();
            p1.LastName = n2;

            Console.Write("\t\tplease enter  Patient's Phone Number : ");
            string n3 = Console.ReadLine();
            p1.PhoneNumber = n3;

            Console.Write("\t\tplease enter  Patient's Gender : ");
            string n4 = Console.ReadLine();
            p1.Gender= n4;

            Console.Write("\t\tplease enter  Patient's Age : ");
            string n5 = Console.ReadLine();
            p1.Age = n5;

            Console.Write("\t\tplease enter  Patient's Address : ");
            string n6 = Console.ReadLine();
            p1.Address = n6;

            Console.Write("\t\tplease enter  Patient's AadharNumber : ");
            string n7 = Console.ReadLine();

            if (IsDuplicate(n7))
            {
                Console.WriteLine("\n\t\tAadhar Number is all ready present : "); return;
            }

            p1.AadharNumber = n7;

            // to Consult....

            Console.WriteLine("\n\t\t Select Speciality to Consult:");
            Console.WriteLine("\n\t\t\t1. General Madicine");
            Console.WriteLine("\n\t\t\t2. Orthopaedics");
            Console.WriteLine("\n\t\t\t3. Dental");
            Console.Write("\n\t\t Enter Your Choice :");
            int choice=int.Parse(Console.ReadLine());
            switch (choice)
            {
                    case 1: p1.SpecialityToConsult= "General Madicine";
                    break;
                    case 2: p1.SpecialityToConsult = "Orthopaedics";
                    break;
                    case 3: p1.SpecialityToConsult = "Dental";
                    break;
            }

            ls.Add(p1);

            Console.Write("\n\t\tPatient Register Successfully!! Please Choose Further Options...");
            Console.Write("\n\t\tclick 1 for Add New Patient : \n\t\tclick 2 for Main Menu : ");
            Console.ReadLine();

            // at the end i am adding ls.add(p1).   1 patient added in list...record...

        }


        // fetch All data 2...
        public void DisplayData()
        {
            if(ls.Count == 0) { 
                Console.WriteLine("\n\t\t : No Record Found :");
                Console.WriteLine("\n\t\t Click Enter to Continue.....");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("\n\t\tRegistration_Id | First Name  | Last Name | Phone Number  | Gender | Age | Address | Aadhar Number| Speciality to Consulted ");
            foreach (var p1 in ls)
            {
                Console.WriteLine("\n\t\t" + p1.RegistrationId + "  | " + p1.FirstName + "  | " + p1.LastName + "  | " + p1.PhoneNumber + "  | " + p1.Gender + "  | " + p1.Age + "  | " + p1.Address + "  | " + p1.AadharNumber + "  | " + p1.SpecialityToConsult);
            }
            Console.WriteLine("\n\t\t Click Enter to Continue.....");
            Console.ReadLine();
        }
        
        ///
        //.....Display enter data....

        public void EnterPatient()
        {
            if (ls.Count == 0)
            {
                Console.WriteLine("\n\t\t : No Record Found :");
                Console.WriteLine("\n\t\t Click Enter to Continue.....");
                Console.ReadLine();
                return;
            }

            Console.Write("\n\t\t Search Panel: \n\t\t\t : Enter Registraion Id : ");
            int n= int.Parse(Console.ReadLine());
            foreach(var p1 in ls)
            {
                if(p1.RegistrationId== n)
                {
                    Console.WriteLine("\n\t\t Patient Detials :");
                    Console.WriteLine("\n\t\t" + p1.RegistrationId + "  | " + p1.FirstName + "  | " + p1.LastName + "  | " + p1.PhoneNumber + "  | " + p1.Gender + "  | " + p1.Age + "  | " + p1.Address + "  | " + p1.AadharNumber + "  | " + p1.SpecialityToConsult);
                    Console.Write("\n\t\tPress Enter to Continue :");
                    Console.ReadLine();
                    return;
                }
            }
        }

    }
}
