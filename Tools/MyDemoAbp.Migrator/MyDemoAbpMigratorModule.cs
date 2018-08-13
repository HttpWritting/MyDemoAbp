using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using MyDemoAbp.EntityFramework;

namespace MyDemoAbp.Migrator
{
    [DependsOn(typeof(MyDemoAbpDataModule))]
    public class MyDemoAbpMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<MyDemoAbpDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}