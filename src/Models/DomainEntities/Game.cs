using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;

namespace Models.DomainEntities
{
    public class Game
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime ReleaseDate { get; set; }

        public int PlatformId { get; set; }

        public Platform Platform { get; set; }

        public List<GameGenre> GameGenres { get; set; }

        public int PublisherId { get; set; }

        public Publisher Publisher { get; set; }

        public int DeveloperId { get; set; }

        public Developer Developer { get; set; }
    }
}
