using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using MyDemoAbp.EntityFramework;

namespace MyDemoAbp
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(MyDemoAbpCoreModule))]
    public class MyDemoAbpDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<MyDemoAbpDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
