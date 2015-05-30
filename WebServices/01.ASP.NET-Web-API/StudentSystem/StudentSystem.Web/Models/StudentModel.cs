namespace StudentSystem.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq.Expressions;

    using StudentSystem.Models;

    public class StudentModel
    {
        public static Expression<Func<Student, StudentModel>> FromStudent
        {
            get
            {
                return s => new StudentModel
                {
                    StudentIdentification = s.StudentIdentification,
                    FirstName = s.FirstName,
                    LastName = s.LastName,
                    Level = s.Level
                };
            }
        }

        [Key]
        public int StudentIdentification { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string LastName { get; set; }

        public int Level { get; set; }

        public StudentInfo AdditionalInformation { get; set; }

    }
}