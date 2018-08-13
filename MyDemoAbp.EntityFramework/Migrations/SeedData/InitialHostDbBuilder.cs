using MyDemoAbp.EntityFramework;
using EntityFramework.DynamicFilters;

namespace MyDemoAbp.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly MyDemoAbpDbContext _context;

        public InitialHostDbBuilder(MyDemoAbpDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
