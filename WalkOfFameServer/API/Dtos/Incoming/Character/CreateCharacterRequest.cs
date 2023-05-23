using System;
using System.ComponentModel.DataAnnotations;
using WalkOfFameServer.Enums;

namespace WalkOfFameServer.API.Dtos.Incoming.Character
{
    public class CreateCharacterRequest
    {
        [Required(ErrorMessage = "empty")]
        public long CityId { get; set; }
        
        [Required(ErrorMessage = "empty")]
        public GenderEnum Gender { get; set; }
        
        [Required(ErrorMessage = "empty")]
        public string FirstName { get; set; }
        
        [Required(ErrorMessage = "empty")]
        public string LastName { get; set; }
        
        [Required(ErrorMessage = "empty"), Range(16, 40, ErrorMessage = "range.{0}.{1}")]
        public int Age { get; set; }
    }
}
