using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IOCPractice.Core;

namespace IOCPractice.Service
{
    public class InjectionTestService:IService
    {
        public string Success()
        {
            return "Success";
        }
    }
}