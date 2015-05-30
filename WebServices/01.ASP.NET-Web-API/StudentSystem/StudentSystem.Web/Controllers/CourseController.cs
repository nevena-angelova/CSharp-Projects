namespace StudentSystem.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    using StudentSystem.Web.Models;
    using StudentSystem.Data;
    using StudentSystem.Models;

    public class CourseController : ApiController
    {
        private IStudentSystemData data;

        public CourseController()
            : this(new StudentsSystemData())
        {
        }

        public CourseController(StudentsSystemData data)
        {
            this.data = data;
        }

        [HttpGet]
        // GET api/student
        public IHttpActionResult All()
        {
            var courses = this.data
                .Courses
                .All()
                .Select(CourseModel.FromCourse);

            return Ok(courses);
        }

        [HttpPost]
        public IHttpActionResult Create(CourseModel course)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Course newCourse = new Course()
            {
                Name = course.Name,
                Description = course.Description,
            };

            this.data.Courses.Add(newCourse);
            this.data.SaveChanges();

            course.Id = newCourse.Id;

            return Ok(course);
        }

        [HttpPut]
        public IHttpActionResult Update(int id, CourseModel course)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Course selectedCourse = this.data.Courses.All().FirstOrDefault(c => c.Id.Equals(id));

            if (selectedCourse == null)
            {
                return BadRequest("Such course does not exist!");
            }

            selectedCourse.Name = course.Name;
            selectedCourse.Description = course.Description;

            this.data.SaveChanges();

            course.Id = id;

            return Ok(course);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id, CourseModel corse)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Course selectedCourse = this.data.Courses.All().FirstOrDefault(c => c.Id == id);

            if (selectedCourse == null)
            {
                return BadRequest("Such course does not exist!");
            }

            this.data.Courses.Delete(selectedCourse);
            this.data.SaveChanges();

            return Ok();
        }

        [HttpPost]
        public IHttpActionResult AddStudent(int id, int studentId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Course selectedCourse = this.data.Courses.All().FirstOrDefault(c => c.Id == id);

            if (selectedCourse == null)
            {
                return BadRequest("Such course does not exist!");
            }

            Student selectedStudent = this.data.Students.All().FirstOrDefault(s => s.StudentIdentification == studentId);

            if (selectedStudent == null)
            {
                return BadRequest("Such student does not exist!");
            }

            selectedCourse.Students.Add(selectedStudent);
            this.data.SaveChanges();

            return Ok();
        }
    }
}