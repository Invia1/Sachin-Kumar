using System;
class RepeatedElements{
   public static void Main(){
      // Count Repeated Elements----->
      string str=Console.ReadLine();  // Console.WriteLine(str); 

      // brute-force -approach-->
    int[] vis=new int[26] ;
      for(int i=0;i<str.Length;i++){
         if(str[i]==' ') continue;    
        if(vis[str[i]-'a'] == 1) continue;
         // count ith alphabet how many times if it is greter then 2 times printed that alpha...
         char ch=str[i]; //str[i]='k';
         vis[str[i]-'a']=1;
        // str[i]='$';
         int cnt=0;
        for(int j=0;j<str.Length;j++){
           if(ch==str[j]) cnt++;
        }
      // checking cnt==2
      if(cnt>=1) Console.WriteLine(ch+ " is present  "+cnt+" times in a Word" );
   }
}
}