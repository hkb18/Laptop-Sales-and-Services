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
    public partial class customer_reg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
       

        protected void registeration_Click(object sender, EventArgs e)
        {
            mainclass cls = new mainclass();
            if (txtname.Text != "" && txtaddr.Text != "" && txtphno.Text != "" && txtusername.Text != "" && txtpasswd.Text != "" && txtconfirmpasswd.Text != "")
            {
                if (txtpasswd.Text == txtconfirmpasswd.Text)
                {
                    if (registeration.CommandName == "")
                        cls.reg(txtname.Text, txtaddr.Text, txtphno.Text, txtusername.Text, txtpasswd.Text);
                    else
                        cls.updatereg(txtname.Text, txtaddr.Text, txtphno.Text, txtusername.Text, txtpasswd.Text, registeration.CommandName);


                    //txtname.Text = txtaddr.Text = txtphno.Text = txtusername.Text = txtpasswd.Text = "";
                    //registeration.CommandName = "";
                    //getdata();
                    lblmsg.ForeColor = Color.Green;
                    lblmsg.Text = "Registration successful ";
                    Response.Redirect("~/login.aspx");
                }
                else
                {

                    lblmsg.ForeColor = System.Drawing.Color.Red;
                    lblmsg.Text = "Password dont match";
                }
            }
            else
            {

                lblmsg.ForeColor = System.Drawing.Color.Red;
                lblmsg.Text = "All fields are mandatory ";
            }
        }
    }

}