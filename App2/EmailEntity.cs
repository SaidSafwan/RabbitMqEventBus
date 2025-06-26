using System;
using Volo.Abp.Domain.Entities;

namespace App2
{
    public class EmailEntity : Entity<Guid>
    {
        public Guid EmailId { get; set; }
        public string Sender { get; set; }
        public string Recipient { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime SentTime { get; set; }
    }
}
