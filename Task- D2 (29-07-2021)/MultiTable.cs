using System;


class Multiplication
{
    
public static void Main() 
    
{
      
Console.WriteLine("Enter number");
      
int num = Convert.ToInt32(Console.ReadLine());
      
for(int i=0; i<=20; i++)
      
{
          
int total = num * i;
          
Console.WriteLine(num + "*" + i + "=" + total + "N");
      
}
      
    
}

}