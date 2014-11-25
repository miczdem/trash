using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Mic.Trash.Business;
using Mic.Trash.BusinessInterfaces;
using Mic.Trash.Data;
using Mic.Trash.RepositoryInterfaces;
using SSW.Data.EF;
using SSW.Data.Interfaces;

namespace Mic.Trash.DependencyResolution
{
    public static class IoCContainer
    {

        public static ContainerBuilder GetBuilder()
        {
            var builder = new ContainerBuilder();

            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            
            builder.RegisterType<DropCreateDatabaseIfModelChanges<TrashDataContext>>().As<IDatabaseInitializer<TrashDataContext>>();
            builder.RegisterType<DbContextFactory<TrashDataContext>>().As<IDbContextFactory<TrashDataContext>>().WithParameter("connectionString", connectionString);
            builder.RegisterType<DbContextManager<TrashDataContext>>().As<IDbContextManager<TrashDataContext>>();
            builder.RegisterType<DbContextManager<TrashDataContext>>().As<IDbContextManager>().InstancePerLifetimeScope();
            
            builder.RegisterType<ArticleRepository>().As<IArticleRepository>();
            builder.RegisterType<ArticleManager>().As<IArticleManager>();
            builder.RegisterType<ApplicationUserRepository>().As<IApplicationUserRepository>();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();
            
            return builder;
        }

    }
}
