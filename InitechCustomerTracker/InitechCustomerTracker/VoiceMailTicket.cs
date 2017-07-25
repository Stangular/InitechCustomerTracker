using System;
using System.Windows.Forms;
using InitechCustomerTracker.model;

namespace InitechCustomerTracker
{
    public partial class VoiceMailTicket : Form
    {
        public VoiceMailTicket(VoiceMail ticket = null )
        {
            InitializeComponent();
            if( ticket != null )
            {
                dateTimePicker_vmail_receieved_date.Value = DateTime.Now;
                dateTimePicker_vmail_receieved_date.Value = ticket.ReceievedTime;
                textBox_vmail_contact_name.Text = ticket.ContactName;
                textBox_vmail_content.Text = ticket.ContentOfMessage;
                checkBox_vmail_responded_to.Checked = ticket.ResponseMade;
                textBox_phonenumber.Text = ticket.PhoneNumber;

            }
        }

        public DateTime GetRecievedDate()
        {
            return dateTimePicker_vmail_receieved_date.Value;
        }

        public string ContactName()
        {
            return textBox_vmail_contact_name.Text;
        }

        public string MessageContent()
        {
            return textBox_vmail_content.Text;
        }

        public bool HaveResponded()
        {
            return checkBox_vmail_responded_to.Checked;
        }

        public string GetPhoneNumber()
        {
            return textBox_phonenumber.Text;
        }

    }
}
