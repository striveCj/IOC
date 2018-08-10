using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IOCPractice.Core;

namespace IOCPractice.Service
{
    public class StudentService: IRun
    {
        public void Run()
        {
            Console.WriteLine("学生在跑");
        }
    }
}