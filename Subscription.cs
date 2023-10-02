using TextSmiles.API.Data.Entities;

namespace TextSmiles.API
{
    public class Subscription
    {
        [Subscribe]
        public Smile OnSmileCreated([EventMessage] Smile smile) => smile;

        [Subscribe]
        public Emotion OnEmotionCreated([EventMessage] Emotion emotion) => emotion;

        [Subscribe]
        public User OnUserCreated([EventMessage] User user) => user;
    }
}
