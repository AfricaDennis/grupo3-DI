using System;
using System.ComponentModel.DataAnnotations;

namespace grupo3.Models
{
    public class UserResponse
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public object student { get; set; }
        public object teacher { get; set; }
        public bool admin { get; set; }

        public UserResponse(int id, string name, string surname, string password, string email, string phone, bool student, bool teacher, bool admin)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.password = password;
            this.email = email;
            this.phone = phone;
            this.student = student;
            this.teacher = teacher;
            this.admin = admin;
        }
    }
}
