using AutomaticGenerator.Generators;
using AutomaticGenerator.Helpers;
using AutomaticGenerator.Models.Generators.FaceBook;
using Newtonsoft.Json;
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
        private MemberGenerator _memberGenerator;

        private JsonStream _jsonStream;

        public GeneratorForm(MemberGenerator memberGenerator, JsonStream jsonStream)
        {
            InitializeComponent();
            
            _memberGenerator = memberGenerator;
            _jsonStream = jsonStream;
        }

        public void GeneratorMemberCell(int index, User user)
        {
            dgvGeneratorMember.Rows[index].Cells["rowIndex"].Value = index + 1;
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
            dgvGeneratorMember.Rows[index].Cells["deletion"].Value = "刪除";
        }

        private void InitializeDgvGeneratorMember()
        {
            if (_memberGenerator.Users.Count != 0)
            {
                foreach (var user in _memberGenerator.Users)
                {
                    var index = dgvGeneratorMember.Rows.Add();
                    GeneratorMemberCell(index, user);
                }
            }
        }

        private async void GeneratorForm_Load(object sender, EventArgs e)
        {
            var readAsync = _jsonStream.ReadToEndAsync();

            // 取得非同步工作的結果。
            _memberGenerator.Users = _jsonStream.ConvertJsonList<User>(await readAsync);

            InitializeDgvGeneratorMember();
        }

        private void createAccount_Click(object sender, EventArgs e)
        {
            var index = dgvGeneratorMember.Rows.Add();
            var user = _memberGenerator.GenerateUser();

            dgvGeneratorMember.Rows.Clear();
            dgvGeneratorMember.Refresh();

            InitializeDgvGeneratorMember();
        }

        private void dgvGeneratorMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGeneratorMember.CurrentCell == null || dgvGeneratorMember.CurrentCell.Value == null || e.RowIndex == -1) 
                return;

            if (e.ColumnIndex == 11)
                _memberGenerator.Register(e.RowIndex);

            if (e.ColumnIndex == 12)
            {
                dgvGeneratorMember.Rows.RemoveAt(e.RowIndex);

                _memberGenerator.Delete(e.RowIndex);

                dgvGeneratorMember.Rows.Clear();
                dgvGeneratorMember.Refresh();

                InitializeDgvGeneratorMember();
            }
        }

        private void GeneratorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _jsonStream.Write(JsonConvert.SerializeObject(_memberGenerator.Users));
        }
    }
}
