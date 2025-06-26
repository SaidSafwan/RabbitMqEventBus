using System;
using Volo.Abp.Domain.Entities;

namespace App2.Entities.Samples
{
    public class Sample : Entity<Guid>
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public Sample()
        {
            Id = Guid.NewGuid();
        }
    }
}
