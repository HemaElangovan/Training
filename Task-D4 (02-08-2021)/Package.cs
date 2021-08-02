using System;

interface Packages
{
    void Silver();
    void Gold();
    void Platinum();
}
class MembershipPackage : Packages
{
    public void Silver()
    {
        Console.WriteLine("You have selected Silver package.");
        Console.WriteLine("3 days accomodation at resort");
    }
    public void Gold()
    {
        Console.WriteLine("You have selected Gold package.");
        Console.WriteLine("5 days accomodation at resort & 2 dinners on the house ");
    }
    public void Platinum()
    {
        Console.WriteLine("You have selected Platinum package.");
        Console.WriteLine("7 days accomodation at resort & 5 dinners on the house");
    }
}
class interfaceMain
{
    public static void Main()
    {
        MembershipPackage msp = new MembershipPackage();
        Console.WriteLine("Enter your package");
        string pck = Console.ReadLine();
        if(pck == "Silver")
        {
        msp.Silver();
        }
        else if (pck == "Gold")
        {
        msp.Gold();
        }
        else if (pck == "Platinum")
        {
        msp.Platinum();
        }
    }
}
 
