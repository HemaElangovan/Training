using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task_D16
{
    public partial class Feedback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           if(!Page.IsPostBack)
            {
                Scourse_ddl.Items.Add("C,C++,Java");
                Scourse_ddl.Items.Add("Dot Net");
                Scourse_ddl.Items.Add("Python");
                Scourse_ddl.Items.Add("Full Stack developer");
                Scourse_ddl.Items.Add("Devops");
            }
     

        }

        protected void btn_Submit_Click(object sender, EventArgs e)
        {
            Msg_lbl.Visible = true;
            Msg_lbl.Text = "Thanks " + Sname_txt.Text+ " for your feedback.";
        }
    }
}