using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask5
{
    [Serializable]
    class Employee
    {
        int EmpID;
        string Name;
        string Gender;
        int Age;
        public Employee(int id, string name, string gender, int age)
        {
            EmpID = id;
            Name = name;
            Gender = gender;
            Age = age;
        }
        public static void Main()
        {
            Employee emp = new Employee(1010, "Jenifer", "Female", 12);
            FileStream fs = new FileStream("D:/Training/Task- D5(03-08-2021)/EmployeeData.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, emp);
            fs.Close();
        
            FileStream fs1 = new FileStream("D:/Training/Task- D5(03-08-2021)/EmployeeData.txt", FileMode.Open, FileAccess.Read);           
            Employee e = (Employee)bf.Deserialize(fs1);
            Console.WriteLine(e.EmpID);
            Console.WriteLine(e.Name);
            Console.WriteLine(e.Gender);
            Console.WriteLine(e.Age);
            Console.Read();
        }
    }
}
