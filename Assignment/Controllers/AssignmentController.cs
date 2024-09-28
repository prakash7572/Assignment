using Microsoft.AspNetCore.Mvc;
using static Assignment.Controllers.AssignmentController;

namespace Assignment.Controllers
{
    public class AssignmentController : Controller
    {
        #region ----Solution 1-----
        public class StudentCourse
        {
            public string? StudentName { get; set; }
            public string? Branch { get; set; }
            public string? Subject { get; set; }
        }

        // Create Static Data
        List<StudentCourse> studentCourses = new List<StudentCourse>
        {
            new StudentCourse { StudentName = "Aisha Khan",     Branch = "Computer Science", Subject = "English"},
            new StudentCourse { StudentName = "Luka Rossi",     Branch = "Computer Science", Subject = "English"},
            new StudentCourse { StudentName = "Emiko Tanaka",   Branch = "Computer Science", Subject = "English"},
            new StudentCourse { StudentName = "Aisha Khan",     Branch = "Computer Science", Subject = "Math"},
            new StudentCourse { StudentName = "Luka Rossi",     Branch = "Computer Science", Subject = "Math"},
            new StudentCourse { StudentName = "Emiko Tanaka",   Branch = "Computer Science", Subject = "Math"},
            new StudentCourse { StudentName = "Aisha Khan",     Branch = "Computer Science", Subject = "Programming"},
            new StudentCourse { StudentName = "Luka Rossi",     Branch = "Computer Science", Subject = "Programming"},
            new StudentCourse { StudentName = "Emiko Tanaka",   Branch = "Computer Science", Subject = "Programming"},
            new StudentCourse { StudentName = "Mateo Garcia",   Branch = "Mechanical",       Subject = "English"},
            new StudentCourse { StudentName = "Jara Patel",     Branch = "Mechanical",       Subject = "English"},
            new StudentCourse { StudentName = "Jara Patel",     Branch = "Mechanical",       Subject = "Math"},
            new StudentCourse { StudentName = "Jara Patel",     Branch = "Mechanical",       Subject = "Math"},
            new StudentCourse { StudentName = "Jara Patel",     Branch = "Mechanical",       Subject = "Drawing"},
            new StudentCourse { StudentName = "Jara Patel",     Branch = "Mechanical",       Subject = "Drawing"},
            new StudentCourse { StudentName = "Eshtan Williams",Branch = "Bio Medical",      Subject = "English"},
            new StudentCourse { StudentName = "Leila Muller",   Branch = "Bio Medical",      Subject = "English"},
            new StudentCourse { StudentName = "Eshtan Williams",Branch = "Bio Medical",      Subject = "Biology"},
            new StudentCourse { StudentName = "Leila Muller",   Branch = "Bio Medical",      Subject = "English"}
        };


        // Count students studying English
        public int EnglishStudentCount()
        {
            return studentCourses.Count(sc => sc.Subject == "English");
        }
        // Count students studying Programming
        public int ProgrammingStudentCount()
        {
            return studentCourses.Count(sc => sc.Subject == "Programming");
        }
        // Count students studying String
        public int DrawingStudentCount()
        {
            return studentCourses.Count(sc => sc.Subject == "Drawing");
        }

        public ActionResult Solution1()
        {
            ViewBag.englishStudentCount = EnglishStudentCount();
            ViewBag.programmingStudentCount = ProgrammingStudentCount();
            ViewBag.drawingStudentCount = DrawingStudentCount();

            // Add a new entry (student, branch, subject)
            StudentCourse newStudentCourse = new StudentCourse
            {
                StudentName = "Student Name", 
                Branch = "Branch Name",       
                Subject = "Subject Name"      
            };

            return View();
        }

        #endregion

        #region -----Soution 2-----

        // check Luca Rossi is present
        public int LucaRossiPresent()
        {
            return studentCourses.Count(sc => sc.StudentName == "Luca Rossi");
        }
        // check “Luca Rossi” is studying “Biology” 
        public string LucaRossiStudyingBiology()
        {
            var studyingBiology = studentCourses.Any(sc => sc.StudentName == "Luka Rossi" && sc.Subject == "Biology");
            return studyingBiology ? "Luka Rossi is studying Biology." : "Luka Rossi is not studying Biology.";
        }

        public ActionResult Solution2()
        {
            ViewBag.LucaRossiPresent = LucaRossiPresent() > 0 ? "Luca Rossi Present" : "Luca Rossi Not Present";
            ViewBag.LucaRossiStudyingBiology = LucaRossiStudyingBiology();
            return View();
        }

        #endregion

        #region -----Soution 3-----
        // Open the SQL file located at the following path:
        // "~/Assignment/Assignment/Assignment.sql"
        // This file is expected to contain SQL statements for initializing 
        // the database or executing necessary queries related to the assignment.
        #endregion

        #region ------Solution 4------
        public ActionResult Solution4()
        { 
            return View();
        }

        #endregion

    }
}
