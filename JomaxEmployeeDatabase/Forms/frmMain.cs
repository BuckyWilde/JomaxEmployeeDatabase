using JomaxEmployeeDatabase.Helpers;
using JomaxEmployeeDatabase.Models;
using JomaxEmployeeDatabase.Services;
using System.ComponentModel;

namespace JomaxEmployeeDatabase
{
    public partial class frmMain : BindableFormBase
    {
        #region Fields
        private readonly DataService dataService = new DataService();
        private Employee? selectedEmployee;
        private Certificate? selectedCertificate;
        private BindingSource employeesBindingSource = new BindingSource();
        private BindingSource certificatesBindingSource = new BindingSource();
        private SortableBindingList<Employee> employees;
        private SortableBindingList<Certificate> certificates;
        #endregion

        #region Properties
        public Employee? SelectedEmployee
        {
            get => selectedEmployee;
            set
            {
                if (value != selectedEmployee)
                {
                    selectedEmployee = value;                    
                    NotifyPropertyChanged();
                }
            }
        }

        public Certificate? SelectedCertificate
        {
            get => selectedCertificate;
            set
            {
                if (value != selectedCertificate)
                {
                    selectedCertificate = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public SortableBindingList<Employee> Employees
        {
            get => employees;
            set
            {
                employees = value;
            }
        }

        public SortableBindingList<Certificate> Certificates
        {
            get => certificates;
            set
            {
                certificates = value;
            }
        }
        #endregion

        public frmMain()
        {
            InitializeComponent();

            // Load the form's icon. The icon will show in the menu bar and form title bar.
            var exe = System.Reflection.Assembly.GetExecutingAssembly();
            var iconStream = exe.GetManifestResourceStream("JomaxEmployeeDatabase.Resources.Icons.Jomax_logo.ico");
            if (iconStream != null)
            {
                this.Icon = new Icon(iconStream);
            }

            employees = new SortableBindingList<Employee>();
            selectedEmployee = Employee.CreateEmployee();
            certificates = new SortableBindingList<Certificate>();
            selectedCertificate = Certificate.CreateCertificate();
            dataService = new DataService();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {            
            Employees = new SortableBindingList<Employee>();
            Certificates = new SortableBindingList<Certificate>();

            // Update the toolstrip with the number of employee records from the database
            toolStripStatusLabelActualRecords.Text = dataService.TotalEmployees().ToString();

            // Load the employee records from the dataservice into the Employees list property
            Employees = dataService.GetEmployees();

            this.employeeBindingSource.DataSource = employees;
            employeesGridView.DataSource = this.employeeBindingSource;

            this.certificateBindingSource.DataSource = certificates;
            certificateGridView.DataSource = certificateBindingSource;

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

        /// <summary>
        /// Method to handle when user clicks on row in the employee grid view
        /// </summary>
        /// <param name="sender">Object.</param>
        /// <param name="e">Event args.</param>
        private void employeesGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Get a new Employee and place it in the SelectedEmployee property
            SelectedEmployee = Employee.CreateEmployee();

            foreach (DataGridViewRow row in employeesGridView.SelectedRows)
            {
                SelectedEmployee = (Employee)row.DataBoundItem;
                if (SelectedEmployee != null)
                {
                    clearAllBindings();

                    //txtFirstName.Text = SelectedEmployee.FirstName;
                    txtFirstName.DataBindings.Add("Text", SelectedEmployee, "FirstName", false, DataSourceUpdateMode.OnPropertyChanged);
                    //txtLastName.Text = SelectedEmployee.LastName;
                    txtLastName.DataBindings.Add("Text", SelectedEmployee, "LastName", false, DataSourceUpdateMode.OnPropertyChanged);
                    //cmbJobTitle.Text = SelectedEmployee.JobTitle;
                    cmbJobTitle.DataBindings.Add("Text", SelectedEmployee, "JobTitle", false, DataSourceUpdateMode.OnPropertyChanged);
                    //cmbDepartment.Text = SelectedEmployee.Department;
                    cmbDepartment.DataBindings.Add("Text", SelectedEmployee, "Department", false, DataSourceUpdateMode.OnPropertyChanged);
                    //numVacationDaysInitial.Value = SelectedEmployee.VacationDaysInitial;
                    numVacationDaysInitial.DataBindings.Add("Value", SelectedEmployee, "VacationDaysInitial", false, DataSourceUpdateMode.OnPropertyChanged);
                    //numVacationDaysAccrued.Value = SelectedEmployee.VacationDaysAcrrued;
                    numVacationDaysAccrued.DataBindings.Add("Value", SelectedEmployee, "VacationDaysAcrrued", false, DataSourceUpdateMode.OnPropertyChanged);
                    //numVacationDaysUsed.Value = SelectedEmployee.VacationDaysUsed;
                    numVacationDaysUsed.DataBindings.Add("Value", SelectedEmployee, "VacationDaysUsed", false, DataSourceUpdateMode.OnPropertyChanged);
                    //txtVacationDaysTotal.Text = SelectedEmployee.VacationDaysTotal().ToString();
                    txtVacationDaysTotal.DataBindings.Add("Text", SelectedEmployee, "VacationDaysTotal", false, DataSourceUpdateMode.OnPropertyChanged);
                    //txtVacationDaysRemaining.Text= SelectedEmployee.VacationDaysRemaining().ToString();
                    txtVacationDaysRemaining.DataBindings.Add("Text", SelectedEmployee, "VacationDaysRemaining", false, DataSourceUpdateMode.OnPropertyChanged);
                    rtxtVacationComments.DataBindings.Add("Text", SelectedEmployee, "VacationComments", true, DataSourceUpdateMode.OnPropertyChanged);

                    btnUpdate.Enabled = true;
                    btnUpdate.Text = "Update";
                    btnDelete.Enabled = true;

                    // Load employees certifications list
                    Certificates = new SortableBindingList<Certificate>();
                    Certificates = dataService.GetCertificates(SelectedEmployee.Id);
                    certificateGridView.DataSource = Certificates;

                    btnAddCert.Enabled = true;
                    certificateGridView.ClearSelection();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (SelectedEmployee != null)
            {
                int recordID = dataService.UpdateEmployee(SelectedEmployee);

                // If the employee ID is 0 this means it will be a new addition to the collection
                if (SelectedEmployee.Id == 0)
                {
                    // Add the new employee to the collection
                    SelectedEmployee.Id = recordID;
                    Employees.Add(SelectedEmployee);

                    toolStripStatusLabelActualRecords.Text = Employees.Count().ToString();
                    UpdateStatus("Added employee record #" + recordID + " to the database", 5);
                }
                // If the employee ID > 0, we must be editing an employee object therefore we must update the record
                else
                {
                    UpdateStatus("Modified employee record #" + recordID + " in the database", 5);
                }

                //Update dataGridView
                employeesGridView.Refresh();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (SelectedEmployee != null)
            {
                SelectedEmployee.CancelEdit();
                ClearControls();
            }            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (SelectedEmployee != null)
            {
                var result = MessageBox.Show("Do you really want to remove " + SelectedEmployee.FullName + " from the database?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    var x = dataService.DeleteRecord<Employee>(SelectedEmployee);
                    Employees.Remove(SelectedEmployee);

                    ClearControls();

                    toolStripStatusLabelActualRecords.Text = (int.Parse(toolStripStatusLabelActualRecords.Text) - 1).ToString();
                    UpdateStatus("Deleted " + x + " record from the database", 5);
                }
            }
        }

        /// <summary>
        /// Method to clear all controls on the form and allow fresh user input
        /// </summary>
        private void ClearControls()
        {
            //Clear all controls and deselect the grid
            employeesGridView.ClearSelection();
            SelectedEmployee = null;
            clearAllBindings();

            txtFirstName.Text = String.Empty;
            txtLastName.Text = String.Empty;
            cmbJobTitle.Text = String.Empty;
            cmbDepartment.Text = String.Empty;
            numVacationDaysInitial.Value = 0;
            numVacationDaysAccrued.Value = 0;
            numVacationDaysUsed.Value = 0;
            rtxtVacationComments.Text = String.Empty;

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

        private void clearAllBindings()
        {
            txtFirstName.DataBindings.Clear();
            txtLastName.DataBindings.Clear();
            cmbDepartment.DataBindings.Clear();
            cmbJobTitle.DataBindings.Clear();
            numVacationDaysInitial.DataBindings.Clear();
            numVacationDaysAccrued.DataBindings.Clear();
            numVacationDaysUsed.DataBindings.Clear();
            txtVacationDaysRemaining.DataBindings.Clear();
            txtVacationDaysTotal.DataBindings.Clear();
            rtxtVacationComments.DataBindings.Clear();
        }

        /// <summary>
        /// Display a staus message on the toolbar
        /// </summary>
        /// <param name="message">a string representing the message to be displayed.</param>
        /// <param name="delay">A time period (seconds) to display the message.</param>
        private void UpdateStatus(string message, int delay)
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = delay * 1000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();

            toolStripStatusOperation.Text = message;
        }

        /// <summary>
        /// A method to handle when UpdateStatus timer is finished.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            toolStripStatusOperation.Text = "Ready for command";
        }

        private void certificateGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedCertificate = Certificate.CreateCertificate();

            foreach (DataGridViewRow row in certificateGridView.SelectedRows)
            {
                SelectedCertificate = (Certificate)row.DataBoundItem;
            }

            btnDeleteCert.Enabled = true;
        }

        private void btnAddCert_Click(object sender, EventArgs e)
        {
            if (SelectedEmployee != null)
            {
                SelectedCertificate = Certificate.CreateCertificate();

                using (dialogAddCertificate addCertDialog = new dialogAddCertificate(SelectedCertificate))
                {
                    if (addCertDialog.Show(SelectedEmployee.Id) == DialogResult.OK)
                    {
                        this.SelectedCertificate = addCertDialog.Certificate;

                        int recordID = dataService.UpdateCertificate(SelectedCertificate);
                        this.SelectedCertificate.Id = recordID;
                        Certificates.Add(this.SelectedCertificate);
                    }
                }
            }
        }

        private void certificateGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Prepare to edit and update a user's certificate
            if (e.RowIndex >= 0)
            {
                var index = e.RowIndex;

                Certificate originalCertificate = Certificate.CreateCertificate();

                this.SelectedCertificate = Certificates[index];
                originalCertificate = SelectedCertificate.Copy();

                if (SelectedEmployee != null)
                {
                    using (dialogAddCertificate addCertDialog = new dialogAddCertificate(SelectedCertificate))
                    {
                        if (addCertDialog.Show(SelectedEmployee.Id) == DialogResult.OK)
                        {
                            this.SelectedCertificate = addCertDialog.Certificate;

                            int recordID = dataService.UpdateCertificate(SelectedCertificate);
                        }
                        else
                        {
                            // Roll back any changes
                            Certificates[index] = originalCertificate;
                        }
                    }                    
                }
            }
        }

        private void btnDeleteCert_Click(object sender, EventArgs e)
        {
            if (SelectedCertificate != null)
            {
                var result = MessageBox.Show("Do you really want to remove " + SelectedCertificate.Description + " from the database?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    var x = dataService.DeleteRecord<Certificate>(SelectedCertificate);
                    Certificates.Remove(SelectedCertificate);

                    UpdateStatus("Deleted " + x + " certificate from the database", 5);

                    certificateGridView.ClearSelection();
                    btnDeleteCert.Enabled = false;
                }
            }
        }
    }
}