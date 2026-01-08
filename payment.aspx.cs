using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LSS
{
    public partial class payment1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["USERNAME"] != null)        //session
            {
                Label1.Text = Session["total"].ToString();
                //string cid = Session["cid"].ToString();
                //mainclass cls = new mainclass();
                //cls.lappay(cid);
            }
            else
            {
                Response.Redirect("~/login.aspx");
            }
           
        }

        protected void btn_submit_Click(object sender, EventArgs e)
        {
            string cid = Session["cid"].ToString();
            mainclass cls = new mainclass();
            cls.lappay(cid);
            Response.Redirect("~/view_ordered_lap.aspx");
        }
    }
}