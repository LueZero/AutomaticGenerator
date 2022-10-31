
namespace AutomaticGenerator
{
    partial class GeneratorForm
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
            this.dgvGeneratorMember = new System.Windows.Forms.DataGridView();
            this.createAccount = new System.Windows.Forms.Button();
            this.rowIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.register = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deletion = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneratorMember)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGeneratorMember
            // 
            this.dgvGeneratorMember.AllowUserToAddRows = false;
            this.dgvGeneratorMember.AllowUserToDeleteRows = false;
            this.dgvGeneratorMember.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGeneratorMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGeneratorMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rowIndex,
            this.lastName,
            this.firstName,
            this.sex,
            this.account,
            this.email,
            this.password,
            this.cellPhone,
            this.year,
            this.month,
            this.day,
            this.register,
            this.deletion});
            this.dgvGeneratorMember.Location = new System.Drawing.Point(-1, -1);
            this.dgvGeneratorMember.Margin = new System.Windows.Forms.Padding(4);
            this.dgvGeneratorMember.Name = "dgvGeneratorMember";
            this.dgvGeneratorMember.RowHeadersWidth = 51;
            this.dgvGeneratorMember.RowTemplate.Height = 25;
            this.dgvGeneratorMember.Size = new System.Drawing.Size(1653, 529);
            this.dgvGeneratorMember.TabIndex = 0;
            this.dgvGeneratorMember.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGeneratorMember_CellClick);
            // 
            // createAccount
            // 
            this.createAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createAccount.Location = new System.Drawing.Point(0, 528);
            this.createAccount.Margin = new System.Windows.Forms.Padding(4);
            this.createAccount.Name = "createAccount";
            this.createAccount.Size = new System.Drawing.Size(1652, 122);
            this.createAccount.TabIndex = 1;
            this.createAccount.Text = "自動產生帳戶資訊";
            this.createAccount.UseVisualStyleBackColor = true;
            this.createAccount.Click += new System.EventHandler(this.createAccount_Click);
            // 
            // rowIndex
            // 
            this.rowIndex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rowIndex.HeaderText = "#";
            this.rowIndex.MinimumWidth = 6;
            this.rowIndex.Name = "rowIndex";
            // 
            // lastName
            // 
            this.lastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastName.HeaderText = "姓";
            this.lastName.MinimumWidth = 6;
            this.lastName.Name = "lastName";
            // 
            // firstName
            // 
            this.firstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstName.HeaderText = "名字";
            this.firstName.MinimumWidth = 6;
            this.firstName.Name = "firstName";
            // 
            // sex
            // 
            this.sex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sex.HeaderText = "性別";
            this.sex.Items.AddRange(new object[] {
            "女性",
            "男性"});
            this.sex.MinimumWidth = 6;
            this.sex.Name = "sex";
            // 
            // account
            // 
            this.account.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.account.HeaderText = "帳號";
            this.account.MinimumWidth = 6;
            this.account.Name = "account";
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.email.HeaderText = "信箱";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            // 
            // password
            // 
            this.password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.password.HeaderText = "密碼";
            this.password.MinimumWidth = 6;
            this.password.Name = "password";
            // 
            // cellPhone
            // 
            this.cellPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cellPhone.HeaderText = "手機";
            this.cellPhone.MinimumWidth = 6;
            this.cellPhone.Name = "cellPhone";
            // 
            // year
            // 
            this.year.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.year.HeaderText = "出生日期(年)";
            this.year.MinimumWidth = 6;
            this.year.Name = "year";
            // 
            // month
            // 
            this.month.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.month.HeaderText = "出生日期(月)";
            this.month.MinimumWidth = 6;
            this.month.Name = "month";
            // 
            // day
            // 
            this.day.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.day.HeaderText = "出生日期(天)";
            this.day.MinimumWidth = 6;
            this.day.Name = "day";
            // 
            // register
            // 
            this.register.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.register.HeaderText = "註冊";
            this.register.MinimumWidth = 6;
            this.register.Name = "register";
            this.register.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.register.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.register.Text = "註冊";
            // 
            // deletion
            // 
            this.deletion.HeaderText = "刪除";
            this.deletion.MinimumWidth = 6;
            this.deletion.Name = "deletion";
            this.deletion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.deletion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.deletion.Width = 125;
            // 
            // GeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1654, 651);
            this.Controls.Add(this.createAccount);
            this.Controls.Add(this.dgvGeneratorMember);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GeneratorForm";
            this.Text = "控制台";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GeneratorForm_FormClosed);
            this.Load += new System.EventHandler(this.GeneratorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneratorMember)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGeneratorMember;
        private System.Windows.Forms.Button createAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewComboBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn account;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.DataGridViewTextBoxColumn month;
        private System.Windows.Forms.DataGridViewTextBoxColumn day;
        private System.Windows.Forms.DataGridViewButtonColumn register;
        private System.Windows.Forms.DataGridViewButtonColumn deletion;
    }
}

