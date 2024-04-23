
namespace MASProjekt
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Platforma z kursami wideo

            //W przypadku istniejącego juz jsona

            string contents = File.ReadAllText(@".\courseList.txt");

            CourseExtend.AddCourse(CourseExtend.DeserializeVideoCourses(contents));


            //Na potrzeby ręcznego dodania obiektów 

            //Creator creator1 = new Creator("Jan", "Nowak", "Fajny twórca");
            //Creator creator2 = new Creator("Jan", "Nowak", "twórca");
            //Creator creator3 = new Creator("Jan", "Nowak", "Fajny twórca");
            //Creator creator4 = new Creator("Jan", "Nowak", "Fajny twórca");

            //List<int> rateList1 = new List<int> { 1, 2, 3, 4 };
            //List<int> rateList2 = new List<int> { 2, 5, 3, 1 };
            //List<int> rateList3 = new List<int> { 1, 2, 5, 4 };
            //List<int> rateList4 = new List<int> { 1, 7, 3, 1 };

            //Course ExampleCourse1 = new Course("course1", creator1, "true", rateList1);
            //Course ExampleCourse2 = new Course("course2", creator2, "true", rateList2);
            //Course ExampleCourse3 = new Course("course3", creator3, "true", rateList3);
            //Course ExampleCourse4 = new Course("course4", creator4, "true", rateList4);

            //CourseExtend.AddCourse(ExampleCourse1);
            //CourseExtend.AddCourse(ExampleCourse2);
            //CourseExtend.AddCourse(ExampleCourse3);
            //CourseExtend.AddCourse(ExampleCourse4);

            //List<Course> courseList = new List<Course>
            //{
            //    ExampleCourse1,
            //    ExampleCourse2,
            //    ExampleCourse3,
            //    ExampleCourse4
            //};

            //File.WriteAllText(@".\courseList.txt", CourseExtend.SerializeVideoCourses(courseList));



            while (true)
            {
                Console.WriteLine("1 - Pokaz aktualne kursy wideo");
                Console.WriteLine("2 - Dodaj nowy kurs");
                Console.WriteLine("3 - Pokaz najwyzej oceniany kurs");
                Console.WriteLine("4 - Usun kurs");
                Console.WriteLine("5 - Exit");

                int type = int.Parse(Console.ReadLine());


                switch (type)
                {
                    case 1:
                        CourseExtend.ShowCourses();
                        break;
                    case 2:
                        Console.WriteLine("Wprowadz nazwe kursu");

                        var courseName = Console.ReadLine();

                        Console.WriteLine("Wprowadz dane twórcy:");

                        Console.WriteLine("Imie: ");
                        var creatorName = Console.ReadLine();  
                        Console.WriteLine("Nazwisko: ");
                        var creatorSurname = Console.ReadLine();    
                        Console.WriteLine("Opis: ");
                        var creatorDescription = Console.ReadLine();

                        Console.WriteLine("Wprowadź opis kursu: ");
                        var newCourseDescription = Console.ReadLine();  

                        Console.WriteLine("Wprowadz oceny użytkowników dla tego kursu: ");
                        List<int> courseRatesList = new List<int>();
                        var courseRate = Console.ReadLine();

                        courseRatesList = courseRate.Split(',', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

                        // Dodawanie nazw kursów do istniejącej listy
                        courseRatesList.AddRange(courseRatesList);
                            

                        Creator newCreator = new Creator(creatorName, creatorSurname, creatorDescription);
                            
                        Course course1 = new Course(courseName, newCreator, newCourseDescription, courseRatesList);
                        CourseExtend.AddCourse(course1);

                        

                        var serializedObject = CourseExtend.SerializeVideoCourses(CourseExtend.VideoCourses);

                        File.WriteAllText(@".\courseList.txt", serializedObject);
                        break;

                    case 3:

                        CourseExtend.FindHighestRatedCourse();

                        break;

                    case 4:
                        Console.WriteLine("Wprowadź nazwę kursu do usunięcia");

                        var name = Console.ReadLine();

                        CourseExtend.RemoveCourse(name);
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
