using JomaxEmployeeDatabase.Helpers;
using System.Collections;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace JomaxEmployeeDatabase.Models
{
    public class Certificate : BindableBase, IDatabaseObject
    {
        private int id = 0;
        private int employeeID = 0;
        private string description = string.Empty;
        private string comments = string.Empty;
        private DateTime dateInitial = DateTime.Now;
        private DateTime? dateExpires = null;
        private bool doesExpire = false;

        // For editableObject
        private bool doingEdit;
        Hashtable props = null;

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

        public int EmployeeID
        {
            get => this.employeeID;
            set
            {
                if (value != this.employeeID)
                {
                    this.employeeID = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Description
        {
            get => this.description;
            set
            {
                if (value != this.description)
                {
                    this.description = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Comments
        {
            get => this.comments;
            set
            {
                if (value != this.comments)
                {
                    this.comments = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public DateTime DateInitial
        {
            get => this.dateInitial;
            set
            {
                if (value != this.dateInitial)
                {
                    this.dateInitial = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public DateTime? DateExpires
        {
            get => this.dateExpires;
            set
            {
                if (value != this.dateExpires)
                {
                    this.dateExpires = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public bool DoesExpire
        {
            get => this.doesExpire;
            set
            {
                if (value != this.doesExpire)
                {
                    this.doesExpire = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private Certificate()
        {
        }

        public static Certificate CreateCertificate()
        {
            return new Certificate();
        }

        public Certificate Copy()
        {
            Certificate other = new Certificate();

            other.id = this.id;
            other.description = this.description;
            other.comments = this.comments;
            other.dateInitial = this.dateInitial;
            other.dateExpires = this.dateExpires;

            return other;
        }

        public string tableName => "certifications";
    }
}