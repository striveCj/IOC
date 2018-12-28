using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IOCPractice.Core;

namespace IOCPractice.Service
{
    public class People:IPeople
    {
        public string Run()
        {
            return "成功";
        }
    }
}