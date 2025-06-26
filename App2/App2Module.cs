using Volo.Abp.Autofac;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.PostgreSql;
using Volo.Abp.EventBus.RabbitMq;
using Volo.Abp.Modularity;

namespace App2
{
    [DependsOn(
        typeof(AbpEventBusRabbitMqModule),
        typeof(AbpAutofacModule),
        typeof(AbpEntityFrameworkCorePostgreSqlModule) // Add PostgreSQL dependency
    )]
    public class App2Module : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpRabbitMqEventBusOptions>(options =>
            {
                options.ClientName = "TestApp2";
                options.ExchangeName = "TestMessages";
            });

            Configure<AbpDbContextOptions>(options =>
            {
                options.UseNpgsql(); // Specify PostgreSQL as the database provider
            });

        }

        //public override void OnPostApplicationInitialization(ApplicationInitializationContext context)
        //{
        //    // Ensure the database is created at runtime
        //    var dbContext = context.ServiceProvider.GetRequiredService<App2DbContext>();
        //    dbContext.Database.EnsureCreated();
        //}
    }
}



//using Volo.Abp.Autofac;
//using Volo.Abp.EntityFrameworkCore;
//using Volo.Abp.EntityFrameworkCore.PostgreSql;

////using Volo.Abp.EntityFrameworkCore;
//using Volo.Abp.EventBus.RabbitMq;
//using Volo.Abp.Modularity;

//namespace App2
//{
//    [DependsOn(
//        typeof(AbpEventBusRabbitMqModule),
//        typeof(AbpAutofacModule),
//        typeof(AbpEntityFrameworkCorePostgreSqlModule) // Add PostgreSQL dependency
//        )]
//    public class App2Module : AbpModule
//    {
//        //public override void ConfigureServices(ServiceConfigurationContext context)
//        //{
//        //    var configuration = context.Services.GetConfiguration();

//        //    Configure<AbpRabbitMqEventBusOptions>(options =>
//        //    {
//        //        options.ClientName = "TestApp2";
//        //        options.ExchangeName = "TestMessages";
//        //    });

//        //    //ConfigureEfCore(context);
//        //}

//        //private void ConfigureEfCore(ServiceConfigurationContext context)
//        //{
//        //    context.Services.AddAbpDbContext<App2DbContext>(options =>
//        //    {
//        //        /* You can remove "includeAllEntities: true" to create
//        //         * default repositories only for aggregate roots
//        //         * Documentation: https://docs.abp.io/en/abp/latest/Entity-Framework-Core#add-default-repositories
//        //         */
//        //        options.AddDefaultRepositories(includeAllEntities: true);
//        //    });

//        //    Configure<AbpDbContextOptions>(options =>
//        //    {
//        //        options.Configure(configurationContext =>
//        //        {
//        //            configurationContext.UseNpgsql();
//        //        });
//        //    });
//        //}


//        public override void ConfigureServices(ServiceConfigurationContext context)
//        {
//            Configure<AbpRabbitMqEventBusOptions>(options =>
//            {
//                options.ClientName = "TestApp2";
//                options.ExchangeName = "TestMessages";
//            });

//            Configure<AbpDbContextOptions>(options =>
//            {
//                options.UseNpgsql(); // Set PostgreSQL as the database provider
//            });
//        }
//    }
//}