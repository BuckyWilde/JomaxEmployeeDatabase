using JomaxEmployeeDatabase.Helpers;
using JomaxEmployeeDatabase.Models;

namespace JomaxEmployeeDatabase
{
    public partial class dialogAddCertificate : BindableFormBase
    {
        private Certificate certificate;

        public Certificate Certificate
        {
            get => certificate;
            set
            {
                if (value != this.certificate)
                {
                    this.certificate = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private int employeeID { get; set; }

        public dialogAddCertificate(Certificate cert)
        {
            InitializeComponent();

            certificate = Certificate.CreateCertificate();

            if (cert != null)
            {
                certificate = cert;
                btnAdd.Text = "Update";
            }
        }

        private void dialogAddCertificate_Load(object sender, EventArgs e)
        {
            // Create the bindings to the Certificate object
            txtCertName.DataBindings.Add("Text", Certificate, "Description", false, DataSourceUpdateMode.OnPropertyChanged);
            rtxtCertComment.DataBindings.Add("Text", Certificate, "Comments", true, DataSourceUpdateMode.OnPropertyChanged);
            txtDateInitial.DataBindings.Add("Text", Certificate, "DateInitial", false, DataSourceUpdateMode.OnPropertyChanged);
            if (Certificate.DateExpires != null)
            {
                txtDateExpires.DataBindings.Add("Text", Certificate, "DateExpires", false, DataSourceUpdateMode.OnPropertyChanged);
            }

            chkDoesExpire.DataBindings.Add("Checked", Certificate, "DoesExpire", false, DataSourceUpdateMode.OnPropertyChanged);
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
                txtDateInitial.Text = calendar.SelectionStart.ToString("MM/dd/yyyy");
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
                txtDateExpires.Text = calendar.SelectionStart.ToString("MM/dd/yyyy");
            }
        }

        private bool validateForm()
        {
            DateTime dateInitial;
            DateTime dateExpires;

            if (!String.IsNullOrWhiteSpace(txtCertName.Text) && DateTime.TryParse(txtDateInitial.Text, out dateInitial))
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
            //certificate = Certificate.CreateCertificate();

            //certificate.Description=txtCertName.Text;
            //certificate.Comments = rtxtCertComment.Text;
            //certificate.DateInitial = DateTime.Parse(txtDateInitial.Text);
            //if (chkDoesExpire.Checked)
            //{
            //    certificate.DateExpires = DateTime.Parse(txtDateExpires.Text);
            //}
            //certificate.EmployeeID = employeeID;
            //certificate.DoesExpire = chkDoesExpire.Checked;

            this.DialogResult = DialogResult.OK;
        }
    }
}