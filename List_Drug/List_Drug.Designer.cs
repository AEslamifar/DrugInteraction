namespace List_Drug
{
    partial class List_Drug
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Text_Search = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.Select_Search = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Cancle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(788, 318);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Text_Search);
            this.groupBox4.Controls.Add(this.Search);
            this.groupBox4.Controls.Add(this.Select_Search);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(800, 76);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            // 
            // Text_Search
            // 
            this.Text_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Text_Search.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Text_Search.Location = new System.Drawing.Point(313, 35);
            this.Text_Search.Name = "Text_Search";
            this.Text_Search.Size = new System.Drawing.Size(206, 27);
            this.Text_Search.TabIndex = 7;
            this.Text_Search.TextChanged += new System.EventHandler(this.Text_Search_TextChanged);
            // 
            // Search
            // 
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Image = global::List_Drug.Properties.Resources.search;
            this.Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Search.Location = new System.Drawing.Point(60, 29);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(211, 32);
            this.Search.TabIndex = 0;
            this.Search.Text = "جستجو";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Select_Search
            // 
            this.Select_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Select_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Select_Search.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_Search.FormattingEnabled = true;
            this.Select_Search.Items.AddRange(new object[] {
            "کد دارو",
            "نام انگلیسی دارو",
            "نام فارسی دارو",
            "شکل دارویی"});
            this.Select_Search.Location = new System.Drawing.Point(525, 35);
            this.Select_Search.Name = "Select_Search";
            this.Select_Search.Size = new System.Drawing.Size(198, 27);
            this.Select_Search.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(568, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "نام ستون جستجو را وارد نمایید:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(387, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "کلمه جستجو را وارد نمایید:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Cancle
            // 
            this.Cancle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Cancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancle.Image = global::List_Drug.Properties.Resources.exit;
            this.Cancle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancle.Location = new System.Drawing.Point(0, 406);
            this.Cancle.Name = "Cancle";
            this.Cancle.Size = new System.Drawing.Size(800, 44);
            this.Cancle.TabIndex = 16;
            this.Cancle.Text = "انصراف";
            this.Cancle.UseVisualStyleBackColor = true;
            // 
            // List_Drug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.Cancle);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximizeBox = false;
            this.Name = "List_Drug";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لیست داروها";
            this.Load += new System.EventHandler(this.List_Drug_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Cancle;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Text_Search;
        private System.Windows.Forms.ComboBox Select_Search;
    }
}