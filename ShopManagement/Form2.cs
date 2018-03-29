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
    public partial class Form2 : Form
    {
        SqlCeConnection con = new SqlCeConnection(@"Data Source=C:\Users\Abrar Abir\documents\visual studio 2010\Projects\ShopManagement\ShopManagement\Database1.sdf");
        String MemberRow;
        String DeptRow;
        String EmpRow;
        public Form2()
        {
            InitializeComponent();
        }

        private void MemberAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand("insert into Member (MemberName,MemberAddress,MemberPhone) values ('" + MemberName.Text + "','" + MemberAdd.Text + "','" + MemberPhn.Text + "') ", con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Infomartion saved");
            }
            catch (Exception)
            {
               // MessageBox.Show("Infomation Not saved ");
            }
            displayMember();
        }

        public void displayMember()
        {
            try
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand("select * from Member", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                da.Fill(dt);
                gvMember.DataSource = dt;
                con.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Infomation Not saved");
            }

        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            displayMember();
            displayDepartment();
            displayEmployee();
        }

        private void gvMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow row = gvMember.Rows[indexRow];
            MemberName.Text = row.Cells[1].Value.ToString();
            MemberAdd.Text = row.Cells[2].Value.ToString();
            MemberPhn.Text = row.Cells[3].Value.ToString();
            MemberRow = row.Cells[0].Value.ToString();
        }

        private void MemberDelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand("delete from Member where MemberName='" + MemberName.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Infomartion Deleted");
            }
            catch (Exception)
            {
                MessageBox.Show("Infomation Not Deleted");
            }
            displayMember();

        }

        private void MemberUpdtBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand("update Member set MemberName='" + MemberName.Text + "', MemberAddress='" + MemberAdd.Text + "',MemberPhone='" + MemberPhn.Text + "' where MemberID='" + MemberRow + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Infomartion updated");
            }
            catch (Exception)
            {
                MessageBox.Show("Information Not Updated");
            }
            displayMember();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand("insert into Department (DepartmentTitle) values ('" + DepartmentNam.Text + "') ", con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Infomartion saved");
            }
            catch (Exception)
            {
                MessageBox.Show("Infomation Not saved " );
            }
            displayDepartment();
        }

        public void displayDepartment()
        {
            try
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand("select * from Department", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                da.Fill(dt);
                gvDepartment.DataSource = dt;
                con.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Infomation Not saved");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand("delete from Department where DepartmentName='" + DepartmentNam.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Infomartion Deleted");
            }
            catch (Exception)
            {
                MessageBox.Show("Infomation Not Deleted");
            }
            displayDepartment();
        }

        private void DelDeptBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand("update Department set DepartmentTitle='" + DepartmentNam.Text + "' where DepartmentID='" + DeptRow + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Infomartion updated");
            }
            catch (Exception)
            {
                MessageBox.Show("Infomation Not Updated");
            }
            displayDepartment();
        }

        private void gvDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow row = gvDepartment.Rows[indexRow];
            DepartmentNam.Text = row.Cells[1].Value.ToString();
            DeptRow = row.Cells[0].Value.ToString();
        }

        private void AddEmpBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand("insert into Employee (EmployeeName,EmployeeAddress,DepartmentID) values ('" + EmpNam.Text + "','" + EmpAdd.Text + "','" + EmpDeptId.Text + "') ", con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Infomartion saved");
            }
            catch (Exception)
            {
                MessageBox.Show("Infomation Not saved ");
            }

            displayEmployee();
        }

        public void displayEmployee()
        {
            try
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand("select * from Employee", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                da.Fill(dt);
                gvEmployee.DataSource = dt;
                con.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Infomation Not saved");
            }


        }

        private void DelEmpBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand("delete from Employee where EmployeeName='" + EmpNam.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Infomartion Deleted");
            }
            catch (Exception)
            {
                MessageBox.Show("Infomation Not Deleted");
            }
            displayEmployee();
        }

        private void gvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow row = gvEmployee.Rows[indexRow];
            EmpNam.Text = row.Cells[1].Value.ToString();
            EmpAdd.Text = row.Cells[2].Value.ToString();
            EmpDeptId.Text = row.Cells[3].Value.ToString();
            EmpRow = row.Cells[0].Value.ToString();
        }

        private void upBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand("update Employee set EmployeeName='" + EmpNam.Text + "', EmployeeAddress='" + EmpAdd.Text + "',DepartmentID='" + EmpDeptId.Text + "' where EmployeeID='" + EmpRow + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Infomartion updated");
            }
            catch (Exception)
            {
                MessageBox.Show("Information Not Updated");
            }
            displayEmployee();
        }



    }
}
