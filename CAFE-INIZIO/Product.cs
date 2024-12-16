using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAFE_INIZIO
{
    public partial class Product : Form
    {
        private int Key = 0;
        private string selectedProductType = "";

        public Product()
        {
            InitializeComponent();
            DisplayProduct();
            ProductDGV.CellDoubleClick += new DataGridViewCellEventHandler(ProductDGV_CellDoubleClick);
            // Disable all input fields initially
            DisableInputFields();
        }
        private void DisableInputFields()
        {
            PrNameTb.Enabled = false;
            PrCatCb.Enabled = false;
            PrQtyTb.Enabled = false;
            PrPriceTb.Enabled = false;
            btnSAVE.Enabled = false;
        }
        private void EnableInputFields(bool isCoffee)
        {
            PrNameTb.Enabled = true;
            PrCatCb.Enabled = true;
            PrPriceTb.Enabled = true;
            PrQtyTb.Enabled = !isCoffee; // Disable quantity for coffee, enable for pastry
            btnSAVE.Enabled = true;

            // Clear all fields
            Clear();
        }


        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\clint\OneDrive\Documents\Database.mdf;Integrated Security=True;Connect Timeout=30");

        private void DisplayProduct()
        {
            try
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }

                Con.Open();
                string Query = "Select * from ProductTbl";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                ProductDGV.DataSource = ds.Tables[0];
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }

        private void Clear()
        {
            PrNameTb.Text = "";
            PrCatCb.Text = "";
            PrQtyTb.Text = "";
            PrPriceTb.Text = "";
            Key = 0;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHOME_Click(object sender, EventArgs e)
        {
            Main mainForm = new Main();
            mainForm.Show();
            this.Hide();
        }

        private void btnEMPLOYEE_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Show();
            this.Hide();
        }

        private void btnPRODUCT_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Show();
            this.Hide();
        }

        private void btnCOSTUMER_Click(object sender, EventArgs e)
        {
            Costumer costumer = new Costumer();
            costumer.Show();
            this.Hide();
        }

        private void PrNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            if (selectedProductType == "")
            {
                MessageBox.Show("Please select product type (Coffee or Pastry) first.");
                return;
            }

            // Validation based on product type
            if (selectedProductType == "Coffee")
            {
                if (PrNameTb.Text == "" || PrCatCb.Text == "" || PrPriceTb.Text == "")
                {
                    MessageBox.Show("Please fill in all required fields");
                    return;
                }
            }
            else // Pastry
            {
                if (PrNameTb.Text == "" || PrCatCb.Text == "" || PrQtyTb.Text == "" || PrPriceTb.Text == "")
                {
                    MessageBox.Show("Please fill in all required fields");
                    return;
                }
            }

            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Insert into ProductTbl (PrName,PrCat,PrQty,PrPrice,PrType) values(@PN,@PC,@PQ,@PP,@PT)", Con);
                cmd.Parameters.AddWithValue("@PN", PrNameTb.Text);
                cmd.Parameters.AddWithValue("@PC", PrCatCb.Text);
                cmd.Parameters.AddWithValue("@PQ", selectedProductType == "Coffee" ? DBNull.Value : (object)PrQtyTb.Text);
                cmd.Parameters.AddWithValue("@PP", PrPriceTb.Text);
                cmd.Parameters.AddWithValue("@PT", selectedProductType);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Added Successfully");
                Con.Close();
                DisplayProduct();
                Clear();
                selectedProductType = ""; // Reset product type
                DisableInputFields(); // Disable fields after saving
                btnCOFFEE.BackColor = SystemColors.Control; // Reset button colors
                btnPASTRY.BackColor = SystemColors.Control;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                    Con.Close();
            }
        }



        private void ProductDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = ProductDGV.Rows[e.RowIndex];

                // Get the product type first
                string productType = row.Cells["PrType"].Value?.ToString() ?? "";
                selectedProductType = productType;

                // Enable fields based on product type
                EnableInputFields(productType == "Coffee");

                // Update button highlighting
                btnCOFFEE.BackColor = (productType == "Coffee") ? Color.LightGreen : SystemColors.Control;
                btnPASTRY.BackColor = (productType == "Pastry") ? Color.LightGreen : SystemColors.Control;

                // Fill the fields
                PrNameTb.Text = row.Cells["PrName"].Value.ToString();
                PrCatCb.Text = row.Cells["PrCat"].Value.ToString();
                PrPriceTb.Text = row.Cells["PrPrice"].Value.ToString();

                if (productType == "Pastry")
                {
                    PrQtyTb.Text = row.Cells["PrQty"].Value?.ToString() ?? "";
                }
                else
                {
                    PrQtyTb.Text = "";
                }

                if (row.Cells["PrID"].Value != DBNull.Value && int.TryParse(row.Cells["PrID"].Value.ToString(), out int prID))
                {
                    Key = prID;
                }
                else
                {
                    Key = 0;
                }
            }
        }


        private void btnEDIT_Click(object sender, EventArgs e)
        {
            if (PrNameTb.Text == "" || PrCatCb.Text == "" || PrQtyTb.Text == "" || PrPriceTb.Text == "")
            {
                MessageBox.Show("Missing Information");
                return;
            }

            try
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }

                Con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE ProductTbl SET PrName = @PN, PrCat = @PC, PrQty = @PQ, PrPrice = @PP WHERE PrID = @EKey", Con);
                cmd.Parameters.AddWithValue("@PN", PrNameTb.Text);
                cmd.Parameters.AddWithValue("@PC", PrCatCb.Text);
                cmd.Parameters.AddWithValue("@PQ", PrQtyTb.Text);
                cmd.Parameters.AddWithValue("@PP", PrPriceTb.Text);
                cmd.Parameters.AddWithValue("@EKey", Key);  // Use the class-level Key

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Product Updated Successfully");
                }
                else
                {
                    MessageBox.Show("No record updated. Please check if the correct row is selected.");
                }

                DisplayProduct();
                Clear();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }


        private void btnDELETE_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Please select a product to delete.");
                return;
            }

            // Confirm the delete action
            var confirmResult = MessageBox.Show(
                "Are you sure you want to delete this product?",
                "Delete Product",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.No)
            {
                return;
            }

            try
            {
                // Open the connection
                Con.Open();

                // Execute the DELETE command
                SqlCommand cmd = new SqlCommand("DELETE FROM ProductTbl WHERE PrID = @PrID", Con);
                cmd.Parameters.AddWithValue("@PrID", Key);

                int rowsAffected = cmd.ExecuteNonQuery();

                // Feedback to the user
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Product deleted successfully.");
                    DisplayProduct(); // Refresh the grid to reflect the deletion
                    Clear(); // Reset the form
                    DisableInputFields(); // Disable inputs
                    btnCOFFEE.BackColor = SystemColors.Control; // Reset button colors
                    btnPASTRY.BackColor = SystemColors.Control;
                    Key = 0; // Reset the key
                }
                else
                {
                    MessageBox.Show("No product found with the selected ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the connection
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }

        private void btnORDER_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.Show();
            this.Hide();
        }

        private void btnLOGOUT_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
        private void btnCOFFEE_Click(object sender, EventArgs e)
        {
            selectedProductType = "Coffee";
            EnableInputFields(true);
            btnCOFFEE.BackColor = Color.LightGreen; // Highlight selected button
            btnPASTRY.BackColor = SystemColors.Control; // Reset other button
            MessageBox.Show("Coffee selected. Please enter product details. Quantity will be set automatically.");
        }
        private void btnPASTRY_Click(object sender, EventArgs e)
        {
            selectedProductType = "Pastry";
            EnableInputFields(false);
            btnPASTRY.BackColor = Color.LightGreen; // Highlight selected button
            btnCOFFEE.BackColor = SystemColors.Control; // Reset other button
            MessageBox.Show("Pastry selected. Please enter all product details including quantity.");
        }
    }
}