using System;
using System.Windows.Forms;

namespace POS_InventoryManagementSystem
{
    public partial class CashierMainForm : Form
    {
        public CashierMainForm()
        {
            InitializeComponent();
            displayUsername();
        }

        public void displayUsername()
        {
            if (user_username != null && Form1.username != null)
            {
                string username = Form1.username.Substring(0, 1).ToUpper() + Form1.username.Substring(1);
                user_username.Text = username;
            }
            else
            {
                MessageBox.Show("Username is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?",
                "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?",
                 "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void cashierOrder1_Load(object sender, EventArgs e)
        {
            
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            ToggleVisibility(adminDashboard2, true);
            ToggleVisibility(adminAddProducts1, false);
            ToggleVisibility(cashierCustomersForm1, false);
            ToggleVisibility(cashierOrder1, false);

            AdminDashboard adForm = adminDashboard2 as AdminDashboard;
            adForm?.refreshData(); // Safe call using null conditional operator
        }

        private void addProducts_btn_Click(object sender, EventArgs e)
        {
            ToggleVisibility(adminDashboard2, false);
            ToggleVisibility(adminAddProducts1, true);
            ToggleVisibility(cashierCustomersForm1, false);
            ToggleVisibility(cashierOrder1, false);

            AdminAddProducts apForm = adminAddProducts1 as AdminAddProducts;
            apForm?.refreshData(); // Safe call using null conditional operator
        }

        private void customers_btn_Click(object sender, EventArgs e)
        {
            ToggleVisibility(adminDashboard2, false);
            ToggleVisibility(adminAddProducts1, false);
            ToggleVisibility(cashierCustomersForm1, true);
            ToggleVisibility(cashierOrder1, false);

            CashierCustomersForm ccfForm = cashierCustomersForm1 as CashierCustomersForm;
            ccfForm?.refreshData(); // Safe call using null conditional operator
        }

        private void order_btn_Click(object sender, EventArgs e)
        {
            ToggleVisibility(adminDashboard2, false);
            ToggleVisibility(adminAddProducts1, false);
            ToggleVisibility(cashierCustomersForm1, false);
            ToggleVisibility(cashierOrder1, true);

            CashierOrder coForm = cashierOrder1 as CashierOrder;
            coForm?.refreshData(); // Safe call using null conditional operator
        }

        private void ToggleVisibility(Control control, bool isVisible)
        {
            control.Visible = isVisible;
        }

        private void adminDashboard2_Load(object sender, EventArgs e)
        {
           
        }
    }
}
