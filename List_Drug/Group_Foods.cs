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
    public partial class Group_Foods : Form
    {
        public Group_Foods()
        {
            InitializeComponent();
        }
        private List_DrugEntities db = new List_DrugEntities();
        private BindingList<Group_Food> list;
        private void Group_Foods_Load(object sender, EventArgs e)
        {
            list = new BindingList<Group_Food>()
            {
                AllowNew = true,
                AllowRemove = true,
                AllowEdit = false,
                RaiseListChangedEvents = true
            };

            List<Group_Food> l = db.Group_Food.ToList();
            for (int i = 0; i < l.Count; i++) {
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

            list.AddNew();

        }
        int number = 0;
        int index = 0;

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            groupBox2.Visible = false;
            NameGroupFoodEdit.Text = "";

            index = dataGridView1.CurrentRow.Index ;
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
                db.Delete_Group_Food(number);
                db.SaveChanges();
                MessageBox.Show("اطلاعات با موفقیت حذف گردید");
                list.RemoveAt(index);
                //dataGridView1.Rows.Remove(dataGridView1.CurrentRow);

            }
            else { 

            }
        }

        private void Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_Edit_Click(object sender, EventArgs e)
        {

            db.Update_Group_Food(number, NameGroupFoodEdit.Text);
            db.SaveChanges();
            MessageBox.Show("اطلاعات با موفقیت تغییر یافت");

            list[index].Name_Group_Food = NameGroupFoodEdit.Text;
            list.ResetBindings();

            NameGroupFoodEdit.Text = "";

            groupBox2.Visible = false;


        }

        void listOfParts_ListChanged(object sender, ListChangedEventArgs e)
        {
            //MessageBox.Show(e.ListChangedType.ToString());
        }

        void listOfParts_AddingNew(object sender, AddingNewEventArgs e)
        {
            Group_Food gf = new Group_Food();
            gf.Name_Group_Food = Name_Group_Drug.Text;
            e.NewObject = gf;

            db.Insert_Group_Food(Name_Group_Drug.Text);
            db.SaveChanges();
            MessageBox.Show("اطلاعات با موفقیت ثبت گردید");

            Name_Group_Drug.Text = "";
           
        }
    }
}
