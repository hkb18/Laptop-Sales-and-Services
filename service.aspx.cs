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
    public partial class service : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            mainclass cls = new mainclass();
            if (Session["USERNAME"] != null)        //session
            {
                string a = Session["USERNAME"] as string;
                DataTable dt = new DataTable();
                dt = cls.getcustomerid(a);
              
               
                Session["cid"] = Request.Cookies["cid"].Value;
 
                
            }

            else
            {
                Response.Redirect("~/login.aspx");
            }

        }

        protected void c_service_Click(object sender, EventArgs e)
        {
            mainclass cls = new mainclass();
            Session["cid"] = Request.Cookies["cid"].Value;
            DateTime CD = DateTime.Now;
            string cid = Session["cid"].ToString();
          //  var DateAsString = DateTime.Now.ToString("yyyy-mm-dd");
            cls.service(txtmodel.Text,txtmodelname.Text,txtserialno.Text,txtreason.Text, cid,CD);
        }
    }
}