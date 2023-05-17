using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.Functionality
{
    internal interface IPatientServices
    {
        void RegisterPatient();
        void DisplayData();
        void EnterPatient();
        //bool IsDuplicate(string str);


    }
}
