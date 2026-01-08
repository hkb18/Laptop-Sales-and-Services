using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LSS
{
    public partial class view_fulldetail1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (Session["USERNAME"] != null )        //session
            {
                order_details();   
                //var cid = Session["cid"];
            }
            else
            {
                Response.Redirect("~/login.aspx");
            }
        }
        public void order_details()
        {
            
            Session["cid"] = Request.Cookies["cid"].Value;
            string cid = Session["cid"].ToString();
            mainclass cls = new mainclass();
            string str = Request.QueryString["lapid"].ToString();
            DataTable dt = new DataTable();
            dt = cls.order_details(str);
            if (dt.Rows.Count > 0)
            {
                Image1.ImageUrl = "data:image/png;base64," + Convert.ToBase64String((byte[])dt.Rows[0]["img1"], 0, ((byte[])dt.Rows[0]["img1"]).Length);
                name.Text = dt.Rows[0]["modelname"].ToString();
                price.Text = dt.Rows[0]["price"].ToString();
            }
        }
        public void calc_Click(object sender, EventArgs e)
        {
            Int32 unitprice = Int32.Parse(price.Text);
            Int32 unit = Int32.Parse(quantity.Text);
            Session["quantity"] = unit;
            Int32 total = unitprice * unit;
            Session["total"] = total;
            tot_amt.Text = total.ToString();
        }
      
        public void LinkButton1_Click(object sender, EventArgs e)
        {
            Session["cid"] = Request.Cookies["cid"].Value;
            string cid = Session["cid"].ToString();
            mainclass cls = new mainclass();
            
            string str = Request.QueryString["lapid"].ToString();
            DateTime CD = DateTime.Now;
            string total = Session["total"].ToString();
            string quantity = Session["quantity"].ToString();
            cls.Addtocart(str, CD, cid, total, quantity);
            Response.Redirect("~/viewcart.aspx"); //go to view cart
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {

        }
    }
}