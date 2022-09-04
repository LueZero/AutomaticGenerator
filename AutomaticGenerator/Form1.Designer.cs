
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
            this.sort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.register = new System.Windows.Forms.DataGridViewButtonColumn();
            this.createAccount = new System.Windows.Forms.Button();
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
            this.lastName,
            this.firstName,
            this.sex,
            this.account,
            this.email,
            this.password,
            this.cellPhone,
            this.register});
            this.dataGridView1.Location = new System.Drawing.Point(-1, -1);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1181, 529);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // sort
            // 
            this.sort.HeaderText = "#";
            this.sort.MinimumWidth = 6;
            this.sort.Name = "sort";
            this.sort.Width = 125;
            // 
            // lastName
            // 
            this.lastName.HeaderText = "姓";
            this.lastName.MinimumWidth = 6;
            this.lastName.Name = "lastName";
            this.lastName.Width = 125;
            // 
            // firstName
            // 
            this.firstName.HeaderText = "名字";
            this.firstName.MinimumWidth = 6;
            this.firstName.Name = "firstName";
            this.firstName.Width = 125;
            // 
            // sex
            // 
            this.sex.HeaderText = "性別";
            this.sex.Items.AddRange(new object[] {
            "女生",
            "男生"});
            this.sex.MinimumWidth = 6;
            this.sex.Name = "sex";
            this.sex.Width = 125;
            // 
            // account
            // 
            this.account.HeaderText = "帳號";
            this.account.MinimumWidth = 6;
            this.account.Name = "account";
            this.account.Width = 125;
            // 
            // email
            // 
            this.email.HeaderText = "信箱";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.Width = 125;
            // 
            // password
            // 
            this.password.HeaderText = "密碼";
            this.password.MinimumWidth = 6;
            this.password.Name = "password";
            this.password.Width = 125;
            // 
            // cellPhone
            // 
            this.cellPhone.HeaderText = "手機";
            this.cellPhone.MinimumWidth = 6;
            this.cellPhone.Name = "cellPhone";
            this.cellPhone.Width = 125;
            // 
            // register
            // 
            this.register.HeaderText = "註冊";
            this.register.MinimumWidth = 6;
            this.register.Name = "register";
            this.register.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.register.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.register.Text = "註冊";
            this.register.Width = 125;
            // 
            // createAccount
            // 
            this.createAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createAccount.Location = new System.Drawing.Point(0, 528);
            this.createAccount.Margin = new System.Windows.Forms.Padding(4);
            this.createAccount.Name = "createAccount";
            this.createAccount.Size = new System.Drawing.Size(1180, 122);
            this.createAccount.TabIndex = 1;
            this.createAccount.Text = "自動產生帳戶資訊";
            this.createAccount.UseVisualStyleBackColor = true;
            this.createAccount.Click += new System.EventHandler(this.createAccount_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 651);
            this.Controls.Add(this.createAccount);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "控制台";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button createAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn sort;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewComboBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn account;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellPhone;
        private System.Windows.Forms.DataGridViewButtonColumn register;
    }
}

