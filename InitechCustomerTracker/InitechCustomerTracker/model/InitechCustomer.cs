using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace InitechCustomerTracker.model
{
    public interface ITicket
    {
        Guid TicketID { get; }
        DateTime ReceievedTime { get; }
        string ContactName { get; }
        bool ResponseMade { get; }
        string ContentOfMessage { get; }
        bool EditTicket();
        XElement GetAsXML();
        string TicketType { get; }
    }

    public abstract class Ticket : ITicket
    {

        public Guid TicketID { get; protected set; }
        public DateTime ReceievedTime { get; protected set; }
        public string ContactName { get; protected set; }
        public bool ResponseMade { get; protected set; }
        public string ContentOfMessage { get; protected set; }

        public abstract bool EditTicket();

        public abstract XElement GetAsXML();
        public abstract string TicketType { get; }
        protected void ParseFromXML(XElement elm)
        {
            XElement e = elm.Descendants("RecievedTime").FirstOrDefault();
            if (e != null)
            {
                long t;
                if (long.TryParse(e.Value, out t))
                {
                    ReceievedTime = new DateTime(t);
                }
            }
            e = elm.Descendants("TicketID").FirstOrDefault();
            if (e != null)
            {
                Guid id;
                if (Guid.TryParse(e.Value, out id))
                {
                    TicketID = id;
                }
                else
                {
                    TicketID = Guid.NewGuid();
                }

            }

            e = elm.Descendants("ContactName").FirstOrDefault();
            if (e != null)
            {
                ContactName = e.Value;
            }
            e = elm.Descendants("ResponseMade").FirstOrDefault();
            if (e != null)
            {
                ResponseMade = (e.Value == "1") ? true : false;
            }
            e = elm.Descendants("Content").FirstOrDefault();
            if (e != null)
            {
                ContentOfMessage = e.Value;
            }
        }
    }

    public class VoiceMail : Ticket
    {
        public string PhoneNumber { get; protected set; }

        public VoiceMail()
        {
            TicketID = Guid.Empty;
            ReceievedTime = DateTime.Now;
        }

        public override string TicketType { get { return "Voice Mail"; } }

        public VoiceMail(XElement elm)
        {
            //          List<XElement> items = elm.Descendants("VMail").ToList();
            if (elm != null)
            {
                ParseFromXML(elm);
                XElement e = elm.Descendants("PhoneNumber").FirstOrDefault();
                if (e != null)
                {
                    PhoneNumber = e.Value;
                }
            }
        }

        public override XElement GetAsXML()
        {
            XElement ticketElement = new XElement("VMail",
      new XElement("TicketID", TicketID.ToString()));
            ticketElement.Add(new XElement("RecievedTime", ReceievedTime.Ticks));
            ticketElement.Add(new XElement("ContactName", ContactName));

            ticketElement.Add(new XElement("ResponseMade", ResponseMade ? "1" : "0"));
            ticketElement.Add(new XElement("Content", ContentOfMessage));

            ticketElement.Add(new XElement("PhoneNumber", PhoneNumber));
            return ticketElement;
        }

        public override bool EditTicket()
        {
            bool result = false;
            VoiceMailTicket dlg = new VoiceMailTicket(this);
            DialogResult dlgResult = dlg.ShowDialog();
            if (dlgResult == DialogResult.OK)
            {
                if (TicketID == Guid.Empty)
                {
                    TicketID = Guid.NewGuid();
                }

                ReceievedTime = dlg.GetRecievedDate();
                ContactName = dlg.ContactName();
                ContentOfMessage = dlg.MessageContent();
                ResponseMade = dlg.HaveResponded();

                PhoneNumber = dlg.GetPhoneNumber();

                result = true;
            }
            else if (dlgResult == DialogResult.Cancel)
            {

            }
            return result;
        }
    }

    public class Email : Ticket
    {
        public string EmailAddress { get; private set; }
        public string EmailSubject { get; private set; }

        public Email()
        {
            TicketID = Guid.Empty;
            ReceievedTime = DateTime.Now;

        }
        public override string TicketType { get { return "EMail"; } }

        public Email(XElement elm)
        {
            if (elm != null)
            {
                ParseFromXML(elm);
                XElement e = elm.Descendants("EmailAddress").FirstOrDefault();
                if (e != null)
                {
                    EmailAddress = e.Value;
                }
                e = elm.Descendants("EmailSubject").FirstOrDefault();
                if (e != null)
                {
                    EmailSubject = e.Value;
                }
            }
        }

        public override XElement GetAsXML()
        {
            XElement ticketElement = new XElement("EMail",
      new XElement("TicketID", TicketID.ToString()));
            ticketElement.Add(new XElement("RecievedTime", ReceievedTime.Ticks));
            ticketElement.Add(new XElement("ContactName", ContactName));

            ticketElement.Add(new XElement("ResponseMade", ResponseMade ? 1 : 0));
            ticketElement.Add(new XElement("Content", ContentOfMessage));

            ticketElement.Add(new XElement("EmailAddress", EmailAddress));
            ticketElement.Add(new XElement("EmailSubject", EmailSubject));
            return ticketElement;
        }

        public override bool EditTicket()
        {
            bool result = false;
            EmailTicketDlg dlg = new EmailTicketDlg(this);
            DialogResult dlgResult = dlg.ShowDialog();
            if (dlgResult == DialogResult.OK)
            {
                if (TicketID == Guid.Empty)
                {
                    TicketID = Guid.NewGuid();
                }
                ReceievedTime = dlg.GetRecievedDate();
                ContactName = dlg.ContactName();
                ContentOfMessage = dlg.MessageContent();
                ResponseMade = dlg.HaveResponded();


                EmailAddress = dlg.EmailAddress();
                EmailSubject = dlg.EmailSubject();

                result = true;
            }
            else if (dlgResult == DialogResult.Cancel)
            {

            }
            return result;
        }
    }

    public class InitechCustomer
    {
        public Guid CustomerID { get; private set; }
        private List<ITicket> _tickets = new List<ITicket>();

        public string CompanyName { get; private set; }
        public string Address { get; private set; }
        public DateTime PurchaseDate { get; private set; }

        public InitechCustomer()
        {
            CustomerID = Guid.NewGuid();
            PurchaseDate = DateTime.Now;
        }

        public InitechCustomer(XElement elm)
        {
            XElement e = elm.Descendants("Address").FirstOrDefault();
            if (e != null)
            {
                Address = e.Value;
            }
            e = elm.Descendants("PurchaseDate").FirstOrDefault();
            if (e != null)
            {
                long t;
                if (long.TryParse(e.Value, out t))
                {
                    PurchaseDate = new DateTime(t);
                }
            }
            e = elm.Descendants("ID").FirstOrDefault();
            if (e != null)
            {
                Guid id;
                if (Guid.TryParse(e.Value, out id))
                {
                    CustomerID = id;
                }
                else
                {
                    CustomerID = Guid.NewGuid();
                }
            }
            e = elm.Descendants("CompanyName").FirstOrDefault();
            if (e != null)
            {
                CompanyName = e.Value;
            }
            List<XElement> tickets = elm.Descendants("VMail").ToList();

            foreach (var t in tickets)
            {
                _tickets.Add(new VoiceMail(t));
            }

            tickets = elm.Descendants("EMail").ToList();
            foreach (var t in tickets)
            {
                _tickets.Add(new Email(t));
            }
        }
        public XElement GetAsXML()
        {
            XElement companyelement = new XElement("Company",
                new XElement("ID", CustomerID.ToString()));
            companyelement.Add(new XElement("CompanyName", CompanyName));
            companyelement.Add(new XElement("Address", Address));
            companyelement.Add(new XElement("PurchaseDate", PurchaseDate.Ticks));
            XElement tickets = new XElement("Tickets");
            foreach (var t in _tickets)
            {
                tickets.Add(t.GetAsXML());
            }
            companyelement.Add(tickets);
            return companyelement;
        }

        public bool EditCustomer()
        {
            bool result = false;
            EditCustomerForm dlg = new EditCustomerForm(this);
            DialogResult dlgResult = dlg.ShowDialog();
            if (dlgResult == DialogResult.OK)
            {
                if (CustomerID == Guid.Empty)
                {
                    CustomerID = Guid.NewGuid();
                }
                CompanyName = dlg.GetCustomerName();
                Address = dlg.GetCustomerAddress();
                PurchaseDate = dlg.GetPurchaseDate();
                result = true;
            }
            else if (dlgResult == DialogResult.Cancel)
            {

            }
            return result;
        }

        public void ShowTicket(Guid ticketID)
        {
            ITicket ticket = _tickets.FirstOrDefault(t => t.TicketID == ticketID);
            if (ticket != null)
            {
                ticket.EditTicket();
            }
        }

        public bool AddEmailTicket()
        {
            Email t = new Email();
            if (t.EditTicket())
            {
                _tickets.Add(t);
                return true;
            }
            return false;
        }
        public bool AddVmailTicket()
        {
            VoiceMail t = new VoiceMail();
            if (t.EditTicket())
            {
                _tickets.Add(t);
                return true;
            }
            return false;
        }

        public List<ITicket> Tickets
        {
            get { return _tickets; }
        }
    }

    public static class Customers
    {
        static List<InitechCustomer> _customers = new List<InitechCustomer>();

        public static void AddCustomer()
        {
            InitechCustomer c = new InitechCustomer();// Garbage collection!
            if (c.EditCustomer())
            {
                _customers.Add(c);
            }
        }

        public static void Save()
        {
            string filename = "";
            var p = Path.GetDirectoryName(Application.ExecutablePath).Replace(@"bin\debug\", string.Empty);
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.InitialDirectory = p;
                // dlg.Multiselect = true;
                DialogResult r = dlg.ShowDialog();
                if (r == DialogResult.OK)
                {
                    if (!dlg.CheckFileExists)
                    {
                        System.IO.FileStream strm = System.IO.File.Create(dlg.FileName);
                        strm.Close();
                    }
                    filename = dlg.FileName;
                    if (String.IsNullOrWhiteSpace(filename))
                    {
                        return;
                    }
                    XDocument doc = new XDocument();
                    XElement root = new XElement("Customers");

                    foreach (var c in _customers)
                    {
                        root.Add(c.GetAsXML());
                    }
                    doc.Add(root);
                    doc.Save(filename);

                }
            }
        }

        public static void Open()
        {
            var p = Path.GetDirectoryName(Application.ExecutablePath).Replace(@"bin\debug\", string.Empty);
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.InitialDirectory = p;
                DialogResult r = dlg.ShowDialog();
                if (r == DialogResult.OK)
                {
                    _customers = XDocument.Load(dlg.FileName)
                        .Descendants("Company")
                        .Select(c => new InitechCustomer(c)).ToList();
                }
            }
        }

        public static List<InitechCustomer> GetCustomers { get { return _customers; } }
    }
}
