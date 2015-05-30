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

    public class HomeworkController : ApiController
    {
        private IStudentSystemData data;

        public HomeworkController()
            : this(new StudentsSystemData())
        {
        }

        public HomeworkController(StudentsSystemData data)
        {
            this.data = data;
        }

        [HttpGet]
        // GET api/student
        public IHttpActionResult All()
        {
            var homeworks = this.data
                .Homeworks
                .All()
                .Select(HomeworkModel.FromHomework);

            return Ok(homeworks);
        }

        [HttpPost]
        public IHttpActionResult Create(HomeworkModel homework)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Homework newHomework = new Homework()
            {
                FileUrl = homework.FileUrl,
                TimeSent = homework.TimeSent,
            };

            this.data.Homeworks.Add(newHomework);
            this.data.SaveChanges();

            homework.Id = newHomework.Id;

            return Ok(homework);
        }
    }
}
