using System;
using System.Threading.Tasks;
using SharedModule;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.EventBus.Distributed;

namespace App2
{
    public class App2EmailEventHandler : IDistributedEventHandler<EmailEventData>, ITransientDependency
    {
        private readonly IRepository<EmailEventDataEntity, Guid> _dbContext;

        public App2EmailEventHandler(IRepository<EmailEventDataEntity, Guid> dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task HandleEventAsync(EmailEventData eventData)
        {
            //Console.WriteLine("Received Email. Saving to database...");

            var emailEntity = new EmailEventDataEntity()
            {
                Sender = eventData.Sender,
                Recipient = eventData.Recipient,
                Subject = eventData.Subject,
                Body = eventData.Body,
                SentTime = DateTime.UtcNow
            };

            await _dbContext.InsertAsync(emailEntity);
            //await _dbContext.Emails.AddAsync(emailEntity);
            //await _dbContext.SaveChangesAsync();

            //Console.WriteLine("Email saved successfully.");
        }
    }
}



//using System;
//using System.Threading.Tasks;
//using SharedModule;
//using Volo.Abp.DependencyInjection;
//using Volo.Abp.EventBus.Distributed;

//namespace App2
//{
//    /// <summary>
//    /// Used to listen for email events sent to App2 by App1.
//    /// </summary>
//    public class App2EmailEventHandler : IDistributedEventHandler<EmailEventData>, ITransientDependency
//    {
//        public async Task HandleEventAsync(EmailEventData eventData)
//        {
//            Console.WriteLine("************************ INCOMING EMAIL ****************************");
//            Console.WriteLine($"Email ID: {eventData.EmailId}");
//            Console.WriteLine($"Sender: {eventData.Sender}");
//            Console.WriteLine($"Recipient: {eventData.Recipient}");
//            Console.WriteLine($"Subject: {eventData.Subject}");
//            Console.WriteLine($"Body: {eventData.Body}");
//            Console.WriteLine($"Sent Time: {eventData.SentTime}");
//            Console.WriteLine("******************************************************************");
//            Console.WriteLine();

//            await Task.CompletedTask; // Simulate async operation if needed
//        }
//    }
//}
