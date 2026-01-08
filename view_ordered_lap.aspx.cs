using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LSS
{
    public partial class view_ordered_lap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["USERNAME"] != null)        //session
            {
                viewlap();
              
            }
            else
            {
                Response.Redirect("~/login.aspx");
            }
        }
        public void viewlap()               //datalist
        {
            mainclass cls = new mainclass();
            string cid = Session["cid"].ToString();
            DataList1.DataSource = cls.view_orderedlap(cid);
            DataList1.DataBind();
        }
    }
}