using System;

class Patient
{
public static void Main(String []args)
{
    int age;
    Console.WriteLine("Enter the Age of Patient");
    age = Convert.ToInt32(Console.ReadLine());
    if(age<16){
     Console.WriteLine("Paediatric case");
    }
    else
    Console.WriteLine("Adult case");
}
    
}