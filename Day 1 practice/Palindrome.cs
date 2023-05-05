using System;
class Palindrome{
    public static void Main(string[] args){
        // To get Input through Console and Print weather string is Palindrome or not..?
        Console.WriteLine("Please Enter A Word");
        string str=Console.ReadLine();
       //  start traversing from first and last index of a Word and check similar alphawords...?
      int firstIndex=0; int lastIndex=str.Length-1;

      while(firstIndex<=lastIndex){
           if(str[firstIndex] != str[lastIndex]) {
              Console.WriteLine("Word is Not a Palindrome"); return;
           }
           firstIndex++;
           lastIndex--;
      }
         Console.WriteLine("Word is a Palindrome");
    }
}