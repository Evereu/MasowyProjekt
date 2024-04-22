using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MASProjekt
{
    public class Creator
    {

        public string Name {  get; private set; }
        public string Surname {  get; private set; }

        public List<Course> CourseList { get; set; }

        public string? Description { get; set; } 

        public Creator(string name, string surname, List<Course> courseList, string description)
        {
            Name = name;    
            Surname = surname;
            CourseList = courseList;
            Description = description;
        }

    }
}
