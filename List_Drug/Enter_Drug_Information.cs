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
    public partial class Enter_Drug_Information : Form
    {
        private List_DrugEntities db = new List_DrugEntities();
        private List<Information_Drug> drug_list;
        private List<Group_Drug> drug_group_list;
        private List<Group_Food> food_group_list;

        AutoCompleteStringCollection FI_DataCollection;
        AutoCompleteStringCollection DI_DataCollection;
        AutoCompleteStringCollection DEI_DataCollection;
        public static string Code = "", name = "";
        public static string FormType = "";
        public static string CodeDrug = "0";
        private bool flg = false;

        public Enter_Drug_Information()
        {
            InitializeComponent();
        }

        private void Enter_Drug_Information_Load(object sender, EventArgs e)
        {

            drug_group_list = db.Group_Drug.ToList();
            drug_list = db.Information_Drug.ToList();
            food_group_list = db.Group_Food.ToList();


            Name_Group_Drug.DataSource = drug_group_list;
            Name_Group_Drug.DisplayMember = "Name_Group_Drug";
            Name_Group_Drug.ValueMember = "Name_Group_Drug";

            //تداخل دارویی اثرگذاری
            TextBoxDEI_Drug.AutoCompleteMode = AutoCompleteMode.Suggest;
            TextBoxDEI_Drug.AutoCompleteSource = AutoCompleteSource.CustomSource;
            DEI_DataCollection = new AutoCompleteStringCollection();
            for (int i = 0; i < drug_list.Count; i++)
            {
                DEI_DataCollection.Add(drug_list[i].Name_Fa + " - " + drug_list[i].Name_En);
            }
            TextBoxDEI_Drug.AutoCompleteCustomSource = DEI_DataCollection;

            //تداخل دارویی
            TextBoxDI_Drug.AutoCompleteMode = AutoCompleteMode.Suggest;
            TextBoxDI_Drug.AutoCompleteSource = AutoCompleteSource.CustomSource;
            DI_DataCollection = new AutoCompleteStringCollection();
            for (int i = 0; i < drug_list.Count; i++)
            {
                DI_DataCollection.Add(drug_list[i].Name_Fa + " - " + drug_list[i].Name_En);
            }
            TextBoxDI_Drug.AutoCompleteCustomSource = DI_DataCollection;

            //تداخل غذایی
            TextBoxFI_Food.AutoCompleteMode = AutoCompleteMode.Suggest;
            TextBoxFI_Food.AutoCompleteSource = AutoCompleteSource.CustomSource;
            FI_DataCollection = new AutoCompleteStringCollection();
            for (int i = 0; i < food_group_list.Count; i++)
            {
                FI_DataCollection.Add(food_group_list[i].Name_Group_Food + " - " + food_group_list[i].Name_Group_Food);
            }
            TextBoxFI_Food.AutoCompleteCustomSource = FI_DataCollection;


            if (FormType == "1")
            {
                BtnUpdate.Enabled = false;
                BtnDelete.Enabled = false;
            }

            if (FormType == "2")
            {
                BtnUpdate.Enabled = true;
                BtnDelete.Enabled = true;
                BtnSaveAll.Enabled = false;

                TextBox_DrugCode.Text = CodeDrug;
                int code = Convert.ToInt32(CodeDrug);

                System.Diagnostics.Debug.WriteLine("Code When Query:" + code);

                var information = db.Information_Drug.Where(items => items.Code_Drug == code).ToList();
                System.Diagnostics.Debug.WriteLine("size:" + code);

                TextBox_Name_Fa.Text = information.ToList().First().Name_Fa;
                TextBox_Name_En.Text = information.ToList().First().Name_En;
                TextBox_Pharmaceutical_Form.Text = information.ToList().First().Pharmaceutical_Form;
                TextBox_Advices.Text = information.ToList().First().Advices;

                var Interaction = db.Interactions.Where(items => items.Code_Drug == code).ToList();
                for (int i = 0; i <= Interaction.ToList().Count - 1; i++)
                {
                    if (dataGridViewDI.RowCount == 0)
                    {
                        dataGridViewDI.ColumnCount = 5;
                        dataGridViewDI.Columns[0].Name = "کد داروی تداخلی";
                        dataGridViewDI.Columns[1].Name = "نام داروی تداخلی";
                        dataGridViewDI.Columns[2].Name = "مدت شروع عوارض";
                        dataGridViewDI.Columns[3].Name = "احتمال وقوع";
                        dataGridViewDI.Columns[4].Name = "عوارض تداخل";
                        dataGridViewDI.Columns[0].Width = 120;
                        dataGridViewDI.Columns[1].Width = 120;
                        dataGridViewDI.Columns[2].Width = 140;
                        dataGridViewDI.Columns[3].Width = 140;
                        dataGridViewDI.Columns[4].Width = 180;
                        DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                        dataGridViewDI.Columns.Add(btn);
                        btn.HeaderText = "عملیات";
                        btn.Text = "حذف";
                        btn.Name = "btn";
                        btn.UseColumnTextForButtonValue = true;
                    }

                    string[] row = new string[] { Interaction.ToList()[i].Code_Durg_Interactions.ToString(), Interaction.ToList()[i].Name_Durg_Interactions.ToString(), Interaction.ToList()[i].Sart_Time.ToString(), Interaction.ToList()[i].Occurrence_Probability.ToString(), Interaction.ToList()[i].Complications.ToString() };

                    // string[] row = new string[] { "1", "Product 1", "1000" };
                    dataGridViewDI.Rows.Add(row);
                }

                var FoodInteractions = db.Food_Interactions.Where(items => items.Code_Drug == code).ToList();
                for (int i = 0; i <= FoodInteractions.ToList().Count - 1; i++)
                {


                    if (dataGridViewFI.RowCount == 0)
                    {
                        dataGridViewFI.ColumnCount = 4;
                        dataGridViewFI.Columns[0].Name = "کد غذا";
                        dataGridViewFI.Columns[1].Name = "نام غذا";
                        dataGridViewFI.Columns[2].Name = "عوارض تداخل غذایی";
                        dataGridViewFI.Columns[3].Name = "توضیحات";

                        dataGridViewFI.Columns[0].Width = 130;
                        dataGridViewFI.Columns[1].Width = 130;
                        dataGridViewFI.Columns[2].Width = 160;
                        dataGridViewFI.Columns[3].Width = 200;

                        DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                        dataGridViewFI.Columns.Add(btn);
                        btn.HeaderText = "عملیات";
                        btn.Text = "حذف";
                        btn.Name = "btn";
                        btn.UseColumnTextForButtonValue = true;
                    }

                    string[] row = new string[] { 
                        FoodInteractions.ToList()[i].Code_Food_Interactions.ToString(),
                        FoodInteractions.ToList()[i].Name_Food_Interactions.ToString(),
                        FoodInteractions.ToList()[i].Complications.ToString(), 
                        FoodInteractions.ToList()[i].Descriptions.ToString() };

                    // string[] row = new string[] { "1", "Product 1", "1000" };
                    dataGridViewFI.Rows.Add(row);

                }

                var EffectInteraction = db.Effect_Interactions.Where(items => items.Code_Drug == code).ToList();
                for (int i = 0; i <= EffectInteraction.ToList().Count - 1; i++)
                {


                    if (dataGridViewDEI.RowCount == 0)
                    {
                        dataGridViewDEI.ColumnCount = 3;
                        dataGridViewDEI.Columns[0].Name = "کد داروی اثر متقابل";
                        dataGridViewDEI.Columns[1].Name = "نام داروی اثر متقابل";
                        dataGridViewDEI.Columns[2].Name = "نوع اثر گذاری";


                        dataGridViewDEI.Columns[0].Width = 150;
                        dataGridViewDEI.Columns[1].Width = 150;
                        dataGridViewDEI.Columns[2].Width = 180;

                        DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                        dataGridViewDEI.Columns.Add(btn);
                        btn.HeaderText = "عملیات";
                        btn.Text = "حذف";
                        btn.Name = "btn";
                        btn.UseColumnTextForButtonValue = true;
                    }

                    string[] row = new string[] { 
                        EffectInteraction.ToList()[i].Code_Drug_Effect_Interactions.ToString(), 
                        EffectInteraction.ToList()[i].Name_Drug_Effect_Interactions.ToString(),
                        EffectInteraction.ToList()[i].Probability_Occurrence.ToString() 
                    };

                    // string[] row = new string[] { "1", "Product 1", "1000" };
                    dataGridViewDEI.Rows.Add(row);


                }
            }
        }

        private void BtnSaveAll_Click(object sender, EventArgs e)
        {

            if (TextBox_DrugCode.Text == "")
            {
                MessageBox.Show("کد دارو را وارد نمایید");
                return;
            }
            if (TextBox_Name_En.Text == "")
            {
                MessageBox.Show("نام انگلیسی دارو را وارد نمایید");
                return;
            }

            if (TextBox_Name_Fa.Text == "")
            {
                MessageBox.Show("نام فارسی دارو را وارد نمایید");
                return;
            }
            int code = Convert.ToInt32(TextBox_DrugCode.Text);
            var list = db.Information_Drug.Where(items => items.Code_Drug == code).ToList();
            if (list.ToList().Count > 0)
            {
                MessageBox.Show("این کد دارو قبلا برای دارویی ثبت شده است");
                return;
            }

            String name = this.Name_Group_Drug.Text;
            int index = Name_Group_Drug.SelectedIndex;
            int drug_group_code = this.drug_group_list[index].Code_Group_Drug;

            db.Insert_Information_Drug(
                Convert.ToInt32(TextBox_DrugCode.Text),
                drug_group_code,
                TextBox_Name_En.Text,
                TextBox_Name_Fa.Text,
                TextBox_Pharmaceutical_Form.Text,
                TextBox_Advices.Text);
            db.SaveChanges();


            for (int i = 0; i <= dataGridViewDI.RowCount - 1; i++)
            {
                db.Insert_Interactions(
                    Convert.ToInt32(TextBox_DrugCode.Text),
                    Convert.ToInt32(dataGridViewDI.Rows[i].Cells[0].Value.ToString()), 
                    dataGridViewDI.Rows[i].Cells[1].Value.ToString(), //name 1
                    dataGridViewDI.Rows[i].Cells[3].Value.ToString(), //ehtemal 3
                    dataGridViewDI.Rows[i].Cells[2].Value.ToString(), //time 2
                    dataGridViewDI.Rows[i].Cells[4].Value.ToString());//avarez 4
                db.SaveChanges();
            }

            for (int i = 0; i <= dataGridViewDEI.RowCount - 1; i++)
            {
                db.Insert_Effect_Interactions(
                    Convert.ToInt32(TextBox_DrugCode.Text),
                    Convert.ToInt32(dataGridViewDEI.Rows[i].Cells[0].Value.ToString()),
                    dataGridViewDEI.Rows[i].Cells[1].Value.ToString(),
                    dataGridViewDEI.Rows[i].Cells[2].Value.ToString());
                db.SaveChanges();
            }


            for (int i = 0; i <= dataGridViewFI.RowCount - 1; i++)
            {
                db.Insert_Food_Interactions(
                    Convert.ToInt32(TextBox_DrugCode.Text), 
                    Convert.ToInt32(dataGridViewFI.Rows[i].Cells[0].Value.ToString()),
                    dataGridViewFI.Rows[i].Cells[2].Value.ToString(),
                    dataGridViewFI.Rows[i].Cells[3].Value.ToString(),
                    dataGridViewFI.Rows[i].Cells[1].Value.ToString());
                db.SaveChanges();
            }

            MessageBox.Show("اطلاعات با موفقیت ثبت گردید");

            this.Close();
        }

        private void BtnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            db.Delete_Information_Drug(Convert.ToInt32(TextBox_DrugCode.Text));
            db.SaveChanges();

            db.Delete_Interactions(Convert.ToInt32(TextBox_DrugCode.Text));
            db.SaveChanges();

            db.Delete_Food_Interactions(Convert.ToInt32(TextBox_DrugCode.Text));
            db.SaveChanges();

            db.Delete_Effect_Interactions(Convert.ToInt32(TextBox_DrugCode.Text));
            db.SaveChanges();

            MessageBox.Show("اطلاعات با موفقیت حذف گردید");

            this.Close();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

            String name = this.Name_Group_Drug.Text;
            int index = Name_Group_Drug.SelectedIndex;
            int group_code = this.drug_group_list[index].Code_Group_Drug;

            Debug.WriteLine("Drug code befor update: "+TextBox_DrugCode.Text);
            db.Update_Information_Drug(
                Convert.ToInt32(TextBox_DrugCode.Text),
                Convert.ToInt32(group_code), 
                TextBox_Name_En.Text, 
                TextBox_Name_Fa.Text, 
                TextBox_Pharmaceutical_Form.Text,
                TextBox_Advices.Text);
            db.SaveChanges();

            db.Dispose();
            db = new List_DrugEntities();
            db.Delete_Interactions(Convert.ToInt32(TextBox_DrugCode.Text));
            db.SaveChanges();
            db.Dispose();
            db = new List_DrugEntities();
            db.Delete_Food_Interactions(Convert.ToInt32(TextBox_DrugCode.Text));
            db.SaveChanges();
            db.Dispose();
            db = new List_DrugEntities();
            db.Delete_Effect_Interactions(Convert.ToInt32(TextBox_DrugCode.Text));
            db.SaveChanges();
            db.Dispose();
            db = new List_DrugEntities();
            for (int i = 0; i <= dataGridViewDI.RowCount - 1; i++)
            {
                db.Insert_Interactions(
                    Convert.ToInt32(TextBox_DrugCode.Text),
                    Convert.ToInt32(dataGridViewDI.Rows[i].Cells[0].Value.ToString()),
                    dataGridViewDI.Rows[i].Cells[1].Value.ToString(),
                    dataGridViewDI.Rows[i].Cells[3].Value.ToString(),
                    dataGridViewDI.Rows[i].Cells[2].Value.ToString(),
                    dataGridViewDI.Rows[i].Cells[4].Value.ToString());
                db.SaveChanges();
            }

            for (int i = 0; i <= dataGridViewDEI.RowCount - 1; i++)
            {
                db.Insert_Effect_Interactions(
                    Convert.ToInt32(TextBox_DrugCode.Text),
                    Convert.ToInt32(dataGridViewDEI.Rows[i].Cells[0].Value.ToString()),
                    dataGridViewDEI.Rows[i].Cells[1].Value.ToString(),
                    dataGridViewDEI.Rows[i].Cells[2].Value.ToString());
                db.SaveChanges();
            }

            for (int i = 0; i <= dataGridViewFI.RowCount - 1; i++)
            {
                db.Insert_Food_Interactions(
                    Convert.ToInt32(TextBox_DrugCode.Text),
                    Convert.ToInt32(dataGridViewFI.Rows[i].Cells[0].Value.ToString()),
                    dataGridViewFI.Rows[i].Cells[2].Value.ToString(),
                    dataGridViewFI.Rows[i].Cells[3].Value.ToString(),
                      dataGridViewFI.Rows[i].Cells[1].Value.ToString());
                db.SaveChanges();
            }
            MessageBox.Show("اطلاعات با موفقیت تغییر یافت");

            this.Close();
        }

        private void Btn_AddDrugInteraction_Click(object sender, EventArgs e)
        {
            if (dataGridViewDI.RowCount == 0)
            {
                dataGridViewDI.ColumnCount = 5;
                dataGridViewDI.Columns[0].Name = "کد داروی تداخلی";
                dataGridViewDI.Columns[1].Name = "نام داروی تداخلی";
                dataGridViewDI.Columns[2].Name = "مدت شروع عوارض";
                dataGridViewDI.Columns[3].Name = "احتمال وقوع";
                dataGridViewDI.Columns[4].Name = "عوارض تداخل";
                dataGridViewDI.Columns[0].Width = 120;
                dataGridViewDI.Columns[1].Width = 120;
                dataGridViewDI.Columns[2].Width = 140;
                dataGridViewDI.Columns[3].Width = 140;
                dataGridViewDI.Columns[4].Width = 180;
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                dataGridViewDI.Columns.Add(btn);
                btn.HeaderText = "عملیات";
                btn.Text = "حذف";
                btn.Name = "btn";
                btn.UseColumnTextForButtonValue = true;
            }

            String name = this.TextBoxDI_Drug.Text;
            int index = DI_DataCollection.IndexOf(name);
            if (index != -1) {
                int code = this.drug_list[index].Code_Drug;

                string[] row = new string[] {
                code.ToString(),
                TextBoxDI_Drug.Text,
                TextBoxDI_Sart_Time.Text,
                TextBoxDI_Occurrence_Probability.Text,
                TextBoxDIComplications.Text
            };

                dataGridViewDI.Rows.Add(row);
            }
            

        }

        private void Btn_AddFoodInteraction_Click(object sender, EventArgs e)
        {
            if (dataGridViewFI.RowCount == 0)
            {
                dataGridViewFI.ColumnCount = 4;
                dataGridViewFI.Columns[0].Name = "کد ماده غذایی";
                dataGridViewFI.Columns[1].Name = "نام ماده غذایی";
                dataGridViewFI.Columns[2].Name = "عوارض تداخل غذایی";
                dataGridViewFI.Columns[3].Name = "توضیحات";

                dataGridViewFI.Columns[0].Width = 130;
                dataGridViewFI.Columns[1].Width = 130;
                dataGridViewFI.Columns[2].Width = 160;
                dataGridViewFI.Columns[3].Width = 200;

                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                dataGridViewFI.Columns.Add(btn);
                btn.HeaderText = "عملیات";
                btn.Text = "حذف";
                btn.Name = "btn";
                btn.UseColumnTextForButtonValue = true;
            }

            String name = this.TextBoxFI_Food.Text;
            int index = FI_DataCollection.IndexOf(name);
            int code = this.drug_list[index].Code_Drug;

            string[] row = new string[] {
                code.ToString(), 
                TextBoxFI_Food.Text, 
                TextBoxFI_Complications.Text, 
                TextBoxFI_Descriptions.Text };

            // string[] row = new string[] { "1", "Product 1", "1000" };
            dataGridViewFI.Rows.Add(row);
        }

        private void Btn_AddEffectInteraction_Click(object sender, EventArgs e)
        {
            if (dataGridViewDEI.RowCount == 0)
            {
                dataGridViewDEI.ColumnCount = 3;
                dataGridViewDEI.Columns[0].Name = "کد داروی اثرگذار";
                dataGridViewDEI.Columns[1].Name = "نام داروی اثرگذار";
                dataGridViewDEI.Columns[2].Name = "نوع اثر گذاری";

                dataGridViewDEI.Columns[0].Width = 150;
                dataGridViewDEI.Columns[1].Width = 150;
                dataGridViewDEI.Columns[2].Width = 180;

                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                dataGridViewDEI.Columns.Add(btn);
                btn.HeaderText = "عملیات";
                btn.Text = "حذف";
                btn.Name = "btn";
                btn.UseColumnTextForButtonValue = true;
            }

            String name = this.TextBoxDEI_Drug.Text;
            int index = DEI_DataCollection.IndexOf(name);
            int code = this.drug_list[index].Code_Drug;

            string[] row = new string[] {
                                code.ToString(),
                TextBoxDEI_Drug.Text,
                TextBoxDEI_Probability_Occurrence.Text };

            dataGridViewDEI.Rows.Add(row);
        }

        private void dataGridViewDI_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                dataGridViewDI.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void dataGridViewFI_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                dataGridViewFI.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridViewDEI_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                dataGridViewDEI.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}
