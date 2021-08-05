using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistrationFormTask
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void State_ddl_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                State_ddl.Items.Add("Tamil Nadu");
                State_ddl.Items.Add("Kerala");
                State_ddl.Items.Add("Karnataka");
                State_ddl.Items.Add("Andra Pradesh");
                State_ddl.Items.Add("Delhi");
            }
        }
        protected void btn_Search_Click(object sender, EventArgs e)
        {          
            if(State_ddl.SelectedItem.Value == "Tamil Nadu")
            {
                City_lb.Items.Clear();
                City_lb.Items.Add("Chennai");
                City_lb.Items.Add("Trichy");
                City_lb.Items.Add("Coimbatore");
                City_lb.Items.Add("Ooty");
            }
            else if(State_ddl.SelectedItem.Value == "Kerala")
            {
                City_lb.Items.Clear();
                City_lb.Items.Add("Cochi");
                City_lb.Items.Add("Thiruvananthapuram");
                City_lb.Items.Add("Alleppey");
                City_lb.Items.Add("Ernakulam");
            }
            else if (State_ddl.SelectedItem.Value == "Karnataka")
            {
                City_lb.Items.Clear();
                City_lb.Items.Add("Bangalore");
                City_lb.Items.Add("Mysore");
                City_lb.Items.Add("Mangalore");
                City_lb.Items.Add("Udupi");
            }
            else if (State_ddl.SelectedItem.Value == "Andra Pradesh")
            {
                City_lb.Items.Clear();
                City_lb.Items.Add("Vishakapatnam");
                City_lb.Items.Add("Hyderabad");
                City_lb.Items.Add("Guntur");
                City_lb.Items.Add("Tirupati");
            }
            else if (State_ddl.SelectedItem.Value == "Delhi")
            {
                City_lb.Items.Clear();
                City_lb.Items.Add("Agra");
                City_lb.Items.Add("Noida");
                City_lb.Items.Add("Jaipur");
                City_lb.Items.Add("Faridabad");
            }
        }
        protected void btn_Submit_Click(object sender, EventArgs e)
        {
            Submit_lbl.Visible = true;
        }
    }
}