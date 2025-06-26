using System;
using Volo.Abp.EventBus;

namespace SharedModule
{
    /// <summary>
    /// Used to send a text message from App1 to App2.
    /// </summary>
    [EventName("Test.App1ToApp2Text")] //Optional event name
    public class App1ToApp2TextEventData
    {
        //public string TextMessage { get; set; }
        public string Sender { get; set; }
        public string Recipient { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime SentTime { get; set; }



        public App1ToApp2TextEventData(EmailEventData emailData)
        {
            Sender = emailData.Sender;
            Recipient = emailData.Recipient;
            Subject = emailData.Subject;
            Body = emailData.Body;
            SentTime = emailData.SentTime;
        }
    }
}
