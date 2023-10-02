using TextSmiles.API.Common;
using TextSmiles.API.Data.Entities;

namespace TextSmiles.API.Emotions
{
    public class EmotionPayloadBase : Payload
    {
        protected EmotionPayloadBase(Emotion emotion)
        {
            Emotion = emotion;
        }

        protected EmotionPayloadBase(IReadOnlyList<UserError> errors)
            : base(errors)
        {
        }

        public Emotion? Emotion { get; }
    }
}
