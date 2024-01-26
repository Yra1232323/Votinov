namespace kyrs
{
    partial class ServicesForm
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
            this.listBoxServices = new System.Windows.Forms.ListBox();
            this.lblServiceName = new System.Windows.Forms.Label();
            this.lblServiceDescription = new System.Windows.Forms.Label();
            this.lblServicePrice = new System.Windows.Forms.Label();
            this.txtNewServiceName = new System.Windows.Forms.TextBox();
            this.txtNewServiceDescription = new System.Windows.Forms.TextBox();
            this.txtNewServicePrice = new System.Windows.Forms.TextBox();
            this.btnAddService = new System.Windows.Forms.Button();
            this.btnUpdateService = new System.Windows.Forms.Button();
            this.btnDeleteService = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxServices
            // 
            this.listBoxServices.FormattingEnabled = true;
            this.listBoxServices.Location = new System.Drawing.Point(12, 32);
            this.listBoxServices.Name = "listBoxServices";
            this.listBoxServices.Size = new System.Drawing.Size(220, 147);
            this.listBoxServices.TabIndex = 0;
            // 
            // lblServiceName
            // 
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.Location = new System.Drawing.Point(12, 13);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(87, 13);
            this.lblServiceName.TabIndex = 1;
            this.lblServiceName.Text = "Название услуг";
            // 
            // lblServiceDescription
            // 
            this.lblServiceDescription.AutoSize = true;
            this.lblServiceDescription.Location = new System.Drawing.Point(247, 64);
            this.lblServiceDescription.Name = "lblServiceDescription";
            this.lblServiceDescription.Size = new System.Drawing.Size(118, 13);
            this.lblServiceDescription.TabIndex = 2;
            this.lblServiceDescription.Text = "Информация о услуге";
            // 
            // lblServicePrice
            // 
            this.lblServicePrice.AutoSize = true;
            this.lblServicePrice.Location = new System.Drawing.Point(247, 32);
            this.lblServicePrice.Name = "lblServicePrice";
            this.lblServicePrice.Size = new System.Drawing.Size(33, 13);
            this.lblServicePrice.TabIndex = 3;
            this.lblServicePrice.Text = "Цена";
            // 
            // txtNewServiceName
            // 
            this.txtNewServiceName.Location = new System.Drawing.Point(12, 195);
            this.txtNewServiceName.Name = "txtNewServiceName";
            this.txtNewServiceName.Size = new System.Drawing.Size(100, 20);
            this.txtNewServiceName.TabIndex = 4;
            // 
            // txtNewServiceDescription
            // 
            this.txtNewServiceDescription.Location = new System.Drawing.Point(12, 222);
            this.txtNewServiceDescription.Name = "txtNewServiceDescription";
            this.txtNewServiceDescription.Size = new System.Drawing.Size(100, 20);
            this.txtNewServiceDescription.TabIndex = 5;
            // 
            // txtNewServicePrice
            // 
            this.txtNewServicePrice.Location = new System.Drawing.Point(12, 248);
            this.txtNewServicePrice.Name = "txtNewServicePrice";
            this.txtNewServicePrice.Size = new System.Drawing.Size(100, 20);
            this.txtNewServicePrice.TabIndex = 6;
            // 
            // btnAddService
            // 
            this.btnAddService.Location = new System.Drawing.Point(12, 274);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(75, 23);
            this.btnAddService.TabIndex = 7;
            this.btnAddService.Text = "Добавить";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // btnUpdateService
            // 
            this.btnUpdateService.Location = new System.Drawing.Point(12, 303);
            this.btnUpdateService.Name = "btnUpdateService";
            this.btnUpdateService.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateService.TabIndex = 8;
            this.btnUpdateService.Text = "Обновить";
            this.btnUpdateService.UseVisualStyleBackColor = true;
            this.btnUpdateService.Click += new System.EventHandler(this.btnUpdateService_Click);
            // 
            // btnDeleteService
            // 
            this.btnDeleteService.Location = new System.Drawing.Point(12, 332);
            this.btnDeleteService.Name = "btnDeleteService";
            this.btnDeleteService.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteService.TabIndex = 9;
            this.btnDeleteService.Text = "Удалить";
            this.btnDeleteService.UseVisualStyleBackColor = true;
            this.btnDeleteService.Click += new System.EventHandler(this.btnDeleteService_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Название услуги";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Информация о услуге";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Цена услуги";
            // 
            // ServicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kyrs.Properties.Resources.fon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(775, 442);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteService);
            this.Controls.Add(this.btnUpdateService);
            this.Controls.Add(this.btnAddService);
            this.Controls.Add(this.txtNewServicePrice);
            this.Controls.Add(this.txtNewServiceDescription);
            this.Controls.Add(this.txtNewServiceName);
            this.Controls.Add(this.lblServicePrice);
            this.Controls.Add(this.lblServiceDescription);
            this.Controls.Add(this.lblServiceName);
            this.Controls.Add(this.listBoxServices);
            this.Name = "ServicesForm";
            this.ShowIcon = false;
            this.Text = "Услуги";
            this.Load += new System.EventHandler(this.ServicesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxServices;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.Label lblServiceDescription;
        private System.Windows.Forms.Label lblServicePrice;
        private System.Windows.Forms.TextBox txtNewServiceName;
        private System.Windows.Forms.TextBox txtNewServiceDescription;
        private System.Windows.Forms.TextBox txtNewServicePrice;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.Button btnUpdateService;
        private System.Windows.Forms.Button btnDeleteService;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}