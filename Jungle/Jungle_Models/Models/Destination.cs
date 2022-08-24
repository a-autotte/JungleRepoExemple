using System.ComponentModel.DataAnnotations;

namespace Jungle_Models.Models
{
    public class Destination
    {
        public int Id { get; set; }
        [StringLength(30)]
        public string Name { get; set; }

        [StringLength(30)]
        public string Region { get; set; }

        public ICollection<Country> Countries { get; set; }
    }
}