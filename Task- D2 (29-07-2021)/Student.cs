using System;


class Student

{
    
public static void Main() 
    
{
        
double total=0;
        
double per=0;
      
int [] subj = new int[5]{87,89,92,98,100};
     
for(int i=0; i<subj.Length; i++)
     
{
         
total = total + subj[i];
     
}
         
Console.WriteLine("The total score is" + total);
         
per = (total/500)*100;
         
Console.WriteLine("The percentage is" + per);
     
    
}

}