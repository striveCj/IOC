using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IOCPractice.Core;
using System.Web.Mvc;

namespace IOCPractice.Service
{
    public class DogService:IAnimal,IRun
    {
        public IEnumerable<IRun> Runs { get; set; }
        private readonly IService _service;
        public DogService()
        {
            _service= DependencyResolver.Current.GetService<IService>();
        }
        public void Run()
        {
            Console.WriteLine("小狗在跑");
        }

        public void Shout()
        {
            foreach (var run in Runs)
            {
                run.Run();
            }
            Console.WriteLine("汪汪汪");
        }
    }
}