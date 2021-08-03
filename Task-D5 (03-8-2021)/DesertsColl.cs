using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask5
{
    class DesertsColl
    {
            static void Main()
            {
                ArrayList list = new ArrayList();
                list.Add("White chocolate cake");
                list.Add("Royal red velvet cake");
                list.Add("Lemon Souffles");
                list.Add("Chocolate mousse");
                list.Add("Custard pudding");
                FileStream fs = new FileStream("D:/Training/Task- D5(03-08-2021)/desert.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                StreamWriter sw = new StreamWriter(fs);
                foreach (string s in list)
                {
                    sw.Write(s + "\n");
                }
                sw.Flush(); // Releases memory from RAM
            sw.Close();
            fs.Close();
            FileInfo f1 = new FileInfo("D:/Training/Task- D5(03-08-2021)/desert.txt");
            Console.WriteLine("The creation time of the file is " + f1.CreationTime +".");
            Console.WriteLine("The length of the file is " + f1.Length + ".");
            Console.ReadLine();

        }
    }
}
