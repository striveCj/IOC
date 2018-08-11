using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IOCPractice.Core
{
    public class DefaultController:Controller
    {
         public IService Service { get; set; }
    }
}