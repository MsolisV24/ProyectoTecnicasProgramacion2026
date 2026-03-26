using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ClassProyecto
{
    partial class FormIMC
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblWeight;
        private Label lblHeight;
        private Label lblAge;
        private Label lblGender;
        private Label lblActivity;

        private TextBox txtWeight;
        private TextBox txtHeight;
        private TextBox txtAge;

        private ComboBox cmbGender;
        private ComboBox cmbActivity;

        private Button btnCalculate;
        private Label lblResult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblWeight = new Label();
            lblHeight = new Label();
            lblAge = new Label();
            lblGender = new Label();
            lblActivity = new Label();
            txtWeight = new TextBox();
            txtHeight = new TextBox();
            txtAge = new TextBox();
            cmbGender = new ComboBox();
            cmbActivity = new ComboBox();
            btnCalculate = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // lblWeight
            // 
            lblWeight.Location = new Point(20, 20);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(100, 23);
            lblWeight.TabIndex = 0;
            lblWeight.Text = "Weight (kg):";
            // 
            // lblHeight
            // 
            lblHeight.Location = new Point(20, 60);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(100, 23);
            lblHeight.TabIndex = 2;
            lblHeight.Text = "Height (m):";
            // 
            // lblAge
            // 
            lblAge.Location = new Point(20, 100);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(100, 23);
            lblAge.TabIndex = 4;
            lblAge.Text = "Age:";
            // 
            // lblGender
            // 
            lblGender.Location = new Point(20, 140);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(100, 23);
            lblGender.TabIndex = 6;
            lblGender.Text = "Gender:";
            // 
            // lblActivity
            // 
            lblActivity.Location = new Point(20, 180);
            lblActivity.Name = "lblActivity";
            lblActivity.Size = new Size(100, 23);
            lblActivity.TabIndex = 8;
            lblActivity.Text = "Activity:";
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(140, 20);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(120, 23);
            txtWeight.TabIndex = 1;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(140, 60);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(120, 23);
            txtHeight.TabIndex = 3;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(140, 100);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(120, 23);
            txtAge.TabIndex = 5;
            // 
            // cmbGender
            // 
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.Location = new Point(140, 140);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(120, 23);
            cmbGender.TabIndex = 7;
            // 
            // cmbActivity
            // 
            cmbActivity.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbActivity.Location = new Point(140, 180);
            cmbActivity.Name = "cmbActivity";
            cmbActivity.Size = new Size(120, 23);
            cmbActivity.TabIndex = 9;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(80, 220);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(120, 30);
            btnCalculate.TabIndex = 10;
            btnCalculate.Text = "Calculate";
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblResult
            // 
            lblResult.Location = new Point(20, 270);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(260, 100);
            lblResult.TabIndex = 11;
            // 
            // FormIMC
            // 
            ClientSize = new Size(300, 380);
            Controls.Add(lblWeight);
            Controls.Add(txtWeight);
            Controls.Add(lblHeight);
            Controls.Add(txtHeight);
            Controls.Add(lblAge);
            Controls.Add(txtAge);
            Controls.Add(lblGender);
            Controls.Add(cmbGender);
            Controls.Add(lblActivity);
            Controls.Add(cmbActivity);
            Controls.Add(btnCalculate);
            Controls.Add(lblResult);
            Name = "FormIMC";
            Text = "Calculator IMC";
            Load += FormIMC_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}