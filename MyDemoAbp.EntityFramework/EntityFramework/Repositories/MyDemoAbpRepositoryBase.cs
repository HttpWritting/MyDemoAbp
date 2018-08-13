using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace MyDemoAbp.EntityFramework.Repositories
{
    public abstract class MyDemoAbpRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<MyDemoAbpDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected MyDemoAbpRepositoryBase(IDbContextProvider<MyDemoAbpDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class MyDemoAbpRepositoryBase<TEntity> : MyDemoAbpRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected MyDemoAbpRepositoryBase(IDbContextProvider<MyDemoAbpDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
