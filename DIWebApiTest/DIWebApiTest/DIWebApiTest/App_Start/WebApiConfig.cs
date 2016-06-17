using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using System.Reflection;
using DIWebApiTest.Configurations;

namespace DIWebApiTest
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            RegisterComponents(config);

            config.Formatters.Remove(config.Formatters.XmlFormatter);

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }

        private static void RegisterComponents(HttpConfiguration config)
        {
            var builder = new ContainerBuilder();

            ModelConfigs.Register(builder);

            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            var container = builder.Build();

            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}
