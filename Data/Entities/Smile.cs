using System.ComponentModel.DataAnnotations;

namespace TextSmiles.API.Data.Entities
{
    public class Smile
    {
        public Guid ID { get; set; }

        [Required]
        [StringLength(200)]
        public string? Name { get; set; }

        [Required]
        public string? Text { get; set; }

        public Guid EmotionID { get; set; }

        public Guid UserID { get; set; }

        public Emotion? Emotion { get; set; }

        public User? User { get; set; }
    }
}
