using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject.Syntax;
using System.Web.Http.Dependencies;
using Ninject.Activation;
using Ninject.Parameters;
using Ninject;

namespace BenedictWebApi.App_Start
{
    /// <summary>
    /// Added to support Asp.net web api
    /// http://www.strathweb.com/2012/05/using-ninject-with-the-latest-asp-net-web-api-source/
    /// </summary>
    public class NinjectResolver : NinjectScope, IDependencyResolver
    {
        private IKernel _kernel;

        public NinjectResolver(IKernel kernel)
            : base(kernel)
        {
            _kernel = kernel;
        }

        public IDependencyScope BeginScope()
        {
            return new NinjectScope(_kernel.BeginBlock());
        }
    }
}