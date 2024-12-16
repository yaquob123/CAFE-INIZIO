using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAFE_INIZIO
{
    public partial class Main : Form
    {
        private string employeeName;
        public Main(string employeeName = "")
        {
            InitializeComponent();
            this.employeeName = employeeName;
            this.Load += Main_Load;
        }

        private void Main_Load(object sender, EventArgs e)
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

        private void btnORDER_Click(object sender, EventArgs e)
        {
            Order order = new Order(employeeName);
            order.Show();
            this.Hide();
        }

        private void btnLOGOUT_Click(object sender, EventArgs e)
        {

            Form1.IsAdmin = false;
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
