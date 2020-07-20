using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models.DomainEntities;

namespace API.DTOs
{
    public class DeveloperDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DeveloperDto(Developer developer)
        {
            Id = developer.Id;
            Name = developer.Name;
            Description = developer.Description;
        }
    }
}
