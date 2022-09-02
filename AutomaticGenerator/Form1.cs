using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutomaticGenerator.Services;

namespace AutomaticGenerator
{
    public partial class Form1 : Form
    {
        private TempMailService _tempMailService;

        public Form1()
        {
            InitializeComponent();
            _tempMailService = new TempMailService(new OneSecmail());
        }

        private void createAccount_Click(object sender, EventArgs e)
        {
            var mails = _tempMailService.GetMailbox();
            var index = dataGridView1.Rows.Add();

            dataGridView1.Rows[index].Cells["sort"].Value = index + 1;
            dataGridView1.Rows[index].Cells["email"].Value = mails;
            dataGridView1.Rows[index].Cells["account"].Value = Mmeber.RandomString(20, true);
            dataGridView1.Rows[index].Cells["password"].Value = Mmeber.RandomString(20, true);
            dataGridView1.Rows[index].Cells["cellPhone"].Value = "0912345678";
            dataGridView1.Rows[index].Cells["register"].Value = "註冊";
        }
    }
}
