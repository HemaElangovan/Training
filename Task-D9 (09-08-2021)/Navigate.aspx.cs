using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace D9_Task
{
    public partial class Navigate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Menu_ddl_Load(object sender, EventArgs e)
        {
            Menu_ddl.Items.Add("Break Fast");
            Menu_ddl.Items.Add("Lunch");
            Menu_ddl.Items.Add("Snacks");
            
        }
        protected void btn1_Submit_Click(object sender, EventArgs e)
        {
            Session["Menu"] = Menu_ddl.SelectedValue;
            Response.Redirect("Menu.aspx");

        }
    }
}