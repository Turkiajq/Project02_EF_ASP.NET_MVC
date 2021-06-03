﻿using System;
namespace Project02_EF_MVC.Models
{
    public class StudentsCourses
    {
        public int Id { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
