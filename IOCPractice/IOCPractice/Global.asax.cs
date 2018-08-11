using Autofac;
using Autofac.Integration.Mvc;
using IOCPractice.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

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
            //构造Autofac容器的builder
            var builder = new ContainerBuilder();
            //注入控制器
            builder.RegisterControllers(typeof(MvcApplication).Assembly).PropertiesAutowired();
            //把程序集数组assemblies中所有非抽象的类型注入
            Assembly[] assemblies = new Assembly[] { Assembly.Load("Service") };
            //builder.RegisterAssemblyTypes(assemblies).AsImplementedInterfaces().PropertiesAutowired();
            //IContainer container = builder.Build();
            //IAnimal animal = container.Resolve<IAnimal>();
            //animal.Shout();
            builder.RegisterAssemblyTypes(assemblies).Where(t=>!t.IsAbstract).AsImplementedInterfaces().PropertiesAutowired();
            //注入特性
            builder.RegisterFilterProvider();
            //注入ActionFilter
            builder.RegisterAssemblyTypes(typeof(MvcApplication).Assembly).Where(t => typeof(ActionFilterAttribute).IsAssignableFrom(t) && !t.IsAbstract).PropertiesAutowired();
            //创建容器
            IContainer container = builder.Build();
            //提供给MVC，这样当MVC创建Controller等对象时都是从Autofac获取
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }
    }
}
