using System;



class UserLogin

{

public void Option(string EmailID, string Password)

{

Console.WriteLine("The mail.id is " + EmailID);

Console.WriteLine("The password is " + Password);

}

public void Option(string MembershipID, int Pin)
{


Console.WriteLine("The MembershipID is " + MembershipID);

Console.WriteLine("The  Pin is " + Pin);

}

public void Option(int MobileNumber, int Pin)

{

Console.WriteLine("The MobileNumber is " + MobileNumber);

Console.WriteLine("The Pin is " + Pin);

}

public static void Main()

{

UserLogin ul = new UserLogin();

Console.WriteLine("Enter EmailId & Password");

string opt = (Console.ReadLine());

if(opt == "hema@gmail.com" )

{

ul.Option("hema@gmail.com","H@238");

}

else

{
    
Console.WriteLine("Invalid mail id");

}

Console.WriteLine("Enter MembershipId & Pin");

string opt1 = (Console.ReadLine());

if(opt1 == "AA12")

{

ul.Option("AA12",6655);

}

else

{
    
Console.WriteLine("Invalid MembershipId");

}

Console.WriteLine("Enter MobileNumber & Pin");

int opt2 = Convert.ToInt32(Console.ReadLine());

if(opt2 == Convert.ToInt32(98745612))

{

ul.Option(98745612,4455);

}

else

{
    
Console.WriteLine("Invalid MobileNumber");

}

}


}