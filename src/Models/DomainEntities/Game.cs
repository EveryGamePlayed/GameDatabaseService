using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design.Serialization;
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

        public string SortTitle { get; set; }

        public string Description { get; set; }

        public DateTime ReleaseDate { get; set; }
        
        public int CommunityRating { get; set; }
        
        public List<Image> Images { get; set; }

        public int PlatformId { get; set; }

        public Platform Platform { get; set; }

        public List<GameGenre> GameGenres { get; set; }

        public int PublisherId { get; set; }

        public Publisher Publisher { get; set; }

        public int DeveloperId { get; set; }

        public Developer Developer { get; set; }
        
        public int SeriesId { get; set; }
        
        public Series Series { get; set; }

        public int Version { get; set; }

        public bool Approved { get; set; }
    }
}
