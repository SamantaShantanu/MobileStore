using MobileStore.BLL.CacheOperations;
using MobileStore.DAL.ResponseCreation;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace MobileStore
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType<ICacheOperations, CacheOperations>();
            container.RegisterType<IResponseCreations, ResponseCreations>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}