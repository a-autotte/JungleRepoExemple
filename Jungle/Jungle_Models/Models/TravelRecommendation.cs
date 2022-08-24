using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jungle_Models.Models
{
    public class TravelRecommendation
    {
        public int Id { get; set; }

        [MaxLength(10)]
        public string DangerLevel { get; set; }

        [MaxLength(int.MaxValue)]
        public string Description { get; set; }

        public String Attribut { get; set; }

        public Travel Travel { get; set; }
    }
}
