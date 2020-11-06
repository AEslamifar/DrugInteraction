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
    public partial class Effect_Interaction : Form
    {
        public Effect_Interaction()
        {
            InitializeComponent();
        }
        private List_DrugEntities db = new List_DrugEntities();
        private void Effect_Interaction_Load(object sender, EventArgs e)
        {
            Code_Drug.Text = Enter_Drug_Information.Code;
            Name_Fa.Text = Enter_Drug_Information.name;

            dataGridView1.DataSource = db.Effect_Interactions.Where(items => items.Information_Drug.Code_Drug == CodeDrug).ToList();
            dataGridView1.Columns[0].HeaderText = "کد ثبت";
            dataGridView1.Columns[1].HeaderText = "کد دارو ";
            dataGridView1.Columns[2].HeaderText = "کد داروی اثر متقابل ";
            dataGridView1.Columns[3].HeaderText = "نام داروی اثر متقابل";
            dataGridView1.Columns[4].HeaderText = "نوع اثر گذاری";
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;





        }
        int CodeDrug = Convert.ToInt32(Enter_Drug_Information.Code);
        private void Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            db.Insert_Effect_Interactions(Convert.ToInt32(Code_Drug.Text),Convert.ToInt32(Code_Drug_Effect_Interactions.Text), Name_Drug_Effect_Interactions.Text, Probability_Occurrence.Text);
            db.SaveChanges();
            MessageBox.Show("اطلاعات با موفقیت ثبت گردید");
            Code_Drug_Effect_Interactions.Text = "";
            Name_Drug_Effect_Interactions.Text = "";
            Probability_Occurrence.Text = "";
            dataGridView1.DataSource = db.Effect_Interactions.Where(items => items.Information_Drug.Code_Drug == CodeDrug).ToList();

        }
        int number = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            number = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Code_Drug_Effect_Interactions.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Name_Drug_Effect_Interactions.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            Probability_Occurrence.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            db.Delete_Effect_Interactions(number);
            db.SaveChanges();
            MessageBox.Show("اطلاعات با موفقیت حذف گردید");
            Code_Drug_Effect_Interactions.Text = "";
            Name_Drug_Effect_Interactions.Text = "";
            Probability_Occurrence.Text = "";
            dataGridView1.DataSource = db.Effect_Interactions.Where(items => items.Information_Drug.Code_Drug == CodeDrug).ToList();

        }

        private void Update_Click(object sender, EventArgs e)
        {
            db.Update_Effect_Interactions(number,Convert.ToInt32(Code_Drug.Text), Convert.ToInt32(Code_Drug_Effect_Interactions.Text), Name_Drug_Effect_Interactions.Text, Probability_Occurrence.Text);
            db.SaveChanges();
            MessageBox.Show("اطلاعات با موفقیت ثبت گردید");
            Code_Drug_Effect_Interactions.Text = "";
            Name_Drug_Effect_Interactions.Text = "";
            Probability_Occurrence.Text = "";
            dataGridView1.DataSource = db.Effect_Interactions.Where(items => items.Information_Drug.Code_Drug == CodeDrug).ToList();

        }
    }
}
