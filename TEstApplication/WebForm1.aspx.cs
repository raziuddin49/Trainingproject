﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Collections;


namespace TEstApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"]!= null)
                
            {
                string id = Request.QueryString["id"].ToString();// String requested to string data to put all the queries
                SqlConnection cnt = new SqlConnection("Data Source=.;Initial Catalog=db_practice; User id=sa; Password=2580;");
                string qry = "select u_id, fname,lname,gender,cityid from users where u_id ="+Convert.ToInt32(id)+"";
                DataTable dts = new DataTable();
                cnt.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter(qry, cnt);
                sqlda.Fill(dts);
                cnt.Close();
                if (dts != null)
                {
                    txtfname.Text = dts.Rows[0]["fname"].ToString();
                    txtlname.Text = dts.Rows[0]["lname"].ToString();
                   string gendervalue = dts.Rows[0]["gender"].ToString();
                    if (gendervalue == "Male")
                    {
                        txtgender.SelectedValue = "m";
                    }
                    else if (gendervalue == "Female")
                    {
                        txtgender.SelectedValue = "f";
                    }
                    ddlcity.SelectedValue = dts.Rows[0]["cityid"].ToString();
                }

               
            }
        

            fillgrid();
            // pastAjaz
        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            string fname = txtfname.Text;
            string lname = txtlname.Text;
            string gender = txtgender.SelectedItem.ToString();
            int cityid = Convert.ToInt32(ddlcity.SelectedValue);

            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=db_practice; User id=sa; Password=2580;");
            string query = "insert into users values('"+fname+"', '"+lname+"', '"+gender+"', '"+cityid+"')"; 
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            if (result > 0)
            { 
                lblmsg.Text = "data saved successfully";
                fillgrid();
            }
            else { lblmsg.Text = "error occurred"; }


            // Integrated Security = True; Encrypt = True; Trust Server Certificate = True

        }
        private void fillgrid()
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=db_practice; User id=sa; Password=2580;");
            string select_query = "select u_id, fname, lname, gender, cityid from users";
            DataTable dt = new DataTable();
            conn.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(select_query, conn);
            sqlDataAdapter.Fill(dt);
            conn.Close();
            grduser.DataSource = dt;
            grduser.DataBind();
        }
    }
}