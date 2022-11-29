using AfosyLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace AfosyLibrary
{
    public class TeamModel
    {
        public List <PersonModel> Persons { get; set; } = new List<PersonModel>();
        public string Cargo { get; set; }
    }

}
