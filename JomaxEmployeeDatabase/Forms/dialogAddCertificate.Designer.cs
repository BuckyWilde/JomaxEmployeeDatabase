namespace JomaxEmployeeDatabase
{
    partial class dialogAddCertificate
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDateInitial = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkDoesExpire = new System.Windows.Forms.CheckBox();
            this.txtDateExpires = new System.Windows.Forms.TextBox();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.rtxtCertComment = new System.Windows.Forms.RichTextBox();
            this.txtCertName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Certificate Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Comments";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDateInitial);
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Location = new System.Drawing.Point(12, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 248);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date Issued";
            // 
            // txtDateInitial
            // 
            this.txtDateInitial.Location = new System.Drawing.Point(12, 202);
            this.txtDateInitial.Name = "txtDateInitial";
            this.txtDateInitial.PlaceholderText = "mm/dd/yyyy";
            this.txtDateInitial.Size = new System.Drawing.Size(134, 23);
            this.txtDateInitial.TabIndex = 4;
            this.txtDateInitial.TextChanged += new System.EventHandler(this.control_TextChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 28);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkDoesExpire);
            this.groupBox2.Controls.Add(this.txtDateExpires);
            this.groupBox2.Controls.Add(this.monthCalendar2);
            this.groupBox2.Location = new System.Drawing.Point(279, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 248);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Expiry Date";
            // 
            // chkDoesExpire
            // 
            this.chkDoesExpire.AutoSize = true;
            this.chkDoesExpire.Location = new System.Drawing.Point(152, 204);
            this.chkDoesExpire.Name = "chkDoesExpire";
            this.chkDoesExpire.Size = new System.Drawing.Size(81, 19);
            this.chkDoesExpire.TabIndex = 5;
            this.chkDoesExpire.Text = "Has Expiry";
            this.chkDoesExpire.UseVisualStyleBackColor = true;
            this.chkDoesExpire.CheckedChanged += new System.EventHandler(this.chkDoesExpire_CheckedChanged);
            // 
            // txtDateExpires
            // 
            this.txtDateExpires.Enabled = false;
            this.txtDateExpires.Location = new System.Drawing.Point(12, 202);
            this.txtDateExpires.Name = "txtDateExpires";
            this.txtDateExpires.PlaceholderText = "mm/dd/yyyy";
            this.txtDateExpires.Size = new System.Drawing.Size(134, 23);
            this.txtDateExpires.TabIndex = 7;
            this.txtDateExpires.TextChanged += new System.EventHandler(this.control_TextChanged);
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Enabled = false;
            this.monthCalendar2.Location = new System.Drawing.Point(12, 28);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 6;
            this.monthCalendar2.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateChanged);
            // 
            // rtxtCertComment
            // 
            this.rtxtCertComment.Location = new System.Drawing.Point(114, 63);
            this.rtxtCertComment.Name = "rtxtCertComment";
            this.rtxtCertComment.Size = new System.Drawing.Size(408, 73);
            this.rtxtCertComment.TabIndex = 2;
            this.rtxtCertComment.Text = "";
            this.rtxtCertComment.TextChanged += new System.EventHandler(this.control_TextChanged);
            // 
            // txtCertName
            // 
            this.txtCertName.Location = new System.Drawing.Point(114, 31);
            this.txtCertName.Name = "txtCertName";
            this.txtCertName.Size = new System.Drawing.Size(182, 23);
            this.txtCertName.TabIndex = 1;
            this.txtCertName.TextChanged += new System.EventHandler(this.control_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(187, 414);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(279, 414);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dialogAddCertificate
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 473);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCertName);
            this.Controls.Add(this.rtxtCertComment);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dialogAddCertificate";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Certificate Information";
            this.Load += new System.EventHandler(this.dialogAddCertificate_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox txtDateInitial;
        private MonthCalendar monthCalendar1;
        private GroupBox groupBox2;
        private CheckBox chkDoesExpire;
        private TextBox txtDateExpires;
        private MonthCalendar monthCalendar2;
        private RichTextBox rtxtCertComment;
        private TextBox txtCertName;
        private Button btnAdd;
        private Button btnCancel;
    }
}