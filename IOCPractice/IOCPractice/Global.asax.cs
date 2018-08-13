using Autofac;
using Autofac.Integration.Mvc;
using IOCPractice.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Compilation;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using IOCPractice.Service;

namespace IOCPractice
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            ControllerBuilder.Current.SetControllerFactory(new DefaultController());
            //构造Autofac容器的builder
            var builder = new ContainerBuilder();
            //注册所有的Controller
            builder.RegisterControllers(Assembly.GetEntryAssembly());
            //RegisterType方式
            builder.RegisterType<InjectionTestService>().AsSelf().InstancePerDependency();
            //Register方式
            builder.Register(c => new InjectionTestService()).AsSelf().InstancePerDependency();
            //获取包含继承了IService接口类的程序集
            var assemblies = BuildManager.GetReferencedAssemblies().Cast<Assembly>().Where(assembly =>
                                 assembly.GetTypes().FirstOrDefault(type => type.GetInterfaces().Contains(typeof(IService))) != null);
            //RegisterAssemblyTypes注册程序集
            var enumerable = assemblies as Assembly[] ?? assemblies.ToArray();
            if (enumerable.Any())
            {
                builder.RegisterAssemblyTypes(enumerable).Where(type => type.GetInterfaces().Contains(typeof(IService)))
                    .AsSelf().InstancePerDependency();
            }
        }
    }
}
