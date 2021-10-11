
namespace Interface
{
    partial class Form1
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
            this.btnCreateContact = new System.Windows.Forms.Button();
            this.btnDeleteContact = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dgvContacts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateContact
            // 
            this.btnCreateContact.Location = new System.Drawing.Point(380, 165);
            this.btnCreateContact.Name = "btnCreateContact";
            this.btnCreateContact.Size = new System.Drawing.Size(75, 23);
            this.btnCreateContact.TabIndex = 0;
            this.btnCreateContact.Text = "Create";
            this.btnCreateContact.UseVisualStyleBackColor = true;
            this.btnCreateContact.Click += new System.EventHandler(this.btnCreateContact_Click);
            // 
            // btnDeleteContact
            // 
            this.btnDeleteContact.Location = new System.Drawing.Point(380, 195);
            this.btnDeleteContact.Name = "btnDeleteContact";
            this.btnDeleteContact.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteContact.TabIndex = 1;
            this.btnDeleteContact.Text = "Delete";
            this.btnDeleteContact.UseVisualStyleBackColor = true;
            this.btnDeleteContact.Click += new System.EventHandler(this.btnDeleteContact_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(130, 105);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 22);
            this.txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(130, 133);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 22);
            this.txtLastName.TabIndex = 2;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(130, 161);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 22);
            this.txtPhone.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(130, 77);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 3;
            // 
            // dgvContacts
            // 
            this.dgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContacts.Location = new System.Drawing.Point(101, 248);
            this.dgvContacts.Name = "dgvContacts";
            this.dgvContacts.RowHeadersWidth = 51;
            this.dgvContacts.RowTemplate.Height = 24;
            this.dgvContacts.Size = new System.Drawing.Size(626, 190);
            this.dgvContacts.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvContacts);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnDeleteContact);
            this.Controls.Add(this.btnCreateContact);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateContact;
        private System.Windows.Forms.Button btnDeleteContact;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView dgvContacts;
    }
}

