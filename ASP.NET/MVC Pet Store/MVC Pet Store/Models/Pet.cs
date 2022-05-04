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
        public Color Color { get; set; }
        public byte ColorId { get; set; }
        public Gender Gender{ get; set; }
        public byte GenderId { get; set; }
        public PetType PetType { get; set; }
        public byte PetTypeId { get; set; }
        public string Biography { get; set; }
    }
}