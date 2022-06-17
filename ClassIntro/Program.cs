namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string courseName = "X";
            string instructorName = "Y";
            int completionRate = 65;

            Console.WriteLine("-----------");

            Course course1 = new Course();
            course1.CourseName = "X course";
            course1.InstructorName = "X Instructor";
            course1.CompletionRate = 55;

            Course course2 = new Course();
            course2.CourseName = "Y course";
            course2.InstructorName = "Y Instructor";
            course2.CompletionRate = 75;

            Course course3 = new Course();
            course3.CourseName = "Z course";
            course3.InstructorName = "Z Instructor";
            course3.CompletionRate = 85;

            Course[] courses = new Course[] { course1, course2, course3 };

            foreach(Course course in courses)
                Console.WriteLine($"{course.CourseName} : {course.InstructorName} : {course.CompletionRate}");
        }
    }

    class Course
    {
        public string CourseName { get; set; }
        public string InstructorName { get; set; }
        public int CompletionRate { get; set; }

    }
}