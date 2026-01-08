using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LSS
{
    public partial class Viewlapdetail : System.Web.UI.Page
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
            DataList1.DataSource = cls.viewlap();
            DataList1.DataBind();        
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            string str= ((LinkButton)(sender)).CommandArgument.ToString();
            Response.Redirect("~/View_fulldetail1.aspx?lapid="+str); //go to view page  
        }
       
    }
}