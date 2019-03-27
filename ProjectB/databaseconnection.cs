using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjectB
{
    class databaseconnection
    {
            private static databaseconnection instance;
            public string connectionstring;
            private SqlConnection connection;

            databaseconnection()
            {

            }

            public static databaseconnection get_instance()
            {
                if (instance == null)
                {
                    instance = new databaseconnection();
                }
                return instance;
            }


            public SqlConnection Getconnection()
            {
                connection = new SqlConnection(connectionstring);
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
                return connection;
            }

            public void close()
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }


        /// <summary>
        /// This function retrieve the list of rubric levels from database
        /// </summary>
        /// <param name="commandText"></param>
        /// <returns></returns>
        public List<levelrubrics> Listoflevels(string commandText)
        {
            connection = Getconnection();
            SqlCommand cmd = new SqlCommand(commandText, connection);
            List<levelrubrics> level1 = new List<levelrubrics>();
            var reader = Getdata(commandText);
            while (reader.Read())
            {

                levelrubrics level = new levelrubrics();
                level.Id = Convert.ToInt32(reader.GetValue(0));
                level.Details = reader.GetString(2);
                level.RubricId = Convert.ToInt32(reader.GetValue(1));
                level.MeasurementLevel = Convert.ToInt32(reader.GetValue(3));
                level1.Add(level);
            }
            return level1;
        }

        /// <summary>
        /// This function retrieve the list of Students levels from database
        /// </summary>
        /// <param name="commandText"></param>
        /// <returns></returns>
        public List<addstudent> Listofstudents(string commandText)
            {
                connection = Getconnection();
                SqlCommand cmd = new SqlCommand(commandText, connection);
                List<addstudent> student_list = new List<addstudent>();
                var reader = Getdata(commandText);
                while (reader.Read())
                {
                    
                    addstudent student = new addstudent();
                    student.Id = Convert.ToInt32(reader.GetValue(0));
                    student.FirstName = reader.GetString(1);
                    student.Lastname = reader.GetString(2);
                    student.Contact = reader.GetString(3);
                    student.Email = reader.GetString(4);
                    student.Registration_no = reader.GetString(5);
                    if(reader.GetInt32(6)==5)
                    {
                        student.Status = 5;
                    }
                    else
                    {
                        student.Status = 6;
                    }
                    student_list.Add(student);
                }
                return student_list;
            }

        public List<addstudent> ListofActivestudents(string commandText)
        {
            connection = Getconnection();
            SqlCommand cmd = new SqlCommand(commandText, connection);
            List<addstudent> student_list = new List<addstudent>();
            var reader = Getdata(commandText);
            while (reader.Read())
            {
                if (reader.GetInt32(6) == 5)
                {
                    addstudent student = new addstudent();
                    student.Id = Convert.ToInt32(reader.GetValue(0));
                    student.FirstName = reader.GetString(1);
                    student.Lastname = reader.GetString(2);
                    student.Contact = reader.GetString(3);
                    student.Email = reader.GetString(4);
                    student.Registration_no = reader.GetString(5);
                    if (reader.GetInt32(6) == 5)
                    {
                        student.Status = 5;
                    }
                    student_list.Add(student);
                }
                
            }
            return student_list;
        }

        /// <summary>
        /// This function retrieve the list of Clos levels from database
        /// </summary>
        /// <param name="commandText"></param>
        /// <returns></returns>
        public List<Clo> ListofClo(string commandText)
        {
            connection = Getconnection();
            SqlCommand cmd = new SqlCommand(commandText, connection);
            List<Clo> clo_list = new List<Clo>();
            var reader = Getdata(commandText);
            while (reader.Read())
            {

                Clo n_clo = new Clo();
                n_clo.Id = Convert.ToInt32(reader.GetValue(0));
                n_clo.Name = reader.GetString(1);
                n_clo.Datecreated = reader.GetDateTime(2).Date;
                n_clo.Dateupdated = reader.GetDateTime(3).Date;
                
                clo_list.Add(n_clo);
            }
            return clo_list;
        }

        /// <summary>
        /// This function retrieve the list of rubrics from database
        /// </summary>
        /// <param name="commandText"></param>
        /// <returns></returns>
        public List<Rubricaddclass> Listofrubrics(string commandText)
        {
            connection = Getconnection();
            SqlCommand cmd = new SqlCommand(commandText, connection);
            List<Rubricaddclass> rubric = new List<Rubricaddclass>();
            var reader = Getdata(commandText);
            while (reader.Read())
            {
                Rubricaddclass j = new Rubricaddclass();
                j.Id = Convert.ToInt32(reader.GetValue(0));
                j.Details = reader.GetString(1);
                j.Cloid = Convert.ToInt32(reader.GetValue(2));
                rubric.Add(j);
            }
            return rubric;
        }

        public List<Assessmentcomponent> Listofcomponents(string commandText)
        {
            connection = Getconnection();
            SqlCommand cmd = new SqlCommand(commandText, connection);
            List<Assessmentcomponent> component = new List<Assessmentcomponent>();
            var reader = Getdata(commandText);
            while (reader.Read())
            {
                Assessmentcomponent j = new Assessmentcomponent();
                j.Id = Convert.ToInt32(reader.GetValue(0));
                j.Name = reader.GetValue(1).ToString();
                j.RubricId =Convert.ToInt32( reader.GetValue(2));
                j.TotalMarks = Convert.ToInt32(reader.GetValue(3));
                j.AssessmentId = Convert.ToInt32(reader.GetValue(6));
                j.DateCreated = Convert.ToDateTime(reader[4]).Date;
                j.DateUpdated = Convert.ToDateTime(reader[5]).Date;
                
                component.Add(j);
            }
            return component;
        }

        public List<Assessmentclass> Listofassessments(string commandText)
        {
            connection = Getconnection();
            SqlCommand cmd = new SqlCommand(commandText, connection);
            List<Assessmentclass> component = new List<Assessmentclass>();
            var reader = Getdata(commandText);
            while (reader.Read())
            {
                Assessmentclass j = new Assessmentclass();
                j.Id = Convert.ToInt32(reader.GetValue(0));
                j.Title = reader.GetValue(1).ToString();
                j.DateCreated = Convert.ToDateTime(reader.GetValue(2));
                j.TotalMarks = Convert.ToInt32(reader.GetValue(3));
                j.TotalWeightage = Convert.ToInt32(reader[4]);

                component.Add(j);
            }
            return component;
        }

        public SqlDataReader Getdata(string query)
            {
                connection = Getconnection();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader data = cmd.ExecuteReader();
                return data;

            }

            public int Executequery(string query)
            {
                connection = Getconnection();
                SqlCommand cmd = new SqlCommand(query, connection);
                int row = cmd.ExecuteNonQuery();
                return row;
            }

            public void Closeconnection()
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

        }
    }
