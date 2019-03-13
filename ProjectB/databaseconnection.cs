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
                    student.Firstname = reader.GetString(1);
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
