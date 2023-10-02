using TextSmiles.API.Common;
using TextSmiles.API.Data.Entities;

namespace TextSmiles.API.Smiles
{
    public class SmilePayloadBase : Payload
    {
        protected SmilePayloadBase(Smile smile)
        {
            Smile = smile;
        }

        protected SmilePayloadBase(IReadOnlyList<UserError> errors)
            : base(errors)
        {
        }

        public Smile? Smile { get; }
    }
}
