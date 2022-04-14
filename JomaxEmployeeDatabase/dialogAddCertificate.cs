using JomaxEmployeeDatabase.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JomaxEmployeeDatabase
{
    public partial class dialogAddCertificate : Form
    {
        public Certificate certificate { get; set; }
        private int employeeID { get; set; }

        public dialogAddCertificate()
        {
            InitializeComponent();
        }

        private void dialogAddCertificate_Load(object sender, EventArgs e)
        {

        }

        public DialogResult Show(int employeeID)
        {
            this.employeeID = employeeID;

            return (ShowDialog());
        }

        public Certificate GetCert()
        {
            return certificate;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            var calendar = sender as MonthCalendar;

            if (calendar != null)
            {
                txtDateInitial.Text=calendar.SelectionStart.ToString("MM-dd-yyyy");
            }
        }

        private void chkDoesExpire_CheckedChanged(object sender, EventArgs e)
        {
            var chkBox = sender as CheckBox;

            chkValidation();

            if (chkBox != null)
            {
                if (chkBox.Checked)
                {
                    monthCalendar2.Enabled = true;
                    txtDateExpires.Enabled = true;
                }

                if (!chkBox.Checked)
                {
                    monthCalendar2.SelectionStart = DateTime.Today;
                    txtDateExpires.Text = "mm-dd-yyyy";
                    txtDateExpires.Enabled = false;
                    monthCalendar2.Enabled = false;
                }
            }            
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            var calendar = sender as MonthCalendar;

            if (calendar != null)
            {
                txtDateExpires.Text = calendar.SelectionStart.ToString("MM-dd-yyyy");
            }
        }

        private bool validateForm()
        {
            DateTime dateInitial;
            DateTime dateExpires;

            if(!String.IsNullOrWhiteSpace(txtCertName.Text)&&!string.IsNullOrWhiteSpace(rtxtCertComment.Text)&& DateTime.TryParse(txtDateInitial.Text, out dateInitial))
            {
                if (chkDoesExpire.Checked && DateTime.TryParse(txtDateExpires.Text, out dateExpires))
                {
                    return true;
                }
                if (!chkDoesExpire.Checked)
                {
                    return true;
                }
            }
            return false;
        }

        private void chkValidation()
        {
            btnAdd.Enabled = false;

            if (validateForm())
            { 
                btnAdd.Enabled = true;
            }                                    
        }

        private void control_TextChanged(object sender, EventArgs e)
        {
            chkValidation();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            certificate=new Certificate();

            certificate.description=txtCertName.Text;
            certificate.comments = rtxtCertComment.Text;
            certificate.dateInitial = DateTime.Parse(txtDateInitial.Text);
            if (chkDoesExpire.Checked)
            {
                certificate.dateExpires = DateTime.Parse(txtDateExpires.Text);
            }
            certificate.employeeID = employeeID;
            certificate.doesExpire = chkDoesExpire.Checked;

            this.DialogResult = DialogResult.OK;
        }
    }
}
