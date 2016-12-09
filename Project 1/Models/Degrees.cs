using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

//THIS IS LINKED DIRECTLY TO THE DEGREE TABLE

namespace Project_1.Models
{
    [Table("Degrees")]
    public class Degrees
    {
        [Key]
        [DisplayName("Degree ID")]
        public int degreeID { get; set; }

        [DisplayName("Name of Degree")]
        [Required(ErrorMessage = "A degree name is required")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "The maximum length is 50, the minimum is 5")]
        public string degreeName { get; set; }

        [DisplayName("Degree Coordinator")]
        [Required(ErrorMessage = "A degree coordinator is required")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "The maximum length is 50, the minimum is 5")]
        public string degreeCoordinator { get; set; }

        [DisplayName("Coordinator Title")]
        [Required(ErrorMessage = "A coordinator title is required")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "The maximum length is 50, the minimum is 5")]
        public string coordinatorTitle { get; set; }

        [DisplayName("Coordinator Office Address")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "The maximum length is 50, the minimum is 5")]
        public string coordinatorOfficeAddress { get; set; }

        [DisplayName("PhD Education")]
        [Required(ErrorMessage = "A PhD education is required")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "The maximum length is 50, the minimum is 5")]
        public string phdEducation { get; set; }

        [DisplayName("Masters Education")]
        [Required(ErrorMessage = "A masters education is required")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "The maximum length is 50, the minimum is 5")]
        public string mastersEducation { get; set; }

        [DisplayName("Bachelors Education")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "The maximum length is 50, the minimum is 5")]
        public string bachelorsEducation { get; set; }

        [DisplayName("Coordinator Picture")]
        [Required(ErrorMessage = "A coordinator picture is required")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "The maximum length is 50, the minimum is 5")]
        public string coordinatorPicture { get; set; }
    }
}