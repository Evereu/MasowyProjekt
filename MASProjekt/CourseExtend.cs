using System.Text.Json;

namespace MASProjekt
{
    public class CourseExtend
    {
        public static List<Course> VideoCourses = new List<Course>(); //Ekstensja
            
        public static void AddCourse(Course course)
        {
            VideoCourses.Add(course);
        }

        public static void RemoveCourse(Course course)
        {
            VideoCourses.Remove(course);
        }

        public static void showCourses()
        {
            Console.WriteLine("Wszystkie dostępne kursy");

            foreach (Course course in VideoCourses)
            {
                Console.WriteLine(course.Name);
            }
        }

        public static void SearchCourse(string courseName) // Metoda klasowa przeciążenie
        {
             VideoCourses.Find(c => c.Name == courseName);
        }

        public static void SearchCourse(int courseLenght) // Metoda klasowa przeciążenie
        {
            VideoCourses.Find(c => c.CourseLenght == courseLenght);
        }

        public static void FindHighestRatedCourse()  // Metoda klasowa
        {
            VideoCourses.Max(course => course.AvgCourseRate);
        }

        public static string SerializeVideoCourses(List<Course> courses)       
        {
            string jsonString = JsonSerializer.Serialize(courses);

            return jsonString;
        }
            
        public static List<Course> DeserializeVideoCourses(string json)
        {
            var course = JsonSerializer.Deserialize<List<Course>>(json);
           
            return course;
        } 
    }   
}
