namespace InitechCustomerTracker
{
    partial class VoiceMailTicket
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
            this.label_email_contact_name = new System.Windows.Forms.Label();
            this.label_email_content = new System.Windows.Forms.Label();
            this.label_receivedTime = new System.Windows.Forms.Label();
            this.textBox_vmail_content = new System.Windows.Forms.TextBox();
            this.checkBox_vmail_responded_to = new System.Windows.Forms.CheckBox();
            this.textBox_vmail_contact_name = new System.Windows.Forms.TextBox();
            this.dateTimePicker_vmail_receieved_date = new System.Windows.Forms.DateTimePicker();
            this.label_PhoneNumber = new System.Windows.Forms.Label();
            this.textBox_phonenumber = new System.Windows.Forms.TextBox();
            this.button_vmail_cancel = new System.Windows.Forms.Button();
            this.button_save_vticket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_email_contact_name
            // 
            this.label_email_contact_name.AutoSize = true;
            this.label_email_contact_name.Location = new System.Drawing.Point(12, 61);
            this.label_email_contact_name.Name = "label_email_contact_name";
            this.label_email_contact_name.Size = new System.Drawing.Size(75, 13);
            this.label_email_contact_name.TabIndex = 15;
            this.label_email_contact_name.Text = "Contact Name";
            // 
            // label_email_content
            // 
            this.label_email_content.AutoSize = true;
            this.label_email_content.Location = new System.Drawing.Point(12, 107);
            this.label_email_content.Name = "label_email_content";
            this.label_email_content.Size = new System.Drawing.Size(44, 13);
            this.label_email_content.TabIndex = 14;
            this.label_email_content.Text = "Content";
            // 
            // label_receivedTime
            // 
            this.label_receivedTime.AutoSize = true;
            this.label_receivedTime.Location = new System.Drawing.Point(12, 9);
            this.label_receivedTime.Name = "label_receivedTime";
            this.label_receivedTime.Size = new System.Drawing.Size(79, 13);
            this.label_receivedTime.TabIndex = 13;
            this.label_receivedTime.Text = "Received Time";
            // 
            // textBox_vmail_content
            // 
            this.textBox_vmail_content.AcceptsReturn = true;
            this.textBox_vmail_content.Location = new System.Drawing.Point(15, 123);
            this.textBox_vmail_content.Multiline = true;
            this.textBox_vmail_content.Name = "textBox_vmail_content";
            this.textBox_vmail_content.Size = new System.Drawing.Size(376, 121);
            this.textBox_vmail_content.TabIndex = 12;
            // 
            // checkBox_vmail_responded_to
            // 
            this.checkBox_vmail_responded_to.AutoSize = true;
            this.checkBox_vmail_responded_to.Location = new System.Drawing.Point(244, 34);
            this.checkBox_vmail_responded_to.Name = "checkBox_vmail_responded_to";
            this.checkBox_vmail_responded_to.Size = new System.Drawing.Size(81, 17);
            this.checkBox_vmail_responded_to.TabIndex = 11;
            this.checkBox_vmail_responded_to.Text = "Responded";
            this.checkBox_vmail_responded_to.UseVisualStyleBackColor = true;
            // 
            // textBox_vmail_contact_name
            // 
            this.textBox_vmail_contact_name.Location = new System.Drawing.Point(15, 77);
            this.textBox_vmail_contact_name.Name = "textBox_vmail_contact_name";
            this.textBox_vmail_contact_name.Size = new System.Drawing.Size(376, 20);
            this.textBox_vmail_contact_name.TabIndex = 10;
            // 
            // dateTimePicker_vmail_receieved_date
            // 
            this.dateTimePicker_vmail_receieved_date.Location = new System.Drawing.Point(15, 29);
            this.dateTimePicker_vmail_receieved_date.Name = "dateTimePicker_vmail_receieved_date";
            this.dateTimePicker_vmail_receieved_date.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_vmail_receieved_date.TabIndex = 9;
            // 
            // label_PhoneNumber
            // 
            this.label_PhoneNumber.AutoSize = true;
            this.label_PhoneNumber.Location = new System.Drawing.Point(16, 263);
            this.label_PhoneNumber.Name = "label_PhoneNumber";
            this.label_PhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.label_PhoneNumber.TabIndex = 16;
            this.label_PhoneNumber.Text = "Phone Number";
            // 
            // textBox_phonenumber
            // 
            this.textBox_phonenumber.Location = new System.Drawing.Point(15, 291);
            this.textBox_phonenumber.Name = "textBox_phonenumber";
            this.textBox_phonenumber.Size = new System.Drawing.Size(376, 20);
            this.textBox_phonenumber.TabIndex = 17;
            // 
            // button_vmail_cancel
            // 
            this.button_vmail_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_vmail_cancel.Location = new System.Drawing.Point(311, 371);
            this.button_vmail_cancel.Name = "button_vmail_cancel";
            this.button_vmail_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_vmail_cancel.TabIndex = 19;
            this.button_vmail_cancel.Text = "Cancel";
            this.button_vmail_cancel.UseVisualStyleBackColor = true;
            // 
            // button_save_vticket
            // 
            this.button_save_vticket.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_save_vticket.Location = new System.Drawing.Point(221, 371);
            this.button_save_vticket.Name = "button_save_vticket";
            this.button_save_vticket.Size = new System.Drawing.Size(75, 23);
            this.button_save_vticket.TabIndex = 18;
            this.button_save_vticket.Text = "Save";
            this.button_save_vticket.UseVisualStyleBackColor = true;
            // 
            // VoiceMailTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 406);
            this.Controls.Add(this.button_vmail_cancel);
            this.Controls.Add(this.button_save_vticket);
            this.Controls.Add(this.textBox_phonenumber);
            this.Controls.Add(this.label_PhoneNumber);
            this.Controls.Add(this.label_email_contact_name);
            this.Controls.Add(this.label_email_content);
            this.Controls.Add(this.label_receivedTime);
            this.Controls.Add(this.textBox_vmail_content);
            this.Controls.Add(this.checkBox_vmail_responded_to);
            this.Controls.Add(this.textBox_vmail_contact_name);
            this.Controls.Add(this.dateTimePicker_vmail_receieved_date);
            this.Name = "VoiceMailTicket";
            this.Text = "VoiceMailTicket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_email_contact_name;
        private System.Windows.Forms.Label label_email_content;
        private System.Windows.Forms.Label label_receivedTime;
        private System.Windows.Forms.TextBox textBox_vmail_content;
        private System.Windows.Forms.CheckBox checkBox_vmail_responded_to;
        private System.Windows.Forms.TextBox textBox_vmail_contact_name;
        private System.Windows.Forms.DateTimePicker dateTimePicker_vmail_receieved_date;
        private System.Windows.Forms.Label label_PhoneNumber;
        private System.Windows.Forms.TextBox textBox_phonenumber;
        private System.Windows.Forms.Button button_vmail_cancel;
        private System.Windows.Forms.Button button_save_vticket;
    }
}