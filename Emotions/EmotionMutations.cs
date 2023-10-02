using TextSmiles.API.Data.Entities;
using TextSmiles.API.Data;
using HotChocolate.Subscriptions;

namespace TextSmiles.API.Emotions
{
    [ExtendObjectType("Mutation")]
    public class EmotionMutations
    {
        public async Task<AddEmotionPayload> AddEmotionAsync(
            AddEmotionInput input,
            [Service] ApplicationDbContext context,
            [Service] ITopicEventSender sender)
        {
            var emotion = new Emotion
            {
                Name = input.Name
            };

            context.Emotions.Add(emotion);
            await context.SaveChangesAsync();

            await sender.SendAsync(nameof(Subscription.OnEmotionCreated), emotion);

            return new AddEmotionPayload(emotion);
        }
    }
}
