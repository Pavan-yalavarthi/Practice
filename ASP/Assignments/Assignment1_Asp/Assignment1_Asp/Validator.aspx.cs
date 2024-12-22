using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment1_Asp
{
    public partial class Validator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Response.Write("<script>alert('Form Validate Successfully')</script>");
            }
            else
            {
                Response.Write("<script>alert('Correct the errors in the form')</script>");

            }
        }

        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}