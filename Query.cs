using Microsoft.Extensions.Hosting;
using TextSmiles.API.Data;
using TextSmiles.API.Data.Entities;
using TextSmiles.API.DataLoader;

namespace TextSmiles.API
{
    public class Query
    {
        public IQueryable<Emotion> GetEmotions([Service] ApplicationDbContext context) =>
            context.Emotions;

        public IQueryable<Smile> GetSmiles([Service] ApplicationDbContext context) =>
            context.Smiles;

        public IQueryable<User> GetUsers([Service] ApplicationDbContext context) =>
        context.Users;

        public async Task<List<Smile>> GetSmilesByEmotionIdAsync(
     [ID(nameof(Smile))] Guid emotionId,
     [Service] SmileByEmotionIdDataloader dataLoader,
     CancellationToken cancellationToken)
        {
            var smilesByEmotions = await dataLoader.LoadAsync(
                emotionId,
                cancellationToken);

            return smilesByEmotions;
        }
    }
}
