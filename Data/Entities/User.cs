using System.ComponentModel.DataAnnotations;

namespace TextSmiles.API.Data.Entities
{
    public class User
    {
        public Guid ID { get; set; }

        [Required]
        [StringLength(100)]
        public string? Username { get; set; }

        public List<Smile>? Smiles { get; set; }
    }
}
