using JomaxEmployeeDatabase.Helpers;
using JomaxEmployeeDatabase.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomaxEmployeeDatabase.Services
{
    public class DataService
    {
        private string connectionString = @"Data Source=K:\Users\smbid\source\repos\JomaxEmployeeDatabase\JomaxEmployeeDatabase\JomaxEmployeeDatabase.db3; Version=3; FailIfMissing=True; Foreign keys=True;";
        private SortableBindingList<Employee> employees;
        private List<Department> departments;
        private List<JobTitle> jobTitles;
        private SortableBindingList<Certificate> certificates;

        public DataService()
        {
            employees = new SortableBindingList<Employee>();
            departments = new List<Department>();
            jobTitles = new List<JobTitle>();
            certificates = new SortableBindingList<Certificate>();
        }

        /// <summary>
        /// Insert or update a record to the database.
        /// </summary>
        /// <param name="employee">Record to be inserted or updated.</param>
        /// <returns>The record ID number associated with the inserted or updated record.</returns>
        public int UpdateEmployee(Employee employee)
        {
            long result = -1;

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    //If we are adding a new record
                    if (employee.Id == 0)
                    {
                        cmd.CommandText = "INSERT INTO employees " +
                        "(firstName, lastName, jobTitle, department, VacationDaysInitial, VacationDaysAcrrued, VacationDaysUsed, DateCreated, dateModified, vacationComments) VALUES " +
                        "(@firstName, @lastName, @jobTitle, @department, @vacationDaysInitial, @vacationDaysAccrued, @vacationDaysUsed, @dateCreated, @dateModified, @vacationComments) " +
                        "returning employeeID";
                        employee.CreatedDate = DateTime.Now;
                    }

                    //Update an existing record
                    else
                    {
                        cmd.CommandText = "UPDATE employees " +
                            "SET firstName = @firstName, " +
                            "lastName = @lastName, " +
                            "jobTitle = @jobTitle, " +
                            "department = @department, " +
                            "VacationDaysInitial = @vacationDaysInitial, " +
                            "VacationDaysAcrrued = @vacationDaysAccrued, " +
                            "VacationDaysUsed = @vacationDaysUsed, " +
                            "dateModified = @dateModified, " +
                            "vacationComments = @vacationComments " +
                            "WHERE employeeID = @employeeID " +
                            "returning employeeID";
                    }
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@firstName", employee.FirstName);
                    cmd.Parameters.AddWithValue("@lastName", employee.LastName);
                    cmd.Parameters.AddWithValue("@jobTitle", employee.JobTitle);
                    cmd.Parameters.AddWithValue("@department", employee.Department);
                    cmd.Parameters.AddWithValue("@vacationDaysInitial", employee.VacationDaysInitial);
                    cmd.Parameters.AddWithValue("@vacationDaysAccrued", employee.VacationDaysAcrrued);
                    cmd.Parameters.AddWithValue("@vacationDaysUsed", employee.VacationDaysUsed);
                    cmd.Parameters.AddWithValue("@employeeID", employee.Id);
                    cmd.Parameters.AddWithValue("@dateCreated", employee.CreatedDate);
                    cmd.Parameters.AddWithValue("@dateModified", DateTime.Now);
                    cmd.Parameters.AddWithValue("@vacationComments", employee.VacationComments);

                    try
                    {
                        result = (long)cmd.ExecuteScalar();
                    }
                    catch (SQLiteException ex)
                    {
                        MessageBox.Show(connectionString, ex.Message);
                    }
                }
                
                conn.Close();
            }
            return (int)result;
        }

        public int UpdateCertificate(Certificate certificate)
        {
            long result = -1;
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    //If we are adding a new record
                    if (certificate.Id == 0)
                    {
                        cmd.CommandText = "INSERT INTO certifications " +
                        "(employeeID, description, comments, dateInitial, dateExpires, doesExpire) VALUES " +
                        "(@employeeID, @description, @comments, @dateInitial, @dateExpires, @doesExpire) " +
                        "returning certificationID";
                    }

                    //Update an existing record
                    else
                    {
                        cmd.CommandText = "UPDATE certifications " +
                            "SET employeeID = @employeeID, " +
                            "description = @description, " +
                            "comments = @comments, " +
                            "dateInitial = @dateInitial, " +
                            "dateExpires = @dateExpires, " +
                            "doesExpire = @doesExpire " +
                            "WHERE certificationID = @certificationID " +
                            "returning certificationID";
                    }
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@employeeID", certificate.EmployeeID);
                    cmd.Parameters.AddWithValue("@description", certificate.Description);
                    cmd.Parameters.AddWithValue("@comments", certificate.Comments);
                    cmd.Parameters.AddWithValue("@dateInitial", certificate.DateInitial);
                    cmd.Parameters.AddWithValue("@dateExpires", certificate.DateExpires);
                    cmd.Parameters.AddWithValue("@doesExpire", certificate.DoesExpire);
                    cmd.Parameters.AddWithValue("@certificationID", certificate.Id);

                    try
                    {
                        result = (long)cmd.ExecuteScalar();
                    }
                    catch (SQLiteException ex)
                    {
                        MessageBox.Show(connectionString, ex.Message);
                    }
                }
                conn.Close();
            }
            return (int)result;
        }

        public SortableBindingList<Employee> GetEmployees()
        {
            employees = new SortableBindingList<Employee>();

            try
            {
                using (SQLiteConnection conn=new SQLiteConnection(connectionString))
                {
                    conn.Open();

                    string sql = "SELECT * FROM employees";

                    using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                    {
                        using (SQLiteDataReader reader= cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Employee employee = Employee.CreateEmployee();
                                employee.Id = (int)(long)reader["employeeID"];
                                employee.FirstName = reader["firstName"].ToString() ?? String.Empty;
                                employee.LastName = reader["lastName"].ToString() ?? String.Empty;
                                employee.CreatedDate = DateTime.Parse((reader["DateCreated"].ToString() ?? DateTime.Now.ToString()));
                                employee.JobTitle = reader["jobTitle"].ToString() ?? String.Empty;
                                employee.Department = reader["department"].ToString() ?? String.Empty;
                                employee.VacationDaysInitial = (int)(long)reader["vacationDaysInitial"];
                                employee.VacationDaysAcrrued = (int)(long)reader["vacationDaysAcrrued"];
                                employee.VacationDaysUsed = (int)(long)reader["vacationDaysUsed"];
                                employee.VacationComments = reader["vacationComments"].ToString() ?? String.Empty;

                                employees.Add(employee);
                            }
                            reader.Close();
                        }
                    }
                    conn.Close();
                }
            }

            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return employees;
        }

        public SortableBindingList<Certificate> GetCertificates(int employeeID)
        {
            certificates = new SortableBindingList<Certificate>();

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();

                    string sql = "SELECT * FROM certifications WHERE employeeID = " + employeeID;

                    using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Certificate certificate = Certificate.CreateCertificate();
                                certificate.Id = (int)(long)reader["certificationID"];
                                certificate.EmployeeID = (int)(long)reader["employeeID"];
                                certificate.Description = reader["description"].ToString() ?? String.Empty;
                                certificate.Comments = reader["comments"].ToString() ?? String.Empty;
                                certificate.DateInitial = DateTime.Parse((string)reader["dateInitial"]);
                                certificate.DoesExpire = Convert.ToBoolean((int)(long)reader["doesExpire"]);
                                if (certificate.DoesExpire)
                                {
                                    certificate.DateExpires = DateTime.Parse((string)reader["dateExpires"]);
                                }

                                certificates.Add(certificate);
                            }
                            reader.Close();
                        }
                    }
                    conn.Close();
                }
            }

            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return certificates;
        }

        /// <summary>
        /// Delete a record from the database
        /// </summary>
        /// <typeparam name="T">IDatabase object</typeparam>
        /// <param name="dataObject">Object to be deleted from the database table</param>
        /// <returns>The number of records affected</returns>
        public int DeleteRecord<T>(IDatabaseObject dataObject) where T : IDatabaseObject
        {
            int result = -1;
            T data = (T)dataObject;
           
            using (SQLiteConnection conn=new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    if (data.GetType() == typeof(Employee))
                    {
                        cmd.CommandText = "DELETE FROM employees WHERE employeeID = @id";
                    }

                    if (data.GetType() == typeof(Certificate))
                    {
                        cmd.CommandText = "DELETE FROM certifications WHERE certificationID = @id";
                    }

                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@id", data.Id);

                    try
                    {
                        result = cmd.ExecuteNonQuery();
                    }

                    catch (SQLiteException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                conn.Close();                
            }
            return result;
        }        

        public IEnumerable<Department> GetDepartments()
        {
            departments=new List<Department>();

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();

                    string sql = "SELECT * FROM departments";

                    using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Department department = new Department();
                                department.Id = (int)(long)reader["departmentID"];
                                department.Name = (string)reader["description"];
                                
                                departments.Add(department);
                            }
                            reader.Close();
                        }
                    }
                    conn.Close();
                }
            }

            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return departments;
        }

        public IEnumerable<JobTitle> GetJobTitles()
        {
            jobTitles = new List<JobTitle>();

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();

                    string sql = "SELECT * FROM jobTitles";

                    using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                JobTitle jobTitle = new JobTitle();
                                jobTitle.Id = (int)(long)reader["jobTitlesID"];
                                jobTitle.Name = (string)reader["description"];

                                jobTitles.Add(jobTitle);
                            }
                            reader.Close();
                        }
                    }
                    conn.Close();
                }
            }

            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return jobTitles;
        }

        public int TotalEmployees()
        {
            int count = 0;

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    cmd.CommandText = "SELECT COUNT(*) FROM employees";

                    try
                    {
                        count = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    catch (SQLiteException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                conn.Close();
            }

            return count;
        }

    }
}
