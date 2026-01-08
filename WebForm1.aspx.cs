using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LSS
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)                //repeater
            {
                getlapdata();
                bind1();            //dropdown
            }

        }
        public void getlapdata()               //repeater
        {
            mainclass cls = new mainclass();
            Repeater1.DataSource = cls.getdatalapdetail();
            Repeater1.DataBind();
        }
        protected void btn_addstock_Click(object sender, EventArgs e)           //repeater  adds 50 +qty
        {
            Button bt = new Button();
            bt = (Button)sender;
            mainclass cls = new mainclass();
            DataTable Dt = new DataTable();
            Dt = cls.getlaptopid(bt.CommandName);
            if (Dt.Rows.Count > 0)
            {

                lapdetail.CommandName = Dt.Rows[0]["lapid"].ToString();
            }
            cls.addstock(lapdetail.CommandName);
            getlapdata();

        }
        protected void btn_delete_Click(object sender, EventArgs e)           //repeater
        {
            Button bt = new Button();
            bt = (Button)sender;
            mainclass cls = new mainclass();
            DataTable Dt = new DataTable();
            Dt = cls.getlaptopid(bt.CommandName);
            if (Dt.Rows.Count > 0)
            {

                lapdetail.CommandName = Dt.Rows[0]["lapid"].ToString();
            }
            cls.dellaptop(lapdetail.CommandName);
            getlapdata();

        }

        protected void btn_edit_Click(object sender, EventArgs e)           //repeater
        {
            Button bt = new Button();
            bt = (Button)sender;
            mainclass cls = new mainclass();
            DataTable Dt = new DataTable();
            Dt = cls.getlaptopid(bt.CommandName);
            if (Dt.Rows.Count > 0)
            {
                txtbrand.Text = Dt.Rows[0]["brand"].ToString();
                txtmodelname.Text = Dt.Rows[0]["modelname"].ToString();
                txtmodelno.Text = Dt.Rows[0]["modelno"].ToString();
                Image1.ImageUrl = "data:image/png;base64," + Convert.ToBase64String((byte[])Dt.Rows[0]["img1"], 0, ((byte[])Dt.Rows[0]["img1"]).Length);        ///image
                Image2.ImageUrl = "data:image/png;base64," + Convert.ToBase64String((byte[])Dt.Rows[0]["img2"], 0, ((byte[])Dt.Rows[0]["img2"]).Length);
                Image3.ImageUrl = "data:image/png;base64," + Convert.ToBase64String((byte[])Dt.Rows[0]["img3"], 0, ((byte[])Dt.Rows[0]["img3"]).Length);
                txtprice.Text = Dt.Rows[0]["price"].ToString();
                txtqty.Text = Dt.Rows[0]["qty"].ToString();
                DropDowncategory.SelectedValue = Dt.Rows[0]["catid"].ToString();///dropdown

                txtmodelyr.Text = Dt.Rows[0]["modelyr"].ToString();
                txtprobrand.Text = Dt.Rows[0]["processor_brand"].ToString();
                txtproname.Text = Dt.Rows[0]["processor_name"].ToString();
                txtprospeed.Text = Dt.Rows[0]["processor_speed"].ToString();
                txtramtech.Text = Dt.Rows[0]["ram_tech"].ToString();
                txtramsize.Text = Dt.Rows[0]["ram_size"].ToString();
                txtos.Text = Dt.Rows[0]["os"].ToString();
                txtgraphicscard.Text = Dt.Rows[0]["graphicscard"].ToString();
                txtbattery.Text = Dt.Rows[0]["battery"].ToString();
                txtbatterylife.Text = Dt.Rows[0]["batterylife"].ToString();                
                lapdetail.CommandName = Dt.Rows[0]["lapid"].ToString();
            }
        }
        public void bind1()   // dropdown
        {
            mainclass m1 = new mainclass();
            DropDowncategory.DataSource = m1.getdatadept();
            DropDowncategory.DataTextField = "cat_type";
            DropDowncategory.DataValueField = "catid";
            DropDowncategory.DataBind();

        }
        protected void lapdetail_Click(object sender, EventArgs e)
        {

            byte[] imgByte = null;
            byte[] imgByte2 = null;
            byte[] imgByte3 = null;
            

            HttpPostedFile File = FileUpload1.PostedFile;
            if (File.ContentLength > 0)
            {
                imgByte = new Byte[File.ContentLength];
                File.InputStream.Read(imgByte, 0, File.ContentLength);
            }


            HttpPostedFile File2 = FileUpload2.PostedFile;
            if (File2.ContentLength > 0)
            {
                imgByte2 = new Byte[File2.ContentLength];
                File2.InputStream.Read(imgByte2, 0, File2.ContentLength);
            }

            HttpPostedFile File3 = FileUpload3.PostedFile;
            if (File3.ContentLength > 0)
            {
                imgByte3 = new Byte[File3.ContentLength];
                File3.InputStream.Read(imgByte3, 0, File3.ContentLength);
            }

           

            mainclass dj = new mainclass();


            if (lapdetail.CommandName == "")
                dj.ADD_LAPDETAIL(txtbrand.Text, txtmodelname.Text, txtmodelno.Text, imgByte, imgByte2, imgByte3, txtprice.Text, txtqty.Text, DropDowncategory.SelectedValue.ToString(), txtmodelyr.Text, txtprobrand.Text, txtproname.Text, txtprospeed.Text,txtramtech.Text, txtramsize.Text, txtos.Text, txtgraphicscard.Text, txtbattery.Text, txtbatterylife.Text);

            else
                dj.update_lapdetail(txtbrand.Text, txtmodelname.Text, txtmodelno.Text, imgByte, imgByte2, imgByte3, txtmodelyr.Text, txtprobrand.Text, txtproname.Text, txtprospeed.Text, txtramtech.Text, txtramsize.Text, txtos.Text, txtgraphicscard.Text, txtbattery.Text, txtbatterylife.Text, txtprice.Text, txtqty.Text, DropDowncategory.SelectedValue.ToString(), lapdetail.CommandName);

            txtbrand.Text = "";
            txtmodelname.Text = "";
            txtmodelno.Text = "";
            txtmodelyr.Text = "";
            txtprobrand.Text = "";
            txtproname.Text = "";
            txtprospeed.Text = "";
            txtramtech.Text = "";
            txtramsize.Text = "";
            txtos.Text = "";
            txtgraphicscard.Text = "";
            txtbattery.Text = "";
            txtbatterylife.Text = "";
            txtprice.Text = "";
            txtqty.Text = "";

            //  DropDowncategory.Text = "";

            lapdetail.CommandName = "";
            getlapdata();

        }


    }
}