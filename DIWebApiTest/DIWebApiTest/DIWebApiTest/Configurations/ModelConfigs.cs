using Autofac;
using DIWebApiTest.Models;

namespace DIWebApiTest.Configurations
{
    public static class ModelConfigs
    {
        public static void Register(ContainerBuilder builder)
        {
            builder.RegisterType<Greeter>().AsImplementedInterfaces().SingleInstance();
            builder.RegisterType<IdProvider>().AsImplementedInterfaces().SingleInstance();
        }
    }
}