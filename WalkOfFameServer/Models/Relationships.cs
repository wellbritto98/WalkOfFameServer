using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WalkOfFameServer.Models
{
    public class Relationship
    {
        [Key]
        [ForeignKey("CharacterOne")]
        [Required]
        public int CharacterOneId { get; set; }

        [Key]
        [ForeignKey("CharacterTwo")]
        [Required]
        public int CharacterTwoId { get; set; }

        [Required]
        [DefaultValue(0)]
        public int CharacterOneLove { get; set; }

        [Required]
        [DefaultValue(0)]
        public int CharacterOneFriendship { get; set; }

        [Required]
        [DefaultValue(0)]
        public int CharacterOneHate { get; set; }

        [Required]
        [DefaultValue(0)]
        public int CharacterTwoLove { get; set; }

        [Required]
        [DefaultValue(0)]
        public int CharacterTwoFriendship { get; set; }

        [Required]
        [DefaultValue(0)]
        public int CharacterTwoHate { get; set; }

        public virtual Character CharacterOne { get; set; }
        public virtual Character CharacterTwo { get; set; }

    }
}
