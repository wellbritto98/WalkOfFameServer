using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WalkOfFameServer.Models
{
    public class Character
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("User")]
        public Guid UserId { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        public int Age { get; set; }

        public DateTime BirthAt { get; set; } = DateTime.Now;

        [Required]
        [ForeignKey("City")]
        public int BirthCityId { get; set; }

        [Required]
        [ForeignKey("Location")]
        public int CurrentLocationId { get; set; }

        [DefaultValue(0)]
        public ulong Money { get; set; }

        public virtual ICollection<Relationship> RelationshipsAsCharacterOne { get; set; }
        public virtual ICollection<Relationship> RelationshipsAsCharacterTwo { get; set; }
    }
}
