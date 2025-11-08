using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;
using System.Security.Cryptography;
using System.Windows.Forms.DataVisualization.Charting;

namespace STUDENT_MS
{
    public class Modify
    {
        SqlDataAdapter dataAdapter;
        public Modify() { }

        public DataTable getAllStudent()
        {
            DataTable dataTable = new DataTable();
            string querry = "select * from Student";
            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(querry, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }

        public DataTable GetAllCourse()
        {
            DataTable dataTable = new DataTable();
            string querry = "SELECT * FROM Course";
            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(querry, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }

        public static bool CheckLogin(string username, string password)
        {
            string query = "select 1 from Account where ID = @username AND Password = @password";
            DataTable dataTable = new DataTable();
            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@username", username);
                    sqlCommand.Parameters.AddWithValue("@password", password);

                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        return reader.HasRows; //check if return any row? --> true
                    }
                }
            }
        }

        public static int CheckRole(string id)
        {
            switch (id[0])
            {
                case 'S':
                    return 0;
                    break;
                case 'L':
                    return 1;
                    break;
                case 'A':
                    return 2;
                    break;
                default:
                    throw new Exception("Invalid ID!");
                    break;
            }
        }

        public static string GetName(string id)
        {
            int role = CheckRole(id);
            string query;
            switch (role)
            {
                case 0:
                    query = "SELECT Name From Student WHERE ID = @id";
                    break;
                case 1:
                    query = "SELECT Name From Lecturer WHERE ID = @id";
                    break;
                case 2:
                    query = "SELECT Name From Admin WHERE ID = @id";
                    break;
                default:
                    throw new Exception("Invalid ID!");
                    break;
            }
            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;

                    object result = sqlCommand.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return result.ToString();
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        public static string PrintByID(string id, int role)
        {
            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                sqlConnection.Open();
                if (role == 0) //STUDENT
                {
                    string query = "SELECT Name, Gender, Dob, Major, FID, StudyDate FROM Student WHERE ID = @id";

                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;

                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            try
                            {
                                if (reader.Read())
                                {
                                    Student s = new Student(
                                        id,
                                        reader["Name"].ToString(),
                                        reader["Gender"].ToString(),
                                        Convert.ToDateTime(reader["Dob"]),
                                        reader["Major"].ToString(),
                                        reader["FID"].ToString(),
                                        Convert.ToDateTime(reader["StudyDate"])
                                    );
                                    return s.PrintDetails();

                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("ERROR: " + ex, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else if (role == 1)
                {
                    string query = "select * from Lecturer where ID = @id";

                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;

                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            try
                            {
                                if (reader.Read())
                                {
                                    Lecturer l = new Lecturer(
                                        id,
                                        reader["Name"].ToString(),
                                        reader["Gender"].ToString(),
                                        Convert.ToDateTime(reader["Dob"]),
                                        reader["FID"].ToString(),
                                        reader["AcademicQual"].ToString(),
                                        Convert.ToDateTime(reader["HireDate"])
                                    );
                                    return l.PrintDetails();

                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("ERROR: " + ex, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
                
            return null;

        }

        public static Dictionary<string, float> GetCourseGPA(string id)
        {
            string query = "SELECT c.Name, (c.Midterm + c.Final)/2 GPA FROM StudentCourse c Where StudentID = @id";

            Dictionary<string, float> courseGpaData = new Dictionary<string, float>();

            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;

                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string courseName = reader["Name"].ToString();
                            float gpa = Convert.ToSingle(reader["GPA"]);
                            courseGpaData.Add(courseName, gpa);
                        }
                    }
                }
                return courseGpaData;
            }
        }

        public DataTable GetEnrolledCourse(string id)
        {
            DataTable dataTable = new DataTable();
            string query = "select Cid, Name, Credit, StartDay, EndDay, Midterm, Final, (Midterm + Final)/2 Total from StudentCourse Where StudentID = @id";

            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }

        public void EnrollCourse(string id, string cid)
        {
            string checkQuery = "select 1 from StudentCourse where StudentID = @id AND Cid = @cid";
            string insertQuery = "insert into StudentCourse values (@Cid, @Name, @Credit, @StartDay, @EndDay, @StudentID, @Midterm, @Final)";

            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                try
                {
                    sqlConnection.Open();
                    //check if the course is already enrolled
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, sqlConnection))
                    {
                        checkCommand.Parameters.AddWithValue("@id", id);
                        checkCommand.Parameters.AddWithValue("@cid", cid);

                        using (SqlDataReader reader = checkCommand.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                MessageBox.Show("Course is already ENROLLED!", "NOTI!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }

                    Course c = GetCourseByID(cid);
                    if (c == null)
                    {
                        MessageBox.Show("Course is NOT EXIST!", "NOTI!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection))
                    {
                        insertCommand.Parameters.AddWithValue("@Cid", c.Cid);
                        insertCommand.Parameters.AddWithValue("@Name", c.Name);
                        insertCommand.Parameters.AddWithValue("@Credit", c.Credit);
                        insertCommand.Parameters.AddWithValue("@StartDay", c.StartDay);
                        insertCommand.Parameters.AddWithValue("@EndDay", c.EndDay);
                        insertCommand.Parameters.AddWithValue("@StudentID", id);
                        //Default: grade = 0
                        insertCommand.Parameters.AddWithValue("@Midterm", 0);
                        insertCommand.Parameters.AddWithValue("@Final", 0);

                        int rowsAffected = insertCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("ENROLL SUCCESSFUL", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("ENROLL FAILED", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        public void RemoveStudentCourse(string id, string cid)
        {
            string removeQuery = "delete from StudentCourse where StudentID = @id AND Cid = @cid";

            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                try
                {
                    sqlConnection.Open();

                    using (SqlCommand removeCommand = new SqlCommand(removeQuery, sqlConnection))
                    {
                        removeCommand.Parameters.AddWithValue("@id", id);
                        removeCommand.Parameters.AddWithValue("@cid", cid);

                        int rowsAffected = removeCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("REMOVE SUCCESSFUL", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("REMOVE FAILED", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        public Course GetCourseByID(string cid)
        {
            string query = "select * from Course where Cid = @cid";
            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.Add("@cid", SqlDbType.NVarChar).Value = cid;

                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Course
                            {
                                Cid = cid,
                                Name = reader["Name"].ToString(),
                                Credit = Convert.ToInt32(reader["Credit"]),
                                StartDay = Convert.ToDateTime(reader["StartDay"]),
                                EndDay = Convert.ToDateTime(reader["EndDay"])
                            };
                        }
                        else
                        {
                            return null; //not found
                        }
                    }
                }
            }
        }

        public decimal GetTuition(string id)
        {
            string query = "select Amount from Tuition where StudentID = @id";
            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                try
                {
                    sqlConnection.Open();

                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;

                        object result = sqlCommand.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            return Convert.ToDecimal(result);
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
            }

        }

        public Student GetStudentByID(string id)
        {
            string query = "SELECT Name, Gender, Dob, Major, FID, StudyDate, Amount, IsPaid FROM Student, Tuition WHERE ID = StudentID AND ID = @id";

            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;

                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        try
                        {
                            if (reader.Read())
                            {
                                Student s = new Student(
                                    id,
                                    reader["Name"].ToString(),
                                    reader["Gender"].ToString(),
                                    Convert.ToDateTime(reader["Dob"]),
                                    reader["Major"].ToString(),
                                    reader["FID"].ToString(),
                                    Convert.ToDateTime(reader["StudyDate"])
                                );
                                s.Fee.Amount = Convert.ToDecimal(reader["Amount"]);
                                s.Fee.IsPaid = Convert.ToBoolean(reader["IsPaid"]);
                                return s;

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ERROR: " + ex, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

            return null;
        }

        public void TuitionChange(Student s)
        {
            string query = "UPDATE Tuition Set Amount = @amount, IsPaid = @isPaid where StudentID = @id";

            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.Add("@id", SqlDbType.NVarChar).Value = s.ID;
                    sqlCommand.Parameters.Add("@amount", SqlDbType.Decimal).Value = s.Fee.Amount;
                    sqlCommand.Parameters.Add("@isPaid", SqlDbType.Bit).Value = s.Fee.IsPaid;
                    int colsAffected = sqlCommand.ExecuteNonQuery();
                    if (colsAffected > 0)
                    {
                        MessageBox.Show("PAY SUCCESSFUL", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("PAY FAILED", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void AssignGrade(string id, string cid, float midterm, float final)
        {
            string query = "Update StudentCourse SET Midterm = @midterm, Final = @final where Cid = @cid and StudentID = @id";

            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
                    sqlCommand.Parameters.Add("@cid", SqlDbType.NVarChar).Value = cid;
                    sqlCommand.Parameters.Add("@midterm", SqlDbType.Float).Value = midterm;
                    sqlCommand.Parameters.Add("@final", SqlDbType.Float).Value = final;

                    try
                    {
                        int rowsAffected = sqlCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("ASSIGN SUCCESSFUL", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("ASSIGN FAILED", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public DataTable GetStudentNameID(string id)
        {
            DataTable dataTable = new DataTable();
            string query = "select Name, Id from Student";

            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }

        public void AddCourse(Course c)
        {
            string query = "INSERT INTO Course Values(@ID, @Name, @Credit, @StartDay, @EndDay)";

            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.Add("@id", SqlDbType.NVarChar).Value = c.Cid;
                    sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar).Value = c.Name;
                    sqlCommand.Parameters.Add("@Credit", SqlDbType.Int).Value = c.Credit;
                    sqlCommand.Parameters.Add("@StartDay", SqlDbType.DateTime).Value = c.StartDay;
                    sqlCommand.Parameters.Add("@EndDay", SqlDbType.DateTime).Value = c.EndDay;
                    try
                    {
                        int rowsAffected = sqlCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("ADD SUCCESSFUL", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("ADD FAILED", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        public void RemoveCourse(string cid)
        {
            string removeQuery = "Delete Course where Cid = @cid";

            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                try
                {
                    sqlConnection.Open();

                    using (SqlCommand removeCommand = new SqlCommand(removeQuery, sqlConnection))
                    {
                        removeCommand.Parameters.AddWithValue("@cid", cid);

                        int rowsAffected = removeCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("REMOVE SUCCESSFUL", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("REMOVE FAILED", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        public Salary GetSalaryByID(string id)
        {
            string query = "select * from Salary where LecturerID = @id";
            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;

                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Salary
                            {
                                Amount = Convert.ToDecimal(reader["Amount"])
                            };  
                        }
                        else
                        {
                            throw new Exception("Cannot get the Salary!");
                        }
                    }
                }
            }
        }
        public void UpdateSalary(string id, Salary s)
        {
            string query = "update Salary set Amount = @amount where LecturerID = @id";

            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
                    sqlCommand.Parameters.Add("@amount", SqlDbType.Decimal).Value = s.Amount;

                    try
                    {
                        int rowsAffected = sqlCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("UPDATE SUCCESSFUL", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("UPDATE FAILED", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        public void UpdateSalary(Lecturer s)
        {
            string query = "Insert INTO Salary Values(@id, @amount)";
            s.Sal.updateSalary(s.AcademicQual);
            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.Add("@id", SqlDbType.NVarChar).Value = s.ID;
                    sqlCommand.Parameters.Add("@amount", SqlDbType.Decimal).Value = s.Sal.Amount;
                    try
                    {
                        int rowsAffected = sqlCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("ADD SALARY SUCCESSFUL", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("ADD SALARY FAILED", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void UpdateAcademicQual(string id, string qual)
        {
            string query = "update Lecturer set AcademicQual = @qual where ID = @id";

            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
                    sqlCommand.Parameters.Add("@qual", SqlDbType.NVarChar).Value = qual;

                    try
                    {
                        int rowsAffected = sqlCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            //MessageBox.Show("UPDATE SUCCESSFUL", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            //MessageBox.Show("UPDATE FAILED", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        public DataTable GetAllAccount()
        {
            DataTable dataTable = new DataTable();
            string querry = "SELECT * FROM Account";
            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(querry, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }

        public void AddAccount(string id, string pass)
        {
            string query = "Insert into Account values (@id, @pass)";

            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
                    sqlCommand.Parameters.Add("@pass", SqlDbType.NVarChar).Value = pass;
                    int colsAffected = sqlCommand.ExecuteNonQuery();
                    if (colsAffected > 0)
                    {
                        MessageBox.Show("ADD ACCOUNT SUCCESSFUL", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("ADD ACCOUNT FAILED", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void RemoveAccount(string id)
        {
            string removeQuery = "Delete Account where ID = @id";

            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                try
                {
                    sqlConnection.Open();

                    using (SqlCommand removeCommand = new SqlCommand(removeQuery, sqlConnection))
                    {
                        removeCommand.Parameters.AddWithValue("@id", id);

                        int rowsAffected = removeCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("REMOVE ACCOUNT SUCCESSFUL", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("REMOVE ACCOUNT FAILED", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void ChangePassword(string id, string password)
        {
            string query = "Update Account SET Password = @password where ID = @id";

            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
                    sqlCommand.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;
                    try
                    {
                        int rowsAffected = sqlCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("UPDATE SUCCESSFUL", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("UPDATE FAILED", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public DataTable GetAllStudentAndCourse()
        {
            DataTable dataTable = new DataTable();
            try
            {
                string querry = "SELECT Student.*, Cid, StudentCourse.Name CourseName, Credit, StartDay, EndDay, Midterm, Final, (Midterm + Final)/2 Total FROM Student JOIN StudentCourse ON Student.ID = StudentCourse.StudentID ORDER BY Student.ID";
                using (SqlConnection sqlConnection = Connection.getConnection())
                {
                    sqlConnection.Open();
                    dataAdapter = new SqlDataAdapter(querry, sqlConnection);
                    dataAdapter.Fill(dataTable);
                    sqlConnection.Close();
                }          
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dataTable;
        }
        public DataTable GetAllStudentInfo(string id)
        {
            DataTable dataTable = new DataTable();
            try
            {
                string query = "SELECT Student.*, Cid, StudentCourse.Name CourseName, Credit, StartDay, EndDay, Midterm, Final, (Midterm + Final)/2 Total FROM Student JOIN StudentCourse ON Student.ID = StudentCourse.StudentID AND StudentID = @id ORDER BY Student.ID";
                using (SqlConnection sqlConnection = Connection.getConnection())
                {
                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
                        using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand))
                        {
                            dataAdapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dataTable;
        }

        public DataTable GetAllTuition()
        {
            DataTable dataTable = new DataTable();
            try
            {
                string querry = "SELECT Name, Tuition.* From Tuition, Student Where StudentID = ID";
                using (SqlConnection sqlConnection = Connection.getConnection())
                {
                    sqlConnection.Open();
                    dataAdapter = new SqlDataAdapter(querry, sqlConnection);
                    dataAdapter.Fill(dataTable);
                    sqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dataTable;
        }

        public void UpdateTuition(string id, decimal amount)
        {
            string query;
            if (amount == 0)
                query = "Update Tuition SET Amount = 0, IsPaid = 1 where StudentID = @id";
            else query = "Update Tuition SET Amount = @amount, IsPaid = 0 where StudentID = @id";
            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
                    sqlCommand.Parameters.Add("@amount", SqlDbType.Decimal).Value = amount;
                    try
                    {
                        int rowsAffected = sqlCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("UPDATE TUITION SUCCESSFUL", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("UPDATE TUITION FAILED", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void AddTuition(string id, decimal amount)
        {
            string query;
            if (amount == 0)
                query = "Insert into Tuition Values(@id, 0, 1)";
            else query = "Insert into Tuition Values(@id, @amount, 0)";
            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
                    sqlCommand.Parameters.Add("@amount", SqlDbType.Decimal).Value = amount;
                    try
                    {
                        int rowsAffected = sqlCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("ADD TUITION SUCCESSFUL", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("ADD TUITION FAILED", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void RemoveTuition(string id)
        {
            string removeQuery = "delete Tuition where ID = @id";

            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                try
                {
                    sqlConnection.Open();

                    using (SqlCommand removeCommand = new SqlCommand(removeQuery, sqlConnection))
                    {
                        removeCommand.Parameters.AddWithValue("@id", id);
                        int rowsAffected = removeCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("REMOVE TUITION SUCCESSFUL", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("REMOVE TUITION FAILED", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void AddStudent(Student s)
        {
            string query = "Insert INTO Student Values(@id, @name, @gender, @dob, @major, @fid, @studyDay)";

            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.Add("@id", SqlDbType.NVarChar).Value = s.ID;
                    sqlCommand.Parameters.Add("@name", SqlDbType.NVarChar).Value = s.Name;
                    sqlCommand.Parameters.Add("@gender", SqlDbType.NVarChar).Value = s.Gender;
                    sqlCommand.Parameters.Add("@dob", SqlDbType.DateTime).Value = s.Dob;
                    sqlCommand.Parameters.Add("@major", SqlDbType.NVarChar).Value = s.Major;
                    sqlCommand.Parameters.Add("@fid", SqlDbType.NVarChar).Value = s.FID;
                    sqlCommand.Parameters.Add("@studyDay", SqlDbType.DateTime).Value = s.StudyDate;
                    try
                    {
                        int rowsAffected = sqlCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("ADD SUCCESSFUL", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("ADD FAILED", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        public void RemoveStudent(string id)
        {
            string removeQuery = "delete from Student where ID = @id";

            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                try
                {
                    sqlConnection.Open();

                    using (SqlCommand removeCommand = new SqlCommand(removeQuery, sqlConnection))
                    {
                        removeCommand.Parameters.AddWithValue("@id", id);
                        int rowsAffected = removeCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("REMOVE SUCCESSFUL", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("REMOVE FAILED", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        public DataTable GetAllLecturer()
        {
            DataTable dataTable = new DataTable();
            try
            {
                string querry = "SELECT * FROM Lecturer";
                using (SqlConnection sqlConnection = Connection.getConnection())
                {
                    sqlConnection.Open();
                    dataAdapter = new SqlDataAdapter(querry, sqlConnection);
                    dataAdapter.Fill(dataTable);
                    sqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dataTable;
        }

        public void AddLecturer(Lecturer s)
        {
            string query = "Insert INTO Lecturer Values(@id, @name, @gender, @dob, @fid, @hireDay, @acaQual)";

            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.Add("@id", SqlDbType.NVarChar).Value = s.ID;
                    sqlCommand.Parameters.Add("@name", SqlDbType.NVarChar).Value = s.Name;
                    sqlCommand.Parameters.Add("@gender", SqlDbType.NVarChar).Value = s.Gender;
                    sqlCommand.Parameters.Add("@dob", SqlDbType.DateTime).Value = s.Dob;
                    sqlCommand.Parameters.Add("@acaQual", SqlDbType.NVarChar).Value = s.AcademicQual;
                    sqlCommand.Parameters.Add("@fid", SqlDbType.NVarChar).Value = s.FID;
                    sqlCommand.Parameters.Add("@hireDay", SqlDbType.DateTime).Value = s.HireDate;
                    try
                    {
                        int rowsAffected = sqlCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("ADD SUCCESSFUL", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("ADD FAILED", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void RemoveLecturer(string id)
        {
            string removeQuery = "delete from Lecturer where ID = @id";

            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                try
                {
                    sqlConnection.Open();

                    using (SqlCommand removeCommand = new SqlCommand(removeQuery, sqlConnection))
                    {
                        removeCommand.Parameters.AddWithValue("@id", id);
                        int rowsAffected = removeCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("REMOVE SUCCESSFUL", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("REMOVE FAILED", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
