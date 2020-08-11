using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.DomainEntities
{
    public class Series
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        public string Title { get; set; }
        
        public string Description { get; set; }
        
        private List<Game> Games { get; set; }

        public int Version { get; set; }

        public bool Approved { get; set; }
    }
}