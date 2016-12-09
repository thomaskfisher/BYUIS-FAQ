using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

//THIS IS NOT LINKED TO A TABLE. IT IS CUSTOMIZED TO CONTAIN BOTH DEGREEQUESTION AND DEGREE INFO

namespace Project_1.Models
{
    public class DegreesAndQuestions
    {
        public int degreeID { get; set; }
        public string degreeName { get; set; }
        public string degreeCoordinator { get; set; }
        public string coordinatorTitle { get; set; }
        public string coordinatorOfficeAddress { get; set; }
        public string phdEducation { get; set; }
        public string mastersEducation { get; set; }
        public string bachelorsEducation { get; set; }
        public string coordinatorPicture { get; set; }


        [Key]
        public int degreeQuestionID { get; set; }
        //public int degreeName { get; set; }
        public int userID { get; set; }
        public string question { get; set; }
        public string answer { get; set; }

        public IEnumerable<DegreeQuestions> DegreeQuestion { get; set; }
        public IEnumerable<Degrees> Degree { get; set; }
    }
}