﻿namespace TaskManager.API.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public DateTime RegistrasionDate { get; set; }
        public DateTime LastLoginDate { get; set; }
        public byte[] Photo { get; set; }

    }
}