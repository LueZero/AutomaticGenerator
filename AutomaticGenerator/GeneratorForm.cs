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
            JsonReader.Load("D:\\AutomaticGenerator\\AutomaticGenerator\\Data\\UserInformation.json");
        }

        private void InitializeDgvGeneratorMember()
        {
            if (_users.Count != 0)
            {
                foreach (var user in _users)
                {
                    var index = dgvGeneratorMember.Rows.Add();
                    dgvGeneratorMember.Rows[index].Cells["rowIndex"].Value = user.Index;
                    dgvGeneratorMember.Rows[index].Cells["lastName"].Value = user.LastName;
                    dgvGeneratorMember.Rows[index].Cells["firstName"].Value = user.FirstName;
                    dgvGeneratorMember.Rows[index].Cells["email"].Value = user.Email;
                    dgvGeneratorMember.Rows[index].Cells["account"].Value = user.Account;
                    dgvGeneratorMember.Rows[index].Cells["password"].Value = user.Password;
                    dgvGeneratorMember.Rows[index].Cells["cellPhone"].Value = user.CellPhone;
                    dgvGeneratorMember.Rows[index].Cells["sex"].Value = user.Sex.ToString();
                    dgvGeneratorMember.Rows[index].Cells["year"].Value = user.Year;
                    dgvGeneratorMember.Rows[index].Cells["month"].Value = user.Month;
                    dgvGeneratorMember.Rows[index].Cells["day"].Value = user.Day;
                    dgvGeneratorMember.Rows[index].Cells["register"].Value = "註冊";
                }
            }
        }

        private async void GeneratorForm_Load(object sender, EventArgs e)
        {
            var readAsync = JsonReader.ReadToEndAsync();

            // 取得非同步工作的結果。
            _users = JsonReader.ConvertJsonList<User>(await readAsync);

            InitializeDgvGeneratorMember();
        }

        private void createAccount_Click(object sender, EventArgs e)
        {
            var index = dgvGeneratorMember.Rows.Add();
            var user = memberGenerator.GenerateUser(index + 1);

            dgvGeneratorMember.Rows[index].Cells["rowIndex"].Value = user.Index;
            dgvGeneratorMember.Rows[index].Cells["lastName"].Value = user.LastName;
            dgvGeneratorMember.Rows[index].Cells["firstName"].Value = user.FirstName;
            dgvGeneratorMember.Rows[index].Cells["email"].Value = user.Email;
            dgvGeneratorMember.Rows[index].Cells["account"].Value = user.Account;
            dgvGeneratorMember.Rows[index].Cells["password"].Value = user.Password;
            dgvGeneratorMember.Rows[index].Cells["cellPhone"].Value = user.CellPhone;
            dgvGeneratorMember.Rows[index].Cells["sex"].Value = user.Sex.ToString();
            dgvGeneratorMember.Rows[index].Cells["year"].Value = user.Year;
            dgvGeneratorMember.Rows[index].Cells["month"].Value = user.Month;
            dgvGeneratorMember.Rows[index].Cells["day"].Value = user.Day;
            dgvGeneratorMember.Rows[index].Cells["register"].Value = "註冊";
        }

        private void dgvGeneratorMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGeneratorMember.CurrentCell == null || dgvGeneratorMember.CurrentCell.Value == null || e.RowIndex == -1) 
                return;

            if (e.ColumnIndex == 11)
                memberGenerator.Register(e.RowIndex);
        }       
    }
}
