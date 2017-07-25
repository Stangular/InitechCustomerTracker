using System;
using System.Diagnostics;
using System.Windows.Forms;
using InitechCustomerTracker.model;

namespace InitechCustomerTracker
{
    public partial class MainForm : Form
    {
        InitechCustomer _selectedCustomer = null;
        public MainForm()
        {
            InitializeComponent();
        }

        private void button_add_customer_Click(object sender, EventArgs e)
        {
            Customers.AddCustomer();
            dataGridView_customers.DataSource = null;
            dataGridView_customers.DataSource = Customers.GetCustomers;


        }

        private void button_open_Click(object sender, EventArgs e)
        {
            Customers.Open();

            dataGridView_customers.DataSource = null;
            dataGridView_customers.DataSource = Customers.GetCustomers;
            dataGridView_customers.AutoGenerateColumns = false;

        }

        private void dataGridView_customers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _selectedCustomer = null;
            try
            {
                var customer = (InitechCustomer)dataGridView_customers.SelectedRows[0].DataBoundItem;
                if (customer != null)
                {
                    dataGridView_tickets.DataSource = null;
                    dataGridView_tickets.DataSource = customer.Tickets;
                    dataGridView_tickets.AutoGenerateColumns = false;

                    customer.EditCustomer();

                    dataGridView_customers.DataSource = null;
                    dataGridView_customers.DataSource = Customers.GetCustomers;
                    dataGridView_customers.AutoGenerateColumns = false;

                    dataGridView_tickets.DataSource = null;
                    dataGridView_tickets.DataSource = customer.Tickets;
                    dataGridView_tickets.AutoGenerateColumns = false;

                    _selectedCustomer = customer;
                }
            }
            catch (System.Exception ex)
            {
                EventLog.WriteEntry("dataGridView_customers_RowHeaderMouseClick", ex.Message);
            }
        }

        private void dataGridView_tickets_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var ITicket = (ITicket)dataGridView_tickets.SelectedRows[0].DataBoundItem;
                if (ITicket != null)
                {
                    ITicket.EditTicket();

                    if (_selectedCustomer != null)
                    {
                        dataGridView_tickets.DataSource = null;
                        dataGridView_tickets.DataSource = _selectedCustomer.Tickets;
                        dataGridView_tickets.AutoGenerateColumns = false;
                    }

                }
            }
            catch (System.Exception ex)
            {
                EventLog.WriteEntry("dataGridView_tickets_RowHeaderMouseClick", ex.Message);
            }


        }

        private void button_save_Click(object sender, EventArgs e)
        {
            Customers.Save();
        }
    }
}
