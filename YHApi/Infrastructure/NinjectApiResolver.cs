using Ninject;
using Service.IService;
using Service.ServiceImp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Dependencies;

namespace YHApi.Infrastructure
{
    public class NinjectApiDependencyResolver : System.Web.Http.Dependencies.IDependencyResolver
    {
        private List<IDisposable> disposableServices = new List<IDisposable>();
        public IKernel Kernel { get; private set; }

        public NinjectApiDependencyResolver(NinjectApiDependencyResolver parent)
        {
            this.Kernel = parent.Kernel;
        }
        public NinjectApiDependencyResolver()
        {
            this.Kernel = new StandardKernel();
            Register<IUserManager, UserManager>();
        }

        public void Register<TFrom, TTo>() where TTo : TFrom
        {
            this.Kernel.Bind<TFrom>().To<TTo>();
        }
        public IDependencyScope BeginScope()
        {
            return new NinjectApiDependencyResolver(this);
        }

        public object GetService(Type serviceType)
        {

            var obj = this.Kernel.TryGet(serviceType);
            return obj;

        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            var servies = this.Kernel.GetAll(serviceType);
            foreach (var service in servies)
            {
                this.AddDisposableService(service);
                yield return service;
            }
        }

        public void Dispose()
        {
            foreach (IDisposable disposable in disposableServices)
            {
                disposable.Dispose();
            }
        }

        private void AddDisposableService(object servie)
        {
            IDisposable disposable = servie as IDisposable;
            if (null != disposable && !disposableServices.Contains(disposable))
            {
                disposableServices.Add(disposable);
            }
        }
    }
}