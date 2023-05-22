using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WalkOfFameServer.Enums;
using WalkOfFameServer.Models.Cities;
using WalkOfFameServer.Models.Users;

namespace WalkOfFameServer.Models.Characters
{
    public class Character
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        public int Age { get; set; }

        public DateTime BirthAt { get; set; } = DateTime.Now;

        [Required]
        [ForeignKey("BirthCityId")]
        public City BirthCity { get; set; }
        
        [Required]
        public GenderEnum Gender { get; set; }

        [Required]
        [ForeignKey("CurrentLocationId")]
        public Location CurrentLocation { get; set; }

        [DefaultValue(0)]
        public ulong Money { get; set; }

        [ForeignKey("UserId")]
        public User User { get; init; }
        
        [InverseProperty("CharacterOne")]
        public List<CharacterRelationship> RelationshipsAsCharacterOne { get; } = new();
        
        [InverseProperty("CharacterTwo")]
        public List<CharacterRelationship> RelationshipsAsCharacterTwo { get; } = new();
    }
}
