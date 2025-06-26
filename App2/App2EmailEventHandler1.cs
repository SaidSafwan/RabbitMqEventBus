//using System;
//using System.Threading.Tasks;
//using SharedModule;
//using Volo.Abp.DependencyInjection;
//using Volo.Abp.EventBus.Distributed;

//namespace App2
//{
//    public class App2EmailEventHandler1 : IDistributedEventHandler<EmailEventData>, ITransientDependency
//    {
//        //private readonly IRepository<EmailEntity, Guid> _emailRepository;
//        //private readonly ILogger<App2EmailEventHandler> _logger;

//        public App2EmailEventHandler1(
//            //ILogger<App2EmailEventHandler> logger,
//            //IRepository<EmailEntity, Guid> emailRepository)
//            )
//        {
//            // _emailRepository = emailRepository;
//            //_logger = logger;
//        }

//        public async Task HandleEventAsync(EmailEventData eventData)
//        {
//            try
//            {
//                Console.WriteLine($"Processing email: {eventData.Subject}");

//                //var email = new EmailEntity
//                //{

//                //    EmailId = eventData.EmailId,
//                //    Sender = eventData.Sender,
//                //    Recipient = eventData.Recipient,
//                //    Subject = eventData.Subject,
//                //    Body = eventData.Body,
//                //    SentTime = eventData.SentTime
//                //};

//                //await _emailRepository.InsertAsync(email);
//            }
//            catch (Exception ex)
//            {
//                //_logger.LogError(ex.Message);
//            }
//        }
//    }
//}
