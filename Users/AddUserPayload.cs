using TextSmiles.API.Common;
using TextSmiles.API.Data.Entities;

namespace TextSmiles.API.Users
{
    public class AddUserPayload : UserPayloadBase
    {
        public AddUserPayload(User user)
            : base(user)
        {
        }

        public AddUserPayload(IReadOnlyList<UserError> errors)
            : base(errors)
        {
        }
    }
}
