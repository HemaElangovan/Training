using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task_D16
{
    public partial class Advertisements : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Amazon_lbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://www.amazon.com/");
        }

        protected void Fabmart_lbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://www.fabmart.com/");
        }
    }
}