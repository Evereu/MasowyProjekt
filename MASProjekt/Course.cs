namespace MASProjekt
{
    //Implementacja ekstensji przy użyciu klasy dodatkowej

    public class Course
    {
        public string Name { get; set; }
        
        public int CourseLenght {  get; set; }
            
        public static int MaxMovieLength { get; } = 60; //Atrybut klasowy (dla wszystkich) 

        public Creator Creator;       //Atrybut złożony
                
        public string? CourseDescription { get; set; }     //opcjonalny
                
        public List<int> CourseRateList { get; set; } //powtarzalny   

        public double AvgCourseRate     // Atrybut pochodny - średnia ocen filmu
        {
            get
            {
                if (CourseRateList == null || CourseRateList.Count == 0)
                {
                    return 0;
                }

                return CourseRateList.Average();
            }
        }

        public Course()     //bez tego deserializacja nie działa
        {

        }

        public Course(string name, Creator creator, string courseDescription, List<int> courseRateList)
        {
            Name = name;    
            Creator = creator;
            CourseDescription = courseDescription;
            CourseRateList = courseRateList;
        }

        public override string ToString()   //Przesłonięcie
        {
     
            string courseRateListString = string.Join(", ", CourseRateList);

            var result = $"Kurs: {Name}, AvgCourseRate: {AvgCourseRate}, Subtitles: {CourseDescription}, CourseRateList: {courseRateListString}";

            return result;
        }

    }   
}
