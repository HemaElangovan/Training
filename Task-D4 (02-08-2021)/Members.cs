using System;

class Members
{
    public string Name;
    public int Age;
    public Members(string name, int age)
    {
      Name = name;
      Age = age;
    }
}
class MemberDetails
{
    string Mname;
    int Mage;
    public MemberDetails(string MemName, int MemAge)
    {
        Mname = MemName;
        Mage = MemAge;
    }
    public void Display()
    {
        Console.WriteLine($"Member Name : {Mname} and age is : {Mage}");
    }
    public static void Main()
    {
        Members m =new Members("Ross", 30);
        Console.WriteLine($"First member name is {m.Name}");
        Console.WriteLine($"First member age is {m.Age}");
        Console.WriteLine("First member name is " + m.Name + " & age is " + m.Age);
        MemberDetails md = new MemberDetails("Rachel", 24);
        Console.WriteLine($"Second member name is {md.Mname}");
        Console.WriteLine($"Second member age is {md.Mage}");
        md.Display();
        
    }
}
