namespace TextSmiles.API.Data.Entities
{
    public class Smile
    {
        public Guid ID { get; set; }
        public string? Name { get; set; }
        public string? Text { get; set; }
        public Guid TagID { get; set; }
        public Guid UserID { get; set; }
    }
}
