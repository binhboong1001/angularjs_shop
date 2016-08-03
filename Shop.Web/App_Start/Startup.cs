using Microsoft.Owin;
using Owin;
using Autofac;
using System.Reflection;
using Shop.Data.Infrastructure;
using Shop.Data;
using Shop.Data.Repositories;
using Shop.Service;
using System.Web.Mvc;
using Autofac.Integration.Mvc;
using System.Web.Http;
using Autofac.Integration.WebApi;

[assembly: OwinStartup(typeof(Shop.Web.App_Start.Startup))]

namespace Shop.Web.App_Start
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
            ConfigAutoFac(app);
            ConfigureAuth(app);
        }
        private void ConfigAutoFac(IAppBuilder app)
        {
            var builder = new ContainerBuilder();
            //config for controller
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            //config for controller api
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            //config for interface
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();
            builder.RegisterType<DbFactory>().As<IDbFactory>().InstancePerRequest();

            //config for dbcontext
            builder.RegisterType<ShopDbContext>().AsSelf().InstancePerRequest();

            #region PostCategoryRepository
            builder.RegisterAssemblyTypes(typeof(PostCategoryRepository).Assembly)
                .Where(t => t.Name.EndsWith("Repository"))
                .AsImplementedInterfaces().InstancePerRequest();
            builder.RegisterAssemblyTypes(typeof(PostCategoryService).Assembly)
               .Where(t => t.Name.EndsWith("Service"))
               .AsImplementedInterfaces().InstancePerRequest();
            #endregion
            #region Error
            builder.RegisterAssemblyTypes(typeof(ErrorRepository).Assembly)
                .Where(t => t.Name.EndsWith("Repository"))
                .AsImplementedInterfaces().InstancePerRequest();
            builder.RegisterAssemblyTypes(typeof(ErrorService).Assembly)
               .Where(t => t.Name.EndsWith("Service"))
               .AsImplementedInterfaces().InstancePerRequest();
            #endregion
            #region Footer
            //builder.RegisterAssemblyTypes(typeof(FooterRepository).Assembly)
            //    .Where(t => t.Name.EndsWith("Repository"))
            //    .AsImplementedInterfaces().InstancePerRequest();
            //builder.RegisterAssemblyTypes(typeof(FooterService).Assembly)
            //   .Where(t => t.Name.EndsWith("Service"))
            //   .AsImplementedInterfaces().InstancePerRequest();
            //#endregion
            //#region Footer
            //builder.RegisterAssemblyTypes(typeof(FooterRepository).Assembly)
            //    .Where(t => t.Name.EndsWith("Repository"))
            //    .AsImplementedInterfaces().InstancePerRequest();
            //builder.RegisterAssemblyTypes(typeof(FooterService).Assembly)
            //   .Where(t => t.Name.EndsWith("Service"))
            //   .AsImplementedInterfaces().InstancePerRequest();
            #endregion
            #region Post
            builder.RegisterAssemblyTypes(typeof(PostRepository).Assembly)
                .Where(t => t.Name.EndsWith("Repository"))
                .AsImplementedInterfaces().InstancePerRequest();
            builder.RegisterAssemblyTypes(typeof(PostService).Assembly)
               .Where(t => t.Name.EndsWith("Service"))
               .AsImplementedInterfaces().InstancePerRequest();
            #endregion

            // gán giá tri vừa cấu hình vào trong thùng chứa cùa autofac
            Autofac.IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            //config for api denpendency injection
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver((IContainer)container);
        }
    }
}
