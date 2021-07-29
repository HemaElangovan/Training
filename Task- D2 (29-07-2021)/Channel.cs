using System;


class Channel
{
    
public static void Main() 
    
{
      
string package;
      
Console.WriteLine("Enter your package");
      
package = Console.ReadLine();
     
switch(package)
     
{
         
case"PackageA" : Console.WriteLine("The rate for the selected TV Channel Package is Rs:250");
         
break;
         
case"PackageB" : Console.WriteLine("The rate for the selected TV Channel Package is Rs:450");
         
break;
         
case"PackageC" : Console.WriteLine("The rate for the selected TV Channel Package is Rs:350");
         
break;
         
default: Console.WriteLine("Please enter the selected TV Channel Package");
         
break;
     
}
      
    
}

}