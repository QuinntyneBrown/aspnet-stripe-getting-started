using AspNet.Stripe.Web.Models;
using AspNet.Stripe.Web.Services.Contracts;
using System.Configuration;

namespace AspNet.Stripe.Web.Services
{
    public class ProductService: IProductService
    {
        public ProductViewModel Get()
        {
            var viewModel = new ProductViewModel();
            viewModel.StripePublishableKey = ConfigurationManager.AppSettings["stripePublishableKey"];
            return viewModel;
        }
    }
}