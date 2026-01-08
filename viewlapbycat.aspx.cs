using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LSS
{
    public partial class viewlapbycat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["USERNAME"] != null)        //session
            //{

                viewlap_bycat();
            //}
            //else
            //{
            //    Response.Redirect("~/login.aspx");
            //}
        }
        public void viewlap_bycat()               //datalist
        {
            mainclass cls = new mainclass();
            string str = Request.QueryString["catid"].ToString();
            DataList1.DataSource = cls.viewlapbycat(str);
            DataList1.DataBind();
        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            string str = ((LinkButton)(sender)).CommandArgument.ToString();
            Response.Redirect("~/View_fulldetail1.aspx?lapid=" + str); //go to view page  
        }
    }
}