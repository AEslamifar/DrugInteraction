using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_Drug
{
    public partial class Main : Form
    {
        private List<Information_Drug> list;
        AutoCompleteStringCollection DataCollection;
        public Main()
        {
            InitializeComponent();
        }
        private List_DrugEntities db = new List_DrugEntities();
        private void Form1_Load(object sender, EventArgs e)
        {
            Left = Top = 0;
            //Width = Screen.PrimaryScreen.WorkingArea.Width;
            //Height = Screen.PrimaryScreen.WorkingArea.Height;

            list = db.Information_Drug.ToList();
            //Code_Drug.DataSource = list;
            //Code_Drug.DisplayMember = "Code_Drug";
            //Code_Drug.ValueMember = "Code_Drug";
            //Code_Drug.DataSource = list;


            //Name_Drug.DisplayMember = "Name_Fa";
            //Name_Drug.ValueMember = "Name_Fa";
            //Name_Drug.DataSource = list;

            textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            DataCollection = new AutoCompleteStringCollection();
            addItems(DataCollection);
            textBox1.AutoCompleteCustomSource = DataCollection;
           
        }

        public void addItems(AutoCompleteStringCollection col)
        {
            for (int i = 0; i < list.Count; i++) {
                col.Add(list[i].Name_Fa + " - " + list[i].Name_En);
            }
        }

        private void Group_Food_Click(object sender, EventArgs e)
        {
            Group_Foods Frm_Enter_Cardex = new Group_Foods();
            Frm_Enter_Cardex.Show();
        }

        private void Group_Medical_Click(object sender, EventArgs e)
        {
            Group_Durg Frm_Enter_Cardex = new Group_Durg();
            Frm_Enter_Cardex.Show();
        }

        private void Enter_Medical_Click(object sender, EventArgs e)
        {
            Enter_Drug_Information.FormType = "1";
            Enter_Drug_Information Frm_Enter_Cardex = new Enter_Drug_Information();
            Frm_Enter_Cardex.Show();
        }

        private void Search_Click(object sender, EventArgs e)
        {
           
            dataGridView1.DataSource = null;
            db = new List_DrugEntities();
            String name = this.textBox1.Text;
            int index = DataCollection.IndexOf(name);
            int code = this.list[index].Code_Drug;
            Debug.WriteLine("code: " + code);

            var listDI = db.Interactions
                .Where(items => items.Code_Drug == code)
                .ToList();

            var listFI = db.Food_Interactions
               .Where(items => items.Code_Drug == code)
               .ToList();

            var listDEI = db.Effect_Interactions
              .Where(items => items.Code_Drug == code)
              .ToList();

            List<InteractionModel> interactionModels = new List<InteractionModel>();
            if (listDI != null) {

                for (int i = 0; i < listDI.Count; i++) {
                    InteractionModel interactionModel = new InteractionModel();
                    interactionModel.Drug_Or_Food_Code = (int)listDI[i].Code_Durg_Interactions;
                    interactionModel.Drug_Or_Food_Name = listDI[i].Name_Durg_Interactions;
                    interactionModel.Interaction_Type = "1";
                    interactionModel.Interaction_Type_Name = "تداخل دارویی";
                    interactionModels.Add(interactionModel);
                }
            }

            if (listFI != null)
            {
                for (int i = 0; i < listFI.Count; i++)
                {
                    InteractionModel interactionModel = new InteractionModel();
                    interactionModel.Drug_Or_Food_Code = (int)listFI[i].Code_Food_Interactions;
                    interactionModel.Drug_Or_Food_Name = listFI[i].Name_Food_Interactions;
                    interactionModel.Interaction_Type = "2";
                    interactionModel.Interaction_Type_Name = "تداخل غذایی";
                    interactionModels.Add(interactionModel);
                }
            }

            if (listDEI != null)
            {
                for (int i = 0; i < listDEI.Count; i++)
                {
                    InteractionModel interactionModel = new InteractionModel();
                    interactionModel.Drug_Or_Food_Code = (int)listDEI[i].Code_Drug_Effect_Interactions;
                    interactionModel.Drug_Or_Food_Name = listDEI[i].Name_Drug_Effect_Interactions;
                    interactionModel.Interaction_Type_Name = "تداخل در اثرگذاری";
                    interactionModel.Interaction_Type = "3";
                    interactionModels.Add(interactionModel);
                }
            }
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = interactionModels;
            dataGridView1.Columns[0].HeaderText = "کد دارو یا غذا";
            dataGridView1.Columns[0].Name = "Code";
            dataGridView1.Columns[0].HeaderText = "کد دارو یا غذا";
            dataGridView1.Columns[1].HeaderText = "نام دارو یا غذا";
            dataGridView1.Columns[1].Width = 250;
            dataGridView1.Columns[2].HeaderText = "نوع تداخل";
            dataGridView1.Columns[2].Name = "Type";
            dataGridView1.Columns[3].HeaderText = "نوع تداخل";
            dataGridView1.Columns[3].Name = "Type";
            dataGridView1.Columns[3].Visible = false;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(btn);
            btn.HeaderText = "عملیات";
            btn.Text = "مشاهده جزییات";
            btn.Name = "btnDetails";
            btn.UseColumnTextForButtonValue = true;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells["Type"].Value.ToString().Equals("تداخل در اثرگذاری") || 
                dataGridView1.CurrentRow.Cells["Type"].Value.ToString().Equals("تداخل دارویی")) {
                Enter_Drug_Information.FormType = "2";
                Enter_Drug_Information.CodeDrug = dataGridView1.CurrentRow.Cells["Code"].Value.ToString();
                System.Diagnostics.Debug.WriteLine("This is a code:" + Enter_Drug_Information.CodeDrug);
                Enter_Drug_Information Frm_Enter_Cardex = new Enter_Drug_Information();
                Frm_Enter_Cardex.Show();
            }
          

        }

        private void button1_Click(object sender, EventArgs e)
        {

            List_Drug Frm_Enter_Cardex = new List_Drug();
            Frm_Enter_Cardex.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            //Application.Exit();

            Form1 Frm_Enter_Cardex = new Form1();
            Frm_Enter_Cardex.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }

    class InteractionModel {
        public int Drug_Or_Food_Code { get; set; }
        public String Drug_Or_Food_Name { get; set; }
        public String Interaction_Type_Name { get; set; }

        public String Interaction_Type { get; set; }

    }
}
