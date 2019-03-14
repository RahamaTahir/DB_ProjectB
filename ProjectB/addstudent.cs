using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectB
{
    class addstudent
    {
        private int id;
        private string firstname;
        private string lastname;
        private string contact;
        private string email;
        private string registration_no;
        private int status;

        public int Id { get => id; set => id = value; }
        
        public string Lastname { get => lastname; set => lastname = value; }
        public string Contact { get => contact; set => contact = value; }
        public string Email { get => email; set => email = value; }
        public string Registration_no { get => registration_no; set => registration_no = value; }
        public int Status { get => status; set => status = value; }
        public string FirstName
        {
            get
            { return firstname; }

            set
            {
                bool flag = true;
                if (string.IsNullOrEmpty(value))
                { flag = false; }
                else
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        if (!Char.IsLetter(value[i]) && !Char.IsWhiteSpace(value[i]))
                        {
                            flag = false;
                        }
                    }
                }
                if (flag == true)
                {
                    firstname = value;
                }
                else
                {
                    throw new Exception();
                }
            }
        }
    }
}
