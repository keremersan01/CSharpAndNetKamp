namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string course1 = "Database Management Systems";
            string course2 = "Data Structures And Algorithms";
            string course3 = "Developing Web Application";
            string course4 = "Artificial Intelligence";

            Console.WriteLine(course1);
            Console.WriteLine(course2);
            Console.WriteLine(course3);
            Console.WriteLine(course4);
            Console.WriteLine("-----------------");

            // arrays 

            string[] courses = new string[] { course1, course2, course3 , course4};

            // classical for-loop
            for(int i = 0; i < courses.Length; ++i)
                Console.WriteLine(courses[i]);

            Console.WriteLine("--------------");
            // enhanced for-loop or foreach loop
            foreach(string course in courses)
                Console.WriteLine(course);
        }
    }
}