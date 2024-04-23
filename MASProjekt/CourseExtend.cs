using System.Text.Json;
using System.Xml.Linq;

namespace MASProjekt
{
    public class CourseExtend
    {
        public static List<Course> VideoCourses = new List<Course>(); //Ekstensja
            
        public static void AddCourse(Course course)
        {
            VideoCourses.Add(course);
        }

        public static void AddCourse(List<Course> courses)
        {
            foreach(Course course in courses)
            {
                VideoCourses.Add(course);

            }
        }

        public static void RemoveCourse(string name)
        {
            VideoCourses.RemoveAll(course => course.Name == name);

        }

        public static void ShowCourses()
        {
            Console.WriteLine("Wszystkie dostępne kursy: ");

            foreach (Course course in VideoCourses)
            {
                Console.WriteLine(course.ToString());   //override tostringa tu jest 
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
        {//VideoCourses.OrderByDescending(course => course.AvgCourseRate).FirstOrDefault();
            VideoCourses.Max(course => course.AvgCourseRate);
        }

        public static string SerializeVideoCourses(List<Course> courses)      //przeciążenie 
        {
            string jsonString = JsonSerializer.Serialize(courses);

            return jsonString;
        }

        public static string SerializeVideoCourses(Course course) //przeciążenie
        {
            string jsonString = JsonSerializer.Serialize(course);

            return jsonString;
        }

        public static List<Course> DeserializeVideoCourses(string json)
        {
            var course = JsonSerializer.Deserialize<List<Course>>(json);
           
            return course;
        } 
    }   
}
