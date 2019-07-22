using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using AutofacRepository.IRepository;
using AutofacRepository.Repository;
using AutofacService;
using AutofacService.Service;

namespace AutofacIOC
{
    public  class Container
    {
        /// <summary>
        /// 单例容器
        /// </summary>
        public static IContainer Instance;
        /// <summary>
        /// 初始化容器
        /// </summary>
        public static void Init()
        {
            //新建容器构造器，用于注册组件和服务
            var builder=new ContainerBuilder();
            //自定义注册
            MyBuild(builder);
            //利用构建器创建容器
            Instance = builder.Build();

        }
        /// <summary>
        /// 自定义注册
        /// </summary>
        /// <param name="builder"></param>

        public static void MyBuild(ContainerBuilder builder)
        {
            builder.RegisterType<StudentRepository>().As<IStudentRepository>();
            builder.RegisterType<StudentService>().As<IStudentService>();
        }

    }
}
