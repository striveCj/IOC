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
using DAL.Attribute;
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
            //AutoFacConfig.Register();
            //实例化一个autofac的创建容器
            var builder = new ContainerBuilder();
            builder.RegisterAssemblyTypes(AppDomain.CurrentDomain.GetAssemblies()).Where(t => t.GetCustomAttribute<IocRegisterAttibute>() != null).AsImplementedInterfaces().InstancePerRequest();
            ////使用Autofac提供的RegisterControllers扩展方法来对程序集中所有的Controller一次性的完成注册
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            var container = builder.Build();
            //下面就是使用MVC的扩展 更改了MVC中的注入方式.
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            //创建autofac管理注册类的容器实例
            //var builder = new ContainerBuilder();
            ////下面就需要为这个容器注册它可以管理的类型
            ////builder的Register方法可以通过多种方式注册类型,之前在控制台程序里面也演示了好几种方式了。
            //builder.RegisterType<People>().As<IPeople>();

            ////builder.RegisterType<DefaultController>().InstancePerDependency();
            ////使用Autofac提供的RegisterControllers扩展方法来对程序集中所有的Controller一次性的完成注册
            //builder.RegisterControllers(Assembly.GetExecutingAssembly());
            ////生成具体的实例
            //var container = builder.Build();
            ////下面就是使用MVC的扩展 更改了MVC中的注入方式.
            //DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
