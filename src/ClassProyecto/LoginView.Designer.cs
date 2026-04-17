namespace ClassProyecto
{
    partial class LoginView
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            btn_Login = new Button();
            btn_RegisterUser = new Button();
            label1 = new Label();
            label2 = new Label();
            txt_UserName = new TextBox();
            txt_Password = new TextBox();
            topPanel = new Panel();
            lblTitle = new Label();
            btnAdmin = new Button();
            topPanel.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Login
            // 
            btn_Login.FlatStyle = FlatStyle.System;
            btn_Login.Location = new Point(225, 260);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(160, 50);
            btn_Login.TabIndex = 0;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // btn_RegisterUser
            // 
            btn_RegisterUser.FlatStyle = FlatStyle.System;
            btn_RegisterUser.Location = new Point(415, 260);
            btn_RegisterUser.Name = "btn_RegisterUser";
            btn_RegisterUser.Size = new Size(160, 50);
            btn_RegisterUser.TabIndex = 1;
            btn_RegisterUser.Text = "Register User";
            btn_RegisterUser.UseVisualStyleBackColor = true;
            btn_RegisterUser.Click += btn_RegisterUser_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(180, 120);
            label1.Name = "label1";
            label1.Size = new Size(140, 28);
            label1.TabIndex = 2;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(180, 180);
            label2.Name = "label2";
            label2.Size = new Size(140, 28);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // txt_UserName
            // 
            txt_UserName.Font = new Font("Segoe UI", 12F);
            txt_UserName.Location = new Point(325, 120);
            txt_UserName.Name = "txt_UserName";
            txt_UserName.Size = new Size(250, 29);
            txt_UserName.TabIndex = 4;
            // 
            // txt_Password
            // 
            txt_Password.Font = new Font("Segoe UI", 12F);
            txt_Password.Location = new Point(325, 180);
            txt_Password.Name = "txt_Password";
            txt_Password.PasswordChar = '●';
            txt_Password.Size = new Size(250, 29);
            txt_Password.TabIndex = 5;
            // 
            // topPanel
            // 
            topPanel.Controls.Add(lblTitle);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(800, 70);
            topPanel.TabIndex = 6;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(800, 70);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Welcome to Sistema de Gestion";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAdmin
            // 
            btnAdmin.Location = new Point(320, 330);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(160, 40);
            btnAdmin.TabIndex = 7;
            btnAdmin.Text = "Admin Login";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Visible = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 467);
            Controls.Add(btnAdmin);
            Controls.Add(topPanel);
            Controls.Add(txt_Password);
            Controls.Add(txt_UserName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_RegisterUser);
            Controls.Add(btn_Login);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += LoginView_Load;
            topPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Login;
        private Button btn_RegisterUser;
        private Label label1;
        private Label label2;
        private TextBox txt_UserName;
        private TextBox txt_Password;
        private Panel topPanel;
        private Label lblTitle;
        private Button btnAdmin;
    }
}