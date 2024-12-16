using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace CAFE_INIZIO
{
    public partial class Costumer : Form
    {
        public Costumer()
        {
            InitializeComponent();
            DisplayCustomer();
            CustomerDGV.CellClick += new DataGridViewCellEventHandler(CustomerDGV_CellClick);

        }
        private void CustomerDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = CustomerDGV.Rows[e.RowIndex];


                CustNameTb.Text = row.Cells["CustName"].Value.ToString();
                CustGenCB.Text = row.Cells["CustGen"].Value.ToString();


                if (row.Cells["CustID"].Value != DBNull.Value && int.TryParse(row.Cells["CustID"].Value.ToString(), out int CustID))
                {
                    Key = CustID;
                }
                else
                {
                    Key = 0;
                }
            }
        }


        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\clint\OneDrive\Documents\Database.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayCustomer()
        {
            try
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }

                Con.Open();
                string Query = "SELECT * FROM CustomerTbl";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                CustomerDGV.DataSource = ds.Tables[0];
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
            CustNameTb.Text = "";
            CustGenCB.Text = "";

        }

        private void btnCOSTUMER_Click(object sender, EventArgs e)
        {
            Costumer costumer = new Costumer();
            costumer.Show();
            this.Hide();
        }

        private void btnHOME_Click(object sender, EventArgs e)
        {
            Main mainForm = new Main();
            mainForm.Show();
            this.Hide();
        }

        private void btnEMPLOYEE_Click(object sender, EventArgs e)
        {
            if (Form1.IsAdmin)
            {
                Employee employee = new Employee();
                employee.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Only the Administrator can access this program",
                              "Access Denied",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
            }
        }

        private void btnPRODUCT_Click(object sender, EventArgs e)
        {
            if (Form1.IsAdmin)
            {
                Product product = new Product();
                product.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Only the Administrator can access this program",
                              "Access Denied",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
            }
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            if (CustNameTb.Text == "" || CustGenCB.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO CustomerTbl (CustName, CustGen) VALUES(@CN, @CG)", Con);
                    cmd.Parameters.AddWithValue("@CN", CustNameTb.Text);
                    cmd.Parameters.AddWithValue("@CG", CustGenCB.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Added Successfully");
                    DisplayCustomer();
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
        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            if (CustNameTb.Text == "" || CustGenCB.Text == "")
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
                // Correct SQL query with SET and WHERE clause
                SqlCommand cmd = new SqlCommand("UPDATE CustomerTbl SET CustName = @CN, CustGen = @CG WHERE CustID = @EKey", Con);
                cmd.Parameters.AddWithValue("@CN", CustNameTb.Text);
                cmd.Parameters.AddWithValue("@CG", CustGenCB.Text);
                cmd.Parameters.AddWithValue("@EKey", Key); // Assuming `Key` is CustID or a unique identifier

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Customer Updated Successfully");
                }
                else
                {
                    MessageBox.Show("No record updated. Please check if the correct row is selected.");
                }

                DisplayCustomer();
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
                MessageBox.Show("Please select a customer to delete.");
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this customer?", "Delete Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            try
            {
                if (Con.State == ConnectionState.Open) Con.Close();
                Con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM CustomerTbl WHERE CustID = @CustID", Con);
                cmd.Parameters.AddWithValue("@CustID", Key);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Customer deleted successfully.");
                    DisplayCustomer();
                    Clear();
                }
                else
                {
                    MessageBox.Show("No customer found with the selected ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Con.State == ConnectionState.Open) Con.Close();
            }
        }
        int Key = 0;

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
    }
}
