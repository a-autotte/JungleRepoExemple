using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Jungle_Models.Models
{
    public class Travel
    {
        public int Id { get; set; }

        [MaxLength(25)]
        public string Name { get; set; }


        public string Description { get; set; }

        
        public double Price { get; set; }

        public DateTime DepartureDate { get; set; }

        [Range(7, 21)]
        public int Duration { get; set; }

        public ICollection<Destination> Destinations { get; set; }

        public ICollection<Guide> Guides { get; set; }

    }
}
