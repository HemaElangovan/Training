using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task_D16
{
    public partial class WebControls : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Clickme_btn_Click(object sender, EventArgs e)
        {          
            Clickme_lbl.Text = "Welcome To Radiant";
            
        }
        private void OnMouseEnterButton1(object sender, EventArgs e)
        {
            Clickme_lbl.BackColor = Color.Yellow;
        }
    }
}