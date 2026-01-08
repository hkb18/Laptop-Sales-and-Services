using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Xml.Linq;
using System.Configuration;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Web.UI.WebControls.WebParts;



namespace LSS
{
    public class mainclass:connection
    {

        //ADMIN DETAILS
        public void WebForm1(string admin_username, string admin_password)          
        {

            SqlCommand cmd = new SqlCommand("INSERT INTO admin1 (admin_username, admin_password)VALUES(@name1, @code1)", sqlcon);
            cmd.Parameters.AddWithValue("@name1", admin_username);
            cmd.Parameters.AddWithValue("@code1", admin_password);
            cmd.ExecuteNonQuery();
            sqlcon.Close();
        }

        //  CUSTOMER REGISTRATION
        public void reg(string name, string addr,string phno,string username,string passwd)         
        {

            SqlCommand cmd = new SqlCommand("INSERT INTO customer (cname, caddress,phno,username,password,usertype)VALUES(@name, @addr,@phno,@username,@password,'U')", sqlcon);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@addr", addr);
            cmd.Parameters.AddWithValue("@phno", phno);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", passwd);
            
            cmd.ExecuteNonQuery();
            sqlcon.Close();
        }

        //get value to repeater CUSTOMER REG
        internal DataTable getdatareg()                
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter("select * from customer", sqlcon);
            adpt.Fill(dt);
            sqlcon.Close();
            return dt;
        }

        //  CUSTOMER REG    display
        internal DataTable getdatcid(string id)                 
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter("select * from customer where cid=@id", sqlcon);
            adpt.SelectCommand.Parameters.AddWithValue("@id", id);
            adpt.Fill(dt);
            return dt;
        }

        //UPDATE code  CUSTOMER REG
        internal void updatereg(string name, string addr, string phno, string username, string passwd, string id)  
        {

           
                SqlCommand cmd = new SqlCommand("update customer set cname=@name, caddress=@addr,phno=@phno,username=@username,password=@password where cid=@id ", sqlcon);

                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@addr", addr);
                cmd.Parameters.AddWithValue("@phno", phno);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", passwd);
                
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                sqlcon.Close();
        }
            ///  elseif for passwd
            
        

        //service customer REQUESTING ADMIN
        public void service(string model ,string modelname,string serialno ,string reason, string cid, DateTime date)         
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO service (lap_model,lap_modelname,serialno,customer_reason,status,cid,c_date )VALUES(@model,@modelname,@serialno,@reason,1,@cid,@date)", sqlcon);
            cmd.Parameters.AddWithValue("@model",model );
            cmd.Parameters.AddWithValue("@modelname", modelname);
            cmd.Parameters.AddWithValue("@serialno", serialno);
            cmd.Parameters.AddWithValue("@reason", reason);
            cmd.Parameters.AddWithValue("@cid", cid);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.ExecuteNonQuery();
            sqlcon.Close();
        }

        internal DataTable order_details(string str)
        {

            DataTable dt = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter("select * from lap where lapid=@str", sqlcon);
            adpt.SelectCommand.Parameters.AddWithValue("@str", str);
            adpt.Fill(dt);
            return dt;
        }
        internal DataTable getcatidgaming()
        {

            DataTable dt = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter("select * from category where catid=1003", sqlcon);
           
            adpt.Fill(dt);
            return dt;
        }
        internal DataTable getcatidnotebook()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter("select * from category where catid=1004", sqlcon);
            adpt.Fill(dt);
            return dt;
        }
        internal DataTable getcatidbusiness()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter("select * from category where catid=1002", sqlcon);
            adpt.Fill(dt);
            return dt;
        }

        public void Addtocart(string str,DateTime date,string cid,string totamt, string qty)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO booking (lapid,quantity,bkdate,cid,bkstatus,shipping_date,delivery_date,totalprice)VALUES(@lapid,@qty,@date,@cid,'incart',0,0,@totamt)", sqlcon);
            cmd.Parameters.AddWithValue("@lapid", str);
            cmd.Parameters.AddWithValue("@qty", qty);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@cid", cid);
            cmd.Parameters.AddWithValue("@totamt", totamt);
           
            cmd.ExecuteNonQuery();
            sqlcon.Close();
        }

        // view cart
        internal DataTable viewcart(string cid)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter("SELECT * FROM booking b, lap l where b.lapid=l.lapid and bkstatus='incart' and cid=@id", sqlcon);
            adpt.SelectCommand.Parameters.AddWithValue("@id", cid);
            adpt.Fill(dt);
            return dt;
        }

        //sum in cart
        internal DataTable viewtotal(string cid)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter("SELECT sum(totalprice) FROM booking where bkstatus='incart' and cid=@id", sqlcon);
            adpt.SelectCommand.Parameters.AddWithValue("@id", cid);
            adpt.Fill(dt);
            return dt;
        }

        internal DataTable removefromcart(string bid)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter("update booking set bkstatus='removed' where bid=@id", sqlcon);
            adpt.SelectCommand.Parameters.AddWithValue("@id", bid);
            adpt.Fill(dt);
            return dt;
        }
        internal DataTable lappay(string bid)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter("update booking set bkstatus='payed' where cid='incart' and cid=@id", sqlcon);
            adpt.SelectCommand.Parameters.AddWithValue("@id", bid);
            adpt.Fill(dt);
            return dt;
        }
        internal DataTable adminacceptservice(string sid)
        {
            DataTable dt = new DataTable();        
            SqlDataAdapter adpt = new SqlDataAdapter("update service set status=2 where sid=@id", sqlcon);
            adpt.SelectCommand.Parameters.AddWithValue("@id", sid);
            adpt.Fill(dt);
            return dt;
        }

        internal DataTable adminrejectservice(string sid)
        {
            DataTable dt = new DataTable();       
            SqlDataAdapter adpt = new SqlDataAdapter("update service set status=3 where sid=@id", sqlcon);
            adpt.SelectCommand.Parameters.AddWithValue("@id", sid);
            adpt.Fill(dt);
            return dt;
        }



        //  Category details ADDING
        public void catergory(string catergory)                
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO category (cat_type)VALUES(@cat)", sqlcon);             
            cmd.Parameters.AddWithValue("@cat", catergory);
            cmd.ExecuteNonQuery();
            sqlcon.Close();
        }




       
        public void ADD_LAPDETAIL(string brand, string modelname, string modelno, byte[] imgbyte, byte[] imgbyte2, byte[] imgbyte3, string price, string qty, string catid, string modelyr , string processor_brand, string processor_name , string processor_speed, string ram_tech, string ram_size, string os, string graphicscard , string battery, string batterylife)
                                                                                                
        {
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO lap (brand, modelname, modelno, img1, img2, img3, price, qty, catid, status, modelyr, processor_brand, processor_name, processor_speed, ram_tech, ram_size , os, graphicscard, battery, batterylife)VALUES(@brand, @modelname, @modelno, @img1, @img2, @img3, @price, @qty, @catid,1, @modelyr, @processor_brand, @processor_name, @processor_speed, @ram_tech, @ram_size , @os, @graphicscard, @battery, @batterylife)", sqlcon);
                                                                                                   
                cmd.Parameters.AddWithValue("@brand", brand);
                cmd.Parameters.AddWithValue("@modelname", modelname);
                cmd.Parameters.AddWithValue("@modelno", modelno);
                cmd.Parameters.AddWithValue("@img1", imgbyte);
                cmd.Parameters.AddWithValue("@img2", imgbyte2);
                cmd.Parameters.AddWithValue("@img3", imgbyte3);
                cmd.Parameters.AddWithValue("@modelyr", modelyr);
                cmd.Parameters.AddWithValue("@processor_brand", processor_brand);
                cmd.Parameters.AddWithValue("@processor_name", processor_name);
                cmd.Parameters.AddWithValue("@processor_speed", processor_speed);
                cmd.Parameters.AddWithValue("@ram_tech", ram_tech);
                cmd.Parameters.AddWithValue("@ram_size", ram_size);
                cmd.Parameters.AddWithValue("@os", os);
                cmd.Parameters.AddWithValue("@graphicscard", graphicscard);
                cmd.Parameters.AddWithValue("@battery", battery);
                cmd.Parameters.AddWithValue("@batterylife", batterylife);
                cmd.Parameters.AddWithValue("@price", price);

                cmd.Parameters.AddWithValue("@qty", qty);
                cmd.Parameters.AddWithValue("@catid", catid);


                cmd.ExecuteNonQuery();
                sqlcon.Close();
            }
            catch (Exception e) {
                throw e;
            }
        }

      



        public void update_lapdetail(string brand, string modelname, string modelno, byte[] imgbyte, byte[] imgbyte2, byte[] imgbyte3, string modelyr, string processor_brand, string processor_name, string processor_speed, string ram_tech, string ram_size, string os, string graphicscard, string battery, string batterylife, string price, string qty, string catid, string id)             
        {
            if (imgbyte != null || imgbyte2 != null || imgbyte3 != null)
            {
                SqlCommand cmd = new SqlCommand("UPDATE lap SET brand=@brand, modelname=@modelname , img1=@img1 ,img2=@img2 ,img3=@img3 ,modelno=@modelno, modelyr=@modelyr , battery=@battery , ram_size=@ram_size , ram_tech=@ram_tech , os=@os, processor_brand=@processor_band , processor_speed=@processor_speed , processor_name=@processor_name , batterylife=@batterylife , graphicscard=@graphicscard , price=@price, qty=@qty, catid=@catid ,status=1 where lapid=@lapid", sqlcon);
                cmd.Parameters.AddWithValue("@brand", brand);
                cmd.Parameters.AddWithValue("@modelname", modelname);
                cmd.Parameters.AddWithValue("@modelno", modelno);
                cmd.Parameters.AddWithValue("@img1", imgbyte);
                cmd.Parameters.AddWithValue("@img2", imgbyte2);
                cmd.Parameters.AddWithValue("@img3", imgbyte3);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@qty", qty);
                cmd.Parameters.AddWithValue("@catid", catid);
                cmd.Parameters.AddWithValue("@modelyr", modelyr);
                cmd.Parameters.AddWithValue("@processor_band", processor_brand);
                cmd.Parameters.AddWithValue("@processor_speed", processor_speed);
                cmd.Parameters.AddWithValue("@processor_name", processor_name);
                cmd.Parameters.AddWithValue("@ram_size", ram_size);
                cmd.Parameters.AddWithValue("@ram_tech", ram_tech);
                cmd.Parameters.AddWithValue("@os", os);
                cmd.Parameters.AddWithValue("@graphicscard", graphicscard);
                cmd.Parameters.AddWithValue("@battery", battery);
                cmd.Parameters.AddWithValue("@batterylife", batterylife);
                cmd.Parameters.AddWithValue("@lapid", id);
                cmd.ExecuteNonQuery();
                sqlcon.Close();
            }
            else
            {
                SqlCommand cmd = new SqlCommand("UPDATE lap SET brand=@brand, modelname=@modelname ,modelno=@modelno, modelyr=@modelyr , battery=@battery , ram_size=@ram_size , ram_tech=@ram_tech , os=@os, processor_brand=@processor_band , processor_speed=@processor_speed , processor_name=@processor_name , batterylife=@batterylife , graphicscard=@graphicscard , price=@price, qty=@qty, catid=@catid ,status=1 where lapid=@lapid", sqlcon);
                cmd.Parameters.AddWithValue("@brand", brand);
                cmd.Parameters.AddWithValue("@modelname", modelname);
                cmd.Parameters.AddWithValue("@modelno", modelno);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@qty", qty);
                cmd.Parameters.AddWithValue("@catid", catid);
                cmd.Parameters.AddWithValue("@modelyr", modelyr);
                cmd.Parameters.AddWithValue("@processor_band", processor_brand);
                cmd.Parameters.AddWithValue("@processor_speed", processor_speed);
                cmd.Parameters.AddWithValue("@processor_name", processor_name);
                cmd.Parameters.AddWithValue("@ram_size", ram_size);
                cmd.Parameters.AddWithValue("@ram_tech", ram_tech);
                cmd.Parameters.AddWithValue("@os", os);
                cmd.Parameters.AddWithValue("@graphicscard", graphicscard);
                cmd.Parameters.AddWithValue("@battery", battery);
                cmd.Parameters.AddWithValue("@batterylife", batterylife);
                cmd.Parameters.AddWithValue("@lapid", id);
                cmd.ExecuteNonQuery();
                sqlcon.Close();
            }
        }



        //add_laptop    delete laptop
        internal void dellaptop(string id)
        {
            SqlCommand cmd = new SqlCommand("update lap set status=2 where lapid=@id", sqlcon);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            sqlcon.Close();
        }

        //add laptop     add stock
        internal void addstock(string id)
        {
            SqlCommand cmd = new SqlCommand("update lap set qty=qty+50 where lapid=@id", sqlcon);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            sqlcon.Close();
        }

        //get value to repeater laptop details
        internal DataTable getdatalapdetail()                ///edited
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter("select * from lap l,category c where l.catid = c.catid and status=1", sqlcon);
            adpt.Fill(dt);
            sqlcon.Close();
            return dt;
        }

        //  laptop details    display
        internal DataTable getlaptopid(string id)                 
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter("select * from lap where lapid=@id", sqlcon);
            adpt.SelectCommand.Parameters.AddWithValue("@id", id);
            adpt.Fill(dt);
            return dt;
        }

   
        internal DataTable getuserid(string id)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter("select * from customer where cid=@id", sqlcon);
            adpt.SelectCommand.Parameters.AddWithValue("@id", id);
            adpt.Fill(dt);
            return dt;
        }
        internal DataTable view_orderedlap(string catid)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter("select * from lap l,booking b where l.lapid = b.lapid and bkstatus='payed'", sqlcon);
            adpt.SelectCommand.Parameters.AddWithValue("@str", catid);
            adpt.Fill(dt);
            return dt;
        }
        internal DataTable getcustomerid(string id)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter("select cid from customer where username=@id", sqlcon);
            adpt.SelectCommand.Parameters.AddWithValue("@id", id);
            adpt.Fill(dt);
            return dt;
        }

        // dropdown
        public DataTable getdatadept()              
        {

            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                Adpt = new SqlDataAdapter("select * from category", sqlcon);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                dt.Rows.InsertAt(dt.NewRow(), 0);
                dt.Rows[0]["catid"] = 0;
                dt.Rows[0]["cat_type"] = "Select";
                return dt;

            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }
        }
        //ADMIN VIEW SERVICE REQ
        internal DataTable viewservicereq()         
        {

            DataTable dt = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter("select * from service where status=1", sqlcon);
            adpt.Fill(dt);
            sqlcon.Close();
            return dt;
        }
        internal DataTable viewlap()        //join query
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter("select * from lap l,category c where l.catid = c.catid and status=1 and qty>0", sqlcon);
            adpt.Fill(dt);
            return dt;
        }

        internal DataTable viewlapbycat(string str)        //join query
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter("select * from lap l,category c where l.catid = c.catid and l.catid=@str and status=1 and qty>0", sqlcon);
            adpt.SelectCommand.Parameters.AddWithValue("@str", str);
            adpt.Fill(dt);
            return dt;
        }
        internal DataTable totalsum(string str)
        {

            DataTable dt = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter("select sum(totalprice) as total from booking where cid=@str and bkstatus='incart'", sqlcon);
            adpt.SelectCommand.Parameters.AddWithValue("@str", str);

           
            adpt.Fill(dt);
            return dt;
        }

        internal DataTable viewlapfull(string str)      //view full lap vdetail
        {
            DataTable dt = new DataTable();
              SqlDataAdapter adpt = new SqlDataAdapter("select * from lap l,category c where l.catid = c.catid and status=1 and lapid=@str", sqlcon);
            adpt.SelectCommand.Parameters.AddWithValue("@str", str);
            adpt.Fill(dt);
            return dt;
        }

    }
}