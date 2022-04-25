using JomaxEmployeeDatabase.Helpers;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace JomaxEmployeeDatabase.Models
{
    /// <summary>Employee object to hold all data regarding an employee</summary>
    public class Employee : BindableBase, IDatabaseObject, IEditableObject
    {
        // Private fields to hold values for public properties
        private int id = 0;

        private string firstName = string.Empty;
        private string lastName = string.Empty;
        private DateTime createdDate;
        private DateTime modifiedDate;
        private string jobTitle = string.Empty;
        private string department = string.Empty;
        private decimal vacationDaysInitial = 0;
        private decimal vacationDaysAcrrued = 0;
        private decimal vacationDaysUsed = 0;
        private string vacationComments = string.Empty;

        private bool isEditing;
        private Employee originalEmployee;

        public int Id
        {
            get => this.id;
            set
            {
                if (value != this.id)
                {
                    this.id = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string FirstName
        {
            get => firstName;
            set
            {
                if (value != this.firstName)
                {
                    this.firstName = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string LastName
        {
            get => this.lastName;
            set
            {
                if (value != this.lastName)
                {
                    this.lastName = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public DateTime CreatedDate
        {
            get => this.createdDate;
            set
            {
                if (value != this.createdDate)
                {
                    this.createdDate = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public DateTime ModifiedDate
        {
            get => this.modifiedDate;
            set
            {
                if (value != this.modifiedDate)
                {
                    this.modifiedDate = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string JobTitle
        {
            get => this.jobTitle;
            set
            {
                if (value != this.jobTitle)
                {
                    this.jobTitle = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Department
        {
            get => department;
            set
            {
                if (value != this.department)
                {
                    this.department = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public decimal VacationDaysInitial
        {
            get => this.vacationDaysInitial;
            set
            {
                if (value != this.vacationDaysInitial)
                {
                    this.vacationDaysInitial = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public int VacationDaysTotal
        {
            get => (int)(this.vacationDaysInitial + this.vacationDaysAcrrued);
        }

        public decimal VacationDaysAcrrued
        {
            get => this.vacationDaysAcrrued;
            set
            {
                if (value != this.vacationDaysAcrrued)
                {
                    this.vacationDaysAcrrued = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public decimal VacationDaysUsed
        {
            get => this.vacationDaysUsed;
            set
            {
                if (value != this.vacationDaysUsed)
                {
                    this.vacationDaysUsed = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string VacationComments
        {
            get => this.vacationComments;
            set
            {
                if (value != this.vacationComments)
                {
                    this.vacationComments = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public int VacationDaysRemaining
        {
            get => (int)(this.VacationDaysTotal - this.vacationDaysUsed);
        }

        public string FullName
        {
            get => FirstName + " " + LastName;
        }

        public string FullName_LastNameFirst
        {
            get => this.ToString();
        }

        public string tableName { get => "employees"; }

        public override string ToString()
        {
            return LastName + ", " + FirstName;
        }

        private Employee()
        {
            //CreatedDate = DateTime.Now;
            isEditing = false;
            //originalEmployee = this.Copy();
        }

        public static Employee CreateEmployee()
        {
            return new Employee();
        }

        public void BeginEdit()
        {
            if (!isEditing)
            {
                if (originalEmployee == null)
                {
                    originalEmployee=Employee.CreateEmployee();
                    originalEmployee = this.Copy();
                }
                isEditing = true;
            }
        }

        public void CancelEdit()
        {
            if (isEditing)
            {
                // revert all edits
                this.id = originalEmployee.Id;
                this.firstName = originalEmployee.FirstName;
                this.lastName = originalEmployee.LastName;
                this.createdDate = originalEmployee.CreatedDate;
                this.modifiedDate = originalEmployee.ModifiedDate;
                this.jobTitle = originalEmployee.JobTitle;
                this.department = originalEmployee.Department;
                this.vacationDaysAcrrued = originalEmployee.vacationDaysAcrrued;
                this.vacationDaysInitial = originalEmployee.vacationDaysInitial;
                this.vacationDaysUsed = originalEmployee.vacationDaysUsed;
            }
        }

        public void EndEdit()
        {
            //End and save the current values
        }

        public Employee Copy()
        {
            Employee other = Employee.CreateEmployee();

            other.FirstName = this.FirstName;
            other.LastName = this.LastName;
            other.id = this.id;
            other.createdDate = this.createdDate;
            other.modifiedDate = this.modifiedDate;
            other.jobTitle = this.jobTitle;
            other.department = this.department;
            other.vacationDaysAcrrued = this.vacationDaysAcrrued;
            other.vacationDaysInitial= this.vacationDaysInitial;
            other.vacationDaysUsed= this.vacationDaysUsed;

            return other;
        }
    }
}