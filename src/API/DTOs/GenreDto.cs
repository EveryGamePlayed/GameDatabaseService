using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Models.DomainEntities;

namespace API.DTOs
{
    public class GenreDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public GenreDto(Genre genre)
        {
            Id = genre.Id;
            Name = genre.Name;
            Description = genre.Description;
        }
    }
}
