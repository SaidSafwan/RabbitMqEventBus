using System;
using System.Threading.Tasks;
using SharedModule;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EventBus.Distributed;

namespace App1;

public class EmployeeHandler
    : IDistributedEventHandler<EmployeeEto>, ITransientDependency
{
    public async Task HandleEventAsync(EmployeeEto eventData)
    {
        Console.WriteLine("************************ INCOMING MESSAGE ****************************");
        Console.WriteLine(eventData.EmpName);
        Console.WriteLine(eventData.Eid);
        Console.WriteLine("**********************************************************************");
        Console.WriteLine();
        await Task.CompletedTask;
    }
}
