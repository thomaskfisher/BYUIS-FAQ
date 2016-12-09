using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

//THIS MODEL IS LINKED TO THE USERS TABLE AND CONTAINS THE NECESSARY VALIDATIONS

namespace Project_1.Models
{
    [Table("Users")]
    public class Users
    {
            [Key]
            [DisplayName("User ID")]
            public int userID { get; set; }

            [Required]
            [DisplayName("Email")]
            [EmailAddress(ErrorMessage = "Please enter a valid email")]
            [StringLength(50, MinimumLength = 10, ErrorMessage = "The maximum length is 50, the minimum is 10")]
            public string userEmail { get; set; }

            //[PasswordPropertyText]
            [DisplayName("Password")]
            [Required(ErrorMessage = "A password is required")]
            [StringLength(50, MinimumLength = 9, ErrorMessage = "The maximum length is 50, the minimum is 9")]
            public string password { get; set; }

            [DisplayName("First Name")]
            [Required(ErrorMessage = "A first name is required")]
            [StringLength(50, MinimumLength = 5, ErrorMessage = "The maximum length is 50, the minimum is 5")]
            public string userFirstName { get; set; }

            [DisplayName("Last Name")]
            [Required(ErrorMessage = "A last name is required")]
            [StringLength(50, MinimumLength = 5, ErrorMessage = "The maximum length is 50, the minimum is 5")]
            public string userLastName { get; set; }

    }
}