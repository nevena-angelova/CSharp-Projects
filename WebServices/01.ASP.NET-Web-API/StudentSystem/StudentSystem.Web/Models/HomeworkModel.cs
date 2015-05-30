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

    public class HomeworkModel
    {
        public static Expression<Func<Homework, HomeworkModel>> FromHomework
        {
            get
            {
                return h => new HomeworkModel
                {
                    FileUrl = h.FileUrl,
                    TimeSent = h.TimeSent,
                };
            }
        }

        public int Id { get; set; }

        public string FileUrl { get; set; }

        public DateTime TimeSent { get; set; }
    }
}