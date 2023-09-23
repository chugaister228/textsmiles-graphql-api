namespace TextSmiles.API.Data.Entities
{
    public class User
    {
        public Guid ID { get; set; }
        public string? Username { get; set; }
        public List<Smile>? Smiles { get; set; }
    }
}
