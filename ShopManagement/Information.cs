using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ShopManagement
{
    public partial class Information : Form
    {
        SqlCeConnection con = new SqlCeConnection(@"Data Source=C:\Users\Abrar Abir\documents\visual studio 2010\Projects\ShopManagement\ShopManagement\Database1.sdf");
        public Information()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void displayTopProduct()
        {
            try
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand("select ProductID ,sum(SellQuantity) as Quantity from Sell group by ProductID order by Quantity desc  ", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                da.Fill(dt);
                gvTopProd.DataSource = dt;
                con.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Infomation Not saved");
            }


        }

        private void Information_Load(object sender, EventArgs e)
        {
            displayTopProduct();
            displayMember();
            displayTopBuyer();
            displayMonth();
            displayM();
            displayweek();
            displayTopsup();
        }

        public void displayMember()
        {
            try
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand("select MemberID ,count(MemberID) as Visits from Sell group by MemberID order by Visits desc  ", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                da.Fill(dt);
                gvTopMember.DataSource = dt;
                con.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Infomation Not saved");
            }


        }
        public void displayTopBuyer()
        {
            try
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand("select  MemberID,sum(Price) as Amount from Sell group by MemberID order by Amount desc  ", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                da.Fill(dt);
                gvTopBuyer.DataSource = dt;
                con.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Infomation Not saved");
            }

        }

        public void displayMonth()
        {
            try
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand("select  datepart(m,SellDate) as Month,sum(Price) as Income from Sell group by datepart(m,SellDate) order by Income desc ", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                da.Fill(dt);
                gvMonth.DataSource = dt;
                con.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Infomation Not saved");
            }

        }

        public void displayM()
        {
            try
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand("select  datepart(yy,SellDate) as Year,sum(Price) as Income from Sell group by datepart(yy,SellDate) order by Income desc ", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                da.Fill(dt);
                gvDaily.DataSource = dt;
                con.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Infomation Not saved");
            }


        }

        public void displayweek()
        {
            try
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand("select  datepart(ww,SellDate) as Week,sum(Price) as Income from Sell group by datepart(ww,SellDate) order by Income desc ", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                da.Fill(dt);
                gvWeekly.DataSource = dt;
                con.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Infomation Not saved");
            }


        }

        public void displayTopsup()
        {
            try
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand("select  SupplierID,Count(ProductID) as Supplies from Stock group by SupplierID order by Supplies desc ", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                da.Fill(dt);
                gvSuplier.DataSource = dt;
                con.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Infomation Not saved");
            }

        }

        
    }
}
