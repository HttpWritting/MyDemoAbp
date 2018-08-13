using System.Linq;
using MyDemoAbp.EntityFramework;
using MyDemoAbp.MultiTenancy;

namespace MyDemoAbp.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly MyDemoAbpDbContext _context;

        public DefaultTenantCreator(MyDemoAbpDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
