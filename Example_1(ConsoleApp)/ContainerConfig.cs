using System.Linq;
using System.Reflection;
using Autofac;
using Library;

namespace Example_1_ConsoleApp_
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Application>().AsSelf();
            //builder.RegisterType<BusinessLogic>().As<IBusinessLogic>();
            builder.RegisterType<BetterBusinessLogic>().As<IBusinessLogic>();

            //Make automatic all RegisterType from the Following Assembly's folder by Reflection
            var assembly = Assembly.Load(nameof(Library));
            builder.RegisterAssemblyTypes(assembly).Where(x => x.Namespace != null && x.Namespace.Contains("Utilities"))
                .As(x => x.GetInterfaces().FirstOrDefault(i => i.Name == "I" + x.Name));

            return builder.Build();
        }
    }
}