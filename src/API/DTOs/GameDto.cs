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

        public List<PlatformDto> Platforms { get; set; }

        public PublisherDto Publisher { get; set; }

        public DeveloperDto Developer { get; set; }

        public List<GenreDto> Genres { get; set; }


        public GameDto(Game game)
        {
            Id = game.Id;
            Title = game.Title;
            Description = game.Description;
            ReleaseDate = game.ReleaseDate;
            
            Publisher = new PublisherDto(game.Publisher);
            Developer = new DeveloperDto(game.Developer);
            foreach (var genre in game.GameGenres)
            {
                Genres.Add(new GenreDto(genre.Genre));
            }
            foreach (var platform in game.GamePlatforms)
            {
                Platforms.Add(new PlatformDto(platform.Platform));
            }
        }
    }
}
