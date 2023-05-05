using System;
class staticReadonlyVar{

    class collegeAdmission{
       public static readonly int rollNo;
         static collegeAdmission(){
            rollNo=1;
            Console.WriteLine(rollNo+"->Initial by object Construct");
        }
    }

    public static void Main(){
      collegeAdmission stu1=new collegeAdmission();
      
      Console.WriteLine(collegeAdmission.rollNo+"->Access by class name");
       
    }
}