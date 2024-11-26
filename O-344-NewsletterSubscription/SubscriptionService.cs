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

        public void Subscribe(string emailAddress)
        {
            var newUser = new Subscription("New User", emailAddress);
            var subscriptionRepo = new SubscriptionFileRepository();
            var emailService = new DummyEmailService();
            var email = new Email(newUser.Email, "info@getacademy.no", "Vertifikasjonskode", $"Vertifikasjonskoden er: {newUser.VerificationCode}");

            Subscription existingUser = null;
            
            
            try
            {
                existingUser = subscriptionRepo.Load(emailAddress);
                if (existingUser != null && existingUser.Email == newUser.Email)
                {
                    Console.WriteLine($"Email {newUser.Email} is already subscribed.");
                    return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading user: {ex.Message}");
            }
            
            subscriptionRepo.Save(newUser);
            emailService.Send(email);
            Console.WriteLine(newUser);
        }

        public void Verify(string emailAddress, string verificationCode)
        {
            var newUser = new Subscription("New User", emailAddress);
            var subscriptionRepo = new SubscriptionFileRepository();
            var emailService = new DummyEmailService();
            var email = new Email(newUser.Email, "info@getacademy.no", "Subscribed!", "Abonnementet på nyhetsbrev er startet");

            newUser = subscriptionRepo.Load(emailAddress);
            
            
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