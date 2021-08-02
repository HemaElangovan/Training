using System;



class AddSub

{
    
int n1 = 10;
    
int n2 = 20;
    
public void Add()
    
{
        
Console.WriteLine("The addition of two numbers is " + (n1+n2));
    
}
    
public void Subtract()
    
{
      
Console.WriteLine("The subtraction of two numbers is "+ (n2-n1));
    
}

}

class MultiDivide
{
    
int x = 2;
    
int y = 4;
    
public void Multiplication()
    
{
        
Console.WriteLine("The multiplication of two numbers is " + x*y);
    
}
    
public void Division()
    
{
        
Console.WriteLine("The division of two numbers is " + y/x);
    
}

}

class ImplementClass

{
    
public static void Main()
    
{
        
AddSub addsub = new AddSub();
        
addsub.Add();
        
addsub.Subtract();
        
MultiDivide md = new MultiDivide();
        
md.Multiplication();
        
md.Division();
    
}

}