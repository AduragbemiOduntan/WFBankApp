namespace WFBankAppPresentation
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
            sidePanel = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            createAcctButton = new Button();
            panel6 = new Panel();
            panel7 = new Panel();
            transactButton = new Button();
            panel4 = new Panel();
            panel5 = new Panel();
            startHereButton = new Button();
            registerLoginPanel = new Panel();
            login = new Button();
            Register = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            password = new TextBox();
            email = new TextBox();
            Logo = new Label();
            createAcctPanel = new Panel();
            transactionPanel = new Panel();
            transDescText = new TextBox();
            label9 = new Label();
            acctTypeText = new TextBox();
            submitTransaction = new Button();
            transactionTypeText = new TextBox();
            amounText = new TextBox();
            label5 = new Label();
            label6 = new Label();
            amountLabel = new Label();
            recAcctNumLabel = new Label();
            recieverAcctNumText = new TextBox();
            label11 = new Label();
            submitAccount = new Button();
            accountTypeText = new TextBox();
            phoneNumberText = new TextBox();
            lastNameText = new TextBox();
            label8 = new Label();
            label7 = new Label();
            lastName = new Label();
            fn = new Label();
            firstNameText = new TextBox();
            label4 = new Label();
            sidePanel.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            registerLoginPanel.SuspendLayout();
            createAcctPanel.SuspendLayout();
            transactionPanel.SuspendLayout();
            SuspendLayout();
            // 
            // sidePanel
            // 
            sidePanel.BackColor = SystemColors.AppWorkspace;
            sidePanel.Controls.Add(panel8);
            sidePanel.Controls.Add(panel6);
            sidePanel.Controls.Add(panel4);
            sidePanel.Location = new Point(2, 1);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(170, 450);
            sidePanel.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.WindowFrame;
            panel8.Controls.Add(panel9);
            panel8.Location = new Point(42, 175);
            panel8.Name = "panel8";
            panel8.Size = new Size(85, 72);
            panel8.TabIndex = 2;
            // 
            // panel9
            // 
            panel9.BackColor = SystemColors.Window;
            panel9.Controls.Add(createAcctButton);
            panel9.Location = new Point(3, 3);
            panel9.Name = "panel9";
            panel9.Size = new Size(85, 72);
            panel9.TabIndex = 1;
            // 
            // createAcctButton
            // 
            createAcctButton.BackColor = SystemColors.AppWorkspace;
            createAcctButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            createAcctButton.Location = new Point(3, 3);
            createAcctButton.Name = "createAcctButton";
            createAcctButton.Size = new Size(76, 63);
            createAcctButton.TabIndex = 1;
            createAcctButton.Text = "Create Account";
            createAcctButton.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.WindowFrame;
            panel6.Controls.Add(panel7);
            panel6.Location = new Point(39, 288);
            panel6.Name = "panel6";
            panel6.Size = new Size(85, 72);
            panel6.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.Window;
            panel7.Controls.Add(transactButton);
            panel7.Location = new Point(3, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(85, 72);
            panel7.TabIndex = 1;
            // 
            // transactButton
            // 
            transactButton.BackColor = SystemColors.AppWorkspace;
            transactButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            transactButton.ForeColor = SystemColors.ControlText;
            transactButton.Location = new Point(3, 3);
            transactButton.Name = "transactButton";
            transactButton.Size = new Size(76, 63);
            transactButton.TabIndex = 2;
            transactButton.Text = "Transact";
            transactButton.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.WindowFrame;
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(39, 61);
            panel4.Name = "panel4";
            panel4.Size = new Size(85, 72);
            panel4.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Window;
            panel5.Controls.Add(startHereButton);
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(85, 72);
            panel5.TabIndex = 1;
            panel5.Paint += panel5_Paint;
            // 
            // startHereButton
            // 
            startHereButton.BackColor = SystemColors.AppWorkspace;
            startHereButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            startHereButton.Location = new Point(3, 3);
            startHereButton.Name = "startHereButton";
            startHereButton.Size = new Size(76, 63);
            startHereButton.TabIndex = 0;
            startHereButton.Text = "Start Here";
            startHereButton.UseVisualStyleBackColor = false;
            startHereButton.Click += startHereButton_Click;
            // 
            // registerLoginPanel
            // 
            registerLoginPanel.BackColor = SystemColors.AppWorkspace;
            registerLoginPanel.Controls.Add(login);
            registerLoginPanel.Controls.Add(Register);
            registerLoginPanel.Controls.Add(label3);
            registerLoginPanel.Controls.Add(label2);
            registerLoginPanel.Controls.Add(label1);
            registerLoginPanel.Controls.Add(password);
            registerLoginPanel.Controls.Add(email);
            registerLoginPanel.Location = new Point(287, 131);
            registerLoginPanel.Name = "registerLoginPanel";
            registerLoginPanel.Size = new Size(356, 273);
            registerLoginPanel.TabIndex = 1;
            // 
            // login
            // 
            login.Location = new Point(189, 216);
            login.Name = "login";
            login.Size = new Size(114, 23);
            login.TabIndex = 6;
            login.Text = "Login";
            login.UseVisualStyleBackColor = true;
            login.Click += login_Click;
            // 
            // Register
            // 
            Register.Location = new Point(32, 216);
            Register.Name = "Register";
            Register.Size = new Size(114, 23);
            Register.TabIndex = 5;
            Register.Text = "Register";
            Register.UseVisualStyleBackColor = true;
            Register.Click += Register_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(113, 22);
            label3.Name = "label3";
            label3.Size = new Size(133, 25);
            label3.TabIndex = 4;
            label3.Text = "Register/Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 138);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 72);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 2;
            label1.Text = "Email";
            // 
            // password
            // 
            password.Location = new Point(32, 156);
            password.Name = "password";
            password.Size = new Size(271, 23);
            password.TabIndex = 1;
            // 
            // email
            // 
            email.Location = new Point(32, 90);
            email.Name = "email";
            email.Size = new Size(271, 23);
            email.TabIndex = 0;
            // 
            // Logo
            // 
            Logo.AutoSize = true;
            Logo.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            Logo.Location = new Point(400, 9);
            Logo.Name = "Logo";
            Logo.Size = new Size(169, 47);
            Logo.TabIndex = 2;
            Logo.Text = "WF BANK";
            // 
            // createAcctPanel
            // 
            createAcctPanel.BackColor = SystemColors.AppWorkspace;
            createAcctPanel.Controls.Add(submitAccount);
            createAcctPanel.Controls.Add(accountTypeText);
            createAcctPanel.Controls.Add(phoneNumberText);
            createAcctPanel.Controls.Add(lastNameText);
            createAcctPanel.Controls.Add(label8);
            createAcctPanel.Controls.Add(label7);
            createAcctPanel.Controls.Add(lastName);
            createAcctPanel.Controls.Add(fn);
            createAcctPanel.Controls.Add(firstNameText);
            createAcctPanel.Controls.Add(label4);
            createAcctPanel.Location = new Point(261, 62);
            createAcctPanel.Name = "createAcctPanel";
            createAcctPanel.Size = new Size(402, 376);
            createAcctPanel.TabIndex = 3;
            // 
            // transactionPanel
            // 
            transactionPanel.BackColor = SystemColors.AppWorkspace;
            transactionPanel.Controls.Add(transDescText);
            transactionPanel.Controls.Add(label9);
            transactionPanel.Controls.Add(acctTypeText);
            transactionPanel.Controls.Add(submitTransaction);
            transactionPanel.Controls.Add(transactionTypeText);
            transactionPanel.Controls.Add(amounText);
            transactionPanel.Controls.Add(label5);
            transactionPanel.Controls.Add(label6);
            transactionPanel.Controls.Add(amountLabel);
            transactionPanel.Controls.Add(recAcctNumLabel);
            transactionPanel.Controls.Add(recieverAcctNumText);
            transactionPanel.Controls.Add(label11);
            transactionPanel.Location = new Point(261, 62);
            transactionPanel.Name = "transactionPanel";
            transactionPanel.Size = new Size(402, 376);
            transactionPanel.TabIndex = 10;
            // 
            // transDescText
            // 
            transDescText.Location = new Point(41, 251);
            transDescText.Name = "transDescText";
            transDescText.Size = new Size(305, 23);
            transDescText.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(41, 233);
            label9.Name = "label9";
            label9.Size = new Size(130, 15);
            label9.TabIndex = 11;
            label9.Text = "Transaction Description";
            // 
            // acctTypeText
            // 
            acctTypeText.Location = new Point(40, 197);
            acctTypeText.Name = "acctTypeText";
            acctTypeText.Size = new Size(305, 23);
            acctTypeText.TabIndex = 10;
            // 
            // submitTransaction
            // 
            submitTransaction.Location = new Point(40, 337);
            submitTransaction.Name = "submitTransaction";
            submitTransaction.Size = new Size(75, 23);
            submitTransaction.TabIndex = 9;
            submitTransaction.Text = "Submit";
            submitTransaction.UseVisualStyleBackColor = true;
            // 
            // transactionTypeText
            // 
            transactionTypeText.Location = new Point(41, 81);
            transactionTypeText.Name = "transactionTypeText";
            transactionTypeText.Size = new Size(305, 23);
            transactionTypeText.TabIndex = 7;
            // 
            // amounText
            // 
            amounText.Location = new Point(41, 138);
            amounText.Name = "amounText";
            amounText.Size = new Size(305, 23);
            amounText.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 179);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 5;
            label5.Text = "Account Type";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 63);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 4;
            label6.Text = "Transaction Type";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new Point(41, 120);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(51, 15);
            amountLabel.TabIndex = 3;
            amountLabel.Text = "Amount";
            // 
            // recAcctNumLabel
            // 
            recAcctNumLabel.AutoSize = true;
            recAcctNumLabel.Location = new Point(40, 293);
            recAcctNumLabel.Name = "recAcctNumLabel";
            recAcctNumLabel.Size = new Size(154, 15);
            recAcctNumLabel.TabIndex = 2;
            recAcctNumLabel.Text = "Reciever's Account Number";
            recAcctNumLabel.Click += label10_Click;
            // 
            // recieverAcctNumText
            // 
            recieverAcctNumText.Location = new Point(42, 311);
            recieverAcctNumText.Name = "recieverAcctNumText";
            recieverAcctNumText.Size = new Size(305, 23);
            recieverAcctNumText.TabIndex = 1;
            recieverAcctNumText.TextChanged += recieverAcctNumText_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(124, 17);
            label11.Name = "label11";
            label11.Size = new Size(156, 25);
            label11.TabIndex = 0;
            label11.Text = "Transaction Form";
            // 
            // submitAccount
            // 
            submitAccount.Location = new Point(41, 308);
            submitAccount.Name = "submitAccount";
            submitAccount.Size = new Size(75, 23);
            submitAccount.TabIndex = 9;
            submitAccount.Text = "Submit";
            submitAccount.UseVisualStyleBackColor = true;
            // 
            // accountTypeText
            // 
            accountTypeText.Location = new Point(41, 259);
            accountTypeText.Name = "accountTypeText";
            accountTypeText.Size = new Size(305, 23);
            accountTypeText.TabIndex = 8;
            // 
            // phoneNumberText
            // 
            phoneNumberText.Location = new Point(41, 197);
            phoneNumberText.Name = "phoneNumberText";
            phoneNumberText.Size = new Size(305, 23);
            phoneNumberText.TabIndex = 7;
            // 
            // lastNameText
            // 
            lastNameText.Location = new Point(41, 138);
            lastNameText.Name = "lastNameText";
            lastNameText.Size = new Size(305, 23);
            lastNameText.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(41, 241);
            label8.Name = "label8";
            label8.Size = new Size(79, 15);
            label8.TabIndex = 5;
            label8.Text = "Account Type";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(41, 179);
            label7.Name = "label7";
            label7.Size = new Size(88, 15);
            label7.TabIndex = 4;
            label7.Text = "Phone Number";
            // 
            // lastName
            // 
            lastName.AutoSize = true;
            lastName.Location = new Point(41, 120);
            lastName.Name = "lastName";
            lastName.Size = new Size(63, 15);
            lastName.TabIndex = 3;
            lastName.Text = "Last Name";
            // 
            // fn
            // 
            fn.AutoSize = true;
            fn.Location = new Point(41, 63);
            fn.Name = "fn";
            fn.Size = new Size(64, 15);
            fn.TabIndex = 2;
            fn.Text = "First Name";
            // 
            // firstNameText
            // 
            firstNameText.Location = new Point(41, 81);
            firstNameText.Name = "firstNameText";
            firstNameText.Size = new Size(305, 23);
            firstNameText.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(94, 17);
            label4.Name = "label4";
            label4.Size = new Size(206, 25);
            label4.TabIndex = 0;
            label4.Text = "Account Creation Form";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(transactionPanel);
            Controls.Add(createAcctPanel);
            Controls.Add(Logo);
            Controls.Add(registerLoginPanel);
            Controls.Add(sidePanel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            sidePanel.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            registerLoginPanel.ResumeLayout(false);
            registerLoginPanel.PerformLayout();
            createAcctPanel.ResumeLayout(false);
            createAcctPanel.PerformLayout();
            transactionPanel.ResumeLayout(false);
            transactionPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel sidePanel;
        private Panel registerLoginPanel;
        private Button Register;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox password;
        private TextBox email;
        private Label Logo;
        private Button login;
        private Panel createAcctPanel;
        private TextBox firstNameText;
        private Label label4;
        private Label label8;
        private Label label7;
        private Label lastName;
        private Label fn;
        private TextBox accountTypeText;
        private TextBox phoneNumberText;
        private TextBox lastNameText;
        private Button submitAccount;
        private Panel transactionPanel;
        private Button submitTransaction;
        private TextBox transactionTypeText;
        private TextBox amounText;
        private Label label5;
        private Label label6;
        private Label amountLabel;
        private Label recAcctNumLabel;
        private TextBox recieverAcctNumText;
        private Label label11;
        private TextBox acctTypeText;
        private Button transactButton;
        private Button createAcctButton;
        private Button startHereButton;
        private Panel panel4;
        private Panel panel5;
        private Panel panel8;
        private Panel panel9;
        private Panel panel6;
        private Panel panel7;
        private TextBox transDescText;
        private Label label9;
    }
}