using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
namespace ShopManagement
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCeConnection con = new SqlCeConnection(@"Data Source=C:\Users\Abrar Abir\Documents\Visual Studio 2010\Projects\ShopManagement\ShopManagement\Database1.sdf");
            SqlCeDataAdapter sda = new SqlCeDataAdapter("select count(*) from LogIn where Name='" + loginName.Text + "' and Pass='" + loginPass.Text + "'",con);
            DataTable dt =new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {

                MessageBox.Show("Log in Succesfull");
                this.Hide();
                UI u = new UI();
                u.Show();
                
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }
    }
}
