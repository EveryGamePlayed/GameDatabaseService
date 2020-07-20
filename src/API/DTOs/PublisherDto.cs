using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models.DomainEntities;

namespace API.DTOs
{
    public class PublisherDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public PublisherDto(Publisher publisher)
        {
            Id = publisher.Id;
            Name = publisher.Name;
            Description = publisher.Description;
        }
    }
}
