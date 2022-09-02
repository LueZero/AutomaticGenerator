
namespace AutomaticGenerator
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.createAccount = new System.Windows.Forms.Button();
            this.sort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.register = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sort,
            this.email,
            this.account,
            this.password,
            this.cellPhone,
            this.register});
            this.dataGridView1.Location = new System.Drawing.Point(-1, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1243, 418);
            this.dataGridView1.TabIndex = 0;
            // 
            // createAccount
            // 
            this.createAccount.Location = new System.Drawing.Point(0, 417);
            this.createAccount.Name = "createAccount";
            this.createAccount.Size = new System.Drawing.Size(1242, 96);
            this.createAccount.TabIndex = 1;
            this.createAccount.Text = "自動產生帳戶資訊";
            this.createAccount.UseVisualStyleBackColor = true;
            this.createAccount.Click += new System.EventHandler(this.createAccount_Click);
            // 
            // sort
            // 
            this.sort.HeaderText = "#";
            this.sort.Name = "sort";
            // 
            // email
            // 
            this.email.HeaderText = "信箱";
            this.email.Name = "email";
            this.email.Width = 250;
            // 
            // account
            // 
            this.account.HeaderText = "帳號";
            this.account.Name = "account";
            this.account.Width = 250;
            // 
            // password
            // 
            this.password.HeaderText = "密碼";
            this.password.Name = "password";
            this.password.Width = 250;
            // 
            // cellPhone
            // 
            this.cellPhone.HeaderText = "手機";
            this.cellPhone.Name = "cellPhone";
            this.cellPhone.Width = 250;
            // 
            // register
            // 
            this.register.HeaderText = "註冊";
            this.register.Name = "register";
            this.register.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.register.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.register.Text = "註冊";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 514);
            this.Controls.Add(this.createAccount);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "控制台";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button createAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn sort;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn account;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellPhone;
        private System.Windows.Forms.DataGridViewButtonColumn register;
    }
}

