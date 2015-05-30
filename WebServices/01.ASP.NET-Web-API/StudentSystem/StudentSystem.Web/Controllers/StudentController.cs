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

    public class StudentController : ApiController
    {
        private IStudentSystemData data;

        public StudentController()
            : this(new StudentsSystemData())
        {
        }

        public StudentController(StudentsSystemData data)
        {
            this.data = data;
        }

        [HttpGet]
        // GET api/student
        public IHttpActionResult All()
        {
            var students = this.data
                .Students
                .All()
                .Select(StudentModel.FromStudent);

            return Ok(students);
        }

        [HttpPost]
        public IHttpActionResult Create(StudentModel student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Student newStudent = new Student()
            {
                FirstName = student.FirstName,
                LastName = student.LastName,
                Level = student.Level,
                AdditionalInformation = student.AdditionalInformation
            };

            this.data.Students.Add(newStudent);
            this.data.SaveChanges();

            student.StudentIdentification = newStudent.StudentIdentification;

            return Ok(student);
        }

        [HttpPut]
        public IHttpActionResult Update(int id, StudentModel student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Student selectedStudent = this.data.Students.All().FirstOrDefault(s => s.StudentIdentification == id);

            if (selectedStudent == null)
            {
                return BadRequest("such student does not exist!");
            }

            selectedStudent.FirstName = student.FirstName;
            selectedStudent.LastName = student.LastName;
            selectedStudent.Level = student.Level;

            this.data.SaveChanges();

            student.StudentIdentification = id;

            return Ok(student);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id, StudentModel student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Student selectedStudent = this.data.Students.All().FirstOrDefault(s => s.StudentIdentification == id);

            if (selectedStudent == null)
            {
                return BadRequest("such student does not exist!");
            }

            this.data.Students.Delete(selectedStudent);
            this.data.SaveChanges();

            return Ok();
        }

        [HttpPost]
        public IHttpActionResult AddCourse(int id, int courseId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Course selectedCourse = this.data.Courses.All().FirstOrDefault(c => c.Id == courseId);

            if (selectedCourse == null)
            {
                return BadRequest("Such course does not exist!");
            }

            Student selectedStudent = this.data.Students.All().FirstOrDefault(s => s.StudentIdentification == id);

            if (selectedStudent == null)
            {
                return BadRequest("Such student does not exist!");
            }

            selectedStudent.Courses.Add(selectedCourse);
            this.data.SaveChanges();

            return Ok();
        }
    }
}