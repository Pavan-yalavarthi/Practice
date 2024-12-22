using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment1_Asp
{
    public partial class Products_Dropdown : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Image1.ImageUrl = "";
                Label1.Text = " Product Price";
            }
        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProduct = DropDownList1.SelectedValue;
            switch (selectedProduct)
            {
                case "1":
                    Image1.ImageUrl = "images/mobile.jpg";
                    break;
                case "2":
                    Image1.ImageUrl = "images/tab.jpg";
                    break;
                case "3":
                    Image1.ImageUrl = "images/laptop.jpg";
                    break;
                default:
                    Image1.ImageUrl = "";
                    Label1.Text = "Please select a product";
                    break;
            }
        }
        protected void Button_Click(object sender, EventArgs e)
        {
            string selectedprod = DropDownList1.SelectedValue;
            string price = " ";
            switch (selectedprod)
            {
                case "1":
                    price = "1000 rupees";
                    break;
                case "2":
                    price = "2000 rupees";
                    break;
                case "3":
                    price = "3000 rupees";
                    break;
                default:
                    price = "Please select product";
                    break;

            }
            Label1.Text = "price:" + price;
        }
    }
}