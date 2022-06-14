using System.ComponentModel.DataAnnotations;

namespace Movieee.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }

        public string ImageUrl { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        //relations
        public List<Movie> Movies { get; set; }
    }
}