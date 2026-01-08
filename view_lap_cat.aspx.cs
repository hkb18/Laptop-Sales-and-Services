using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace LSS
{
    public partial class view_lap_cat1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GAMING_Click(object sender, EventArgs e)
        {
            mainclass cls = new mainclass();
            DataTable dt = new DataTable();
            dt = cls.getcatidgaming();
            if (dt.Rows.Count > 0)
            {

                GAMING.CommandArgument = dt.Rows[0]["catid"].ToString();
            }
            string str = ((LinkButton)(sender)).CommandArgument.ToString();
            Response.Redirect("~/viewlapbycat.aspx?catid=" +str);
        }

        protected void NOTEBOOK_Click(object sender, EventArgs e)
        {
            mainclass cls = new mainclass();
            DataTable dt = new DataTable();
            dt = cls.getcatidnotebook();
            if (dt.Rows.Count > 0)
            {

                NOTEBOOK.CommandArgument = dt.Rows[0]["catid"].ToString();
            }
            string str = ((LinkButton)(sender)).CommandArgument.ToString();
            Response.Redirect("~/viewlapbycat.aspx?catid=" + str);
        }

        protected void BUSINESS_Click(object sender, EventArgs e)
        {
            mainclass cls = new mainclass();
            DataTable dt = new DataTable();
            dt = cls.getcatidbusiness();
            if (dt.Rows.Count > 0)
            {

                BUSINESS.CommandArgument = dt.Rows[0]["catid"].ToString();
            }
            string str = ((LinkButton)(sender)).CommandArgument.ToString();
            Response.Redirect("~/viewlapbycat.aspx?catid=" + str);
        }
    }
}