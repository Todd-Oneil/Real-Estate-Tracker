
namespace RealEstate
{
    partial class Dashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.topPanel = new System.Windows.Forms.Panel();
            this.greetingLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.propertyList = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.downPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.term = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mortPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condoFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mgmtFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utilities = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profitLoss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propertyList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.topPanel.Controls.Add(this.greetingLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1226, 100);
            this.topPanel.TabIndex = 0;
            // 
            // greetingLabel
            // 
            this.greetingLabel.AutoSize = true;
            this.greetingLabel.BackColor = System.Drawing.Color.Black;
            this.greetingLabel.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.greetingLabel.ForeColor = System.Drawing.Color.White;
            this.greetingLabel.Location = new System.Drawing.Point(524, 31);
            this.greetingLabel.Name = "greetingLabel";
            this.greetingLabel.Size = new System.Drawing.Size(136, 37);
            this.greetingLabel.TabIndex = 0;
            this.greetingLabel.Text = "Welcome";
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.Controls.Add(this.propertyList);
            this.mainPanel.Location = new System.Drawing.Point(143, 129);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1048, 364);
            this.mainPanel.TabIndex = 0;
            // 
            // propertyList
            // 
            this.propertyList.AllowUserToAddRows = false;
            this.propertyList.AllowUserToDeleteRows = false;
            this.propertyList.AllowUserToResizeColumns = false;
            this.propertyList.AllowUserToResizeRows = false;
            this.propertyList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyList.BackgroundColor = System.Drawing.Color.White;
            this.propertyList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.propertyList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.propertyList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.City,
            this.Address,
            this.listPrice,
            this.downPayment,
            this.rate,
            this.term,
            this.mortPayment,
            this.rent,
            this.condoFee,
            this.mgmtFee,
            this.utilities,
            this.propTax,
            this.profitLoss});
            this.propertyList.GridColor = System.Drawing.Color.White;
            this.propertyList.Location = new System.Drawing.Point(23, 22);
            this.propertyList.MultiSelect = false;
            this.propertyList.Name = "propertyList";
            this.propertyList.ReadOnly = true;
            this.propertyList.RowHeadersVisible = false;
            this.propertyList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.propertyList.RowTemplate.Height = 25;
            this.propertyList.ShowEditingIcon = false;
            this.propertyList.Size = new System.Drawing.Size(1001, 320);
            this.propertyList.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.ID.DefaultCellStyle = dataGridViewCellStyle1;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // City
            // 
            this.City.DataPropertyName = "city";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.City.DefaultCellStyle = dataGridViewCellStyle2;
            this.City.HeaderText = "City";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "address";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.Address.DefaultCellStyle = dataGridViewCellStyle3;
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // listPrice
            // 
            this.listPrice.DataPropertyName = "asking_price";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.listPrice.DefaultCellStyle = dataGridViewCellStyle4;
            this.listPrice.HeaderText = "List Price";
            this.listPrice.Name = "listPrice";
            this.listPrice.ReadOnly = true;
            // 
            // downPayment
            // 
            this.downPayment.DataPropertyName = "down_payment";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.downPayment.DefaultCellStyle = dataGridViewCellStyle5;
            this.downPayment.HeaderText = "Down Payment";
            this.downPayment.Name = "downPayment";
            this.downPayment.ReadOnly = true;
            // 
            // rate
            // 
            this.rate.DataPropertyName = "mortgage_rate";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.rate.DefaultCellStyle = dataGridViewCellStyle6;
            this.rate.HeaderText = "Mortgage Rate";
            this.rate.Name = "rate";
            this.rate.ReadOnly = true;
            // 
            // term
            // 
            this.term.DataPropertyName = "mortgage_term";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.term.DefaultCellStyle = dataGridViewCellStyle7;
            this.term.HeaderText = "Mortgage Term";
            this.term.Name = "term";
            this.term.ReadOnly = true;
            // 
            // mortPayment
            // 
            this.mortPayment.DataPropertyName = "mortgage_payment";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.mortPayment.DefaultCellStyle = dataGridViewCellStyle8;
            this.mortPayment.HeaderText = "Mortgage Payment";
            this.mortPayment.Name = "mortPayment";
            this.mortPayment.ReadOnly = true;
            // 
            // rent
            // 
            this.rent.DataPropertyName = "total_monthly_rent";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            this.rent.DefaultCellStyle = dataGridViewCellStyle9;
            this.rent.HeaderText = "Monthly Rent";
            this.rent.Name = "rent";
            this.rent.ReadOnly = true;
            // 
            // condoFee
            // 
            this.condoFee.DataPropertyName = "monthly_condo_fees";
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.condoFee.DefaultCellStyle = dataGridViewCellStyle10;
            this.condoFee.HeaderText = "Condo Fee";
            this.condoFee.Name = "condoFee";
            this.condoFee.ReadOnly = true;
            // 
            // mgmtFee
            // 
            this.mgmtFee.DataPropertyName = "monthly_mgmt_fee";
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            this.mgmtFee.DefaultCellStyle = dataGridViewCellStyle11;
            this.mgmtFee.HeaderText = "Management Fee";
            this.mgmtFee.Name = "mgmtFee";
            this.mgmtFee.ReadOnly = true;
            // 
            // utilities
            // 
            this.utilities.DataPropertyName = "monthly_utilities";
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            this.utilities.DefaultCellStyle = dataGridViewCellStyle12;
            this.utilities.HeaderText = "Utilities";
            this.utilities.Name = "utilities";
            this.utilities.ReadOnly = true;
            // 
            // propTax
            // 
            this.propTax.DataPropertyName = "monthly_prop_tax";
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            this.propTax.DefaultCellStyle = dataGridViewCellStyle13;
            this.propTax.HeaderText = "Property Tax";
            this.propTax.Name = "propTax";
            this.propTax.ReadOnly = true;
            // 
            // profitLoss
            // 
            this.profitLoss.DataPropertyName = "monthly_profit_loss";
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            this.profitLoss.DefaultCellStyle = dataGridViewCellStyle14;
            this.profitLoss.HeaderText = "Profit / Loss";
            this.profitLoss.Name = "profitLoss";
            this.profitLoss.ReadOnly = true;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.addButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(0, 48);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(137, 28);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add Property";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.panel1.Controls.Add(this.logoutBtn);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 404);
            this.panel1.TabIndex = 1;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.logoutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.Location = new System.Drawing.Point(0, 364);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(137, 28);
            this.logoutBtn.TabIndex = 0;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 504);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.Shown += new System.EventHandler(this.Dashboard_Shown);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.propertyList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label greetingLabel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.DataGridView propertyList;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn listPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn downPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn term;
        private System.Windows.Forms.DataGridViewTextBoxColumn mortPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn rent;
        private System.Windows.Forms.DataGridViewTextBoxColumn condoFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn mgmtFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn utilities;
        private System.Windows.Forms.DataGridViewTextBoxColumn propTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn profitLoss;
    }
}