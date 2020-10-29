using System.Linq;
using System.Reflection;
using Autofac;
using Module = Autofac.Module;

namespace Library2
{
    public class WebModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(Assembly.Load(nameof(Library2)))
                .Where(x => x.Namespace != null && x.Namespace.Contains("Infrastructure"))
                .As(x => x.GetInterfaces().FirstOrDefault(t => t.Name == "I" + x.Name));

            base.Load(builder);
        }
    }
}
