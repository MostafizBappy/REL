using System.Web.Mvc;
using BLL.DMS.Repositories;
using Unity;
using Unity.AspNet.Mvc;

namespace Web.DMS
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IEntityRepository, EntityRepository>();
            container.RegisterType<ISalesRepository, SalesRepository>();
            container.RegisterType<ICustomerRepository, CustomerRepository>();
            container.RegisterType<IAccountRepository, AccountRepository>();
            container.RegisterType<IStockRepository, StockRepository>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}