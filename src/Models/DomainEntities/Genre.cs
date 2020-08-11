using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.DomainEntities
{
    public class Genre
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public List<GameGenre> GameGenres { get; set; }

        public int Version { get; set; }

        public bool Approved { get; set; }
    }
}