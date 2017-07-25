using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InitechCustomerTracker.model;

namespace InitechCustomerTracker
{
    public partial class EditCustomerForm : Form
    {
        InitechCustomer _customer = null;
        public EditCustomerForm(InitechCustomer customer = null)
        {
            InitializeComponent();
            if (customer != null)
            {
                textBox_customer_name.Text = customer.CompanyName;
                textBox_customer_address.Text = customer.Address;
                dateTimePicker1_purchase_date.Value = customer.PurchaseDate;
                _customer = customer;
            }
        }

        public string GetCustomerName()
        {
            return textBox_customer_name.Text;
        }

        public string GetCustomerAddress()
        {
            return textBox_customer_address.Text;
        }

        public DateTime GetPurchaseDate()
        {
            return dateTimePicker1_purchase_date.Value;
        }

        private void button_add_eticket_Click(object sender, EventArgs e)
        {
            _customer.AddEmailTicket();
        }

        private void button_vmail_ticket_Click(object sender, EventArgs e)
        {
            _customer.AddVmailTicket();
        }
    }
}
