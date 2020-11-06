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
    public partial class Group_Durg : Form
    {
        public Group_Durg()
        {
            InitializeComponent();
        }
        private List_DrugEntities db = new List_DrugEntities();
        private BindingList<Group_Drug> list;
        private void Group_Drug_Load(object sender, EventArgs e)
        {
            list = new BindingList<Group_Drug>()
            {
                AllowNew = true,
                AllowRemove = true,
                AllowEdit = false,
                RaiseListChangedEvents = true
            };

            List<Group_Drug> l = db.Group_Drug.ToList();
            for (int i = 0; i < l.Count; i++)
            {
                list.Add(l[i]);
            }

            list.AddingNew += new AddingNewEventHandler(listOfParts_AddingNew);
            list.ListChanged += new ListChangedEventHandler(listOfParts_ListChanged);

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = list;

            dataGridView1.Columns[0].HeaderText = "کد";
            dataGridView1.Columns[0].DisplayIndex = 0;
            dataGridView1.Columns[0].Name = "Code";

            dataGridView1.Columns[1].HeaderText = "نام";
            dataGridView1.Columns[1].DisplayIndex = 1;
            dataGridView1.Columns[1].Name = "Name";

            dataGridView1.Columns[2].Visible = false;



            var editButton = new DataGridViewButtonColumn
            {
                Name = "Edit",
                HeaderText = "عملیات",
                Text = "ویرایش",
                DisplayIndex = 2,
                UseColumnTextForButtonValue = true
            };

            var deleteButton = new DataGridViewButtonColumn
            {
                Name = "Delete",
                HeaderText = "عملیات",
                Text = "حذف",
                DisplayIndex = 3,
                UseColumnTextForButtonValue = true
            };

            this.dataGridView1.Columns.Add(editButton);
            this.dataGridView1.Columns.Add(deleteButton);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Name_Group_Drug.Text.Trim()))
            {
                MessageBox.Show("خطا! لطفا نام گروه دارویی را وارد کنید");
            }
            else
              list.AddNew();

        }
        int number = 0;
        int index = 0;

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            groupBox2.Visible = false;
            NameGroupFoodEdit.Text = "";

            index = dataGridView1.CurrentRow.Index;
            number = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Code"].Value.ToString());
            if (e.ColumnIndex < 0) return;
            if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("Edit"))
            {
                groupBox2.Visible = true;
                //edit
                NameGroupFoodEdit.Text = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
            }
            else
            if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("Delete"))
            {
                //delete
                db.Delete_Group_Drug(number);
                db.SaveChanges();
                MessageBox.Show("اطلاعات با موفقیت حذف گردید");
                list.RemoveAt(index);
                //dataGridView1.Rows.Remove(dataGridView1.CurrentRow);

            }
            else
            {

            }
        }

        private void Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_Edit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(NameGroupFoodEdit.Text.Trim()))
            {
                MessageBox.Show("خطا! لطفا نام گروه دارویی را وارد کنید");
            }
            else {
                db.Update_Group_Drug(number, NameGroupFoodEdit.Text);
                db.SaveChanges();
                MessageBox.Show("اطلاعات با موفقیت تغییر یافت");

                list[index].Name_Group_Drug = NameGroupFoodEdit.Text;
                list.ResetBindings();

                NameGroupFoodEdit.Text = "";

                groupBox2.Visible = false;
            }

               


        }

        void listOfParts_ListChanged(object sender, ListChangedEventArgs e)
        {
            //MessageBox.Show(e.ListChangedType.ToString());
        }

        void listOfParts_AddingNew(object sender, AddingNewEventArgs e)
        {
            Group_Drug gf = new Group_Drug();
            gf.Name_Group_Drug = Name_Group_Drug.Text;
            e.NewObject = gf;

            db.Insert_Group_Drug(Name_Group_Drug.Text);
            db.SaveChanges();
            MessageBox.Show("اطلاعات با موفقیت ثبت گردید");

            Name_Group_Drug.Text = "";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

