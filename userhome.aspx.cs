using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LSS
{
    public partial class userhome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            mainclass cls = new mainclass();

            if (Session["USERNAME"] != null)        //session
            {
                string a = Session["USERNAME"] as string;
                DataTable dt = new DataTable();
                dt = cls.getcustomerid(a);
           
                lblsuccess.ForeColor = Color.Green;
              Session["cid"]=  Request.Cookies["cid"].Value;
           
                lblsuccess.Text = "LOGIN SUCCESSFULLLL, welcome " + Session["USERNAME"] + Session["cid"].ToString();
            }
            
            else
            {
                Response.Redirect("~/login.aspx");
            }
            
        }
        protected void btn_signout_Click(object sender, EventArgs e)
        {
            Session["USERNAME"] = null;       //sesssion
            Response.Redirect("~/login.aspx");
        }
    }
}