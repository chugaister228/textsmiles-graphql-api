namespace TextSmiles.API.Data.Entities
{
    public class Emotion
    {
        public Guid ID { get; set; }
        public string? Name { get; set; }
        public List<Smile>? Smiles { get; set; }
    }
}
