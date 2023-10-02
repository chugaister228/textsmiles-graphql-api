using TextSmiles.API.Data.Entities;
using TextSmiles.API.Data;
using HotChocolate.Subscriptions;

namespace TextSmiles.API.Smiles
{
    [ExtendObjectType("Mutation")]
    public class SmileMutations
    {
        public async Task<AddSmilePayload> AddSmileAsync(
            AddSmileInput input,
            [Service] ApplicationDbContext context,
            [Service] ITopicEventSender sender)
        {
            var smile = new Smile
            {
                Name = input.Name,
                Text = input.Text,
                EmotionID = input.EmotionID,
                UserID = input.UserID
            };

            context.Smiles.Add(smile);
            await context.SaveChangesAsync();

            await sender.SendAsync(nameof(Subscription.OnSmileCreated), smile);

            return new AddSmilePayload(smile);
        }
    }
}
