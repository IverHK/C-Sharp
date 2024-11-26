using O_344_NewsletterSubscription.Model;

namespace O_344_NewsletterSubscription.Interfaces

{
    internal interface ISubscriptionRepository
    {
        void Save(Subscription subscription);
        Subscription Load(string email);
    }
}