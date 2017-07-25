namespace InitechCustomerTracker
{
    partial class EditCustomerForm
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
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.label_company_name = new System.Windows.Forms.Label();
            this.label_address = new System.Windows.Forms.Label();
            this.dateTimePicker1_purchase_date = new System.Windows.Forms.DateTimePicker();
            this.label_purchase_date = new System.Windows.Forms.Label();
            this.textBox_customer_address = new System.Windows.Forms.TextBox();
            this.textBox_customer_name = new System.Windows.Forms.TextBox();
            this.button_add_eticket = new System.Windows.Forms.Button();
            this.button_vmail_ticket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(197, 265);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 0;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // button_save
            // 
            this.button_save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_save.Location = new System.Drawing.Point(115, 265);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 1;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            // 
            // label_company_name
            // 
            this.label_company_name.AutoSize = true;
            this.label_company_name.Location = new System.Drawing.Point(3, 9);
            this.label_company_name.Name = "label_company_name";
            this.label_company_name.Size = new System.Drawing.Size(85, 13);
            this.label_company_name.TabIndex = 2;
            this.label_company_name.Text = "Company Name:";
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Location = new System.Drawing.Point(3, 51);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(48, 13);
            this.label_address.TabIndex = 3;
            this.label_address.Text = "Address:";
            // 
            // dateTimePicker1_purchase_date
            // 
            this.dateTimePicker1_purchase_date.Location = new System.Drawing.Point(6, 178);
            this.dateTimePicker1_purchase_date.Name = "dateTimePicker1_purchase_date";
            this.dateTimePicker1_purchase_date.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1_purchase_date.TabIndex = 4;
            // 
            // label_purchase_date
            // 
            this.label_purchase_date.AutoSize = true;
            this.label_purchase_date.Location = new System.Drawing.Point(7, 162);
            this.label_purchase_date.Name = "label_purchase_date";
            this.label_purchase_date.Size = new System.Drawing.Size(81, 13);
            this.label_purchase_date.TabIndex = 5;
            this.label_purchase_date.Text = "Purchase Date:";
            // 
            // textBox_customer_address
            // 
            this.textBox_customer_address.AcceptsReturn = true;
            this.textBox_customer_address.Location = new System.Drawing.Point(10, 68);
            this.textBox_customer_address.Multiline = true;
            this.textBox_customer_address.Name = "textBox_customer_address";
            this.textBox_customer_address.Size = new System.Drawing.Size(262, 91);
            this.textBox_customer_address.TabIndex = 6;
            // 
            // textBox_customer_name
            // 
            this.textBox_customer_name.Location = new System.Drawing.Point(10, 25);
            this.textBox_customer_name.Name = "textBox_customer_name";
            this.textBox_customer_name.Size = new System.Drawing.Size(262, 20);
            this.textBox_customer_name.TabIndex = 7;
            // 
            // button_add_eticket
            // 
            this.button_add_eticket.Location = new System.Drawing.Point(40, 221);
            this.button_add_eticket.Name = "button_add_eticket";
            this.button_add_eticket.Size = new System.Drawing.Size(106, 26);
            this.button_add_eticket.TabIndex = 9;
            this.button_add_eticket.Text = "Add Email Ticket";
            this.button_add_eticket.UseVisualStyleBackColor = true;
            this.button_add_eticket.Click += new System.EventHandler(this.button_add_eticket_Click);
            // 
            // button_vmail_ticket
            // 
            this.button_vmail_ticket.Location = new System.Drawing.Point(152, 221);
            this.button_vmail_ticket.Name = "button_vmail_ticket";
            this.button_vmail_ticket.Size = new System.Drawing.Size(120, 26);
            this.button_vmail_ticket.TabIndex = 10;
            this.button_vmail_ticket.Text = "Add Voice Mail Ticket";
            this.button_vmail_ticket.UseVisualStyleBackColor = true;
            this.button_vmail_ticket.Click += new System.EventHandler(this.button_vmail_ticket_Click);
            // 
            // EditCustomerForm
            // 
            this.AcceptButton = this.button_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(284, 300);
            this.Controls.Add(this.button_vmail_ticket);
            this.Controls.Add(this.button_add_eticket);
            this.Controls.Add(this.textBox_customer_name);
            this.Controls.Add(this.textBox_customer_address);
            this.Controls.Add(this.label_purchase_date);
            this.Controls.Add(this.dateTimePicker1_purchase_date);
            this.Controls.Add(this.label_address);
            this.Controls.Add(this.label_company_name);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_cancel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditCustomerForm";
            this.Text = "EditCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label_company_name;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_purchase_date;
        private System.Windows.Forms.Label label_purchase_date;
        private System.Windows.Forms.TextBox textBox_customer_address;
        private System.Windows.Forms.TextBox textBox_customer_name;
        private System.Windows.Forms.Button button_add_eticket;
        private System.Windows.Forms.Button button_vmail_ticket;
    }
}