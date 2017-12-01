using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeStudentCourses
{
    public class CourseInstance
    {
        public int InstanceId { get; set; }
        public Course Course { get; set; }
        public Student Student { get; set; }
        public int Gpa { get; set; }

        public CourseInstance(int instanceId, Course course, Student studentId, int gpa = 0)
        {
            this.InstanceId = instanceId;
            this.Course = course;
            this.Student = studentId;
            this.Gpa = gpa;
        }

    }
}