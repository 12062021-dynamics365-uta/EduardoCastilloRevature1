using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Pet_Store.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string  Breed { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }
        public string Gender { get; set; }
        public string PetType { get; set; }
        public string Biography { get; set; }
    }
}