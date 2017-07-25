using System;
using System.Windows.Forms;
using InitechCustomerTracker.model;

namespace InitechCustomerTracker
{
    public partial class EmailTicketDlg : Form
    {
        public EmailTicketDlg( Email ticket = null )
        {
            InitializeComponent();
            dateTimePicker_receieved_date.Value = DateTime.Now;
            if (ticket != null)
            {
                dateTimePicker_receieved_date.Value = ticket.ReceievedTime;
                textBox_email_contact_name.Text = ticket.ContactName;
                textBox_email_content.Text = ticket.ContentOfMessage;
                checkBox_responded_to.Checked = ticket.ResponseMade;
                textBox_email_address.Text = ticket.EmailAddress;
                textBox_email_subject.Text = ticket.EmailSubject;
            }
        }

        public DateTime GetRecievedDate()
        {
            return dateTimePicker_receieved_date.Value;
        }

        public string ContactName()
        {
            return textBox_email_contact_name.Text;
        }

        public string MessageContent()
        {
            return textBox_email_content.Text;
        }

        public bool HaveResponded()
        {
            return checkBox_responded_to.Checked;
        }

        public string EmailAddress()
        {
            return textBox_email_address.Text;
        }

        public string EmailSubject()
        {
            return textBox_email_subject.Text;
        }
    }
}
