namespace ClassProyecto
{
    partial class FormAdminPanel
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            gbUsers = new GroupBox();
            dgvUsers = new DataGridView();
            btnDeleteUser = new Button();
            btnAddUser = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            txtLastName = new TextBox();
            txtName = new TextBox();
            lblPassword = new Label();
            lblUsername = new Label();
            lblLastName = new Label();
            lblName = new Label();
            gbProducts = new GroupBox();
            dgvProducts = new DataGridView();
            btnDeleteProduct = new Button();
            btnAddProduct = new Button();
            nudDietId = new NumericUpDown();
            nudPeopleId = new NumericUpDown();
            nudPrice = new NumericUpDown();
            txtProductName = new TextBox();
            lblDietId = new Label();
            lblPeopleId = new Label();
            lblPrice = new Label();
            lblProductName = new Label();
            gbUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            gbProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDietId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPeopleId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            SuspendLayout();
            // 
            // gbUsers
            // 
            gbUsers.Controls.Add(dgvUsers);
            gbUsers.Controls.Add(btnDeleteUser);
            gbUsers.Controls.Add(btnAddUser);
            gbUsers.Controls.Add(txtPassword);
            gbUsers.Controls.Add(txtUsername);
            gbUsers.Controls.Add(txtLastName);
            gbUsers.Controls.Add(txtName);
            gbUsers.Controls.Add(lblPassword);
            gbUsers.Controls.Add(lblUsername);
            gbUsers.Controls.Add(lblLastName);
            gbUsers.Controls.Add(lblName);
            gbUsers.Location = new Point(12, 12);
            gbUsers.Name = "gbUsers";
            gbUsers.Size = new Size(600, 350);
            gbUsers.TabIndex = 0;
            gbUsers.TabStop = false;
            gbUsers.Text = "User Management";
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(6, 140);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.Size = new Size(588, 200);
            dgvUsers.TabIndex = 10;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(519, 100);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(75, 34);
            btnDeleteUser.TabIndex = 9;
            btnDeleteUser.Text = "Delete";
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(438, 100);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(75, 34);
            btnAddUser.TabIndex = 8;
            btnAddUser.Text = "Add";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(438, 52);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(156, 23);
            txtPassword.TabIndex = 7;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(438, 23);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(156, 23);
            txtUsername.TabIndex = 6;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(73, 52);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(156, 23);
            txtLastName.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(73, 23);
            txtName.Name = "txtName";
            txtName.Size = new Size(156, 23);
            txtName.TabIndex = 4;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(373, 55);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(60, 15);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(367, 26);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(63, 15);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(6, 55);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(66, 15);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "Last Name:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(26, 26);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // gbProducts
            // 
            gbProducts.Controls.Add(dgvProducts);
            gbProducts.Controls.Add(btnDeleteProduct);
            gbProducts.Controls.Add(btnAddProduct);
            gbProducts.Controls.Add(nudDietId);
            gbProducts.Controls.Add(nudPeopleId);
            gbProducts.Controls.Add(nudPrice);
            gbProducts.Controls.Add(txtProductName);
            gbProducts.Controls.Add(lblDietId);
            gbProducts.Controls.Add(lblPeopleId);
            gbProducts.Controls.Add(lblPrice);
            gbProducts.Controls.Add(lblProductName);
            gbProducts.Location = new Point(12, 368);
            gbProducts.Name = "gbProducts";
            gbProducts.Size = new Size(600, 350);
            gbProducts.TabIndex = 1;
            gbProducts.TabStop = false;
            gbProducts.Text = "Product Management";
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(6, 140);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.Size = new Size(588, 200);
            dgvProducts.TabIndex = 10;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Location = new Point(519, 100);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(75, 34);
            btnDeleteProduct.TabIndex = 9;
            btnDeleteProduct.Text = "Delete";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(438, 100);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(75, 34);
            btnAddProduct.TabIndex = 8;
            btnAddProduct.Text = "Add";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // nudDietId
            // 
            nudDietId.Location = new Point(438, 52);
            nudDietId.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudDietId.Name = "nudDietId";
            nudDietId.Size = new Size(156, 23);
            nudDietId.TabIndex = 7;
            nudDietId.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudPeopleId
            // 
            nudPeopleId.Location = new Point(438, 23);
            nudPeopleId.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPeopleId.Name = "nudPeopleId";
            nudPeopleId.Size = new Size(156, 23);
            nudPeopleId.TabIndex = 6;
            nudPeopleId.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudPrice
            // 
            nudPrice.DecimalPlaces = 2;
            nudPrice.Location = new Point(73, 52);
            nudPrice.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(156, 23);
            nudPrice.TabIndex = 5;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(73, 23);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(156, 23);
            txtProductName.TabIndex = 4;
            // 
            // lblDietId
            // 
            lblDietId.AutoSize = true;
            lblDietId.Location = new Point(390, 54);
            lblDietId.Name = "lblDietId";
            lblDietId.Size = new Size(41, 15);
            lblDietId.TabIndex = 3;
            lblDietId.Text = "DietId:";
            // 
            // lblPeopleId
            // 
            lblPeopleId.AutoSize = true;
            lblPeopleId.Location = new Point(380, 25);
            lblPeopleId.Name = "lblPeopleId";
            lblPeopleId.Size = new Size(56, 15);
            lblPeopleId.TabIndex = 2;
            lblPeopleId.Text = "PeopleId:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(24, 54);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(36, 15);
            lblPrice.TabIndex = 1;
            lblPrice.Text = "Kcal:";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(6, 26);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(52, 15);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "Product:";
            // 
            // FormAdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 730);
            Controls.Add(gbProducts);
            Controls.Add(gbUsers);
            Name = "FormAdminPanel";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Admin Panel";
            gbUsers.ResumeLayout(false);
            gbUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            gbProducts.ResumeLayout(false);
            gbProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDietId).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPeopleId).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox gbUsers;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox gbProducts;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.NumericUpDown nudDietId;
        private System.Windows.Forms.NumericUpDown nudPeopleId;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblDietId;
        private System.Windows.Forms.Label lblPeopleId;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblProductName;
    }
}