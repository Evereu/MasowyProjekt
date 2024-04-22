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

        public string? Description { get; set; } 

        public Creator(string name, string surname, string description)
        {
            Name = name;    
            Surname = surname;
            Description = description;
        }

    }
}
