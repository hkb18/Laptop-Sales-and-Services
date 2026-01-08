using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LSS
{
    public partial class view_req_service : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            viewservicereq();
        }
        public void viewservicereq()               //datalist
        {
            mainclass cls = new mainclass();
            DataList1.DataSource = cls.viewservicereq();
            DataList1.DataBind();
        }

        protected void LinkButton1_Click(object sender, EventArgs e) // accept
        {
            mainclass cls = new mainclass();
            string sid = ((LinkButton)(sender)).CommandArgument.ToString();
            cls.adminacceptservice(sid);
            //Response.Redirect("~/view_req_service.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)  //reject
        {
            mainclass cls = new mainclass();
            string sid = ((LinkButton)(sender)).CommandArgument.ToString();
            cls.adminrejectservice(sid);
            Response.Redirect("~/view_req_service.aspx");
        }
    }
}