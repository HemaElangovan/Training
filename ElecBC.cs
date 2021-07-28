using System;


class ElectricityBillCal

{
   
public static void  Main() 
    
{
        
Console.WriteLine("Please enter the units");
        
int units = Convert.ToInt32(Console.ReadLine());
        
if(units <=200)
        
{
            
Console.WriteLine(units*2);
        
}
        
else if(units<350)
        
{
            
Console.WriteLine((200*2) + (units-200)*3);
        
}
        else if(units<=500)
        
{
           
Console.WriteLine((200*2) + (200*3) + (units-350)*5);
        
}
        
else if(units >500)
        
{
            
Console.WriteLine((200*2) + (200*3) + (200*5) + (units-500) * 7);   
        
}
    
}

}