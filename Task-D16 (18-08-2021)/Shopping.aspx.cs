using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task_D16
{
    public partial class Shopping : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Groceries_lb1_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Cost_lbl2.Visible = true;
            if (Groceries_lb1.SelectedItem.Value == "Hand Wash")
            {
                img_hw.Visible = true;
                img_san.Visible = false;
                img_pasta.Visible = false;
                img_rice.Visible = false; 
                Cost_lbl.Text = "65" ;
            }
            else if (Groceries_lb1.SelectedItem.Value == "Sanitizer")
            {
                img_hw.Visible = false;
                img_san.Visible = true;
                img_pasta.Visible = false;
                img_rice.Visible = false;
                Cost_lbl.Text = "45";
            }
            else if (Groceries_lb1.SelectedItem.Value == "Pasta")
            {
                img_hw.Visible = false;
                img_san.Visible = false;
                img_pasta.Visible = true;
                img_rice.Visible = false;
                Cost_lbl.Text = "45";
            }
            else if (Groceries_lb1.SelectedItem.Value == "Rice")
            {
                img_hw.Visible = false;
                img_san.Visible = false;
                img_pasta.Visible = false;
                img_rice.Visible = true;
                Cost_lbl.Text = "55";
            }
        }
        protected void btn_TotPrice_Click(object sender, EventArgs e)
        {
            TotPrice_lbl.Visible = true;
            int cost =  Convert.ToInt32(Cost_lbl.Text);
            int qtn = Convert.ToInt32(qtn_txt.Text);
            int total = cost * qtn;
            TotPrice_lbl.Text = "Total Cost is " + total.ToString();
        }
    }
}