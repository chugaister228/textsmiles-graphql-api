using TextSmiles.API.Common;
using TextSmiles.API.Data.Entities;

namespace TextSmiles.API.Smiles
{
    public class AddSmilePayload : SmilePayloadBase
    {
        public AddSmilePayload(Smile smile)
            : base(smile)
        {
        }

        public AddSmilePayload(IReadOnlyList<UserError> errors)
            : base(errors)
        {
        }
    }
}
