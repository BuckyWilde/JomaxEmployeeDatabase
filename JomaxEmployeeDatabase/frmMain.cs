using JomaxEmployeeDatabase.Models;
using JomaxEmployeeDatabase.Services;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.IO;

namespace JomaxEmployeeDatabase
{
    public partial class frmMain : Form
    {
        private DataService dataService=new DataService();

        private Employee SelectedEmployee { get; set; }

        private Certificate SelectedCertificate { get; set; }
       
        private List<Employee> employees;
        public List<Employee> Employees
        { get { return employees; } set { employees = value; } }

        private List<Certificate> certificates;
        public List<Certificate> Certificates
        { get { return certificates; } set { certificates = value; } }

        public frmMain()
        {
            InitializeComponent();

            employees= new List<Employee>();
            SelectedEmployee = new Employee();
            certificates = new List<Certificate>();
            SelectedCertificate = new Certificate();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Employees=new List<Employee>();
            dataService=new DataService();
            Certificates=new List<Certificate>();

            toolStripStatusLabelActualRecords.Text = dataService.TotalEmployees().ToString();

            Employees = (List<Employee>)dataService.GetEmployees();
            employeesGridView.DataSource = Employees;
            
            employeesGridView.Dock= DockStyle.Fill;

            certificateGridView.DataSource = Certificates;
            // Load department combobox with pick list from database
            foreach (Department department in dataService.GetDepartments())
            {
                cmbDepartment.Items.Add(department.Name);
            }
            
            // Load jobTitles combo box with pick list from database
            foreach (JobTitle title in dataService.GetJobTitles())
            {
                cmbJobTitle.Items.Add(title.Name);
            }

            //Start off with nothing selected
            employeesGridView.ClearSelection();
        }

        private void employeesGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedEmployee= new Employee();

            foreach(DataGridViewRow row in employeesGridView.SelectedRows)
            {
                SelectedEmployee = row.DataBoundItem as Employee;
                if (SelectedEmployee != null)
                {
                    txtFirstName.DataBindings.Clear();
                    txtLastName.DataBindings.Clear();
                    cmbJobTitle.DataBindings.Clear();
                    cmbDepartment.DataBindings.Clear();
                    numVacationDaysInitial.DataBindings.Clear();
                    numVacationDaysAccrued.DataBindings.Clear();
                    numVacationDaysUsed.DataBindings.Clear();
                    txtFirstName.Text = SelectedEmployee.FirstName;
                    txtLastName.Text = SelectedEmployee.LastName;
                    cmbJobTitle.Text = SelectedEmployee.JobTitle;
                    cmbDepartment.Text = SelectedEmployee.Department;
                    numVacationDaysInitial.Value = SelectedEmployee.VacationDaysInitial ?? 0;
                    numVacationDaysAccrued.Value = SelectedEmployee.VacationDaysAcrrued ?? 0;
                    numVacationDaysUsed.Value = SelectedEmployee.VacationDaysUsed ?? 0;
                    txtVacationDaysTotal.Text = SelectedEmployee.VacationDaysTotal.ToString();
                    txtVacationDaysRemaining.Text= SelectedEmployee.VacationDaysRemaining.ToString();

                    btnUpdate.Enabled = true;
                    btnUpdate.Text = "Update";
                    btnDelete.Enabled = true;

                    // Load employees certifications list
                    Certificates=new List<Certificate>();
                    Certificates = (List<Certificate>)dataService.GetCertificates(SelectedEmployee.EmployeeID);
                    certificateGridView.DataSource=Certificates;

                    btnAddCert.Enabled = true;
                    certificateGridView.ClearSelection();
                }
            }            
        }

        private void UpdateVacationDaysDisplay(object sender, EventArgs e)
        {
            //Update the vacation days total and remaining text boxes
            txtVacationDaysTotal.Text = (numVacationDaysInitial.Value + numVacationDaysAccrued.Value).ToString();
            txtVacationDaysRemaining.Text = ((numVacationDaysInitial.Value + numVacationDaysAccrued.Value) - numVacationDaysUsed.Value).ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Save new data to employee record
            //build new employee record
            SelectedEmployee.FirstName = txtFirstName.Text;
            SelectedEmployee.LastName = txtLastName.Text;
            SelectedEmployee.Department = cmbDepartment.Text;
            SelectedEmployee.JobTitle = cmbJobTitle.Text;
            SelectedEmployee.VacationDaysInitial = numVacationDaysInitial.Value;
            SelectedEmployee.VacationDaysAcrrued = numVacationDaysAccrued.Value;
            SelectedEmployee.VacationDaysUsed = numVacationDaysUsed.Value;

            var x = dataService.UpdateEmployee(SelectedEmployee);

            if(SelectedEmployee.EmployeeID==0)
            {
                Employees = (List<Employee>)dataService.GetEmployees();
                employeesGridView.DataSource = Employees;

                toolStripStatusLabelActualRecords.Text = (int.Parse(toolStripStatusLabelActualRecords.Text) + 1).ToString();
                UpdateStatus("Added " + x + " record to the database", 5);
            }
            else
            {
                UpdateStatus("Modified " + x + " record in the database", 5);
            }

            //Update dataGridView            
            employeesGridView.Refresh();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls();            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you really want to remove " + SelectedEmployee.FullName + " from the database?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                var x = dataService.DeleteEmployee(SelectedEmployee.EmployeeID);
                Employees.Remove(SelectedEmployee);

                employeesGridView.DataSource = null;
                employeesGridView.DataSource = Employees;

                ClearControls();

                toolStripStatusLabelActualRecords.Text = (int.Parse(toolStripStatusLabelActualRecords.Text) - 1).ToString();
                UpdateStatus("Deleted " + x + " record from the database", 5);
            }
        }

        private void ClearControls()
        {
            //Clear all controls and deselect the grid
            employeesGridView.ClearSelection();
            SelectedEmployee = new Employee();            

            txtFirstName.Text = null;
            txtLastName.Text = null;
            cmbJobTitle.Text = null;
            cmbDepartment.Text = null;
            numVacationDaysInitial.Value = 0;
            numVacationDaysAccrued.Value = 0;
            numVacationDaysUsed.Value = 0;

            //Prepare for adding a new record
            btnUpdate.Text = "Add";
            btnDelete.Enabled = false;

            btnAddCert.Text = "Add";
            btnAddCert.Enabled = false;
            btnDeleteCert.Enabled = false;

            UpdateStatus("All fields cleared", 5);
            Certificates.Clear();
            certificateGridView.DataSource = null;
        }

        private void UpdateStatus(string message, int delay)
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = delay * 1000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();

            toolStripStatusOperation.Text = message;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            toolStripStatusOperation.Text = "Ready for command";
        }

        private void certificateGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedCertificate = new Certificate();

            foreach (DataGridViewRow row in certificateGridView.SelectedRows)
            {
                SelectedCertificate = row.DataBoundItem as Certificate;
            }
            
            btnDeleteCert.Enabled = true;
        }

        private void btnAddCert_Click(object sender, EventArgs e)
        {
            SelectedCertificate = null;

            using (dialogAddCertificate addCertDialog = new dialogAddCertificate())
            {
                if (addCertDialog.Show(SelectedEmployee.EmployeeID) == DialogResult.OK)
                {
                    this.SelectedCertificate = addCertDialog.certificate;

                    dataService.UpdateCertificate(SelectedCertificate);
                    Certificates = new List<Certificate>();
                    Certificates = (List<Certificate>)dataService.GetCertificates(SelectedEmployee.EmployeeID);
                    certificateGridView.DataSource = null;
                    certificateGridView.DataSource = Certificates;
                }
            }
        }

        private void certificateGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Prepare to edit and update a user's certificate
        }

        private void btnDeleteCert_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you really want to remove " + SelectedCertificate.description + " from the database?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                var x = dataService.DeleteCertificate(SelectedCertificate.cerificationID);
                Certificates.Remove(SelectedCertificate);
                
                certificateGridView.DataSource=null;
                certificateGridView.DataSource = Certificates;

                UpdateStatus("Deleted " + x + " certificate from the database", 5);

                certificateGridView.ClearSelection();
                btnDeleteCert.Enabled = false;
            }
        }
    }
}