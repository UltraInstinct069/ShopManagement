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
    public partial class Sell : Form
    {
        SqlCeConnection con = new SqlCeConnection(@"Data Source=C:\Users\Abrar Abir\Documents\Visual Studio 2010\Projects\ShopManagement\ShopManagement\Database1.sdf");
        int grandTotal = 0;
        int tableRows;
        int StockQuan,StockNo,RestQuan;
        int TtPrice;
        public Sell()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand("select MAX(CategoryID) from Category", con);
                cmd.ExecuteNonQuery();
                object s = cmd.ExecuteScalar();
                String ss = Convert.ToString(s);
                label1.Text = ss;
                
            }
            catch (Exception)
            {
                MessageBox.Show("Infomation Not saved");
            }
            
            DataTable tb = new DataTable();

            tb.Columns.Add("Id");
            tb.Columns.Add("name");
            tb.Columns.Add("cg");
            tb.Columns.Add("age");

            DataRow row = tb.NewRow();
            
            row["Id"] = textBox1.Text;
            row["name"] = textBox2.Text;
            row["cg"] = textBox3.Text;
            row["age"] = textBox4.Text;
            tb.Rows.Add(row);

            foreach (DataRow Dr in tb.Rows)
            {
                int num = gvProdStck.Rows.Add();
                gvProdStck.Rows[num].Cells[0].Value = Dr["Id"].ToString();
                gvProdStck.Rows[num].Cells[1].Value = Dr["name"].ToString();
                gvProdStck.Rows[num].Cells[2].Value = Dr["cg"].ToString();
                gvProdStck.Rows[num].Cells[3].Value = Dr["age"].ToString();

            }*/
            }

        public void displayProdStock()
        {
            try
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand("select StockNo,p.ProductID,ProductTitle,ProductBrand,Quantity,SellPrice from Product as p,Stock as s where p.ProductID=s.ProductID", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                da.Fill(dt);
                gvProdStck.DataSource = dt;
                con.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Infomation Not saved");
            }


        }

        private void Sell_Load(object sender, EventArgs e)
        {
            displayProdStock();
            displayFullSell();
        }

        private void gvProdStck_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow row = gvProdStck.Rows[indexRow];
            sellProdId.Text = row.Cells[1].Value.ToString();
            sellProdTitle.Text = row.Cells[2].Value.ToString();
            sellPrice.Text = row.Cells[5].Value.ToString();
            StockQuan = Convert.ToInt16(row.Cells[4].Value.ToString());
            StockNo = Convert.ToInt16(row.Cells[0].Value.ToString());
            
        }

        private void addCartBtn_Click(object sender, EventArgs e)
        {
            int sinPrice,quan;
            try
            {
                DataTable tb = new DataTable();

                tb.Columns.Add("PrdID");
                tb.Columns.Add("PrdTitle");
                tb.Columns.Add("Quantty");
                tb.Columns.Add("UntPrice");
                tb.Columns.Add("Ttprice");
                tb.Columns.Add("RemQuan");
                tb.Columns.Add("StckNo");
                DataRow row = tb.NewRow();

                sinPrice = Convert.ToInt32(sellPrice.Text);
                quan = Convert.ToInt16(sellQuan.Text);
                StockQuan = StockQuan - quan;
                TtPrice = sinPrice * quan;
                grandTotal = grandTotal + TtPrice;
                String tt = Convert.ToString(TtPrice);
                row["PrdID"] = sellProdId.Text;
                row["PrdTitle"] = sellProdTitle.Text;
                row["Quantty"] = sellQuan.Text;
                row["UntPrice"] = sellPrice.Text;
                row["Ttprice"] = tt;
                row["RemQuan"] = StockQuan;
                row["StckNo"] = StockNo;
                tb.Rows.Add(row);
                tableRows = tableRows + tb.Rows.Count;
                label6.Text = Convert.ToString(tableRows);
                TA.Text = Convert.ToString(grandTotal);
                foreach (DataRow Dr in tb.Rows)
                {
                    int num = gvSell.Rows.Add();
                    gvSell.Rows[num].Cells[0].Value = Dr["PrdID"].ToString();
                    gvSell.Rows[num].Cells[1].Value = Dr["PrdTitle"].ToString();
                    gvSell.Rows[num].Cells[2].Value = Dr["Quantty"].ToString();
                    gvSell.Rows[num].Cells[3].Value = Dr["UntPrice"].ToString();
                    gvSell.Rows[num].Cells[4].Value = Dr["Ttprice"].ToString();
                    gvSell.Rows[num].Cells[5].Value = Dr["RemQuan"].ToString();
                    gvSell.Rows[num].Cells[6].Value = Dr["StckNo"].ToString();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter the Quantity ");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void CheckoutBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand("insert into Invoice (Amount) values ('" + grandTotal + "') ", con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Invoice saved");
            }
            catch (Exception)
            {
                MessageBox.Show("Invoice Not saved ");
            }
            try
            {
                String pdid, pdtitle, pdquan,iv,remQuan,StckNo,pdPrice;
                for (int i = 0; i < tableRows; i++)
                {
                    pdid = gvSell.Rows[i].Cells[0].Value.ToString();
                    pdtitle = gvSell.Rows[i].Cells[1].Value.ToString();
                    pdquan = gvSell.Rows[i].Cells[2].Value.ToString();
                    remQuan = gvSell.Rows[i].Cells[5].Value.ToString();
                    pdPrice = gvSell.Rows[i].Cells[4].Value.ToString();
                    StckNo = gvSell.Rows[i].Cells[6].Value.ToString();
                    con.Open();
                    SqlCeCommand cmd = new SqlCeCommand("select MAX(InvoiceNo) from Invoice", con);
                    cmd.ExecuteNonQuery();
                    object s = cmd.ExecuteScalar();
                    iv = Convert.ToString(s);

                    cmd = new SqlCeCommand("update Stock set Quantity='" + remQuan + "' where StockNo='" + StckNo + "' and ProductID='" + pdid + "'", con);
                    cmd.ExecuteNonQuery();

                    cmd = new SqlCeCommand("insert into Sell (InvoiceNo,ProductID,SellQuantity,SellDate,EmployeeID,MemberID,StockNo,Price) values ('" + iv + "','" + pdid + "','" + pdquan + "',getdate(),'" + sellEmpID.Text + "','" + sellMemId.Text + "','" + StckNo + "','" + pdPrice + "') ", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                MessageBox.Show("Sell Infomartion saved");
            }
            catch (Exception)
            {
                MessageBox.Show(" Sell Infomation Not saved ");
            }
            displayFullSell();
            displayProdStock();
        }
        public void displayFullSell()
        {
            try
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand("select InvoiceNo,p.ProductID,ProductTitle,SellQuantity,SellDate,EmployeeID,MemberID,StockNo from Sell as s,Product as p where s.ProductID=p.ProductID", con);
                
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                da.Fill(dt);
                gvFullSell.DataSource = dt;
                con.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Infomation Not saved");
            }


        }

        private void gvFullSell_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           /* int indexRow = e.RowIndex;
            DataGridViewRow row = gvFullSell.Rows[indexRow];
            fsInvo.Text = row.Cells[0].Value.ToString();
            fsPID.Text = row.Cells[1].Value.ToString();
            fsSelQuan.Text = row.Cells[2].Value.ToString();
            fsSelldate.Text = row.Cells[3].Value.ToString();
            fsEmpID.Text = row.Cells[4].Value.ToString();
            fsMemID.Text = row.Cells[5].Value.ToString();
            fsStockNo.Text = row.Cells[6].Value.ToString();
            RestQuan = Convert.ToInt16(fsSelQuan.Text = row.Cells[2].Value.ToString());*/
        }

        private void DelSelBtn_Click(object sender, EventArgs e)
        {
           /* try
            {
                
                con.Open();
                

                SqlCeCommand cmd = new SqlCeCommand("delete from Sell where InvoiceNo='" + fsInvo.Text + "' and ProductID='" + fsPID.Text + "'" , con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Infomartion Deleted");
            }
            catch (Exception)
            {
                MessageBox.Show("Infomation Not Deleted");
            }
            displayFullSell();
            displayProdStock();*/
        }

        private void rmvBtn_Click(object sender, EventArgs e)
        {
            String aT; ;
            int index = gvSell.CurrentCell.RowIndex;
            aT = gvSell.Rows[index].Cells[4].Value.ToString();
            int a = Convert.ToInt16(aT);
            grandTotal = grandTotal - a;
            gvSell.Rows.RemoveAt(index);
            tableRows = tableRows - 1;
            TA.Text = grandTotal.ToString();
            
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void SearchSell_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                if (rdIV.Checked)
                {
                    SqlCeCommand cmd = new SqlCeCommand("select InvoiceNo,p.ProductID,ProductTitle,SellQuantity,SellDate,EmployeeID,MemberID,StockNo from Sell as s,Product as p where s.ProductID=p.ProductID and InvoiceNo like '" + SearchSell.Text + "%'", con);
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                    da.Fill(dt);
                    gvFullSell.DataSource = dt;
                    con.Close();
                }
                else if (rdProdID.Checked)
                {
                    SqlCeCommand cmd = new SqlCeCommand("select InvoiceNo,p.ProductID,ProductTitle,SellQuantity,SellDate,EmployeeID,MemberID,StockNo from Sell as s,Product as p where s.ProductID=p.ProductID and p.ProductID like '" + SearchSell.Text + "%'", con);
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                    da.Fill(dt);
                    gvFullSell.DataSource = dt;
                    con.Close();
                }
                else if (rdProdTitle.Checked)
                {
                    SqlCeCommand cmd = new SqlCeCommand("select InvoiceNo,p.ProductID,ProductTitle,SellQuantity,SellDate,EmployeeID,MemberID,StockNo from Sell as s,Product as p where s.ProductID=p.ProductID and ProductTitle like '" + SearchSell.Text + "%'", con);

                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                    da.Fill(dt);
                    gvFullSell.DataSource = dt;
                    con.Close();
                }
                else if (rdEmploy.Checked)
                {
                    SqlCeCommand cmd = new SqlCeCommand("select InvoiceNo,p.ProductID,ProductTitle,SellQuantity,SellDate,EmployeeID,MemberID,StockNo from Sell as s,Product as p where s.ProductID=p.ProductID and EmployeeID like '" + SearchSell.Text + "%'", con);
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                    da.Fill(dt);
                    gvFullSell.DataSource = dt;
                    con.Close();
                }
                // cmd.ExecuteNonQuery();



            }
            catch (Exception)
            {
                MessageBox.Show("Infomation Not saved");
            }
        }

        private void ClearBTN_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tableRows; i++)
                gvSell.Rows.Clear();

            grandTotal = 0;
            tableRows = 0;

            TA.Text = grandTotal.ToString();
            label6.Text = tableRows.ToString();
        }

        private void report_Click(object sender, EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("test.pdf", FileMode.Create));
            doc.Open();
            Paragraph para = new Paragraph(" ");
            
            doc.Add(para);
            
            
            
            try
            {
                String pdid, pdtitle, pdquan, iv, remQuan, StckNo, pdPrice,UnitPrice;
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand("select MAX(InvoiceNo) from Invoice", con);
                cmd.ExecuteNonQuery();
                object s = cmd.ExecuteScalar();
                iv = Convert.ToString(s);
                //doc.Open();
                para = new Paragraph("\t\tInvoice No : " + iv + "\n\t\tMember ID : " + sellMemId.Text + "\n\t\tEmplyee ID :"+sellEmpID.Text+"\n\n");
                doc.Add(para);
                
                para = new Paragraph("\t\tProductID\t       ProductTitle\t       Quantity\t       UnitPrice\t       In total\n\n");
                doc.Add(para);
                

                con.Close();
                
                for (int i = 0; i < tableRows; i++)
                {
                    pdid = gvSell.Rows[i].Cells[0].Value.ToString();
                    pdtitle = gvSell.Rows[i].Cells[1].Value.ToString();
                    pdquan = gvSell.Rows[i].Cells[2].Value.ToString();
                    remQuan = gvSell.Rows[i].Cells[5].Value.ToString();
                    UnitPrice = gvSell.Rows[i].Cells[3].Value.ToString();
                    pdPrice = gvSell.Rows[i].Cells[4].Value.ToString();
                    StckNo = gvSell.Rows[i].Cells[6].Value.ToString();
                    
                    para = new Paragraph("\t\t" + pdid + "                  " + pdtitle + "                    " + pdquan + "                  " + UnitPrice + "                 " + pdPrice + "\n ");
                    doc.Add(para); 
                    
                }
                
                para = new Paragraph("\n\nTotal Amount of taka : "+grandTotal);
                doc.Add(para);
                doc.Close();
                MessageBox.Show("Sell Infomartion saved");
            }
            catch (Exception)
            {
                MessageBox.Show(" Sell Infomation Not saved ");
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand("select StockNo,p.ProductID,ProductTitle,ProductBrand,Quantity,SellPrice from Product as p,Stock as s where p.ProductID=s.ProductID and ProductTitle like '" + textBox1.Text + "%'", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                da.Fill(dt);
                gvProdStck.DataSource = dt;
                con.Close();
                
                
            }
            catch (Exception)
            {
                MessageBox.Show("Infomation Not saved");
            }
        }


        }
    }

