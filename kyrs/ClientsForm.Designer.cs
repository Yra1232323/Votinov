namespace kyrs
{
    partial class ClientsForm
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
            this.listBoxClients = new System.Windows.Forms.ListBox();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblClientEmail = new System.Windows.Forms.Label();
            this.lblClientPhone = new System.Windows.Forms.Label();
            this.txtNewClientName = new System.Windows.Forms.TextBox();
            this.txtNewClientContact = new System.Windows.Forms.TextBox();
            this.txtNewClientEmail = new System.Windows.Forms.TextBox();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnUpdateClient = new System.Windows.Forms.Button();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxClients
            // 
            this.listBoxClients.FormattingEnabled = true;
            this.listBoxClients.Location = new System.Drawing.Point(12, 12);
            this.listBoxClients.Name = "listBoxClients";
            this.listBoxClients.Size = new System.Drawing.Size(232, 238);
            this.listBoxClients.TabIndex = 0;
            this.listBoxClients.SelectedIndexChanged += new System.EventHandler(this.ListBoxClients_SelectedIndexChanged);
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(250, 20);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(73, 13);
            this.lblClientName.TabIndex = 1;
            this.lblClientName.Text = "Имя клиента";
            // 
            // lblClientEmail
            // 
            this.lblClientEmail.AutoSize = true;
            this.lblClientEmail.Location = new System.Drawing.Point(250, 60);
            this.lblClientEmail.Name = "lblClientEmail";
            this.lblClientEmail.Size = new System.Drawing.Size(81, 13);
            this.lblClientEmail.TabIndex = 2;
            this.lblClientEmail.Text = "Почта клиента";
            // 
            // lblClientPhone
            // 
            this.lblClientPhone.AutoSize = true;
            this.lblClientPhone.Location = new System.Drawing.Point(250, 100);
            this.lblClientPhone.Name = "lblClientPhone";
            this.lblClientPhone.Size = new System.Drawing.Size(85, 13);
            this.lblClientPhone.TabIndex = 3;
            this.lblClientPhone.Text = "Номер клиента";
            // 
            // txtNewClientName
            // 
            this.txtNewClientName.Location = new System.Drawing.Point(356, 146);
            this.txtNewClientName.Name = "txtNewClientName";
            this.txtNewClientName.Size = new System.Drawing.Size(100, 20);
            this.txtNewClientName.TabIndex = 4;
            // 
            // txtNewClientContact
            // 
            this.txtNewClientContact.Location = new System.Drawing.Point(356, 189);
            this.txtNewClientContact.Name = "txtNewClientContact";
            this.txtNewClientContact.Size = new System.Drawing.Size(100, 20);
            this.txtNewClientContact.TabIndex = 5;
            // 
            // txtNewClientEmail
            // 
            this.txtNewClientEmail.Location = new System.Drawing.Point(356, 229);
            this.txtNewClientEmail.Name = "txtNewClientEmail";
            this.txtNewClientEmail.Size = new System.Drawing.Size(100, 20);
            this.txtNewClientEmail.TabIndex = 6;
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(250, 140);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(100, 30);
            this.btnAddClient.TabIndex = 1;
            this.btnAddClient.Text = "Добавить клиента";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.Location = new System.Drawing.Point(250, 180);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(100, 30);
            this.btnUpdateClient.TabIndex = 2;
            this.btnUpdateClient.Text = "Обновить клиента";
            this.btnUpdateClient.UseVisualStyleBackColor = true;
            this.btnUpdateClient.Click += new System.EventHandler(this.btnUpdateClient_Click);
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Location = new System.Drawing.Point(250, 220);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(100, 30);
            this.btnDeleteClient.TabIndex = 3;
            this.btnDeleteClient.Text = "Удалить клиента";
            this.btnDeleteClient.UseVisualStyleBackColor = true;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Имя клиента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Номер клиента";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Почта клиента";
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kyrs.Properties.Resources.fon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteClient);
            this.Controls.Add(this.btnUpdateClient);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.txtNewClientEmail);
            this.Controls.Add(this.txtNewClientContact);
            this.Controls.Add(this.txtNewClientName);
            this.Controls.Add(this.lblClientPhone);
            this.Controls.Add(this.lblClientEmail);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.listBoxClients);
            this.Name = "ClientsForm";
            this.ShowIcon = false;
            this.Text = "Клиенты";
            this.Load += new System.EventHandler(this.ClientsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxClients;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblClientEmail;
        private System.Windows.Forms.Label lblClientPhone;
        private System.Windows.Forms.TextBox txtNewClientName;
        private System.Windows.Forms.TextBox txtNewClientContact;
        private System.Windows.Forms.TextBox txtNewClientEmail;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnUpdateClient;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}