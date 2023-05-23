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
        public long Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        public int Age { get; set; }

        public DateTime BirthAt { get; set; } = DateTime.Now;

        public long BirthCityId { get; set; }
        
        [Required]
        [ForeignKey(nameof(BirthCityId))]
        public virtual City BirthCity { get; set; }
        
        [Required]
        public GenderEnum Gender { get; set; }
        
        public long CurrentLocationId { get; set; }

        [Required]
        [ForeignKey(nameof(CurrentLocationId))]
        public virtual Location CurrentLocation { get; set; }

        [DefaultValue(0)]
        public ulong Money { get; set; }
        
        public long UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public virtual User User { get; init; }
        
        [InverseProperty("CharacterOne")]
        public List<CharacterRelationship> RelationshipsAsCharacterOne { get; } = new();
        
        [InverseProperty("CharacterTwo")]
        public List<CharacterRelationship> RelationshipsAsCharacterTwo { get; } = new();
    }
}
