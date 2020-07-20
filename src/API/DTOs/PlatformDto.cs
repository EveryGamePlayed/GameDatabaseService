using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models.DomainEntities;

namespace API.DTOs
{
    public class PlatformDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Manufacturer { get; set; }

        public string Description { get; set; }
        public PlatformDto(Platform platform)
        {
            Id = platform.Id;
            Name = platform.Name;
            Manufacturer = platform.Manufacturer;
            Description = platform.Description;
        }
    }
}
