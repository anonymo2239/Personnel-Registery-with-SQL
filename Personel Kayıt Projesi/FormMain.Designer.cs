namespace udemy_ders_21_Personel_Kayıt_Projesi_
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskSalary = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOccupation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbboxCity = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGraphics = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnUptade = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.perIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSituationDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.perOccupationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablePersonnelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelVeriTabaniDataSet = new udemy_ders_21_Personel_Kayıt_Projesi_.PersonelVeriTabaniDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.table_PersonnelTableAdapter = new udemy_ders_21_Personel_Kayıt_Projesi_.PersonelVeriTabaniDataSetTableAdapters.Table_PersonnelTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_logout = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePersonnelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mskSalary);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtOccupation);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbboxCity);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSurname);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label3);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // mskSalary
            // 
            resources.ApplyResources(this.mskSalary, "mskSalary");
            this.mskSalary.Name = "mskSalary";
            this.mskSalary.ValidatingType = typeof(int);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // radioButton2
            // 
            resources.ApplyResources(this.radioButton2, "radioButton2");
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            resources.ApplyResources(this.radioButton1, "radioButton1");
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // txtOccupation
            // 
            resources.ApplyResources(this.txtOccupation, "txtOccupation");
            this.txtOccupation.Name = "txtOccupation";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // cmbboxCity
            // 
            this.cmbboxCity.FormattingEnabled = true;
            this.cmbboxCity.Items.AddRange(new object[] {
            resources.GetString("cmbboxCity.Items"),
            resources.GetString("cmbboxCity.Items1"),
            resources.GetString("cmbboxCity.Items2"),
            resources.GetString("cmbboxCity.Items3"),
            resources.GetString("cmbboxCity.Items4"),
            resources.GetString("cmbboxCity.Items5"),
            resources.GetString("cmbboxCity.Items6"),
            resources.GetString("cmbboxCity.Items7"),
            resources.GetString("cmbboxCity.Items8"),
            resources.GetString("cmbboxCity.Items9"),
            resources.GetString("cmbboxCity.Items10"),
            resources.GetString("cmbboxCity.Items11"),
            resources.GetString("cmbboxCity.Items12"),
            resources.GetString("cmbboxCity.Items13"),
            resources.GetString("cmbboxCity.Items14"),
            resources.GetString("cmbboxCity.Items15"),
            resources.GetString("cmbboxCity.Items16"),
            resources.GetString("cmbboxCity.Items17"),
            resources.GetString("cmbboxCity.Items18"),
            resources.GetString("cmbboxCity.Items19"),
            resources.GetString("cmbboxCity.Items20"),
            resources.GetString("cmbboxCity.Items21"),
            resources.GetString("cmbboxCity.Items22"),
            resources.GetString("cmbboxCity.Items23"),
            resources.GetString("cmbboxCity.Items24"),
            resources.GetString("cmbboxCity.Items25"),
            resources.GetString("cmbboxCity.Items26"),
            resources.GetString("cmbboxCity.Items27"),
            resources.GetString("cmbboxCity.Items28"),
            resources.GetString("cmbboxCity.Items29"),
            resources.GetString("cmbboxCity.Items30"),
            resources.GetString("cmbboxCity.Items31"),
            resources.GetString("cmbboxCity.Items32"),
            resources.GetString("cmbboxCity.Items33"),
            resources.GetString("cmbboxCity.Items34"),
            resources.GetString("cmbboxCity.Items35"),
            resources.GetString("cmbboxCity.Items36"),
            resources.GetString("cmbboxCity.Items37"),
            resources.GetString("cmbboxCity.Items38"),
            resources.GetString("cmbboxCity.Items39"),
            resources.GetString("cmbboxCity.Items40"),
            resources.GetString("cmbboxCity.Items41"),
            resources.GetString("cmbboxCity.Items42"),
            resources.GetString("cmbboxCity.Items43"),
            resources.GetString("cmbboxCity.Items44"),
            resources.GetString("cmbboxCity.Items45"),
            resources.GetString("cmbboxCity.Items46"),
            resources.GetString("cmbboxCity.Items47"),
            resources.GetString("cmbboxCity.Items48"),
            resources.GetString("cmbboxCity.Items49"),
            resources.GetString("cmbboxCity.Items50"),
            resources.GetString("cmbboxCity.Items51"),
            resources.GetString("cmbboxCity.Items52"),
            resources.GetString("cmbboxCity.Items53"),
            resources.GetString("cmbboxCity.Items54"),
            resources.GetString("cmbboxCity.Items55"),
            resources.GetString("cmbboxCity.Items56"),
            resources.GetString("cmbboxCity.Items57"),
            resources.GetString("cmbboxCity.Items58"),
            resources.GetString("cmbboxCity.Items59"),
            resources.GetString("cmbboxCity.Items60"),
            resources.GetString("cmbboxCity.Items61"),
            resources.GetString("cmbboxCity.Items62"),
            resources.GetString("cmbboxCity.Items63"),
            resources.GetString("cmbboxCity.Items64"),
            resources.GetString("cmbboxCity.Items65"),
            resources.GetString("cmbboxCity.Items66"),
            resources.GetString("cmbboxCity.Items67"),
            resources.GetString("cmbboxCity.Items68"),
            resources.GetString("cmbboxCity.Items69"),
            resources.GetString("cmbboxCity.Items70"),
            resources.GetString("cmbboxCity.Items71"),
            resources.GetString("cmbboxCity.Items72"),
            resources.GetString("cmbboxCity.Items73"),
            resources.GetString("cmbboxCity.Items74"),
            resources.GetString("cmbboxCity.Items75"),
            resources.GetString("cmbboxCity.Items76"),
            resources.GetString("cmbboxCity.Items77"),
            resources.GetString("cmbboxCity.Items78"),
            resources.GetString("cmbboxCity.Items79"),
            resources.GetString("cmbboxCity.Items80")});
            resources.ApplyResources(this.cmbboxCity, "cmbboxCity");
            this.cmbboxCity.Name = "cmbboxCity";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtID
            // 
            resources.ApplyResources(this.txtID, "txtID");
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtSurname
            // 
            resources.ApplyResources(this.txtSurname, "txtSurname");
            this.txtSurname.Name = "txtSurname";
            // 
            // txtName
            // 
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.Name = "txtName";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnGraphics);
            this.groupBox2.Controls.Add(this.btnStatistics);
            this.groupBox2.Controls.Add(this.btnClean);
            this.groupBox2.Controls.Add(this.btnUptade);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnList);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGraphics
            // 
            resources.ApplyResources(this.btnGraphics, "btnGraphics");
            this.btnGraphics.Name = "btnGraphics";
            this.btnGraphics.UseVisualStyleBackColor = true;
            this.btnGraphics.Click += new System.EventHandler(this.btnGraphics_Click);
            // 
            // btnStatistics
            // 
            resources.ApplyResources(this.btnStatistics, "btnStatistics");
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnClean
            // 
            resources.ApplyResources(this.btnClean, "btnClean");
            this.btnClean.Name = "btnClean";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnUptade
            // 
            resources.ApplyResources(this.btnUptade, "btnUptade");
            this.btnUptade.Name = "btnUptade";
            this.btnUptade.UseVisualStyleBackColor = true;
            this.btnUptade.Click += new System.EventHandler(this.btnUptade_Click);
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnList
            // 
            resources.ApplyResources(this.btnList, "btnList");
            this.btnList.Name = "btnList";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.dataGridView1);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.perIDDataGridViewTextBoxColumn,
            this.perNameDataGridViewTextBoxColumn,
            this.perSurnameDataGridViewTextBoxColumn,
            this.perCityDataGridViewTextBoxColumn,
            this.perSalaryDataGridViewTextBoxColumn,
            this.perSituationDataGridViewCheckBoxColumn,
            this.perOccupationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tablePersonnelBindingSource;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // perIDDataGridViewTextBoxColumn
            // 
            this.perIDDataGridViewTextBoxColumn.DataPropertyName = "PerID";
            resources.ApplyResources(this.perIDDataGridViewTextBoxColumn, "perIDDataGridViewTextBoxColumn");
            this.perIDDataGridViewTextBoxColumn.Name = "perIDDataGridViewTextBoxColumn";
            this.perIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // perNameDataGridViewTextBoxColumn
            // 
            this.perNameDataGridViewTextBoxColumn.DataPropertyName = "PerName";
            resources.ApplyResources(this.perNameDataGridViewTextBoxColumn, "perNameDataGridViewTextBoxColumn");
            this.perNameDataGridViewTextBoxColumn.Name = "perNameDataGridViewTextBoxColumn";
            // 
            // perSurnameDataGridViewTextBoxColumn
            // 
            this.perSurnameDataGridViewTextBoxColumn.DataPropertyName = "PerSurname";
            resources.ApplyResources(this.perSurnameDataGridViewTextBoxColumn, "perSurnameDataGridViewTextBoxColumn");
            this.perSurnameDataGridViewTextBoxColumn.Name = "perSurnameDataGridViewTextBoxColumn";
            // 
            // perCityDataGridViewTextBoxColumn
            // 
            this.perCityDataGridViewTextBoxColumn.DataPropertyName = "PerCity";
            resources.ApplyResources(this.perCityDataGridViewTextBoxColumn, "perCityDataGridViewTextBoxColumn");
            this.perCityDataGridViewTextBoxColumn.Name = "perCityDataGridViewTextBoxColumn";
            // 
            // perSalaryDataGridViewTextBoxColumn
            // 
            this.perSalaryDataGridViewTextBoxColumn.DataPropertyName = "PerSalary";
            resources.ApplyResources(this.perSalaryDataGridViewTextBoxColumn, "perSalaryDataGridViewTextBoxColumn");
            this.perSalaryDataGridViewTextBoxColumn.Name = "perSalaryDataGridViewTextBoxColumn";
            // 
            // perSituationDataGridViewCheckBoxColumn
            // 
            this.perSituationDataGridViewCheckBoxColumn.DataPropertyName = "PerSituation";
            resources.ApplyResources(this.perSituationDataGridViewCheckBoxColumn, "perSituationDataGridViewCheckBoxColumn");
            this.perSituationDataGridViewCheckBoxColumn.Name = "perSituationDataGridViewCheckBoxColumn";
            // 
            // perOccupationDataGridViewTextBoxColumn
            // 
            this.perOccupationDataGridViewTextBoxColumn.DataPropertyName = "PerOccupation";
            resources.ApplyResources(this.perOccupationDataGridViewTextBoxColumn, "perOccupationDataGridViewTextBoxColumn");
            this.perOccupationDataGridViewTextBoxColumn.Name = "perOccupationDataGridViewTextBoxColumn";
            // 
            // tablePersonnelBindingSource
            // 
            this.tablePersonnelBindingSource.DataMember = "Table_Personnel";
            this.tablePersonnelBindingSource.DataSource = this.personelVeriTabaniDataSet;
            // 
            // personelVeriTabaniDataSet
            // 
            this.personelVeriTabaniDataSet.DataSetName = "PersonelVeriTabaniDataSet";
            this.personelVeriTabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // table_PersonnelTableAdapter
            // 
            this.table_PersonnelTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.aboutUsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            resources.ApplyResources(this.aboutUsToolStripMenuItem, "aboutUsToolStripMenuItem");
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // btn_logout
            // 
            resources.ApplyResources(this.btn_logout, "btn_logout");
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePersonnelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mskSalary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOccupation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbboxCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGraphics;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnUptade;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private PersonelVeriTabaniDataSet personelVeriTabaniDataSet;
        private System.Windows.Forms.BindingSource tablePersonnelBindingSource;
        private PersonelVeriTabaniDataSetTableAdapters.Table_PersonnelTableAdapter table_PersonnelTableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn perIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perSituationDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perOccupationDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_logout;
    }
}

