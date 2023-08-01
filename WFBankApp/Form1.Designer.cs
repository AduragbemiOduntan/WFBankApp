namespace WFBankApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            BtnLogin = new Button();
            BtnReg = new Button();
            loginPage1 = new LoginPage();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            registrationPage1 = new RegistrationPage();
            Registration = new Label();
            EmailRegLabel = new Label();
            RegEmailBox = new TextBox();
            PasswordRegLabel = new Label();
            RegPasswordBox = new TextBox();
            BtnSubmitReg = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(327, 209);
            label2.Name = "label2";
            label2.Size = new Size(127, 37);
            label2.TabIndex = 4;
            label2.Text = "Welcome";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(261, 172);
            label1.Name = "label1";
            label1.Size = new Size(255, 37);
            label1.TabIndex = 5;
            label1.Text = "WFBank Application";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(BtnLogin);
            panel1.Controls.Add(BtnReg);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 50);
            panel1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(43, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // BtnLogin
            // 
            BtnLogin.Location = new Point(716, 14);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(75, 23);
            BtnLogin.TabIndex = 1;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = true;
            // 
            // BtnReg
            // 
            BtnReg.Location = new Point(619, 14);
            BtnReg.Name = "BtnReg";
            BtnReg.Size = new Size(75, 23);
            BtnReg.TabIndex = 0;
            BtnReg.Text = "Register";
            BtnReg.UseVisualStyleBackColor = true;
            BtnReg.Click += BtnReg_Click;
            // 
            // loginPage1
            // 
            loginPage1.BackColor = SystemColors.MenuBar;
            loginPage1.Location = new Point(0, 43);
            loginPage1.Name = "loginPage1";
            loginPage1.Size = new Size(800, 410);
            loginPage1.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(284, 146);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(309, 23);
            textBox1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Window;
            label3.Location = new Point(284, 117);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 9;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Window;
            label4.Location = new Point(283, 209);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 10;
            label4.Text = "Password";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(283, 238);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(309, 23);
            textBox2.TabIndex = 11;
            // 
            // registrationPage1
            // 
            registrationPage1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            registrationPage1.BackColor = SystemColors.ScrollBar;
            registrationPage1.Location = new Point(0, 43);
            registrationPage1.Name = "registrationPage1";
            registrationPage1.Size = new Size(800, 519);
            registrationPage1.TabIndex = 12;
            // 
            // Registration
            // 
            Registration.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Registration.AutoSize = true;
            Registration.BackColor = SystemColors.Window;
            Registration.Location = new Point(381, 67);
            Registration.Name = "Registration";
            Registration.Size = new Size(101, 15);
            Registration.TabIndex = 17;
            Registration.Text = "Registration Form";
            // 
            // EmailRegLabel
            // 
            EmailRegLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EmailRegLabel.AutoSize = true;
            EmailRegLabel.BackColor = SystemColors.Window;
            EmailRegLabel.Location = new Point(282, 117);
            EmailRegLabel.Name = "EmailRegLabel";
            EmailRegLabel.Size = new Size(36, 15);
            EmailRegLabel.TabIndex = 13;
            EmailRegLabel.Text = "Email";
            // 
            // RegEmailBox
            // 
            RegEmailBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RegEmailBox.Location = new Point(283, 146);
            RegEmailBox.Name = "RegEmailBox";
            RegEmailBox.Size = new Size(309, 23);
            RegEmailBox.TabIndex = 15;
            // 
            // PasswordRegLabel
            // 
            PasswordRegLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PasswordRegLabel.AutoSize = true;
            PasswordRegLabel.BackColor = SystemColors.Window;
            PasswordRegLabel.Location = new Point(283, 209);
            PasswordRegLabel.Name = "PasswordRegLabel";
            PasswordRegLabel.Size = new Size(57, 15);
            PasswordRegLabel.TabIndex = 14;
            PasswordRegLabel.Text = "Password";
            // 
            // RegPasswordBox
            // 
            RegPasswordBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RegPasswordBox.Location = new Point(282, 238);
            RegPasswordBox.Name = "RegPasswordBox";
            RegPasswordBox.Size = new Size(318, 23);
            RegPasswordBox.TabIndex = 16;
            // 
            // BtnSubmitReg
            // 
            BtnSubmitReg.Location = new Point(292, 298);
            BtnSubmitReg.Name = "BtnSubmitReg";
            BtnSubmitReg.Size = new Size(75, 23);
            BtnSubmitReg.TabIndex = 18;
            BtnSubmitReg.Text = "Submit";
            BtnSubmitReg.UseVisualStyleBackColor = true;
            BtnSubmitReg.Click += BtnSubmitReg_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuText;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnSubmitReg);
            Controls.Add(Registration);
            Controls.Add(RegPasswordBox);
            Controls.Add(RegEmailBox);
            Controls.Add(PasswordRegLabel);
            Controls.Add(EmailRegLabel);
            Controls.Add(registrationPage1);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(loginPage1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(label2);
            ForeColor = SystemColors.ControlDarkDark;
            Name = "Form1";
            Text = "WFBank Application";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Panel panel1;
        private Button BtnLogin;
        private Button BtnReg;
        private LoginPage loginPage1;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private RegistrationPage registrationPage1;
        private Label Registration;
        private Button button1;
        private Label EmailRegLabel;
        private TextBox RegEmailBox;
        private Label PasswordRegLabel;
        private TextBox RegPasswordBox;
        private Button BtnSubmitReg;
    }
}