using System;


class TaxCalculation

{
    
public virtual void calculateTax()
    
{
     
int value = 50000;
     
double vat = ((20.00/100)*value);
     
Console.WriteLine("The VAT value is " + vat);
    
}

}

class Tax : TaxCalculation

{
    
public override void calculateTax()
    
{
        
int val = 70000;
        
double gst = ((12.00/100)*val);
        
Console.WriteLine("The GST value is " + gst);
    
}
    
public static void Main()
    
{
        
Tax t = new Tax();
        
t.calculateTax();
    
}

}