using System;



class NameAge
{
    
public static void Main() 
    
{
        
Console.WriteLine("Enter name");
      
string name = Console.ReadLine();

Console.WriteLine("Enter age");      
int age = Convert.ToInt32(Console.ReadLine());
      
for(int i=0; i<age; i++)
      
{
          
Console.WriteLine(name);
      
}
      
    
}

}