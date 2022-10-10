using AutomaticGenerator.Generators;
using AutomaticGenerator.Helpers;
using AutomaticGenerator.Models.Generators.FaceBook;
using RandomNameGeneratorLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomaticGenerator
{
    public partial class GeneratorForm : Form
    {
        private MemberGenerator memberGenerator;

        private List<User> _users;

        public GeneratorForm()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            memberGenerator = new FaceBook(new TempMailService(), new PersonNameGenerator(), new Chrome());

            JsonReader.Load("D:\\AutomaticGenerator\\AutomaticGenerator\\Data\\UserInformations.json");
        }

        private async void GeneratorForm_Load(object sender, EventArgs e)
        {
            var readAsync = JsonReader.ReadToEndAsync();

            // 取得非同步工作的結果。
            _users = JsonReader.ConvertJsonList<User>(await readAsync);
        }

        private void createAccount_Click(object sender, EventArgs e)
        {
            var index = dataGridView1.Rows.Add();
            var user = memberGenerator.GenerateUser(index + 1);
          
            dataGridView1.Rows[index].Cells["rowIndex"].Value = user.Index;
            dataGridView1.Rows[index].Cells["lastName"].Value = user.LastName;
            dataGridView1.Rows[index].Cells["firstName"].Value = user.FirstName;
            dataGridView1.Rows[index].Cells["email"].Value = user.Email;
            dataGridView1.Rows[index].Cells["account"].Value = user.Account;
            dataGridView1.Rows[index].Cells["password"].Value = user.Password;
            dataGridView1.Rows[index].Cells["cellPhone"].Value = user.CellPhone;
            dataGridView1.Rows[index].Cells["sex"].Value = user.Sex.ToString();
            dataGridView1.Rows[index].Cells["year"].Value = user.Year;
            dataGridView1.Rows[index].Cells["month"].Value = user.Month;
            dataGridView1.Rows[index].Cells["day"].Value = user.Day;
            dataGridView1.Rows[index].Cells["register"].Value = "註冊";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell == null || dataGridView1.CurrentCell.Value == null || e.RowIndex == -1) 
                return;

            if (e.ColumnIndex == 11)
                memberGenerator.Register(e.RowIndex);
        }       
    }
}
