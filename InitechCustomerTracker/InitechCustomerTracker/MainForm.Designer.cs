namespace InitechCustomerTracker
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_customers = new System.Windows.Forms.Label();
            this.dataGridView_customers = new System.Windows.Forms.DataGridView();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_add_customer = new System.Windows.Forms.Button();
            this.button_open = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.label_tickets = new System.Windows.Forms.Label();
            this.dataGridView_tickets = new System.Windows.Forms.DataGridView();
            this.TicketType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceievedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResponseMade = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_customers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tickets)).BeginInit();
            this.SuspendLayout();
            // 
            // label_customers
            // 
            this.label_customers.AutoSize = true;
            this.label_customers.Location = new System.Drawing.Point(3, 4);
            this.label_customers.Name = "label_customers";
            this.label_customers.Size = new System.Drawing.Size(56, 13);
            this.label_customers.TabIndex = 0;
            this.label_customers.Text = "Customers";
            // 
            // dataGridView_customers
            // 
            this.dataGridView_customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_customers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CompanyName,
            this.Address,
            this.PurchaseDate});
            this.dataGridView_customers.Location = new System.Drawing.Point(6, 21);
            this.dataGridView_customers.Name = "dataGridView_customers";
            this.dataGridView_customers.Size = new System.Drawing.Size(814, 221);
            this.dataGridView_customers.TabIndex = 1;
            this.dataGridView_customers.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_customers_RowHeaderMouseClick);
            // 
            // CompanyName
            // 
            this.CompanyName.DataPropertyName = "CompanyName";
            this.CompanyName.HeaderText = "Company Name";
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Width = 200;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.Width = 450;
            // 
            // PurchaseDate
            // 
            this.PurchaseDate.DataPropertyName = "PurchaseDate";
            this.PurchaseDate.HeaderText = "PurchaseDate";
            this.PurchaseDate.Name = "PurchaseDate";
            // 
            // button_add_customer
            // 
            this.button_add_customer.Location = new System.Drawing.Point(96, 248);
            this.button_add_customer.Name = "button_add_customer";
            this.button_add_customer.Size = new System.Drawing.Size(84, 26);
            this.button_add_customer.TabIndex = 2;
            this.button_add_customer.Text = "Add Customer";
            this.button_add_customer.UseVisualStyleBackColor = true;
            this.button_add_customer.Click += new System.EventHandler(this.button_add_customer_Click);
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(6, 248);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(84, 26);
            this.button_open.TabIndex = 3;
            this.button_open.Text = "Open";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(186, 248);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(77, 26);
            this.button_save.TabIndex = 4;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label_tickets
            // 
            this.label_tickets.AutoSize = true;
            this.label_tickets.Location = new System.Drawing.Point(3, 277);
            this.label_tickets.Name = "label_tickets";
            this.label_tickets.Size = new System.Drawing.Size(42, 13);
            this.label_tickets.TabIndex = 5;
            this.label_tickets.Text = "Tickets";
            // 
            // dataGridView_tickets
            // 
            this.dataGridView_tickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_tickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TicketType,
            this.ReceievedTime,
            this.ContactName,
            this.ResponseMade});
            this.dataGridView_tickets.Location = new System.Drawing.Point(6, 293);
            this.dataGridView_tickets.Name = "dataGridView_tickets";
            this.dataGridView_tickets.Size = new System.Drawing.Size(814, 150);
            this.dataGridView_tickets.TabIndex = 7;
            this.dataGridView_tickets.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_tickets_RowHeaderMouseClick);
            // 
            // TicketType
            // 
            this.TicketType.DataPropertyName = "TicketType";
            this.TicketType.HeaderText = "Ticket Type";
            this.TicketType.Name = "TicketType";
            // 
            // ReceievedTime
            // 
            this.ReceievedTime.DataPropertyName = "ReceievedTime";
            this.ReceievedTime.HeaderText = "Received";
            this.ReceievedTime.Name = "ReceievedTime";
            // 
            // ContactName
            // 
            this.ContactName.DataPropertyName = "ContactName";
            this.ContactName.HeaderText = "Contact Name";
            this.ContactName.Name = "ContactName";
            this.ContactName.ReadOnly = true;
            // 
            // ResponseMade
            // 
            this.ResponseMade.DataPropertyName = "ResponseMade";
            this.ResponseMade.HeaderText = "Responded";
            this.ResponseMade.Name = "ResponseMade";
            this.ResponseMade.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ResponseMade.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 482);
            this.Controls.Add(this.dataGridView_tickets);
            this.Controls.Add(this.label_tickets);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_open);
            this.Controls.Add(this.button_add_customer);
            this.Controls.Add(this.dataGridView_customers);
            this.Controls.Add(this.label_customers);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_customers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_customers;
        private System.Windows.Forms.DataGridView dataGridView_customers;
        private System.Windows.Forms.Button button_add_customer;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseDate;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label_tickets;
        private System.Windows.Forms.DataGridView dataGridView_tickets;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceievedTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ResponseMade;
    }
}

