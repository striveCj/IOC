using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac.Core;
using AutofacService;

namespace AutoFacConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AutofacIOC.Container.Init();//初始化容器，将需要的组件添加到容器中
            PrintStudentName(10001);

            Console.ReadKey();

        }
        /// <summary>
        /// 输出学生姓名
        /// </summary>
        /// <param name="id"></param>

        public static void PrintStudentName(long id)
        {
            IStudentService stuService = AutofacIOC.Container.Instance.Resolve<IStudentService>();
            string name = stuService.GetStuName(id);
            Console.WriteLine(name);
        }
    }
}
