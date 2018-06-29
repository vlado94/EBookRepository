using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EBookRepository.Models
{
    public class User : Entity
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Role { get; set; }

        public User() { }
        public User(string firstName, string lastName, string userName, string password, string role)
        {
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            Password = password;
            Role = role;
        }

    }
}