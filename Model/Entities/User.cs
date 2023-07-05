using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardConsole.Model.Enum;

namespace CardConsole.Model.Entities
{
    public class User : BaseEntity
    {
        public string FirstName;
        public string LastName;
        public string Email;
        public string Password;
        public string PhoneNumber;
        public DateTime Dob;
        public Gender Gender;

        public string Role;

        public User(int id, string firstName, string lastName, string email, string password, string phoneNumber, DateTime dob, Gender gender, string role) : base(id)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            PhoneNumber = phoneNumber;
            Dob = dob;
            Gender = gender;
            Role = role;



        }
    }
}