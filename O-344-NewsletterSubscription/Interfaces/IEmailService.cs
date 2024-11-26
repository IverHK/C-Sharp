using O_344_NewsletterSubscription.Model;


namespace O_344_NewsletterSubscription.Interfaces


{
    internal interface IEmailService
    {
        void Send(Email email);
    }
}