using SchoolAdminSystem.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SchoolAdminSystem.Models
{
    public class DataAccessLayer
    {
        private readonly string _connectionString = SqlHelper.ConnectionString;

        public IEnumerable<Teacher> GetAllTeachers()
        {
            List<Teacher> listTeachers = new List<Teacher>();

            using (SqlConnection con = new SqlConnection(_connectionString))

            {
                SqlCommand cmd = new SqlCommand("sp_TeacherRead", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Teacher teacher = new Teacher
                    {
                        TeacherId = Convert.ToInt32(rdr["TeacherId"]),
                        FirstName = rdr["FirstName"].ToString(),
                        LastName = rdr["LastName"].ToString(),
                        SubjectId = Convert.ToInt32(rdr["SubjectId"]),
                        StudentId = Convert.ToInt32(rdr["StudentId"])
                    };

                    listTeachers.Add(teacher);

                }
                con.Close();
            }

            return listTeachers;
        }
    }
}
