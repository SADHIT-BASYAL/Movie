using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movieee.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        public string ImageUrl { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; } = string.Empty;

        //relations

        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}