using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace D9_Task
{
    public partial class GSRate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                GS_ddl.Items.Clear();
                GS_ddl.Items.Add("Gold");
                GS_ddl.Items.Add("Silver");
                GS_ddl.Items.Add("Diamond");
                GS_ddl.Items.Add("Platinum");
            }
            
        }
        protected void Btn_ViewRate_Click(object sender, EventArgs e)
        {

            string name = GS_ddl.SelectedValue.ToString();
            if (name == "Gold")
            {
                HiddenField1.Value = "1grm = 4500";
                Literal1.Text = HiddenField1.Value;
            }
            else if (name == "Silver")
            {
                HiddenField1.Value = "1grm = 70";
                Literal1.Text = HiddenField1.Value;
            }
            else if (name == "Diamond")
            {
                HiddenField1.Value = "1grm = 5100";
                Literal1.Text = HiddenField1.Value;
            }
            else if (name == "Platinum")
            {
                HiddenField1.Value = "1grm = 5500";
                Literal1.Text = HiddenField1.Value;
            }
        }
    }
}