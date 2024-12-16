using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;

namespace CAFE_INIZIO
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
            DisplayEmployee();
            EmployeeDGV.CellClick += new DataGridViewCellEventHandler(EmployeeDGV_CellClick);
        }
    
    private void EmployeeDGV_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0) // Make sure we clicked on a row
        {
            DataGridViewRow row = EmployeeDGV.Rows[e.RowIndex];

            // Populate the textboxes with the data from the selected row
            EmpNameTb.Text = row.Cells["EmpName"].Value.ToString();
            EmpConTb.Text = row.Cells["EmpCon"].Value.ToString();
            EmpAddTb.Text = row.Cells["EmpAdd"].Value.ToString();
            EmpPassTb.Text = row.Cells["EmpPass"].Value.ToString();

            // Handle the date value
            if (row.Cells["EmpDOB"].Value != DBNull.Value)
            {
                EmpDOB.Value = Convert.ToDateTime(row.Cells["EmpDOB"].Value);
            }

            // Store the Employee Number (Key) for update/delete operations
            if (row.Cells["EmpNum"].Value != DBNull.Value)
            {
                Key = Convert.ToInt32(row.Cells["EmpNum"].Value);
            }
            else
            {
                Key = 0;
            }
        }
    }
    SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\clint\OneDrive\Documents\Database.mdf;Integrated Security=True;Connect Timeout=30");
        
        private void DisplayEmployee()//stored procedure
        {
            try
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }

                Con.Open();
                string Query = "GetAllEmployees";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                EmployeeDGV.DataSource = ds.Tables[0];
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
            EmpNameTb.Text = "";
            EmpConTb.Text = "";
            EmpAddTb.Text = "";
            EmpPassTb.Text = "";
            Key = 0;  
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
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

        private void btnCOSTUMER_Click(object sender, EventArgs e)
        {
            Costumer costumer = new Costumer();
            costumer.Show();
            this.Hide();
        }

        // SAVE Button Logic
        private void btnSAVE_Click(object sender, EventArgs e)
        {
            if (EmpNameTb.Text == "" || EmpConTb.Text == "" || EmpAddTb.Text == "" || EmpPassTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into EmployeeTbl (EmpName,EmpCon,EmpAdd,EmpPass,EmpDOB) values(@EN,@EC,@EA,@EP,@ED)", Con);
                    cmd.Parameters.AddWithValue("@EN", EmpNameTb.Text);
                    cmd.Parameters.AddWithValue("@EC", EmpConTb.Text);
                    cmd.Parameters.AddWithValue("@EA", EmpAddTb.Text);
                    cmd.Parameters.AddWithValue("@EP", EmpPassTb.Text);  
                    cmd.Parameters.AddWithValue("@ED", EmpDOB.Value.Date);  
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Added");
                    Con.Close();
                    DisplayEmployee();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        // EDIT Button Logic
        private void btnEDIT_Click(object sender, EventArgs e)
        {
            if (EmpNameTb.Text == "" || EmpConTb.Text == "" || EmpAddTb.Text == "" || EmpPassTb.Text == "")
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
                SqlCommand cmd = new SqlCommand("UPDATE EmployeeTbl SET EmpName=@EN, EmpCon=@EC, EmpAdd=@EA, EmpPass=@EP, EmpDOB=@ED WHERE EmpNum=@EKey", Con);
                cmd.Parameters.AddWithValue("@EN", EmpNameTb.Text);
                cmd.Parameters.AddWithValue("@EC", EmpConTb.Text);
                cmd.Parameters.AddWithValue("@EA", EmpAddTb.Text);
                cmd.Parameters.AddWithValue("@EP", EmpPassTb.Text);  
                cmd.Parameters.AddWithValue("@ED", EmpDOB.Value.Date);  
                cmd.Parameters.AddWithValue("@EKey", Key);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Updated Successfully");
                DisplayEmployee();
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

        // DELETE Button Logic
        private void btnDELETE_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select an Employee");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM EmployeeTbl WHERE EmpNum=@EKey", Con);
                    cmd.Parameters.AddWithValue("@EKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Deleted Successfully");
                    Con.Close();
                    DisplayEmployee();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        int Key = 0;  // Holds the EmpNum value for editing or deleting

        private void EmpDOB_ValueChanged(object sender, EventArgs e)
        {
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
    }
}
