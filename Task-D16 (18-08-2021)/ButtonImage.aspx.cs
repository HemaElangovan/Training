using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task_D16
{
    public partial class ButtonImage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void imgbtn_Oval_Click(object sender, ImageClickEventArgs e)
        {
            imgbtn_Bottom.ImageUrl = "~/Images/oval.png";
        }

        protected void imgbtn_Rectangle_Click(object sender, ImageClickEventArgs e)
        {
            imgbtn_Bottom.ImageUrl = "~/Images/rectangle.png";
        }

        protected void imgbtn_Triangle_Click(object sender, ImageClickEventArgs e)
        {
            imgbtn_Bottom.ImageUrl = "~/Images/triangle.png";
        }

        protected void imgbtn_Bottom_Click(object sender, ImageClickEventArgs e)
        {
            imgbtn_Bottom.ImageUrl = "";
        }
    }
}