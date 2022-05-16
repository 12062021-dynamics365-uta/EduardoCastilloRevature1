using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC_Pet_Store.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Display(Name = "Name")]
        public string FullName { get { return FirstName + " " + LastName; } }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }


        //Pet preferences
       
        public int? DesiredAge { get; set; }
        public Color DesiredColor { get; set; }
        public byte DesiredColorId { get; set; }
        public Gender DesiredGender { get; set; }
        public byte DesiredGenderId { get; set; }
        public PetType DesiredPetType { get; set; }
        public byte DesiredPetTypeId { get; set; }
        public string OtherPreferences { get; set; }   

    }
}