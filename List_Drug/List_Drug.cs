using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_Drug
{
    public partial class List_Drug : Form
    {
        public List_Drug()
        {
            InitializeComponent();
        }
        private List_DrugEntities db = new List_DrugEntities();
        private void List_Drug_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Information_Drug.Join(db.Group_Drug,
                information_Drug => information_Drug.Code_Group_Drug,
                group_Drug => group_Drug.Code_Group_Drug,
            (information_Drug, group_Drug) => new
            {
                Code_Drug = information_Drug.Code_Drug,
                Goup_Name = group_Drug.Name_Group_Drug,
                Name_En = information_Drug.Name_En,
                NameFa = information_Drug.Name_Fa,
                Pharmaceutical_Form = information_Drug.Pharmaceutical_Form,
                Advices = information_Drug.Advices
            }).ToList();
            dataGridView1.Columns[0].HeaderText = "کد دارو";
            dataGridView1.Columns[0].Name = "Code";
            dataGridView1.Columns[1].HeaderText = "گروه دارویی";
            dataGridView1.Columns[2].HeaderText = "نام انگلیسی";
            dataGridView1.Columns[3].HeaderText = "نام فارسی";
            dataGridView1.Columns[4].HeaderText = " شکل دارو";
            dataGridView1.Columns[5].HeaderText = "  توصیه های مصرف";
          
            var deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "dataGridViewDeleteButton";
            deleteButton.HeaderText = "عملیات";
            deleteButton.Text = "مشاهده و ویرایش";
            deleteButton.UseColumnTextForButtonValue = true;

            this.dataGridView1.Columns.Add(deleteButton);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Enter_Drug_Information.FormType = "2";
            Enter_Drug_Information.CodeDrug = dataGridView1.CurrentRow.Cells["Code"].Value.ToString();
            System.Diagnostics.Debug.WriteLine("This is a code:" + Enter_Drug_Information.CodeDrug);
            Enter_Drug_Information Frm_Enter_Cardex = new Enter_Drug_Information();
            Frm_Enter_Cardex.Show();
        }

        private void Search_Click(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Text_Search_TextChanged(object sender, EventArgs e)
        {
            if (Search.Text == "" || Search.Text.Length < 2)
            {
                return;
            }

            if (Select_Search.Text == "کد دارو")
            {
                int number = Convert.ToInt32(Text_Search.Text);
                var list = db.Information_Drug.Where(items => items.Code_Drug == number).ToList();
                dataGridView1.DataSource = list;
            }
            else if (Select_Search.Text == "نام انگلیسی دارو")
            {
                var list = db.Information_Drug.Where(items => items.Name_En.Contains(Text_Search.Text)).ToList();
                dataGridView1.DataSource = list;
            }
            else if (Select_Search.Text == "نام فارسی دارو")
            {
                var list = db.Information_Drug.Where(items => items.Name_Fa.Contains(Text_Search.Text)).ToList();
                dataGridView1.DataSource = list;
            }
            else if (Select_Search.Text == "شکل دارویی")
            {
                var list = db.Information_Drug.Where(items => items.Pharmaceutical_Form.Contains(Search.Text)).ToList();
                dataGridView1.DataSource = list;
            }
        }
    }
}
