using System.ComponentModel.DataAnnotations;

namespace Jungle_Models.Models
{
    public class Guide
    {
        public int Id { get; set; }

        [MaxLength(25)]
        public string LastName { get; set; }

        [MaxLength(25)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string Speciality { get; set; }
    }
}
