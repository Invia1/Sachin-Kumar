using System;

class staticvariableProgram{

     class CollegeVotes{
       public static int FirstCandidate=0; // static varibale initialised and access by multiple object of Same Class ..
       public static int SecondCandidate=0;
// ----------functions----------
       public void VoteCandidate1(){
            FirstCandidate++;
        }
       public void VoteCandidate2(){
            SecondCandidate++;
        }


       public int getCandidate1(){
            return FirstCandidate;
        }
       public int getCandidate2(){
            return SecondCandidate;
        }
     }

    public static void Main(){
       CollegeVotes stu1=new CollegeVotes();
       CollegeVotes stu2=new CollegeVotes();
       CollegeVotes stu3=new CollegeVotes();
       CollegeVotes stu4=new CollegeVotes();

        stu1.VoteCandidate1();
        stu2.VoteCandidate1();
        stu3.VoteCandidate1();
        stu4.VoteCandidate2();
        stu1.VoteCandidate2();
        stu2.VoteCandidate1();


        //stu1.getCandidate1();
        Console.WriteLine("candiate 1 get "+stu1.getCandidate1()+ " votes " + " and Candidate 2 get " + stu1.getCandidate2() + " votes" );

    }   
} 