using System;
using Volo.Abp.EventBus;

namespace SharedModule
{
    [EventName("employee")]
    public class EmployeeEto
    {
        public string EmpName { get; set; }
        public Guid Eid { get; set; }
    }
}
