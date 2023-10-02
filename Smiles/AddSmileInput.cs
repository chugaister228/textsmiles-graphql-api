namespace TextSmiles.API.Smiles
{
    public record AddSmileInput(

        string? Name,
        string? Text,
        Guid EmotionID,
        Guid UserID

    );
}
