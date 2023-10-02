using TextSmiles.API.Common;
using TextSmiles.API.Data.Entities;

namespace TextSmiles.API.Users
{
    public class UserPayloadBase : Payload
    {
        protected UserPayloadBase(User user)
        {
            User = user;
        }

        protected UserPayloadBase(IReadOnlyList<UserError> errors)
            : base(errors)
        {
        }

        public User? User { get; }
    }
}
