using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistrationForm_D8_Task
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_btn_Click(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();
            list.Add("First Name: "+ Fname_txt.Text);
            list.Add("Last Name: " + Lname_txt.Text);
            list.Add("Age: " + Age_txt.Text);
            list.Add("Gender: " + RadioButtonList1.SelectedItem.Text);
            list.Add("Marital Status: " + RadioButtonList2.SelectedItem.Text);
            list.Add("Email ID: " + Email_txt.Text);
            list.Add("Pincode: " + Pinc_txt.Text);           
            FileStream fs = new FileStream("D:/Training/Task-D8(06-08-2021)/RegistrationForm.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            foreach (object det in list)
            {
                sw.Write(det.ToString() + "\n");
                Console.WriteLine(det);
            }
            sw.Flush();
            sw.Close();
            fs.Close();         
            Response.Redirect("Navigated.aspx");
        }
    }
}