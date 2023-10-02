using TextSmiles.API.Data.Entities;
using TextSmiles.API.Data;
using HotChocolate.Subscriptions;

namespace TextSmiles.API.Users
{
    [ExtendObjectType("Mutation")]
    public class UserMutations
    {
        public async Task<AddUserPayload> AddUserAsync(
            AddUserInput input,
            [Service] ApplicationDbContext context,
            [Service] ITopicEventSender sender)
        {
            var user = new User
            {
                Username = input.Username
            };

            context.Users.Add(user);
            await context.SaveChangesAsync();

            await sender.SendAsync(nameof(Subscription.OnUserCreated), user);

            return new AddUserPayload(user);
        }
    }
}
