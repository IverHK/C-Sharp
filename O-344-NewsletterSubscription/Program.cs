using O_344_NewsletterSubscription;
using O_344_NewsletterSubscription.Implementations;
using O_344_NewsletterSubscription.Model;

namespace O_344_NewsletterSubscription;

class Program
{
    static void Main(string[] args)
    {
        var emailService = new DummyEmailService();
        var subscriptionRepo = new SubscriptionFileRepository();
        var subscriptionService = new SubscriptionService(emailService, subscriptionRepo);

        while (true)
        {
            Console.Write("Meny:\n1: Melde på nyhetsbrev\n2: Verifisere\n");
            var choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.Write("Skriv inn epostadresse: ");
                var emailAddress = Console.ReadLine();
                subscriptionService.Subscribe(emailAddress, emailService, subscriptionRepo);
            }
            else if (choice == "2")
            {
                Console.Write("Skriv inn epostadresse: ");
                var emailAddress = Console.ReadLine();
                Console.Write("Skriv inn verifikasjonskode: ");
                var code = Console.ReadLine();
                subscriptionService.Verify(emailAddress, code, emailService, subscriptionRepo);
            }
        }
    }
}