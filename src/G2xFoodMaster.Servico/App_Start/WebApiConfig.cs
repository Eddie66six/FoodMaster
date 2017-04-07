using System.Web.Http;
using G2xFoodMaster.Infra.Cross_Cutting.Ioc;
using SimpleInjector.Integration.WebApi;

namespace G2xFoodMaster.Servico
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(SimpleInjectContainer.RegistrarServicos());

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
