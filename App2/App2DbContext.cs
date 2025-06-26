using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace App2
{
    public class App2DbContext : AbpDbContext<App2DbContext>
    {
        public DbSet<EmailEventDataEntity> Emails { get; set; }

        public App2DbContext(DbContextOptions<App2DbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure the EmailEventDataEntity table
            modelBuilder.Entity<EmailEventDataEntity>(b =>
            {
                b.ToTable("Emails");
                b.HasKey(e => e.Id);
                b.Property(e => e.Sender).IsRequired().HasMaxLength(256);
                b.Property(e => e.Recipient).IsRequired().HasMaxLength(256);
                b.Property(e => e.Subject).HasMaxLength(512);
                b.Property(e => e.Body).HasMaxLength(2048);
                b.Property(e => e.SentTime).IsRequired();
            });
        }
    }
}



//using Microsoft.EntityFrameworkCore;
//using Volo.Abp.EntityFrameworkCore;

//namespace App2
//{
//    public class App2DbContext1 : AbpDbContext<App2DbContext1>
//    {
//        public DbSet<EmailEntity> Emails { get; set; }

//        public App2DbContext1(DbContextOptions<App2DbContext1> options)
//            : base(options)
//        {
//        }


//        protected override void OnModelCreating(ModelBuilder builder)
//        {
//            base.OnModelCreating(builder);

//            /* Include modules to your migration db context */

//            //builder.ConfigurePermissionManagement();
//            //builder.ConfigureSettingManagement();
//            //builder.ConfigureAuditLogging();
//            //builder.ConfigureIdentity();
//            //builder.ConfigureIdentityServer();
//            //builder.ConfigureFeatureManagement();
//            //builder.ConfigureTenantManagement();

//            /* Configure your own entities below */
//        }
//    }
//}
