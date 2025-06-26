using Volo.Abp.EventBus;

namespace SharedModule
{
    /// <summary>
    /// Used to indicate that App2 has received a text message.
    /// </summary>
    [EventName("Test.App2EmailReceived")] //Optional event name
    public class App2EmailReceivedEventData
    {
        public EmailEventData ReceivedText { get; set; }

        public App2EmailReceivedEventData()
        {

        }

        public App2EmailReceivedEventData(EmailEventData receivedText)
        {
            ReceivedText = receivedText;
        }
    }
}