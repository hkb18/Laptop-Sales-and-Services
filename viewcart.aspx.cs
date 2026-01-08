using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LSS
{
    public partial class viewcart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["USERNAME"] != null)        //session
            {
               
                viewlap();
                total_sum();
            }
            else
            {
                Response.Redirect("~/login.aspx");
            }
        }
        public void viewlap()               //datalist
        {
            mainclass cls = new mainclass();
        //    string str = Request.QueryString["lapid"].ToString();
            string cid = Session["cid"].ToString();
            DataList1.DataSource = cls.viewcart(cid);
            DataList1.DataBind();
        }
        protected void btn_buy_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/payment.aspx");

        }

        public void total_sum()           //datalist
        {
            mainclass cls = new mainclass();
            string cid = Session["cid"].ToString();
            DataTable dt = new DataTable();
            dt= cls.totalsum(cid);
            if(dt.Rows.Count > 0)
            {
                Session["total"] = dt.Rows[0]["total"];
                //Label7.Text= dt.Rows[0]["total"].ToString();
                Label7.Text = Session["total"].ToString();
                string total = Session["total"].ToString();
            }
           // Response.Redirect("~/payment.aspx");

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        { 
            mainclass cls = new mainclass();           
            string str = ((LinkButton)(sender)).CommandArgument.ToString();            
            string cid = Session["cid"].ToString();
            cls.removefromcart(str);
            Response.Redirect("~/userhome.aspx");
        }



       


    }
}