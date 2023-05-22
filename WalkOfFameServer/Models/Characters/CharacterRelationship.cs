using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WalkOfFameServer.Models.Characters
{
    [PrimaryKey("CharacterOneId", "CharacterTwoId")]
    public class CharacterRelationship
    {
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

        [ForeignKey("CharacterOneId")]
        public Character CharacterOne { get; set; }
        
        [ForeignKey("CharacterTwoId")]
        public Character CharacterTwo { get; set; }
    }
}
