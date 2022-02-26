using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace CollegeManagementSystemMez.Models
{
        public class Student
        {
            public int StudentId { get; set; }

            [Required]
            public string FirstName { get; set; }
            [DisplayFormat(DataFormatString = "{0:c}")]

            [Required]
            public string LastName { get; set; }
            [DisplayFormat(DataFormatString = "{0:c}")]


        //    public DateTime EnrollmentDate { get; set; }
        //    [DataType(DataType.Date)]
        //    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

            [Required]
            public string BirthDate { get; set; }
     

    //   [DisplayFormat(DataFormatString = "{0:%h}")]

            [Required]
            [EmailAddress]
            public string EmailAddress { get; set; }

            [Required]
            public string Country { get; set; }
        }

    }
