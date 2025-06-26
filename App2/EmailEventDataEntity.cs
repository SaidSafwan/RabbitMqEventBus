using System;
using Volo.Abp.Domain.Entities;

namespace App2
{
    public class EmailEventDataEntity : Entity<Guid>
    {
        public string Sender { get; set; }
        public string Recipient { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime SentTime { get; set; }
    }
}
