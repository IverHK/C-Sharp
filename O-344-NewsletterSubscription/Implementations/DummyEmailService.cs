using O_344_NewsletterSubscription.Interfaces;
using O_344_NewsletterSubscription.Model;

namespace O_344_NewsletterSubscription.Implementations
{
    internal class DummyEmailService : IEmailService
    {
        public void Send(Email email)
        {
            Console.WriteLine(email);
        }
    }
}