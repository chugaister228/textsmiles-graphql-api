using TextSmiles.API.Common;
using TextSmiles.API.Data.Entities;

namespace TextSmiles.API.Emotions
{
    public class AddEmotionPayload : EmotionPayloadBase
    {
        public AddEmotionPayload(Emotion emotion)
            : base(emotion)
        {
        }

        public AddEmotionPayload(IReadOnlyList<UserError> errors)
            : base(errors)
        {
        }
    }
}
