using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Autofac.Integration.Mvc;

namespace IOCPractice.Core
{
    public class DefaultController:DefaultControllerFactory
    {
        //protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        //{
        //       //return controllerType == null
        //       // ? base.GetControllerInstance(requestContext, controllerType)
        //       // : AutofacDependencyResolver.Resolve<IController>(controllerType);
        //}
    }
}