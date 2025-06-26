using System;
using Volo.Abp.EventBus;

namespace SharedModule
{
    [EventName("Test.EmailEvent")]
    public class EmailEventData
    {
        public string Sender { get; set; }
        public string Recipient { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime SentTime { get; set; }

        public EmailEventData(string sender, string recipient, string subject, string body)
        {
            Sender = sender;
            Recipient = recipient;
            Subject = subject;
            Body = body;
            SentTime = DateTime.UtcNow;
        }
    }
}
