using System;
using System.Threading.Tasks;
using SharedModule;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EventBus.Distributed;

namespace App1
{
    public class App1MessagingService : ITransientDependency
    {
        private readonly IDistributedEventBus _distributedEventBus;

        public App1MessagingService(IDistributedEventBus distributedEventBus)
        {
            _distributedEventBus = distributedEventBus;
        }

        //public async Task RunAsync()
        //{
        //    Console.WriteLine("*** Started the APPLICATION 1 ***");
        //    Console.WriteLine("Write a message and press ENTER to send to the App2.");
        //    Console.WriteLine("Press ENTER (without writing a message) to stop the application.");

        //    string message;
        //    do
        //    {
        //        Console.WriteLine();

        //        message = Console.ReadLine();

        //        if (!message.IsNullOrEmpty())
        //        {
        //            await _distributedEventBus.PublishAsync(new App1ToApp2TextEventData(message));
        //        }
        //        else
        //        {
        //            await _distributedEventBus.PublishAsync(new App1ToApp2TextEventData("App1 is exiting. Bye bye...!"));
        //        }

        //    } while (!message.IsNullOrEmpty());
        //}

        public async Task RunAsync()
        {
            Console.WriteLine("*** Started the APPLICATION 1 ***");
            Console.WriteLine("Enter the number of emails to send:");

            if (int.TryParse(Console.ReadLine(), out var emailCount) && emailCount > 0)
            {
                await SendEmailsAsync(emailCount);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number of emails.");
            }

            Console.WriteLine("Exiting application.");
        }

        private async Task SendEmailsAsync(int count)
        {
            var random = new Random();
            var emailDomains = new[] { "example.com", "test.com", "demo.com" };

            for (int i = 0; i < count; i++)
            {
                var email = new EmailEventData(
                    sender: $"user{random.Next(1, 100)}@{emailDomains[random.Next(emailDomains.Length)]}",
                    recipient: $"recipient{random.Next(1, 100)}@{emailDomains[random.Next(emailDomains.Length)]}",
                    subject: $"Subject {i + 1}",
                    body: $"This is a randomly generated email body for email {i + 1}."
                );

                await _distributedEventBus.PublishAsync(email);
                Console.WriteLine($"Email {i + 1} sent: {email.Subject} -> {email.Recipient}");
            }
        }

    }
}