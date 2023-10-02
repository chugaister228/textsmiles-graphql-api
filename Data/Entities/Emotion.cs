using System.ComponentModel.DataAnnotations;

namespace TextSmiles.API.Data.Entities
{
    public class Emotion
    {
        public Guid ID { get; set; }

        [Required]
        [StringLength(200)]
        public string? Name { get; set; }

        public List<Smile>? Smiles { get; set; }
    }
}
