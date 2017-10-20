namespace TeCSSchoolManagmentSystem
{
    partial class MainWindow
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.table = new System.Windows.Forms.DataGridView();
            this.Student_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.First_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Math = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Physics = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Computing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Economics = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.English = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Business = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Biology = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chemistry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Average = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ranking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Progressing_decision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbCourseCode = new System.Windows.Forms.ComboBox();
            this.txtRanking = new System.Windows.Forms.TextBox();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.txtTotalScore = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.txtChemistry = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEconomics = new System.Windows.Forms.TextBox();
            this.txtBiology = new System.Windows.Forms.TextBox();
            this.lblMath = new System.Windows.Forms.Label();
            this.txtComputing = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBusiness = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPhysics = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rtTranscript = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtProgressionDecision = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.btnLoadFromFile = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnTranscript = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRanking = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student_ID,
            this.First_Name,
            this.Surname,
            this.Math,
            this.Physics,
            this.Computing,
            this.Economics,
            this.English,
            this.Business,
            this.Biology,
            this.Chemistry,
            this.Average,
            this.Ranking,
            this.Total_Score,
            this.Progressing_decision});
            this.table.Location = new System.Drawing.Point(12, 336);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(1008, 182);
            this.table.TabIndex = 0;
            this.table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cell_click);
            // 
            // Student_ID
            // 
            this.Student_ID.HeaderText = "Student_ID";
            this.Student_ID.Name = "Student_ID";
            this.Student_ID.ReadOnly = true;
            this.Student_ID.ToolTipText = "Student_ID";
            // 
            // First_Name
            // 
            this.First_Name.HeaderText = "First_Name";
            this.First_Name.Name = "First_Name";
            this.First_Name.ReadOnly = true;
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Surname";
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            // 
            // Math
            // 
            this.Math.HeaderText = "Math";
            this.Math.Name = "Math";
            this.Math.ReadOnly = true;
            this.Math.ToolTipText = "Math";
            // 
            // Physics
            // 
            this.Physics.HeaderText = "Physics";
            this.Physics.Name = "Physics";
            this.Physics.ReadOnly = true;
            // 
            // Computing
            // 
            this.Computing.HeaderText = "Computing";
            this.Computing.Name = "Computing";
            this.Computing.ReadOnly = true;
            // 
            // Economics
            // 
            this.Economics.HeaderText = "Economics";
            this.Economics.Name = "Economics";
            this.Economics.ReadOnly = true;
            // 
            // English
            // 
            this.English.HeaderText = "English";
            this.English.Name = "English";
            this.English.ReadOnly = true;
            // 
            // Business
            // 
            this.Business.HeaderText = "Business";
            this.Business.Name = "Business";
            this.Business.ReadOnly = true;
            // 
            // Biology
            // 
            this.Biology.HeaderText = "Biology";
            this.Biology.Name = "Biology";
            this.Biology.ReadOnly = true;
            // 
            // Chemistry
            // 
            this.Chemistry.HeaderText = "Chemistry";
            this.Chemistry.Name = "Chemistry";
            this.Chemistry.ReadOnly = true;
            // 
            // Average
            // 
            this.Average.HeaderText = "Average";
            this.Average.Name = "Average";
            this.Average.ReadOnly = true;
            // 
            // Ranking
            // 
            this.Ranking.HeaderText = "Ranking";
            this.Ranking.Name = "Ranking";
            this.Ranking.ReadOnly = true;
            // 
            // Total_Score
            // 
            this.Total_Score.HeaderText = "Total_Score";
            this.Total_Score.Name = "Total_Score";
            this.Total_Score.ReadOnly = true;
            // 
            // Progressing_decision
            // 
            this.Progressing_decision.HeaderText = "Progressing_decision";
            this.Progressing_decision.Name = "Progressing_decision";
            this.Progressing_decision.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.cmbCourseCode);
            this.groupBox1.Controls.Add(this.txtRanking);
            this.groupBox1.Controls.Add(this.txtAverage);
            this.groupBox1.Controls.Add(this.txtTotalScore);
            this.groupBox1.Controls.Add(this.txtSurname);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.txtStudentID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 308);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(20, 142);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 19);
            this.label14.TabIndex = 3;
            this.label14.Text = "Course code:";
            // 
            // cmbCourseCode
            // 
            this.cmbCourseCode.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbCourseCode.FormattingEnabled = true;
            this.cmbCourseCode.Location = new System.Drawing.Point(139, 139);
            this.cmbCourseCode.Name = "cmbCourseCode";
            this.cmbCourseCode.Size = new System.Drawing.Size(121, 26);
            this.cmbCourseCode.TabIndex = 2;
            // 
            // txtRanking
            // 
            this.txtRanking.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtRanking.Location = new System.Drawing.Point(139, 254);
            this.txtRanking.Name = "txtRanking";
            this.txtRanking.Size = new System.Drawing.Size(121, 25);
            this.txtRanking.TabIndex = 1;
            this.txtRanking.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validator);
            // 
            // txtAverage
            // 
            this.txtAverage.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAverage.Location = new System.Drawing.Point(139, 216);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.Size = new System.Drawing.Size(121, 25);
            this.txtAverage.TabIndex = 1;
            this.txtAverage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validator);
            // 
            // txtTotalScore
            // 
            this.txtTotalScore.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTotalScore.Location = new System.Drawing.Point(139, 178);
            this.txtTotalScore.Name = "txtTotalScore";
            this.txtTotalScore.Size = new System.Drawing.Size(121, 25);
            this.txtTotalScore.TabIndex = 1;
            this.txtTotalScore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validator);
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSurname.Location = new System.Drawing.Point(139, 101);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(121, 25);
            this.txtSurname.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFirstName.Location = new System.Drawing.Point(139, 63);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(121, 25);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtStudentID.Location = new System.Drawing.Point(139, 25);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(121, 25);
            this.txtStudentID.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(20, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ranking:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(20, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Average:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(20, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total score:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(20, 100);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 19);
            this.label15.TabIndex = 0;
            this.label15.Text = "Surname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(20, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Firstname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "StudentID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEnglish);
            this.groupBox2.Controls.Add(this.txtChemistry);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtEconomics);
            this.groupBox2.Controls.Add(this.txtBiology);
            this.groupBox2.Controls.Add(this.lblMath);
            this.groupBox2.Controls.Add(this.txtComputing);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtBusiness);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtPhysics);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtMath);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(314, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 308);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // txtEnglish
            // 
            this.txtEnglish.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtEnglish.Location = new System.Drawing.Point(132, 165);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(100, 25);
            this.txtEnglish.TabIndex = 1;
            this.txtEnglish.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validator);
            // 
            // txtChemistry
            // 
            this.txtChemistry.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtChemistry.Location = new System.Drawing.Point(132, 270);
            this.txtChemistry.Name = "txtChemistry";
            this.txtChemistry.Size = new System.Drawing.Size(100, 25);
            this.txtChemistry.TabIndex = 1;
            this.txtChemistry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validator);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(18, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Physics:";
            // 
            // txtEconomics
            // 
            this.txtEconomics.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtEconomics.Location = new System.Drawing.Point(132, 130);
            this.txtEconomics.Name = "txtEconomics";
            this.txtEconomics.Size = new System.Drawing.Size(100, 25);
            this.txtEconomics.TabIndex = 1;
            this.txtEconomics.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validator);
            // 
            // txtBiology
            // 
            this.txtBiology.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBiology.Location = new System.Drawing.Point(132, 235);
            this.txtBiology.Name = "txtBiology";
            this.txtBiology.Size = new System.Drawing.Size(100, 25);
            this.txtBiology.TabIndex = 1;
            this.txtBiology.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validator);
            // 
            // lblMath
            // 
            this.lblMath.AutoSize = true;
            this.lblMath.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMath.Location = new System.Drawing.Point(18, 31);
            this.lblMath.Name = "lblMath";
            this.lblMath.Size = new System.Drawing.Size(52, 19);
            this.lblMath.TabIndex = 0;
            this.lblMath.Text = "Math:";
            // 
            // txtComputing
            // 
            this.txtComputing.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtComputing.Location = new System.Drawing.Point(132, 95);
            this.txtComputing.Name = "txtComputing";
            this.txtComputing.Size = new System.Drawing.Size(100, 25);
            this.txtComputing.TabIndex = 1;
            this.txtComputing.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validator);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(18, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 19);
            this.label13.TabIndex = 0;
            this.label13.Text = "Computing:";
            // 
            // txtBusiness
            // 
            this.txtBusiness.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBusiness.Location = new System.Drawing.Point(132, 200);
            this.txtBusiness.Name = "txtBusiness";
            this.txtBusiness.Size = new System.Drawing.Size(100, 25);
            this.txtBusiness.TabIndex = 1;
            this.txtBusiness.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validator);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(18, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Business:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(18, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 19);
            this.label12.TabIndex = 0;
            this.label12.Text = "Economics:";
            // 
            // txtPhysics
            // 
            this.txtPhysics.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPhysics.Location = new System.Drawing.Point(132, 60);
            this.txtPhysics.Name = "txtPhysics";
            this.txtPhysics.Size = new System.Drawing.Size(100, 25);
            this.txtPhysics.TabIndex = 1;
            this.txtPhysics.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validator);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(18, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Biology:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(18, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "English:";
            // 
            // txtMath
            // 
            this.txtMath.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMath.Location = new System.Drawing.Point(132, 25);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(100, 25);
            this.txtMath.TabIndex = 1;
            this.txtMath.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validator);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(18, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Chemistry:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rtTranscript);
            this.groupBox3.Location = new System.Drawing.Point(594, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(426, 308);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // rtTranscript
            // 
            this.rtTranscript.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtTranscript.Location = new System.Drawing.Point(6, 19);
            this.rtTranscript.Name = "rtTranscript";
            this.rtTranscript.Size = new System.Drawing.Size(414, 278);
            this.rtTranscript.TabIndex = 0;
            this.rtTranscript.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtProgressionDecision);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(12, 524);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(194, 104);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // txtProgressionDecision
            // 
            this.txtProgressionDecision.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtProgressionDecision.Location = new System.Drawing.Point(16, 62);
            this.txtProgressionDecision.Name = "txtProgressionDecision";
            this.txtProgressionDecision.Size = new System.Drawing.Size(162, 25);
            this.txtProgressionDecision.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Progression decision:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnExit);
            this.groupBox5.Controls.Add(this.btnSaveToFile);
            this.groupBox5.Controls.Add(this.btnLoadFromFile);
            this.groupBox5.Controls.Add(this.btnReset);
            this.groupBox5.Controls.Add(this.btnUpdate);
            this.groupBox5.Controls.Add(this.btnClear);
            this.groupBox5.Controls.Add(this.btnTranscript);
            this.groupBox5.Controls.Add(this.btnDelete);
            this.groupBox5.Controls.Add(this.btnRanking);
            this.groupBox5.Location = new System.Drawing.Point(212, 524);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(808, 104);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(526, 65);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(264, 33);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveToFile.Location = new System.Drawing.Point(661, 19);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(129, 33);
            this.btnSaveToFile.TabIndex = 0;
            this.btnSaveToFile.Text = "Save to file";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // btnLoadFromFile
            // 
            this.btnLoadFromFile.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoadFromFile.Location = new System.Drawing.Point(526, 19);
            this.btnLoadFromFile.Name = "btnLoadFromFile";
            this.btnLoadFromFile.Size = new System.Drawing.Size(129, 33);
            this.btnLoadFromFile.TabIndex = 0;
            this.btnLoadFromFile.Text = "Load from file";
            this.btnLoadFromFile.UseVisualStyleBackColor = true;
            this.btnLoadFromFile.Click += new System.EventHandler(this.btnLoadFromFile_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.Location = new System.Drawing.Point(358, 65);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(136, 33);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdate.Location = new System.Drawing.Point(358, 19);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(136, 33);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.Location = new System.Drawing.Point(190, 65);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(136, 33);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnTranscript
            // 
            this.btnTranscript.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTranscript.Location = new System.Drawing.Point(190, 19);
            this.btnTranscript.Name = "btnTranscript";
            this.btnTranscript.Size = new System.Drawing.Size(136, 33);
            this.btnTranscript.TabIndex = 0;
            this.btnTranscript.Text = "Transcript";
            this.btnTranscript.UseVisualStyleBackColor = true;
            this.btnTranscript.Click += new System.EventHandler(this.btnTranscript_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(22, 65);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(136, 33);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRanking
            // 
            this.btnRanking.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRanking.Location = new System.Drawing.Point(22, 19);
            this.btnRanking.Name = "btnRanking";
            this.btnRanking.Size = new System.Drawing.Size(136, 33);
            this.btnRanking.TabIndex = 0;
            this.btnRanking.Text = "Ranking";
            this.btnRanking.UseVisualStyleBackColor = true;
            this.btnRanking.Click += new System.EventHandler(this.btnRanking_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 631);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.table);
            this.MaximumSize = new System.Drawing.Size(1040, 665);
            this.MinimumSize = new System.Drawing.Size(1040, 665);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeSchoolManagmentSystem";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbCourseCode;
        private System.Windows.Forms.TextBox txtRanking;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.TextBox txtTotalScore;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.TextBox txtChemistry;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEconomics;
        private System.Windows.Forms.TextBox txtBiology;
        private System.Windows.Forms.Label lblMath;
        private System.Windows.Forms.TextBox txtComputing;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBusiness;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPhysics;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnTranscript;
        private System.Windows.Forms.Button btnRanking;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLoadFromFile;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtProgressionDecision;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtTranscript;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn First_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Math;
        private System.Windows.Forms.DataGridViewTextBoxColumn Physics;
        private System.Windows.Forms.DataGridViewTextBoxColumn Computing;
        private System.Windows.Forms.DataGridViewTextBoxColumn Economics;
        private System.Windows.Forms.DataGridViewTextBoxColumn English;
        private System.Windows.Forms.DataGridViewTextBoxColumn Business;
        private System.Windows.Forms.DataGridViewTextBoxColumn Biology;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chemistry;
        private System.Windows.Forms.DataGridViewTextBoxColumn Average;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ranking;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn Progressing_decision;
        private System.Windows.Forms.Button btnSaveToFile;
    }
}

