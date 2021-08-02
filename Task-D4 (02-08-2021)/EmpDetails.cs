using System;

class EmployeeDetails
{
   
    public int EmployeeID;
    public string Name;
   public string Gender;
   public int YearsOfExperience;
   public int Salary;
     public EmployeeDetails(int Eid, string name, string gender, int exp, int salary)
     {
         EmployeeID = Eid;
         Name = name;
         Gender = gender;
         YearsOfExperience = exp;
         Salary = salary;
     }
}
class EmpDepartment
{
    string Department;
    public EmployeeDetails EmpDet;
    public EmpDepartment(string dept, EmployeeDetails ed )
    {
        Department = dept;
        EmpDet = ed;
    }
    public static void Main()
    {
        EmployeeDetails edet = new EmployeeDetails(01,"Ross","Male",05,50000);
        EmpDepartment edept = new EmpDepartment("Production", edet);
        Console.WriteLine($"EmployeeID is {edet.EmployeeID}.");
        Console.WriteLine($"Employee name is {edet.Name}.");
        Console.WriteLine($"Employee gender is {edet.Gender}.");
        Console.WriteLine($"Employee experience is {edet.YearsOfExperience}.");
        Console.WriteLine($"Employee salary is {edet.Salary}.");
        Console.WriteLine($"Employee belongs to {edept.Department} department.");
        if(edept.Department == "Sales")
        {
           double Bonus= ((20.0/100) * edet.Salary) ;
           Console.WriteLine($"The bonus amount is " + Bonus);
        }
        else if (edept.Department == "Marketing")
        {
             double Bonus= ((20.0/100) * edet.Salary) ;
           Console.WriteLine($"The bonus amount is " + Bonus);
        }
        else if (edept.Department == "Production")
        {
            double Bonus= ((10.0/100) * edet.Salary) ;
           Console.WriteLine($"The bonus amount is " + Bonus);
        }
    }
}