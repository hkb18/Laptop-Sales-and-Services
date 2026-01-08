using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LSS
{
    public partial class category : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void category_btn_Click(object sender, EventArgs e)
        {
            mainclass dj = new mainclass();
            dj.catergory(txtcategory.Text);
        }
    }
}