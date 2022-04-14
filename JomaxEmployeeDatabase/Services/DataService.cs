using JomaxEmployeeDatabase.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomaxEmployeeDatabase.Services
{
    public class DataService
    {
        private string connectionString = @"Data Source=K:\Users\smbid\source\repos\JomaxEmployeeDatabase\JomaxEmployeeDatabase\JomaxEmployeeDatabase.db3; Version=3; FailIfMissing=True; Foreign keys=True;";
        private List<Employee> employees;
        private List<Department> departments;
        private List<JobTitle> jobTitles;
        private List<Certificate> certificates;

        public DataService()
        {
            employees = new List<Employee>();
            departments = new List<Department>();
            jobTitles = new List<JobTitle>();
            certificates = new List<Certificate>();
        }

        public int UpdateEmployee(Employee employee)
        {
            int result = -1;
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    //If we are adding a new record
                    if (employee.EmployeeID == 0)
                    {
                        cmd.CommandText = "INSERT INTO employees " +
                        "(firstName, lastName, jobTitle, department, VacationDaysInitial, VacationDaysAcrrued, VacationDaysUsed, DateCreated) VALUES " +
                        "(@firstName, @lastName, @jobTitle, @department, @vacationDaysInitial, @vacationDaysAccrued, @vacationDaysUsed, @dateCreated)";
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
                            "VacationDaysUsed = @vacationDaysUsed " +
                            "WHERE employeeID = @employeeID";
                    }
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@firstName", employee.FirstName);
                    cmd.Parameters.AddWithValue("@lastName", employee.LastName);
                    cmd.Parameters.AddWithValue("@jobTitle", employee.JobTitle);
                    cmd.Parameters.AddWithValue("@department", employee.Department);
                    cmd.Parameters.AddWithValue("@vacationDaysInitial", employee.VacationDaysInitial);
                    cmd.Parameters.AddWithValue("@vacationDaysAccrued", employee.VacationDaysAcrrued);
                    cmd.Parameters.AddWithValue("@vacationDaysUsed", employee.VacationDaysUsed);
                    cmd.Parameters.AddWithValue("@employeeID", employee.EmployeeID);
                    cmd.Parameters.AddWithValue("@dateCreated", employee.CreatedDate);

                    try
                    {
                        result=cmd.ExecuteNonQuery();
                    }
                    catch (SQLiteException ex)
                    {
                        MessageBox.Show(connectionString, ex.Message);
                    }
                }
                conn.Close();
            }
            return result;
        }

        public int UpdateCertificate(Certificate certificate)
        {
            int result = -1;
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    //If we are adding a new record
                    if (certificate.cerificationID == 0)
                    {
                        cmd.CommandText = "INSERT INTO certifications " +
                        "(employeeID, description, comments, dateInitial, dateExpires, doesExpire) VALUES " +
                        "(@employeeID, @description, @comments, @dateInitial, @dateExpires, @doesExpire)";
                    }

                    //Update an existing record
                    else
                    {
                        cmd.CommandText = "UPDATE employees " +
                            "SET employeeID = @employeeID, " +
                            "description = @description, " +
                            "comments = @comments, " +
                            "dateInitial = @dateInitial, " +
                            "dateExpires = @dateExpires, " +
                            "doesExpire = @doesExpire " +                            
                            "WHERE certificationID = @certificationID";
                    }
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@employeeID", certificate.employeeID);
                    cmd.Parameters.AddWithValue("@description", certificate.description);
                    cmd.Parameters.AddWithValue("@comments", certificate.comments);
                    cmd.Parameters.AddWithValue("@dateInitial", certificate.dateInitial);
                    cmd.Parameters.AddWithValue("@dateExpires", certificate.dateExpires);
                    cmd.Parameters.AddWithValue("@doesExpire", certificate.doesExpire);
                    cmd.Parameters.AddWithValue("@certificationID", certificate.cerificationID);

                    try
                    {
                        result = cmd.ExecuteNonQuery();
                    }
                    catch (SQLiteException ex)
                    {
                        MessageBox.Show(connectionString, ex.Message);
                    }
                }
                conn.Close();
            }
            return result;
        }

        public IEnumerable<Employee> GetEmployees()
        {
            employees = new List<Employee>();

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
                                Employee employee = new Employee();
                                employee.EmployeeID = (int)(long)reader["employeeID"];
                                employee.FirstName = reader["firstName"].ToString() ?? "first name";
                                employee.LastName = reader["lastName"].ToString() ?? "last name";
                                employee.CreatedDate = DateTime.Parse((reader["DateCreated"].ToString() ?? DateTime.Now.ToString()));
                                employee.JobTitle = reader["jobTitle"].ToString() ?? "Labourer";
                                employee.Department = reader["department"].ToString() ?? "Shop";
                                employee.VacationDaysInitial = (int)(long)reader["vacationDaysInitial"];
                                employee.VacationDaysAcrrued = (int)(long)reader["vacationDaysAcrrued"];
                                employee.VacationDaysUsed = (int)(long)reader["vacationDaysUsed"];

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

        public IEnumerable<Certificate> GetCertificates(int employeeID)
        {
            certificates = new List<Certificate>();

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
                                Certificate certificate = new Certificate();
                                certificate.cerificationID = (int)(long)reader["certificationID"];
                                certificate.employeeID = (int)(long)reader["employeeID"];
                                certificate.description = reader["description"].ToString();
                                certificate.comments = reader["comments"].ToString();
                                certificate.dateInitial = DateTime.Parse(reader["dateInitial"].ToString());                                
                                certificate.doesExpire = Convert.ToBoolean((int)(long)reader["doesExpire"]);
                                if (certificate.doesExpire)
                                {
                                    certificate.dateExpires = DateTime.Parse(reader["dateExpires"].ToString());
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

        public int DeleteEmployee(int id)
        {
            int result = -1;

            using (SQLiteConnection conn=new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    cmd.CommandText = "DELETE FROM employees WHERE employeeID = @id";

                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@id", id);

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

        public int DeleteCertificate(int id)
        {
            int result = -1;

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    cmd.CommandText = "DELETE FROM certifications WHERE certificationID = @id";

                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@id", id);

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
