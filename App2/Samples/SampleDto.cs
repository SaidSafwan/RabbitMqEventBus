using System;

namespace App2.Samples
{
    public class SampleDto
    : EntityDto<Guid>
    {
        public string Name { get; set; }
        public string Email { get; set; }

    }
}
