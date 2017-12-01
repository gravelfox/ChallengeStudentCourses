using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeStudentCourses
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void assignment1Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a List of Courses (add three example Courses ...
             * make up the details).  Each Course should have at least two
             * Students enrolled in them.  Use Object and Collection
             * Initializers.  Then, iterate through each Course and print
             * out the Course's details and the Students that are enrolled in
             * each Course.
             */
            List<Student> activeStudents = new List<Student>
            {
                new Student {StudentId = 1997109, Name = "Harry Potter" },
                new Student {StudentId = 1997110, Name = "Hermione Granger" },
                new Student {StudentId = 1997111, Name = "Ron Weasley" },
                new Student {StudentId = 1997112, Name = "Neville Longbottom" },
                new Student {StudentId = 1997113, Name = "Draco Malfoy" },
                new Student {StudentId = 1997114, Name = "Luna Lovegood" },
                new Student {StudentId = 1997115, Name = "Ginny Weasley" },
                new Student {StudentId = 1997116, Name = "Cho Chang" },
                new Student {StudentId = 1997117, Name = "Gregory Goyle" },
            };

            List<Course> offeredCourses = new List<Course>
            {
                new Course {CourseId = 19101, Name = "Intro to Defence Against the Dark Arts", Students = new List<Student>
                    {
                    activeStudents.Find(p => p.StudentId == 1997109),
                    activeStudents.Find(p => p.StudentId == 1997112),
                    activeStudents.Find(p => p.StudentId == 1997115)
                    }
                },
                new Course {CourseId = 17102, Name = "Survey of Potions", Students = new List<Student>
                    {
                    activeStudents.Find(p => p.StudentId == 1997110),
                    activeStudents.Find(p => p.StudentId == 1997113),
                    activeStudents.Find(p => p.StudentId == 1997116)
                    }
                },
                new Course {CourseId = 04201, Name = "Incantations and Invocations for Enchantments", Students = new List<Student> {
                    activeStudents.Find(p => p.StudentId == 1997111),
                    activeStudents.Find(p => p.StudentId == 1997114),
                    activeStudents.Find(p => p.StudentId == 1997117)
                    }
                }
            };

            string result = "";

            foreach (Course course in offeredCourses)
            {
                result += string.Format("Course: {0:00000} - {1}<br />", course.CourseId, course.Name);
                foreach (Student student in course.Students)
                {
                    result += string.Format("&nbsp;&nbsp;Student: {0} - {1}<br />", student.StudentId.ToString(), student.Name);
                }
            }

            resultLabel.Text = result;


        }

        protected void assignment2Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a Dictionary of Students (add three example Students
             * ... make up the details).  Use the StudentId as the 
             * key.  Each student must be enrolled in two Courses.  Use
             * Object and Collection Initializers.  Then, iterate through
             * each student and print out to the web page each Student's
             * info and the Courses the Student is enrolled in.
             */
            List<Course> courseOffering = new List<Course>
            {
                 new Course {CourseId = 19101, Name = "Intro to Defence Against the Dark Arts" },
                 new Course {CourseId = 17102, Name = "Survey of Potions" },
                 new Course {CourseId = 04201, Name = "Incantations and Invocations for Enchantments" }
            };

            Dictionary<int, Student> studentRoll = new Dictionary<int, Student>
            {
                { 1997109, new Student { Name = "Harry Potter", Courses = new List<Course>
                    { courseOffering.Find(p => p.CourseId == 19101), courseOffering.Find(p => p.CourseId == 04201) }
                }},
                { 1997110, new Student { Name = "Hermione Granger", Courses = new List<Course>
                    { courseOffering.Find(p => p.CourseId == 17102), courseOffering.Find(p => p.CourseId == 04201) }
                }},
                { 1997111, new Student { Name = "Ron Weasley", Courses = new List<Course>
                    { courseOffering.Find(p => p.CourseId == 17102), courseOffering.Find(p => p.CourseId == 19101) }
                }}
            };

            string result = "";

            foreach (KeyValuePair<int, Student> student in studentRoll)
            {
                result += string.Format("Student: {0} - {1}<br />", student.Key, student.Value.Name);
                foreach (Course course in student.Value.Courses)
                {
                    result += string.Format("&nbsp;&nbsp;Course: {0:00000} - {1}<br />", course.CourseId, course.Name);
                }
            }

            resultLabel.Text = result;

        }

        protected void assignment3Button_Click(object sender, EventArgs e)
        {
            /*
             * We need to keep track of each Student's grade (0 to 100) in a 
             * particular Course.  This means at a minimum, you'll need to add 
             * another class, and depending on your implementation, you will 
             * probably need to modify the existing classes to accommodate this 
             * new requirement.  Give each Student a grade in each Course they
             * are enrolled in (make up the data).  Then, for each student, 
             * print out each Course they are enrolled in and their grade.
             */

            List<Course> courseOffering = new List<Course>
            {
                 new Course {CourseId = 19101, Name = "Intro to Defence Against the Dark Arts" },
                 new Course {CourseId = 17102, Name = "Survey of Potions" },
                 new Course {CourseId = 04201, Name = "Incantations and Invocations for Enchantments" }
            };

            List<Student> activeStudents = new List<Student>
            {
                new Student {StudentId = 1997109, Name = "Harry Potter" },
                new Student {StudentId = 1997110, Name = "Hermione Granger" },
                new Student {StudentId = 1997111, Name = "Ron Weasley" },
                new Student {StudentId = 1997112, Name = "Neville Longbottom" },
                new Student {StudentId = 1997113, Name = "Draco Malfoy" },
                new Student {StudentId = 1997114, Name = "Luna Lovegood" },
                new Student {StudentId = 1997115, Name = "Ginny Weasley" },
                new Student {StudentId = 1997116, Name = "Cho Chang" },
                new Student {StudentId = 1997117, Name = "Gregory Goyle" }
            };

            List<CourseInstance> currentSemester = new List<CourseInstance>
            {
                new CourseInstance(199710911, courseOffering.Find(p => p.CourseId == 19101) ,activeStudents.Find(p => p.StudentId == 1997109), 91),
                new CourseInstance(199710912, courseOffering.Find(p => p.CourseId == 04201) ,activeStudents.Find(p => p.StudentId == 1997109), 92),
                new CourseInstance(199710913, courseOffering.Find(p => p.CourseId == 17102) ,activeStudents.Find(p => p.StudentId == 1997109), 96),
                new CourseInstance(199711011, courseOffering.Find(p => p.CourseId == 19101) ,activeStudents.Find(p => p.StudentId == 1997110), 100),
                new CourseInstance(199711012, courseOffering.Find(p => p.CourseId == 04201) ,activeStudents.Find(p => p.StudentId == 1997110), 100),
                new CourseInstance(199711013, courseOffering.Find(p => p.CourseId == 17102) ,activeStudents.Find(p => p.StudentId == 1997110), 99),
                new CourseInstance(199711111, courseOffering.Find(p => p.CourseId == 19101) ,activeStudents.Find(p => p.StudentId == 1997111), 79),
                new CourseInstance(199711112, courseOffering.Find(p => p.CourseId == 04201) ,activeStudents.Find(p => p.StudentId == 1997111), 82),
                new CourseInstance(199711113, courseOffering.Find(p => p.CourseId == 17102) ,activeStudents.Find(p => p.StudentId == 1997111), 83)
            };

            string result = "";

            foreach (Student student in activeStudents)
            {
                if (currentSemester.FirstOrDefault(p => p.Student.StudentId == student.StudentId) != null) {
                    result += string.Format("Student: {0} {1}<br />", student.StudentId, student.Name);
                    foreach (CourseInstance courseInstance in currentSemester)
                    {
                        result += (courseInstance.Student.StudentId == student.StudentId) ? string.Format("&nbsp;&nbsp;Enrolled in: {0} {1} - Grade: {2}<br />", courseInstance.Course.CourseId, courseInstance.Course.Name, courseInstance.Gpa):"";
                    }
                }
            }

            resultLabel.Text = result;
        }
    }
}