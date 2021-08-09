using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace D9_Task
{
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Session["Menu"].ToString();
            if (name == "Break Fast")
            {
                Menu_lb1.Items.Add("Idli");
                Menu_lb1.Items.Add("Dosa");
                Menu_lb1.Items.Add("Chapathi");
                Menu_lb1.Items.Add("Poori");
                Menu_lb1.Items.Add("Pongal");
            }
            else if (name == "Lunch")
            {
                Menu_lb1.Items.Add("Fried Rice");
                Menu_lb1.Items.Add("Meals");
                Menu_lb1.Items.Add("Veg Biryani");
                Menu_lb1.Items.Add("Mushroom Biryani");
                Menu_lb1.Items.Add("Variety Rice");
            }
            else if (name == "Snacks")
            {
                Menu_lb1.Items.Add("Puffs");
                Menu_lb1.Items.Add("Samosa");
                Menu_lb1.Items.Add("Chaat");
                Menu_lb1.Items.Add("Sweets");
                Menu_lb1.Items.Add("Shakes");
            }


        }

        protected void Btn_Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("Navigate.aspx");
        }
    }
}