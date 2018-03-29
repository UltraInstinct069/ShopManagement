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
    public partial class Form1 : Form
    {
        SqlCeConnection con = new SqlCeConnection(@"Data Source=C:\Users\Abrar Abir\Documents\Visual Studio 2010\Projects\ShopManagement\ShopManagement\Database1.sdf");
        String CategoryRow;
        String SubCategoryRow;
        String ProductRow;
        String SupplierRow;
        String StckNO;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void categoryAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand("insert into Category (CategoryTitle) values ('" + categoryTitle.Text + "') ", con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Infomartion saved");
            }
            catch (Exception)
            {
                MessageBox.Show("Infomation Not saved "+ categoryTitle.Text +" ");
            }
            displayCategory();
        }
        public void displayCategory()
        {
            try
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand("select * from Category", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                da.Fill(dt);
                gvCategory.DataSource = dt;
                con.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Infomation Not saved");
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displayCategory();
            displaySubCategory();
            displayProduct();
            displayProductSubCategory();
            displaySupplier();
            displaySearchProduct();
            displayStockSUp();
            displayStock();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand("delete from Category where CategoryTitle='" + categoryTitle.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Infomartion Deleted");
            }
            catch (Exception)
            {
                MessageBox.Show("Infomation Not Deleted");
            }
            displayCategory();
        }

        private void gvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int indexRow = e.RowIndex;
            DataGridViewRow row = gvCategory.Rows[indexRow];
            categoryTitle.Text = row.Cells[1].Value.ToString();
            CategoryRow = row.Cells[0].Value.ToString();
            

        }

        private void catUpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand("update Category set CategoryTitle='" + categoryTitle.Text + "' where CategoryID='" + CategoryRow + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Infomartion updated");
            }
            catch (Exception)
            {
                MessageBox.Show("Infomation Not Updated");
            }
            displayCategory();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void addSubcatButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand("insert into SubCategory (SubCategoryName,CategoryID) values ('" + SubCatTitle.Text + "','"+CatIdForSub.Text +"') ", con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Infomartion saved");
            }
            catch (Exception)
            {
                MessageBox.Show("Infomation Not saved " + categoryTitle.Text + " ");
            }
            displaySubCategory();
            displayProductSubCategory();
        }
        public void displaySubCategory()
        {
            try
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand("select * from SubCategory", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                da.Fill(dt);
                gvSubCategory.DataSource = dt;
                con.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Infomation Not saved");
            }


        }

        private void gvSubCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow row = gvSubCategory.Rows[indexRow];
            SubCatTitle.Text = row.Cells[1].Value.ToString();
            CatIdForSub.Text = row.Cells[2].Value.ToString();
            SubCategoryRow = row.Cells[0].Value.ToString();

        }

        private void SubCatDelButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand("delete from SubCategory where SubCategoryName='" + SubCatTitle.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Infomartion Deleted");
            }
            catch (Exception)
            {
                MessageBox.Show("Infomation Not Deleted");
            }
            displaySubCategory();
            displayProductSubCategory();
        }

        private void SubCatUpButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand("update SubCategory set SubCategoryName='" + SubCatTitle.Text + "',CategoryID='"+CatIdForSub.Text+"' where SubCategoryID='" + SubCategoryRow + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Infomartion updated");
            }
            catch (Exception)
            {
                MessageBox.Show("Infomation Not Updated");
            }
            displaySubCategory();
            displayProductSubCategory();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand("insert into Product (ProductTitle,ProductBrand,SubCategoryID) values ('" + PrductName.Text + "','" + ProductBrand.Text + "','" + SubIdForProduct.Text + "') ", con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Infomartion saved");
            }
            catch (Exception)
            {
                MessageBox.Show("Infomation Not saved ");
            }
            displayProduct();
        }
        public void displayProduct()
        {
            try
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand("select * from Product", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                da.Fill(dt);
                gvProduct.DataSource = dt;
                con.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Table not Updated");
            }


        }

        private void gvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow row = gvProduct.Rows[indexRow];
            PrductName.Text = row.Cells[1].Value.ToString();
            ProductBrand.Text = row.Cells[2].Value.ToString();
            SubIdForProduct.Text = row.Cells[3].Value.ToString();
            ProductRow = row.Cells[0].Value.ToString();
        }

        private void DelProdButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand("delete from Product where ProductTitle='" + PrductName.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Infomartion Deleted");
            }
            catch (Exception)
            {
                MessageBox.Show("Infomation Not Deleted");
            }
            displayProduct();
        }

        private void UpProdButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand("update Product set ProductTitle='" + PrductName.Text + "', ProductBrand='" + ProductBrand.Text + "',SubCategoryID='"+SubIdForProduct.Text+"' where ProductID='" +ProductRow + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Infomartion updated");
            }
            catch (Exception)
            {
                MessageBox.Show("Information Not Updated");
            }
            displayProduct();
        }
        public void displayProductSubCategory()
        {
            try
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand("select * from SubCategory", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                da.Fill(dt);
                gvProdSubcat.DataSource = dt;
                con.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Table Not updated");
            }


        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand("insert into Supplier (SupplierName,SupplierCompany,SupplierAddress,SupplierPhone) values ('" + SupName.Text + "','" + SupComp.Text + "','" + SupAddres.Text + "','" + SupPhn.Text + "') ", con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Infomartion saved");
            }
            catch (Exception)
            {
                MessageBox.Show("Infomation Not saved ");
            }
            displaySupplier();
        }


        public void displaySupplier()
        {
            try
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand("select * from Supplier", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                da.Fill(dt);
                gvSupplier.DataSource = dt;
                con.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Infomation Not saved");
            }

        }

        private void DelSupBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand("delete from Supplier where SupplierName='" + SupName.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Infomartion Deleted");
            }
            catch (Exception)
            {
                MessageBox.Show("Infomation Not Deleted");
            }
            displaySupplier();
        }

        private void gvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow row = gvSupplier.Rows[indexRow];
            SupName.Text = row.Cells[1].Value.ToString();
            SupComp.Text = row.Cells[2].Value.ToString();
            SupAddres.Text = row.Cells[3].Value.ToString();
            SupPhn.Text = row.Cells[4].Value.ToString();
            SupplierRow = row.Cells[0].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand("update Supplier set SupplierName='" + SupName.Text + "', SupplierCompany='" + SupComp.Text + "',SupplierAddress='" + SupAddres.Text + "',SupplierPhone='" + SupPhn.Text + "' where SupplierID='" + SupplierRow + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Infomartion updated");
            }
            catch (Exception)
            {
                MessageBox.Show("Information Not Updated");
            }
            displaySupplier();
        }


        public void displaySearchProduct()
        {
            try
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand("select ProductID,ProductTitle,ProductBrand,sc.SubCategoryID,SubCategoryName,c.CategoryID,CategoryTitle from Product as p,SubCategory as sc,Category as c where p.SubCategoryID=sc.SubcategoryID and sc.CategoryID=c.CategoryID", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                da.Fill(dt);
                GvSearchProd.DataSource = dt;
                con.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Infomation Not saved");
            }

        }

        private void SearchProdBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                
                if (RbProdID.Checked)
                {
                    SqlCeCommand cmd = new SqlCeCommand("select ProductID,ProductTitle,ProductBrand,sc.SubCategoryID,SubCategoryName,c.CategoryID,CategoryTitle from Product as p,SubCategory as sc,Category as c where p.SubCategoryID=sc.SubcategoryID and sc.CategoryID=c.CategoryID and ProductID like '"+ Searchkey.Text +"%'", con);
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                    da.Fill(dt);
                    GvSearchProd.DataSource = dt;
                    con.Close();
                }
                else if (RbProdNam.Checked)
                {
                    SqlCeCommand cmd = new SqlCeCommand("select ProductID,ProductTitle,ProductBrand,sc.SubCategoryID,SubCategoryName,c.CategoryID,CategoryTitle from Product as p,SubCategory as sc,Category as c where p.SubCategoryID=sc.SubcategoryID and sc.CategoryID=c.CategoryID and ProductTitle like '" + Searchkey.Text + "%'", con);
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                    da.Fill(dt);
                    GvSearchProd.DataSource = dt;
                    con.Close();
                }
                else if (RbSubCatId.Checked)
                {
                    SqlCeCommand cmd = new SqlCeCommand("select ProductID,ProductTitle,ProductBrand,sc.SubCategoryID,SubCategoryName,c.CategoryID,CategoryTitle from Product as p,SubCategory as sc,Category as c where p.SubCategoryID=sc.SubcategoryID and sc.CategoryID=c.CategoryID and sc.SubCategoryID like '" + Searchkey.Text + "%'", con);

                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                    da.Fill(dt);
                    GvSearchProd.DataSource = dt;
                    con.Close();
                }
                else if (RdCatId.Checked)
                {
                    SqlCeCommand cmd = new SqlCeCommand("select ProductID,ProductTitle,ProductBrand,sc.SubCategoryID,SubCategoryName,c.CategoryID,CategoryTitle from Product as p,SubCategory as sc,Category as c where p.SubCategoryID=sc.SubcategoryID and sc.CategoryID=c.CategoryID and c.CategoryID like '" + Searchkey.Text + "%'", con);
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                    da.Fill(dt);
                    GvSearchProd.DataSource = dt;
                    con.Close();
                }
               // cmd.ExecuteNonQuery();
               


            }
            catch (Exception)
            {
                MessageBox.Show("Infomation Not saved");
            }
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            displaySearchProduct();
        }

        private void Searchkey_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                if (RbProdID.Checked)
                {
                    SqlCeCommand cmd = new SqlCeCommand("select ProductID,ProductTitle,ProductBrand,sc.SubCategoryID,SubCategoryName,c.CategoryID,CategoryTitle from Product as p,SubCategory as sc,Category as c where p.SubCategoryID=sc.SubcategoryID and sc.CategoryID=c.CategoryID and ProductID like '" + Searchkey.Text + "%'", con);
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                    da.Fill(dt);
                    GvSearchProd.DataSource = dt;
                    con.Close();
                }
                else if (RbProdNam.Checked)
                {
                    SqlCeCommand cmd = new SqlCeCommand("select ProductID,ProductTitle,ProductBrand,sc.SubCategoryID,SubCategoryName,c.CategoryID,CategoryTitle from Product as p,SubCategory as sc,Category as c where p.SubCategoryID=sc.SubcategoryID and sc.CategoryID=c.CategoryID and ProductTitle like '" + Searchkey.Text + "%'", con);
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                    da.Fill(dt);
                    GvSearchProd.DataSource = dt;
                    con.Close();
                }
                else if (RbSubCatId.Checked)
                {
                    SqlCeCommand cmd = new SqlCeCommand("select ProductID,ProductTitle,ProductBrand,sc.SubCategoryID,SubCategoryName,c.CategoryID,CategoryTitle from Product as p,SubCategory as sc,Category as c where p.SubCategoryID=sc.SubcategoryID and sc.CategoryID=c.CategoryID and sc.SubCategoryID like '" + Searchkey.Text + "%'", con);

                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                    da.Fill(dt);
                    GvSearchProd.DataSource = dt;
                    con.Close();
                }
                else if (RdCatId.Checked)
                {
                    SqlCeCommand cmd = new SqlCeCommand("select ProductID,ProductTitle,ProductBrand,sc.SubCategoryID,SubCategoryName,c.CategoryID,CategoryTitle from Product as p,SubCategory as sc,Category as c where p.SubCategoryID=sc.SubcategoryID and sc.CategoryID=c.CategoryID and c.CategoryID like '" + Searchkey.Text + "%'", con);
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                    da.Fill(dt);
                    GvSearchProd.DataSource = dt;
                    con.Close();
                }
                // cmd.ExecuteNonQuery();



            }
            catch (Exception)
            {
                MessageBox.Show("Select the category first");
            }
        }

        public void displayStockSUp()
        {
            try
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand("select * from Supplier", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                da.Fill(dt);
                gvStockSupp.DataSource = dt;
                con.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Infomation Not saved");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void searcSupSTock_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand("select *  from Supplier where SupplierName like '" + searcSupSTock.Text + "%'", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                da.Fill(dt);
                gvStockSupp.DataSource = dt;
                con.Close();
            }
            catch (Exception)
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand("insert into Stock (ProductID,Quantity,SupplierID,BarcodeNo,PurchaseNo,SellPrice,ManuDate,ExpDate,EmployeeID,PurchaseDate) values ('" + StkProdID.Text + "','" + StckQuan.Text + "','" + StckSupID.Text + "','" + barcod.Text + "','" + StckPurPrice.Text + "','" + StckSellPrice.Text + "','" + MfgDate.Text + "','" + ExpDate.Text + "','" + StckEmpID.Text + "',getdate()) ", con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Infomartion saved");
                displayStock();
            }
            catch (Exception)
            {
                MessageBox.Show("Infomation Not saved ");
            }
        }

        public void displayStock()
        {
            try
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand("select * from Stock", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                da.Fill(dt);
                gvStock.DataSource = dt;
                con.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Infomation Not saved");
            }


        }

        private void stckDelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand("delete from Stock where StockNo='" + StckNO + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Infomartion Deleted");
            }
            catch (Exception)
            {
                MessageBox.Show("Infomation Not Deleted");
            }
            displayStock();
        }

        private void gvStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow row = gvStock.Rows[indexRow];
            StkProdID.Text = row.Cells[1].Value.ToString();
            StckQuan.Text = row.Cells[2].Value.ToString();
            StckSupID.Text = row.Cells[3].Value.ToString();
            barcod.Text = row.Cells[4].Value.ToString();
            StckPurPrice.Text = row.Cells[5].Value.ToString();
            StckSellPrice.Text = row.Cells[6].Value.ToString();
            MfgDate.Text = row.Cells[7].Value.ToString();
            ExpDate.Text = row.Cells[8].Value.ToString();
           StckEmpID.Text = row.Cells[9].Value.ToString();
           StckNO = row.Cells[0].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand("update Stock set ProductID='" + StkProdID.Text + "', Quantity='" + StckQuan.Text + "',SupplierID='" + StckSupID.Text + "',BarcodeNo='" + barcod.Text + "',PurchaseNo='" + StckPurPrice.Text + "',SellPrice='" + StckSellPrice.Text + "',ManuDate='" + MfgDate.Text + "',ExpDate='" + ExpDate.Text + "',EmployeeID='" + StckEmpID.Text + "' where StockNo='" + StckNO + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Infomartion updated");
            }
            catch (Exception)
            {
                MessageBox.Show("Information Not Updated");
            }
            displayStock();
        }



    }
}
