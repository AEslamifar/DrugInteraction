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
    public partial class Interaction : Form
    {
        public Interaction()
        {
            InitializeComponent();
        }
        private List_DrugEntities db = new List_DrugEntities();
        private void Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int CodeDrug=Convert.ToInt32(Enter_Drug_Information.Code);
        private void Interaction_Load(object sender, EventArgs e)
        {
              Code_Drug.Text= Enter_Drug_Information.Code;
              Name_Fa.Text = Enter_Drug_Information.name;
            dataGridView1.DataSource = db.Interactions.Where(items => items.Information_Drug.Code_Drug == CodeDrug).ToList();
            dataGridView1.Columns[0].HeaderText = "کد ثبت";
            dataGridView1.Columns[1].HeaderText = "نام دارو";
            dataGridView1.Columns[2].HeaderText = "کد داروی تداخل ";
            dataGridView1.Columns[3].HeaderText = "نام داروی تداخل ";
            dataGridView1.Columns[4].HeaderText = "احتمال وقوع";
            dataGridView1.Columns[5].HeaderText = "مدت شروع عوارض";
            dataGridView1.Columns[6].HeaderText = "عوارض تداخل";

            dataGridView1.Columns[7].Visible = false;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            db.Insert_Interactions(Convert.ToInt32(Code_Drug.Text), Convert.ToInt32(Code_Durg_Interactions.Text), Name_Durg_Interactions.Text, Occurrence_Probability.Text, Sart_Time.Text, Complications.Text);
            db.SaveChanges();
            MessageBox.Show("اطلاعات با موفقیت ثبت گردید");
            Code_Durg_Interactions.Text = "";
            Name_Durg_Interactions.Text = "";
            Occurrence_Probability.Text = "";
            Sart_Time.Text = "";
            Complications.Text = "";
            dataGridView1.DataSource = db.Interactions.Where(items => items.Information_Drug.Code_Drug == CodeDrug).ToList();


        }
        int number = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            number = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Code_Durg_Interactions.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Name_Durg_Interactions.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            Occurrence_Probability.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            Sart_Time.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            Complications.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
           
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            db.Delete_Interactions(number);
            db.SaveChanges();
            MessageBox.Show("اطلاعات با موفقیت حذف گردید");

            Code_Durg_Interactions.Text = "";
            Name_Durg_Interactions.Text = "";
            Occurrence_Probability.Text = "";
            Sart_Time.Text = "";
            Complications.Text = "";
            
            dataGridView1.DataSource = db.Interactions.Where(items=>items.Information_Drug.Code_Drug== CodeDrug).ToList();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            db.Update_Interactions(number,Convert.ToInt32(Code_Drug.Text), Convert.ToInt32(Code_Durg_Interactions.Text), Name_Durg_Interactions.Text, Occurrence_Probability.Text, Sart_Time.Text, Complications.Text);

            db.SaveChanges();
            MessageBox.Show("اطلاعات با موفقیت تغییر یافت");


            Code_Durg_Interactions.Text = "";
            Name_Durg_Interactions.Text = "";
            Occurrence_Probability.Text = "";
            Sart_Time.Text = "";
            Complications.Text = "";
            dataGridView1.DataSource = db.Interactions.Where(items => items.Information_Drug.Code_Drug == CodeDrug).ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
