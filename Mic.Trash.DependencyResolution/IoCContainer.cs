using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Mic.Trash.Business;
using Mic.Trash.BusinessInterfaces;
using Mic.Trash.Data;
using Mic.Trash.RepositoryInterfaces;

namespace Mic.Trash.DependencyResolution
{
    public static class IoCContainer
    {

        public static ContainerBuilder GetBuilder()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ArticleRepository>().As<IArticleRepository>();
            builder.RegisterType<ArticleManager>().As<IArticleManager>();
            builder.RegisterType<ApplicationUserRepository>().As<IApplicationUserRepository>();
            builder.RegisterType<TrashDataContext>().As<ITrashDataContext>();
            return builder;
        }

    }
}
