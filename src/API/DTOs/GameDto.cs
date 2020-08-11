using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models.DomainEntities;

namespace API.DTOs
{
    public class GameDto
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public PlatformDto Platform { get; set; }

        public PublisherDto Publisher { get; set; }

        public DeveloperDto Developer { get; set; }

        public List<GenreDto> Genres { get; set; }


        public GameDto(Game game)
        {
            Id = game.Id;
            Title = game.Title;
            Description = game.Description;
            ReleaseDate = game.ReleaseDate;
            Platform = new PlatformDto(game.Platform);
            Publisher = new PublisherDto(game.Publisher);
            Developer = new DeveloperDto(game.Developer);
            foreach (var genre in game.GameGenres)
            {
                Genres.Add(new GenreDto(genre.Genre));
            }
        }
    }
}
