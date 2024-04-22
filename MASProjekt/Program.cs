namespace MASProjekt
{
    public class Program
    {
        static void Main(string[] args)
        {   

            //Platforma z kursami wideo

            

            Creator creator = new Creator("Jan", "Nowak", 60);

            List<int> list = new List<int> { 1,2,3,4};

            Course course1 = new Course("course1", creator, "true", list);
            Course course2 = new Course("course2", creator, "true", list);
            Course course3 = new Course("course3", creator, "true", list);
            Course course4 = new Course("course4", creator, "true", list);

            CourseExtend.AddCourse(course1);
            CourseExtend.AddCourse(course2);
            CourseExtend.AddCourse(course3);
            CourseExtend.AddCourse(course4);




            while (true)
            {
                Console.WriteLine("Wprowadz nazwe kursu");

                var courseName = Console.ReadLine();    

                Console.WriteLine("Wprowadz twórce");

                var b = Console.ReadLine();

                Console.WriteLine("Wprowadz trzecie");

                var c = Console.ReadLine();

                Console.WriteLine("Wprowadz czwarte");

                var d = Console.ReadLine();

                Console.WriteLine("Wprowadz piate");
            }







           var abc =  CourseExtend.SerializeVideoCourses(CourseExtend.VideoCourses);

            Console.WriteLine("@@@@"+abc);

            var hhh =  CourseExtend.DeserializeVideoCourses(abc);

            foreach( var h in hhh )
            {
                Console.WriteLine("Name: " + h.Name);
                Console.WriteLine("Subtitles: " + h.Subtitles);
                //Console.WriteLine("AvgCourseRate: " + h.AvgCourseRate);
                foreach ( var rate in h.CourseRateList)
                {
                    Console.WriteLine("rate: " + rate);
                }
            }
        }
    }
}
