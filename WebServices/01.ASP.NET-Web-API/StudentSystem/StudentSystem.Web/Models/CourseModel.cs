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

    public class CourseModel
    {
        public static Expression<Func<Course, CourseModel>> FromCourse
        {
            get
            {
                return c => new CourseModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    Description = c.Description,
                };
            }

        }

        public int Id { get; set; }

        [Column("CourseName")]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}