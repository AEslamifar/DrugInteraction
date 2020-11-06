using System.Windows.Forms;

namespace List_Drug
{
    partial class Enter_Drug_Information
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Enter_Drug_Information));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Name_Group_Drug = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TextBox_Advices = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox_Name_Fa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TextBox_Pharmaceutical_Form = new System.Windows.Forms.TextBox();
            this.TextBox_Name_En = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TextBox_DrugCode = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TextBoxDIComplications = new System.Windows.Forms.TextBox();
            this.dataGridViewDI = new System.Windows.Forms.DataGridView();
            this.label19 = new System.Windows.Forms.Label();
            this.btnAddDrugInteraction = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.TextBoxDI_Occurrence_Probability = new System.Windows.Forms.TextBox();
            this.TextBoxDI_Sart_Time = new System.Windows.Forms.TextBox();
            this.TextBoxDI_Drug = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.TextBoxFI_Food = new System.Windows.Forms.TextBox();
            this.dataGridViewFI = new System.Windows.Forms.DataGridView();
            this.TextBoxFI_Descriptions = new System.Windows.Forms.TextBox();
            this.btnAddFoodInteraction = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.TextBoxFI_Complications = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnSaveAll = new System.Windows.Forms.Button();
            this.dataGridViewDEI = new System.Windows.Forms.DataGridView();
            this.TextBoxDEI_Probability_Occurrence = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnAddEffectInteraction = new System.Windows.Forms.Button();
            this.TextBoxDEI_Drug = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDI)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFI)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDEI)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Name_Group_Drug);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.TextBox_Advices);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.TextBox_Name_Fa);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.TextBox_Pharmaceutical_Form);
            this.groupBox2.Controls.Add(this.TextBox_Name_En);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.TextBox_DrugCode);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Location = new System.Drawing.Point(6, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(926, 81);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "اطلاعات دارو";
            // 
            // Name_Group_Drug
            // 
            this.Name_Group_Drug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Name_Group_Drug.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Name_Group_Drug.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name_Group_Drug.FormattingEnabled = true;
            this.Name_Group_Drug.Location = new System.Drawing.Point(327, 21);
            this.Name_Group_Drug.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name_Group_Drug.Name = "Name_Group_Drug";
            this.Name_Group_Drug.Size = new System.Drawing.Size(172, 24);
            this.Name_Group_Drug.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(174, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 18);
            this.label13.TabIndex = 4;
            this.label13.Text = "توصیه های  مصرف:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TextBox_Advices
            // 
            this.TextBox_Advices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_Advices.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TextBox_Advices.Location = new System.Drawing.Point(18, 20);
            this.TextBox_Advices.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox_Advices.Name = "TextBox_Advices";
            this.TextBox_Advices.Size = new System.Drawing.Size(150, 23);
            this.TextBox_Advices.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(174, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "شکل دارویی:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TextBox_Name_Fa
            // 
            this.TextBox_Name_Fa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_Name_Fa.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TextBox_Name_Fa.Location = new System.Drawing.Point(644, 51);
            this.TextBox_Name_Fa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox_Name_Fa.Name = "TextBox_Name_Fa";
            this.TextBox_Name_Fa.Size = new System.Drawing.Size(185, 23);
            this.TextBox_Name_Fa.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(835, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "نام فارسی دارو:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(515, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 18);
            this.label14.TabIndex = 4;
            this.label14.Text = "نام گروه دارویی:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TextBox_Pharmaceutical_Form
            // 
            this.TextBox_Pharmaceutical_Form.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_Pharmaceutical_Form.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TextBox_Pharmaceutical_Form.Location = new System.Drawing.Point(18, 49);
            this.TextBox_Pharmaceutical_Form.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox_Pharmaceutical_Form.Name = "TextBox_Pharmaceutical_Form";
            this.TextBox_Pharmaceutical_Form.Size = new System.Drawing.Size(150, 23);
            this.TextBox_Pharmaceutical_Form.TabIndex = 5;
            // 
            // TextBox_Name_En
            // 
            this.TextBox_Name_En.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_Name_En.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TextBox_Name_En.Location = new System.Drawing.Point(644, 24);
            this.TextBox_Name_En.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox_Name_En.Name = "TextBox_Name_En";
            this.TextBox_Name_En.Size = new System.Drawing.Size(185, 23);
            this.TextBox_Name_En.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label15.Location = new System.Drawing.Point(835, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 18);
            this.label15.TabIndex = 4;
            this.label15.Text = "نام انگلیسی دارو:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TextBox_DrugCode
            // 
            this.TextBox_DrugCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_DrugCode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TextBox_DrugCode.Location = new System.Drawing.Point(327, 49);
            this.TextBox_DrugCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox_DrugCode.Name = "TextBox_DrugCode";
            this.TextBox_DrugCode.Size = new System.Drawing.Size(172, 23);
            this.TextBox_DrugCode.TabIndex = 5;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label18.Location = new System.Drawing.Point(558, 53);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 18);
            this.label18.TabIndex = 4;
            this.label18.Text = "کد دارو:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.TextBoxDIComplications);
            this.groupBox4.Controls.Add(this.dataGridViewDI);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.btnAddDrugInteraction);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.TextBoxDI_Occurrence_Probability);
            this.groupBox4.Controls.Add(this.TextBoxDI_Sart_Time);
            this.groupBox4.Controls.Add(this.TextBoxDI_Drug);
            this.groupBox4.Location = new System.Drawing.Point(6, 86);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(926, 200);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "تداخل های دارویی";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(515, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "مدت شروع عوارض:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TextBoxDIComplications
            // 
            this.TextBoxDIComplications.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxDIComplications.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TextBoxDIComplications.Location = new System.Drawing.Point(327, 52);
            this.TextBoxDIComplications.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxDIComplications.Name = "TextBoxDIComplications";
            this.TextBoxDIComplications.Size = new System.Drawing.Size(172, 23);
            this.TextBoxDIComplications.TabIndex = 5;
            // 
            // dataGridViewDI
            // 
            this.dataGridViewDI.AllowUserToAddRows = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewDI.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewDI.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDI.Location = new System.Drawing.Point(71, 80);
            this.dataGridViewDI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewDI.Name = "dataGridViewDI";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewDI.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewDI.Size = new System.Drawing.Size(758, 111);
            this.dataGridViewDI.TabIndex = 22;
            this.dataGridViewDI.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDI_CellClick);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label19.Location = new System.Drawing.Point(835, 54);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(75, 18);
            this.label19.TabIndex = 4;
            this.label19.Text = "احتمال وقوع:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAddDrugInteraction
            // 
            this.btnAddDrugInteraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDrugInteraction.Image = ((System.Drawing.Image)(resources.GetObject("btnAddDrugInteraction.Image")));
            this.btnAddDrugInteraction.Location = new System.Drawing.Point(71, 26);
            this.btnAddDrugInteraction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddDrugInteraction.Name = "btnAddDrugInteraction";
            this.btnAddDrugInteraction.Size = new System.Drawing.Size(67, 49);
            this.btnAddDrugInteraction.TabIndex = 0;
            this.btnAddDrugInteraction.UseVisualStyleBackColor = true;
            this.btnAddDrugInteraction.Click += new System.EventHandler(this.Btn_AddDrugInteraction_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(515, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "عوارض تداخل:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label23.Location = new System.Drawing.Point(833, 26);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(96, 18);
            this.label23.TabIndex = 4;
            this.label23.Text = "نام داروی تداخلی:";
            this.label23.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TextBoxDI_Occurrence_Probability
            // 
            this.TextBoxDI_Occurrence_Probability.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxDI_Occurrence_Probability.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TextBoxDI_Occurrence_Probability.Location = new System.Drawing.Point(644, 52);
            this.TextBoxDI_Occurrence_Probability.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxDI_Occurrence_Probability.Name = "TextBoxDI_Occurrence_Probability";
            this.TextBoxDI_Occurrence_Probability.Size = new System.Drawing.Size(185, 23);
            this.TextBoxDI_Occurrence_Probability.TabIndex = 5;
            // 
            // TextBoxDI_Sart_Time
            // 
            this.TextBoxDI_Sart_Time.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxDI_Sart_Time.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TextBoxDI_Sart_Time.Location = new System.Drawing.Point(327, 26);
            this.TextBoxDI_Sart_Time.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxDI_Sart_Time.Name = "TextBoxDI_Sart_Time";
            this.TextBoxDI_Sart_Time.Size = new System.Drawing.Size(172, 23);
            this.TextBoxDI_Sart_Time.TabIndex = 5;
            // 
            // TextBoxDI_Drug
            // 
            this.TextBoxDI_Drug.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxDI_Drug.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TextBoxDI_Drug.Location = new System.Drawing.Point(644, 26);
            this.TextBoxDI_Drug.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxDI_Drug.Name = "TextBoxDI_Drug";
            this.TextBoxDI_Drug.Size = new System.Drawing.Size(185, 23);
            this.TextBoxDI_Drug.TabIndex = 5;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Honeydew;
            this.groupBox5.Controls.Add(this.TextBoxFI_Food);
            this.groupBox5.Controls.Add(this.dataGridViewFI);
            this.groupBox5.Controls.Add(this.TextBoxFI_Descriptions);
            this.groupBox5.Controls.Add(this.btnAddFoodInteraction);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.TextBoxFI_Complications);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Location = new System.Drawing.Point(6, 294);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(926, 215);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "تداخل های غذایی";
            // 
            // TextBoxFI_Food
            // 
            this.TextBoxFI_Food.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxFI_Food.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TextBoxFI_Food.Location = new System.Drawing.Point(644, 28);
            this.TextBoxFI_Food.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxFI_Food.Name = "TextBoxFI_Food";
            this.TextBoxFI_Food.Size = new System.Drawing.Size(185, 23);
            this.TextBoxFI_Food.TabIndex = 6;
            // 
            // dataGridViewFI
            // 
            this.dataGridViewFI.AllowUserToAddRows = false;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewFI.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewFI.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewFI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFI.Location = new System.Drawing.Point(71, 81);
            this.dataGridViewFI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewFI.Name = "dataGridViewFI";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewFI.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewFI.Size = new System.Drawing.Size(758, 122);
            this.dataGridViewFI.TabIndex = 22;
            this.dataGridViewFI.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFI_CellClick);
            // 
            // TextBoxFI_Descriptions
            // 
            this.TextBoxFI_Descriptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxFI_Descriptions.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TextBoxFI_Descriptions.Location = new System.Drawing.Point(178, 54);
            this.TextBoxFI_Descriptions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxFI_Descriptions.Name = "TextBoxFI_Descriptions";
            this.TextBoxFI_Descriptions.Size = new System.Drawing.Size(651, 23);
            this.TextBoxFI_Descriptions.TabIndex = 5;
            // 
            // btnAddFoodInteraction
            // 
            this.btnAddFoodInteraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFoodInteraction.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFoodInteraction.Image")));
            this.btnAddFoodInteraction.Location = new System.Drawing.Point(71, 28);
            this.btnAddFoodInteraction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddFoodInteraction.Name = "btnAddFoodInteraction";
            this.btnAddFoodInteraction.Size = new System.Drawing.Size(67, 49);
            this.btnAddFoodInteraction.TabIndex = 0;
            this.btnAddFoodInteraction.UseVisualStyleBackColor = true;
            this.btnAddFoodInteraction.Click += new System.EventHandler(this.Btn_AddFoodInteraction_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(515, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 18);
            this.label9.TabIndex = 4;
            this.label9.Text = "عوارض تداخل غذایی:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TextBoxFI_Complications
            // 
            this.TextBoxFI_Complications.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxFI_Complications.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TextBoxFI_Complications.Location = new System.Drawing.Point(178, 28);
            this.TextBoxFI_Complications.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxFI_Complications.Name = "TextBoxFI_Complications";
            this.TextBoxFI_Complications.Size = new System.Drawing.Size(321, 23);
            this.TextBoxFI_Complications.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(835, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 18);
            this.label11.TabIndex = 4;
            this.label11.Text = "نام غذای تداخلی:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(835, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 18);
            this.label12.TabIndex = 4;
            this.label12.Text = "توضیحات :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox3.Controls.Add(this.dataGridViewDEI);
            this.groupBox3.Controls.Add(this.TextBoxDEI_Probability_Occurrence);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.btnAddEffectInteraction);
            this.groupBox3.Controls.Add(this.TextBoxDEI_Drug);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Location = new System.Drawing.Point(6, 514);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(926, 169);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "تداخل های دارویی موثر در میزان اثر گذاری";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnCancel);
            this.groupBox1.Controls.Add(this.BtnDelete);
            this.groupBox1.Controls.Add(this.BtnUpdate);
            this.groupBox1.Controls.Add(this.BtnSaveAll);
            this.groupBox1.Location = new System.Drawing.Point(77, 687);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(486, 76);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // BtnCancel
            // 
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Image = global::List_Drug.Properties.Resources.exit;
            this.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancel.Location = new System.Drawing.Point(335, 19);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(104, 49);
            this.BtnCancel.TabIndex = 0;
            this.BtnCancel.Text = "انصراف";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancle_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Image = global::List_Drug.Properties.Resources.delete;
            this.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDelete.Location = new System.Drawing.Point(126, 19);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(102, 49);
            this.BtnDelete.TabIndex = 0;
            this.BtnDelete.Text = "حذف";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Image = global::List_Drug.Properties.Resources.update;
            this.BtnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUpdate.Location = new System.Drawing.Point(17, 19);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(103, 49);
            this.BtnUpdate.TabIndex = 0;
            this.BtnUpdate.Text = "ویرایش";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnSaveAll
            // 
            this.BtnSaveAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSaveAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSaveAll.Image = global::List_Drug.Properties.Resources.Untitled;
            this.BtnSaveAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSaveAll.Location = new System.Drawing.Point(234, 19);
            this.BtnSaveAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSaveAll.Name = "BtnSaveAll";
            this.BtnSaveAll.Size = new System.Drawing.Size(95, 49);
            this.BtnSaveAll.TabIndex = 0;
            this.BtnSaveAll.Text = "ذخیره";
            this.BtnSaveAll.UseVisualStyleBackColor = true;
            this.BtnSaveAll.Click += new System.EventHandler(this.BtnSaveAll_Click);
            // 
            // dataGridViewDEI
            // 
            this.dataGridViewDEI.AllowUserToAddRows = false;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dataGridViewDEI.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewDEI.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDEI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDEI.Location = new System.Drawing.Point(71, 60);
            this.dataGridViewDEI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewDEI.Name = "dataGridViewDEI";
            this.dataGridViewDEI.Size = new System.Drawing.Size(758, 92);
            this.dataGridViewDEI.TabIndex = 22;
            this.dataGridViewDEI.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDEI_CellClick);
            // 
            // TextBoxDEI_Probability_Occurrence
            // 
            this.TextBoxDEI_Probability_Occurrence.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxDEI_Probability_Occurrence.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TextBoxDEI_Probability_Occurrence.Location = new System.Drawing.Point(188, 33);
            this.TextBoxDEI_Probability_Occurrence.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxDEI_Probability_Occurrence.Name = "TextBoxDEI_Probability_Occurrence";
            this.TextBoxDEI_Probability_Occurrence.Size = new System.Drawing.Size(321, 23);
            this.TextBoxDEI_Probability_Occurrence.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("IRANSans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label16.Location = new System.Drawing.Point(515, 36);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 18);
            this.label16.TabIndex = 4;
            this.label16.Text = "نوع اثر گذاری:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAddEffectInteraction
            // 
            this.btnAddEffectInteraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEffectInteraction.Image = global::List_Drug.Properties.Resources.add;
            this.btnAddEffectInteraction.Location = new System.Drawing.Point(71, 20);
            this.btnAddEffectInteraction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddEffectInteraction.Name = "btnAddEffectInteraction";
            this.btnAddEffectInteraction.Size = new System.Drawing.Size(67, 36);
            this.btnAddEffectInteraction.TabIndex = 0;
            this.btnAddEffectInteraction.UseVisualStyleBackColor = true;
            this.btnAddEffectInteraction.Click += new System.EventHandler(this.Btn_AddEffectInteraction_Click);
            // 
            // TextBoxDEI_Drug
            // 
            this.TextBoxDEI_Drug.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxDEI_Drug.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TextBoxDEI_Drug.Location = new System.Drawing.Point(644, 33);
            this.TextBoxDEI_Drug.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxDEI_Drug.Name = "TextBoxDEI_Drug";
            this.TextBoxDEI_Drug.Size = new System.Drawing.Size(185, 23);
            this.TextBoxDEI_Drug.TabIndex = 5;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("IRANSans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label20.Location = new System.Drawing.Point(835, 33);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(109, 18);
            this.label20.TabIndex = 4;
            this.label20.Text = "نام داروی اثر متقابل:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(966, 749);
            this.panel1.TabIndex = 25;
            // 
            // Enter_Drug_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(966, 749);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Enter_Drug_Information";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "افزودن داروی جدید";
            this.Load += new System.EventHandler(this.Enter_Drug_Information_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDI)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFI)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDEI)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox2;
        private ComboBox Name_Group_Drug;
        private Label label13;
        private TextBox TextBox_Advices;
        private Label label2;
        private TextBox TextBox_Name_Fa;
        private Label label1;
        private Label label14;
        private TextBox TextBox_Pharmaceutical_Form;
        private TextBox TextBox_Name_En;
        private Label label15;
        private TextBox TextBox_DrugCode;
        private Label label18;
        private GroupBox groupBox4;
        private Label label7;
        private TextBox TextBoxDIComplications;
        private DataGridView dataGridViewDI;
        private Label label19;
        private Button btnAddDrugInteraction;
        private Label label8;
        private Label label23;
        private TextBox TextBoxDI_Occurrence_Probability;
        private TextBox TextBoxDI_Sart_Time;
        private TextBox TextBoxDI_Drug;
        private GroupBox groupBox5;
        private TextBox TextBoxFI_Food;
        private DataGridView dataGridViewFI;
        private TextBox TextBoxFI_Descriptions;
        private Button btnAddFoodInteraction;
        private Label label9;
        private TextBox TextBoxFI_Complications;
        private Label label11;
        private Label label12;
        private GroupBox groupBox3;
        private GroupBox groupBox1;
        private Button BtnCancel;
        private Button BtnDelete;
        private Button BtnUpdate;
        private Button BtnSaveAll;
        private DataGridView dataGridViewDEI;
        private TextBox TextBoxDEI_Probability_Occurrence;
        private Label label16;
        private Button btnAddEffectInteraction;
        private TextBox TextBoxDEI_Drug;
        private Label label20;
        private Panel panel1;
    }
}