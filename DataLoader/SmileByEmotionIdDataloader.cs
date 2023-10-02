using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Hosting;
using TextSmiles.API.Data;
using TextSmiles.API.Data.Entities;

namespace TextSmiles.API.DataLoader
{
    public class SmileByEmotionIdDataloader : BatchDataLoader<Guid, List<Smile>>
    {
        private readonly ApplicationDbContext _dbContext;

        public SmileByEmotionIdDataloader(
            IBatchScheduler batchScheduler,
            ApplicationDbContext dbContext)
            : base(batchScheduler)
        {
            _dbContext = dbContext ??
                throw new ArgumentNullException(nameof(dbContext));
        }

        protected override async Task<IReadOnlyDictionary<Guid, List<Smile>>> LoadBatchAsync(
            IReadOnlyList<Guid> keys,
            CancellationToken cancellationToken)
        {
            var smilesByEmotion = await _dbContext.Smiles
                .Where(smile => keys.Contains(smile.EmotionID))
                .GroupBy(smile => smile.EmotionID)
                .ToDictionaryAsync(
                    group => group.Key,
                    group => group.ToList(),
                    cancellationToken);

            return smilesByEmotion;
        }
    }
}