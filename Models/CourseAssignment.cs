using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.Models
{
    public class CourseAssignment
    {
        public int InstructorId { get; set; }
        public int CourseId { get; set; }
        public Instructor Instructor { get; set; }
        public Course Course { get; set; }
    }
}