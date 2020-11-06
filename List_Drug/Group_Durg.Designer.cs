namespace List_Drug
{
    partial class Group_Durg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Name_Group_Drug = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NameGroupFoodEdit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_Edit = new System.Windows.Forms.Button();
            this.Cancle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.Name_Group_Drug);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Save);
            this.groupBox1.Location = new System.Drawing.Point(9, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 90);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "افزودن گروه دارویی جدید";
            // 
            // Name_Group_Drug
            // 
            this.Name_Group_Drug.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Name_Group_Drug.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name_Group_Drug.Location = new System.Drawing.Point(143, 34);
            this.Name_Group_Drug.Name = "Name_Group_Drug";
            this.Name_Group_Drug.Size = new System.Drawing.Size(280, 30);
            this.Name_Group_Drug.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(429, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "نام گروه دارویی";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Save
            // 
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Image = global::List_Drug.Properties.Resources.Untitled;
            this.Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Save.Location = new System.Drawing.Point(37, 34);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(100, 30);
            this.Save.TabIndex = 0;
            this.Save.Text = "ذخیره";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.NameGroupFoodEdit);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Button_Edit);
            this.groupBox2.Location = new System.Drawing.Point(9, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(517, 90);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ویرایش گروه دارویی";
            this.groupBox2.Visible = false;
            // 
            // NameGroupFoodEdit
            // 
            this.NameGroupFoodEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameGroupFoodEdit.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NameGroupFoodEdit.Location = new System.Drawing.Point(143, 34);
            this.NameGroupFoodEdit.Name = "NameGroupFoodEdit";
            this.NameGroupFoodEdit.Size = new System.Drawing.Size(280, 30);
            this.NameGroupFoodEdit.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(429, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "نام گروه دارویی";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Button_Edit
            // 
            this.Button_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Edit.Image = global::List_Drug.Properties.Resources.update;
            this.Button_Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Edit.Location = new System.Drawing.Point(37, 34);
            this.Button_Edit.Name = "Button_Edit";
            this.Button_Edit.Size = new System.Drawing.Size(100, 30);
            this.Button_Edit.TabIndex = 0;
            this.Button_Edit.Text = "ویرایش";
            this.Button_Edit.UseVisualStyleBackColor = true;
            this.Button_Edit.Click += new System.EventHandler(this.Button_Edit_Click);
            // 
            // Cancle
            // 
            this.Cancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancle.Image = global::List_Drug.Properties.Resources.exit;
            this.Cancle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancle.Location = new System.Drawing.Point(432, 428);
            this.Cancle.Name = "Cancle";
            this.Cancle.Size = new System.Drawing.Size(94, 33);
            this.Cancle.TabIndex = 7;
            this.Cancle.Text = "خروج";
            this.Cancle.UseVisualStyleBackColor = true;
            this.Cancle.Click += new System.EventHandler(this.Cancle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(517, 222);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Group_Durg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(534, 468);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Cancle);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Group_Durg";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت گروه های دارویی";
            this.Load += new System.EventHandler(this.Group_Drug_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Name_Group_Drug;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox NameGroupFoodEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_Edit;
        private System.Windows.Forms.Button Cancle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}