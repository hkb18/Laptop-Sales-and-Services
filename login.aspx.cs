using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LSS
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Cookies["USRNAME"] != null && Request.Cookies["PASSWD"] != null)
                {
                    txtusername.Text = Request.Cookies["USRNAME"].Value;
                    txtpasswd.Attributes["value"] = Request.Cookies["PASSWD"].Value;
                    CheckBox1.Checked = true;
                }
            }
        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            mainclass cls=new mainclass();
            
                SqlCommand cmd = new SqlCommand("select * from customer where username='" + txtusername.Text + "' and password='" + txtpasswd.Text + "'", cls.sqlcon);
               
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count != 0)
                {
                    if (CheckBox1.Checked)              //remember me
                    {
                        Response.Cookies["USRNAME"].Value = txtusername.Text;
                        Response.Cookies["PASSWD"].Value = txtpasswd.Text;

                        Response.Cookies["USRNAME"].Expires = DateTime.Now.AddDays(15);     ///expire after 15 days
                        Response.Cookies["PASSWD"].Expires = DateTime.Now.AddDays(15);


                    }
                    else
                    {
                        Response.Cookies["USRNAME"].Expires = DateTime.Now.AddDays(-1);     ///doesnt want to store
                        Response.Cookies["PASSWD"].Expires = DateTime.Now.AddDays(-1);
                    }

                Button bt = new Button();
               
                string id = dt.Rows[0]["cid"].ToString();

                string usertype;
                    usertype = dt.Rows[0][6].ToString().Trim();

                    if (usertype == "U")
                    {
                   
                    
                    Session["USERNAME"] = txtusername.Text;         //session
                    Response.Cookies["cid"].Value = id; //cookies ilu id pass cheythu
                    Response.Redirect("~/userhome.aspx?cid="+id);
                        lblerror.Text = "USER";
                    
                }
                    if (usertype == "A")
                    {
                    

                    Session["USERNAME"] = txtusername.Text;         //session
                        Response.Redirect("~/WebForm1.aspx?cid="+id); 
                        lblerror.Text = "ADMIN";
                    }
                }
                else
                {
                    lblerror.Text = "Invalid username or password";

                }
        

        }
    }
}