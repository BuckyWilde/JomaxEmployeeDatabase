using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomaxEmployeeDatabase.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; } = 0;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedDate { get; set; }
        public string JobTitle { get; set; }
        public string Department { get; set; }
        public decimal? VacationDaysInitial { get; set; }
        public decimal? VacationDaysTotal
        {
            get => VacationDaysInitial + VacationDaysAcrrued;
        }
        public decimal? VacationDaysAcrrued { get; set; }
        public decimal? VacationDaysUsed { get; set; }
        public decimal? VacationDaysRemaining
        {
            get => VacationDaysTotal - VacationDaysUsed;
        }

        public string FullName
        {
            get => FirstName + " " + LastName;
        }

        public string LastNameFirst
        {
            get=>this.ToString();
        }

        public override string ToString()
        {
            return LastName + ", " + FirstName;
        }

        public Employee()
        {
            FirstName = "first";
            LastName = "last";
            CreatedDate = DateTime.Now;
            JobTitle = "Unspecified";
            Department = "Unspecified";
        }

        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            CreatedDate=DateTime.Now;
            JobTitle = "Unspecified";
            Department = "Unspecified";
        }
    }
}
