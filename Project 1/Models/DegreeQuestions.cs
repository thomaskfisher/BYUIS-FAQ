using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

//THIS IS LINKED TO THE DEGREEQUESTIONS TABLE

namespace Project_1.Models
{
    [Table("DegreeQuestions")]
    public class DegreeQuestions
    {
        [Key]
        [DisplayName("Degree Question ID")]
        public int degreeQuestionID { get; set; }

        [DisplayName("Degree ID")]
        [Required(ErrorMessage = "A degree ID is required")]
        public int degreeID { get; set; }

        [DisplayName("User ID")]
        [Required(ErrorMessage = "A user ID is required")]
        public int userID { get; set; }

        [DisplayName("Question")]
        [Required(ErrorMessage = "A question is required")]
        public string question { get; set; }

        [DisplayName("Answer")]
        public string answer { get; set; }
    }
}