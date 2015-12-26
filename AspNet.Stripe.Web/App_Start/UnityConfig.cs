using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using AspNet.Stripe.Web.Services.Contracts;
using AspNet.Stripe.Web.Services;

namespace AspNet.Stripe.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            container.RegisterType<IProductService, ProductService>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}