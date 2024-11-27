using O_344_NewsletterSubscription.Implementations;
using O_344_NewsletterSubscription.Interfaces;
using O_344_NewsletterSubscription.Model;

namespace O_344_NewsletterSubscription
{
    internal class SubscriptionService
    {
        private readonly IEmailService _emailService;
        private ISubscriptionRepository _subscriptionRepository;

        public SubscriptionService(
            IEmailService emailService, 
            ISubscriptionRepository subscriptionRepository)
        {
            _subscriptionRepository = subscriptionRepository;
            _emailService = emailService;
        }

        public void Subscribe(string emailAddress, DummyEmailService emailService, SubscriptionFileRepository subscriptionRepo)
        {
            var newUser = new Subscription("New User", emailAddress);
            var email = new Email(newUser.Email, "info@getacademy.no", "Vertifikasjonskode", $"Vertifikasjonskoden er: {newUser.VerificationCode}");
            
            Subscription existingUser = subscriptionRepo.Load(emailAddress);
            if (existingUser == null)
            {
                subscriptionRepo.Save(newUser);
                emailService.Send(email);
                Console.WriteLine(newUser);
            }
            else if (existingUser != null)
            {
                Console.WriteLine($"Email {newUser.Email} is already subscribed.");
            }
        }

        public void Verify(string emailAddress, string verificationCode, DummyEmailService emailService, SubscriptionFileRepository subscriptionRepo)
        {
            Subscription newUser = subscriptionRepo.Load(emailAddress);
            var email = new Email(newUser.Email, "info@getacademy.no", "Subscribed!", "Abonnementet på nyhetsbrev er startet");
            
            if (verificationCode == newUser.VerificationCode)
            {
                    newUser.IsVerified = true;
                    subscriptionRepo.Save(newUser);
                    emailService.Send(email);
                    Console.WriteLine("Exiting, here is new userInfo "+newUser);
                    Environment.Exit(0);
            }
        }
    }
}