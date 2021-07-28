using System;

class Campus
{
public static void Main(String []args)
{
    int Aptitude;
    int Technical;
    int Hr;
    Console.WriteLine("Enter your GPA");
    int Gpa = Convert.ToInt32(Console.ReadLine());
    if(Gpa>7)
    {
      Console.WriteLine("Enter your Aptitude Score(Out of 10)");
      Aptitude = Convert.ToInt32(Console.ReadLine());
        if(Aptitude>7)
        {
         Console.WriteLine("Enter your Technical Interview Score(Out of 10)");
         Technical = Convert.ToInt32(Console.ReadLine());
            if(Technical>7){
               Console.WriteLine("Enter your HR Interview Score(Out of 10)"); 
                 Hr = Convert.ToInt32(Console.ReadLine()); 
                 if(Hr>7){
                   Console.WriteLine("Selected"); 
                  }
              else{
                   Console.WriteLine("Not Selected"); 
                   }
            }
            else{
             Console.WriteLine("Try After 3 months");
               }
        }
        else{
             Console.WriteLine("Try After 6 months");
           }
    }
   else{
   Console.WriteLine("Not Eligible");
    }
}
    
}