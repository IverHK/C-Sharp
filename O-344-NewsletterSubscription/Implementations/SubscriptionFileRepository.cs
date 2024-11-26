
using System.Text.Json;
using O_344_NewsletterSubscription.Interfaces;
using O_344_NewsletterSubscription.Model;

namespace O_344_NewsletterSubscription.Implementations
{
    internal class SubscriptionFileRepository : ISubscriptionRepository
    {
        public void Save(Subscription subscription)
        {
            var json = JsonSerializer.Serialize(subscription);
            var filename = subscription.Email + ".json";
            File.WriteAllText(filename, json);
        }

        public Subscription Load(string email)
        {
            var filename = email + ".json";
            var json = File.ReadAllText(filename);
            return JsonSerializer.Deserialize<Subscription>(json);
        }
    }
}