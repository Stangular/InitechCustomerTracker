namespace InitechCustomerTracker
{
    partial class EmailTicketDlg
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
            this.button_save_ticket = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.dateTimePicker_receieved_date = new System.Windows.Forms.DateTimePicker();
            this.textBox_email_contact_name = new System.Windows.Forms.TextBox();
            this.checkBox_responded_to = new System.Windows.Forms.CheckBox();
            this.textBox_email_content = new System.Windows.Forms.TextBox();
            this.label_receivedTime = new System.Windows.Forms.Label();
            this.label_email_content = new System.Windows.Forms.Label();
            this.label_email_contact_name = new System.Windows.Forms.Label();
            this.label_email_subject = new System.Windows.Forms.Label();
            this.label_email_address = new System.Windows.Forms.Label();
            this.textBox_email_address = new System.Windows.Forms.TextBox();
            this.textBox_email_subject = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_save_ticket
            // 
            this.button_save_ticket.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_save_ticket.Location = new System.Drawing.Point(232, 417);
            this.button_save_ticket.Name = "button_save_ticket";
            this.button_save_ticket.Size = new System.Drawing.Size(75, 23);
            this.button_save_ticket.TabIndex = 0;
            this.button_save_ticket.Text = "Save";
            this.button_save_ticket.UseVisualStyleBackColor = true;
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(313, 417);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 1;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_receieved_date
            // 
            this.dateTimePicker_receieved_date.Location = new System.Drawing.Point(4, 29);
            this.dateTimePicker_receieved_date.Name = "dateTimePicker_receieved_date";
            this.dateTimePicker_receieved_date.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_receieved_date.TabIndex = 2;
            // 
            // textBox_email_contact_name
            // 
            this.textBox_email_contact_name.Location = new System.Drawing.Point(4, 77);
            this.textBox_email_contact_name.Name = "textBox_email_contact_name";
            this.textBox_email_contact_name.Size = new System.Drawing.Size(376, 20);
            this.textBox_email_contact_name.TabIndex = 3;
            // 
            // checkBox_responded_to
            // 
            this.checkBox_responded_to.AutoSize = true;
            this.checkBox_responded_to.Location = new System.Drawing.Point(233, 34);
            this.checkBox_responded_to.Name = "checkBox_responded_to";
            this.checkBox_responded_to.Size = new System.Drawing.Size(81, 17);
            this.checkBox_responded_to.TabIndex = 4;
            this.checkBox_responded_to.Text = "Responded";
            this.checkBox_responded_to.UseVisualStyleBackColor = true;
            // 
            // textBox_email_content
            // 
            this.textBox_email_content.AcceptsReturn = true;
            this.textBox_email_content.Location = new System.Drawing.Point(4, 123);
            this.textBox_email_content.Multiline = true;
            this.textBox_email_content.Name = "textBox_email_content";
            this.textBox_email_content.Size = new System.Drawing.Size(376, 121);
            this.textBox_email_content.TabIndex = 5;
            // 
            // label_receivedTime
            // 
            this.label_receivedTime.AutoSize = true;
            this.label_receivedTime.Location = new System.Drawing.Point(1, 9);
            this.label_receivedTime.Name = "label_receivedTime";
            this.label_receivedTime.Size = new System.Drawing.Size(79, 13);
            this.label_receivedTime.TabIndex = 6;
            this.label_receivedTime.Text = "Received Time";
            // 
            // label_email_content
            // 
            this.label_email_content.AutoSize = true;
            this.label_email_content.Location = new System.Drawing.Point(1, 107);
            this.label_email_content.Name = "label_email_content";
            this.label_email_content.Size = new System.Drawing.Size(44, 13);
            this.label_email_content.TabIndex = 7;
            this.label_email_content.Text = "Content";
            // 
            // label_email_contact_name
            // 
            this.label_email_contact_name.AutoSize = true;
            this.label_email_contact_name.Location = new System.Drawing.Point(1, 61);
            this.label_email_contact_name.Name = "label_email_contact_name";
            this.label_email_contact_name.Size = new System.Drawing.Size(75, 13);
            this.label_email_contact_name.TabIndex = 8;
            this.label_email_contact_name.Text = "Contact Name";
            // 
            // label_email_subject
            // 
            this.label_email_subject.AutoSize = true;
            this.label_email_subject.Location = new System.Drawing.Point(1, 309);
            this.label_email_subject.Name = "label_email_subject";
            this.label_email_subject.Size = new System.Drawing.Size(71, 13);
            this.label_email_subject.TabIndex = 9;
            this.label_email_subject.Text = "Email Subject";
            // 
            // label_email_address
            // 
            this.label_email_address.AutoSize = true;
            this.label_email_address.Location = new System.Drawing.Point(1, 260);
            this.label_email_address.Name = "label_email_address";
            this.label_email_address.Size = new System.Drawing.Size(73, 13);
            this.label_email_address.TabIndex = 10;
            this.label_email_address.Text = "Email Address";
            // 
            // textBox_email_address
            // 
            this.textBox_email_address.Location = new System.Drawing.Point(6, 276);
            this.textBox_email_address.Name = "textBox_email_address";
            this.textBox_email_address.Size = new System.Drawing.Size(374, 20);
            this.textBox_email_address.TabIndex = 11;
            // 
            // textBox_email_subject
            // 
            this.textBox_email_subject.Location = new System.Drawing.Point(4, 325);
            this.textBox_email_subject.Name = "textBox_email_subject";
            this.textBox_email_subject.Size = new System.Drawing.Size(375, 20);
            this.textBox_email_subject.TabIndex = 12;
            // 
            // EmailTicketDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 452);
            this.Controls.Add(this.textBox_email_subject);
            this.Controls.Add(this.textBox_email_address);
            this.Controls.Add(this.label_email_address);
            this.Controls.Add(this.label_email_subject);
            this.Controls.Add(this.label_email_contact_name);
            this.Controls.Add(this.label_email_content);
            this.Controls.Add(this.label_receivedTime);
            this.Controls.Add(this.textBox_email_content);
            this.Controls.Add(this.checkBox_responded_to);
            this.Controls.Add(this.textBox_email_contact_name);
            this.Controls.Add(this.dateTimePicker_receieved_date);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_save_ticket);
            this.Name = "EmailTicketDlg";
            this.Text = "TicketDlg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_save_ticket;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.DateTimePicker dateTimePicker_receieved_date;
        private System.Windows.Forms.TextBox textBox_email_contact_name;
        private System.Windows.Forms.CheckBox checkBox_responded_to;
        private System.Windows.Forms.TextBox textBox_email_content;
        private System.Windows.Forms.Label label_receivedTime;
        private System.Windows.Forms.Label label_email_content;
        private System.Windows.Forms.Label label_email_contact_name;
        private System.Windows.Forms.Label label_email_subject;
        private System.Windows.Forms.Label label_email_address;
        private System.Windows.Forms.TextBox textBox_email_address;
        private System.Windows.Forms.TextBox textBox_email_subject;
    }
}