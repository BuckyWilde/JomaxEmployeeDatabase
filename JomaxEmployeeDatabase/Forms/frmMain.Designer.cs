namespace JomaxEmployeeDatabase
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelTotalRecords = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelActualRecords = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusOperation = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.employeesGridView = new System.Windows.Forms.DataGridView();
            this.fullNameLastNameFirstDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lastNameFirstDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteCert = new System.Windows.Forms.Button();
            this.btnAddCert = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.certificateGridView = new System.Windows.Forms.DataGridView();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateInitialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateExpiresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doesExpireDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.certificateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtxtVacationComments = new System.Windows.Forms.RichTextBox();
            this.txtVacationDaysRemaining = new System.Windows.Forms.TextBox();
            this.numVacationDaysUsed = new System.Windows.Forms.NumericUpDown();
            this.txtVacationDaysTotal = new System.Windows.Forms.TextBox();
            this.numVacationDaysAccrued = new System.Windows.Forms.NumericUpDown();
            this.numVacationDaysInitial = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.cmbJobTitle = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.certificateGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVacationDaysUsed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVacationDaysAccrued)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVacationDaysInitial)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelTotalRecords,
            this.toolStripStatusLabelActualRecords,
            this.toolStripStatusOperation});
            this.statusStrip1.Location = new System.Drawing.Point(0, 625);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1040, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelTotalRecords
            // 
            this.toolStripStatusLabelTotalRecords.Name = "toolStripStatusLabelTotalRecords";
            this.toolStripStatusLabelTotalRecords.Size = new System.Drawing.Size(77, 17);
            this.toolStripStatusLabelTotalRecords.Text = "Total Records";
            // 
            // toolStripStatusLabelActualRecords
            // 
            this.toolStripStatusLabelActualRecords.Name = "toolStripStatusLabelActualRecords";
            this.toolStripStatusLabelActualRecords.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusLabelActualRecords.Text = "0";
            // 
            // toolStripStatusOperation
            // 
            this.toolStripStatusOperation.Margin = new System.Windows.Forms.Padding(100, 3, 0, 2);
            this.toolStripStatusOperation.Name = "toolStripStatusOperation";
            this.toolStripStatusOperation.Size = new System.Drawing.Size(115, 17);
            this.toolStripStatusOperation.Text = "Ready for command";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1040, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.employeesGridView);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 585);
            this.panel1.TabIndex = 3;
            // 
            // employeesGridView
            // 
            this.employeesGridView.AllowUserToResizeRows = false;
            this.employeesGridView.AutoGenerateColumns = false;
            this.employeesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employeesGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.employeesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullNameLastNameFirstDataGridViewTextBoxColumn,
            this.jobTitleDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn});
            this.employeesGridView.DataSource = this.employeeBindingSource;
            this.employeesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeesGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.employeesGridView.Location = new System.Drawing.Point(0, 0);
            this.employeesGridView.MultiSelect = false;
            this.employeesGridView.Name = "employeesGridView";
            this.employeesGridView.RowHeadersVisible = false;
            this.employeesGridView.RowTemplate.Height = 25;
            this.employeesGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.employeesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeesGridView.Size = new System.Drawing.Size(353, 581);
            this.employeesGridView.TabIndex = 0;
            this.employeesGridView.TabStop = false;
            this.employeesGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeesGridView_CellClick);
            // 
            // fullNameLastNameFirstDataGridViewTextBoxColumn
            // 
            this.fullNameLastNameFirstDataGridViewTextBoxColumn.DataPropertyName = "FullName_LastNameFirst";
            this.fullNameLastNameFirstDataGridViewTextBoxColumn.HeaderText = "Name";
            this.fullNameLastNameFirstDataGridViewTextBoxColumn.Name = "fullNameLastNameFirstDataGridViewTextBoxColumn";
            this.fullNameLastNameFirstDataGridViewTextBoxColumn.ReadOnly = true;
            this.fullNameLastNameFirstDataGridViewTextBoxColumn.ToolTipText = "Employee\'s name, last, first";
            // 
            // jobTitleDataGridViewTextBoxColumn
            // 
            this.jobTitleDataGridViewTextBoxColumn.DataPropertyName = "JobTitle";
            this.jobTitleDataGridViewTextBoxColumn.HeaderText = "Job Title";
            this.jobTitleDataGridViewTextBoxColumn.Name = "jobTitleDataGridViewTextBoxColumn";
            this.jobTitleDataGridViewTextBoxColumn.ToolTipText = "Current job position";
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            this.departmentDataGridViewTextBoxColumn.ToolTipText = "Current work department";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(JomaxEmployeeDatabase.Models.Employee);
            // 
            // lastNameFirstDataGridViewTextBoxColumn
            // 
            this.lastNameFirstDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastNameFirstDataGridViewTextBoxColumn.DataPropertyName = "LastNameFirst";
            this.lastNameFirstDataGridViewTextBoxColumn.DividerWidth = 1;
            this.lastNameFirstDataGridViewTextBoxColumn.HeaderText = "Name";
            this.lastNameFirstDataGridViewTextBoxColumn.Name = "lastNameFirstDataGridViewTextBoxColumn";
            this.lastNameFirstDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.lastNameFirstDataGridViewTextBoxColumn.ToolTipText = "Employee\'s name. Last name first";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteCert);
            this.groupBox1.Controls.Add(this.btnAddCert);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cmbDepartment);
            this.groupBox1.Controls.Add(this.cmbJobTitle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(390, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 585);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Information";
            // 
            // btnDeleteCert
            // 
            this.btnDeleteCert.Enabled = false;
            this.btnDeleteCert.Location = new System.Drawing.Point(503, 315);
            this.btnDeleteCert.Name = "btnDeleteCert";
            this.btnDeleteCert.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCert.TabIndex = 15;
            this.btnDeleteCert.Text = "Remove";
            this.btnDeleteCert.UseVisualStyleBackColor = true;
            this.btnDeleteCert.Click += new System.EventHandler(this.btnDeleteCert_Click);
            // 
            // btnAddCert
            // 
            this.btnAddCert.Enabled = false;
            this.btnAddCert.Location = new System.Drawing.Point(422, 315);
            this.btnAddCert.Name = "btnAddCert";
            this.btnAddCert.Size = new System.Drawing.Size(75, 23);
            this.btnAddCert.TabIndex = 13;
            this.btnAddCert.Text = "Add";
            this.btnAddCert.UseVisualStyleBackColor = true;
            this.btnAddCert.Click += new System.EventHandler(this.btnAddCert_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.certificateGridView);
            this.groupBox3.Location = new System.Drawing.Point(6, 335);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(575, 244);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Certificates";
            // 
            // certificateGridView
            // 
            this.certificateGridView.AllowUserToResizeRows = false;
            this.certificateGridView.AutoGenerateColumns = false;
            this.certificateGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.certificateGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.certificateGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descriptionDataGridViewTextBoxColumn,
            this.commentsDataGridViewTextBoxColumn,
            this.dateInitialDataGridViewTextBoxColumn,
            this.dateExpiresDataGridViewTextBoxColumn,
            this.doesExpireDataGridViewCheckBoxColumn});
            this.certificateGridView.DataSource = this.certificateBindingSource;
            this.certificateGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.certificateGridView.Location = new System.Drawing.Point(3, 19);
            this.certificateGridView.MultiSelect = false;
            this.certificateGridView.Name = "certificateGridView";
            this.certificateGridView.ReadOnly = true;
            this.certificateGridView.RowHeadersVisible = false;
            this.certificateGridView.RowTemplate.Height = 25;
            this.certificateGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.certificateGridView.Size = new System.Drawing.Size(569, 222);
            this.certificateGridView.TabIndex = 14;
            this.certificateGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.certificateGridView_CellClick);
            this.certificateGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.certificateGridView_CellDoubleClick);
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commentsDataGridViewTextBoxColumn
            // 
            this.commentsDataGridViewTextBoxColumn.DataPropertyName = "Comments";
            this.commentsDataGridViewTextBoxColumn.HeaderText = "Comments";
            this.commentsDataGridViewTextBoxColumn.Name = "commentsDataGridViewTextBoxColumn";
            this.commentsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateInitialDataGridViewTextBoxColumn
            // 
            this.dateInitialDataGridViewTextBoxColumn.DataPropertyName = "DateInitial";
            this.dateInitialDataGridViewTextBoxColumn.HeaderText = "DateInitial";
            this.dateInitialDataGridViewTextBoxColumn.Name = "dateInitialDataGridViewTextBoxColumn";
            this.dateInitialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateExpiresDataGridViewTextBoxColumn
            // 
            this.dateExpiresDataGridViewTextBoxColumn.DataPropertyName = "DateExpires";
            this.dateExpiresDataGridViewTextBoxColumn.HeaderText = "DateExpires";
            this.dateExpiresDataGridViewTextBoxColumn.Name = "dateExpiresDataGridViewTextBoxColumn";
            this.dateExpiresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doesExpireDataGridViewCheckBoxColumn
            // 
            this.doesExpireDataGridViewCheckBoxColumn.DataPropertyName = "DoesExpire";
            this.doesExpireDataGridViewCheckBoxColumn.HeaderText = "DoesExpire";
            this.doesExpireDataGridViewCheckBoxColumn.Name = "doesExpireDataGridViewCheckBoxColumn";
            this.doesExpireDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // certificateBindingSource
            // 
            this.certificateBindingSource.DataSource = typeof(JomaxEmployeeDatabase.Models.Certificate);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(179, 199);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(93, 200);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(6, 200);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Add";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtxtVacationComments);
            this.groupBox2.Controls.Add(this.txtVacationDaysRemaining);
            this.groupBox2.Controls.Add(this.numVacationDaysUsed);
            this.groupBox2.Controls.Add(this.txtVacationDaysTotal);
            this.groupBox2.Controls.Add(this.numVacationDaysAccrued);
            this.groupBox2.Controls.Add(this.numVacationDaysInitial);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(288, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 273);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vacation Days";
            // 
            // rtxtVacationComments
            // 
            this.rtxtVacationComments.Location = new System.Drawing.Point(6, 174);
            this.rtxtVacationComments.Name = "rtxtVacationComments";
            this.rtxtVacationComments.Size = new System.Drawing.Size(278, 93);
            this.rtxtVacationComments.TabIndex = 10;
            this.rtxtVacationComments.Text = "";
            // 
            // txtVacationDaysRemaining
            // 
            this.txtVacationDaysRemaining.Location = new System.Drawing.Point(88, 137);
            this.txtVacationDaysRemaining.Name = "txtVacationDaysRemaining";
            this.txtVacationDaysRemaining.ReadOnly = true;
            this.txtVacationDaysRemaining.Size = new System.Drawing.Size(100, 23);
            this.txtVacationDaysRemaining.TabIndex = 9;
            this.txtVacationDaysRemaining.TabStop = false;
            this.txtVacationDaysRemaining.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numVacationDaysUsed
            // 
            this.numVacationDaysUsed.Location = new System.Drawing.Point(88, 108);
            this.numVacationDaysUsed.Name = "numVacationDaysUsed";
            this.numVacationDaysUsed.Size = new System.Drawing.Size(100, 23);
            this.numVacationDaysUsed.TabIndex = 8;
            this.numVacationDaysUsed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtVacationDaysTotal
            // 
            this.txtVacationDaysTotal.Location = new System.Drawing.Point(88, 79);
            this.txtVacationDaysTotal.Name = "txtVacationDaysTotal";
            this.txtVacationDaysTotal.ReadOnly = true;
            this.txtVacationDaysTotal.Size = new System.Drawing.Size(100, 23);
            this.txtVacationDaysTotal.TabIndex = 7;
            this.txtVacationDaysTotal.TabStop = false;
            this.txtVacationDaysTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numVacationDaysAccrued
            // 
            this.numVacationDaysAccrued.Location = new System.Drawing.Point(88, 50);
            this.numVacationDaysAccrued.Name = "numVacationDaysAccrued";
            this.numVacationDaysAccrued.Size = new System.Drawing.Size(100, 23);
            this.numVacationDaysAccrued.TabIndex = 6;
            this.numVacationDaysAccrued.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numVacationDaysInitial
            // 
            this.numVacationDaysInitial.Location = new System.Drawing.Point(88, 19);
            this.numVacationDaysInitial.Name = "numVacationDaysInitial";
            this.numVacationDaysInitial.Size = new System.Drawing.Size(100, 23);
            this.numVacationDaysInitial.TabIndex = 5;
            this.numVacationDaysInitial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "Remaining";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Used";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Accrued";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Initial";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(93, 159);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(159, 23);
            this.cmbDepartment.TabIndex = 4;
            // 
            // cmbJobTitle
            // 
            this.cmbJobTitle.FormattingEnabled = true;
            this.cmbJobTitle.Location = new System.Drawing.Point(93, 115);
            this.cmbJobTitle.Name = "cmbJobTitle";
            this.cmbJobTitle.Size = new System.Drawing.Size(159, 23);
            this.cmbJobTitle.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Job Title";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(93, 71);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(159, 23);
            this.txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(93, 32);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(159, 23);
            this.txtFirstName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "First Name";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 647);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Jomax Employee Records";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.certificateGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVacationDaysUsed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVacationDaysAccrued)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVacationDaysInitial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabelTotalRecords;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripStatusLabel toolStripStatusLabelActualRecords;
        //private BindingSource employeeBindingSource1;
        private Panel panel1;
        private GroupBox groupBox1;
        private ComboBox cmbDepartment;
        private ComboBox cmbJobTitle;
        private Label label4;
        private Label label3;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label label2;
        private Label label1;
        private DataGridViewTextBoxColumn lastNameFirstDataGridViewTextBoxColumn;
        private GroupBox groupBox2;
        private TextBox txtVacationDaysRemaining;
        private NumericUpDown numVacationDaysUsed;
        private TextBox txtVacationDaysTotal;
        private NumericUpDown numVacationDaysAccrued;
        private NumericUpDown numVacationDaysInitial;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button btnDelete;
        private Button btnUpdate;
        private BindingSource employeeBindingSource;
        //private BindingSource employeeBindingSource2;
        //private DataGridViewTextBoxColumn lastNameFirstDataGridViewTextBoxColumn1;
        private Button btnClear;
        private ToolStripStatusLabel toolStripStatusOperation;
        private BindingSource certificateBindingSource;
        private GroupBox groupBox3;
        private DataGridView certificateGridView;
        private Button btnDeleteCert;
        private Button btnAddCert;
        private DataGridView employeesGridView;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn commentsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateInitialDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateExpiresDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn doesExpireDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn fullNameLastNameFirstDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn jobTitleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private RichTextBox rtxtVacationComments;
    }
}