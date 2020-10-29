using System;
using Autofac;
using Library;

namespace Example_1_ConsoleApp_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var container = ContainerConfig.Configure();

            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<Application>();
                app.Run();
            }

            Console.ReadKey(true);
        }
    }
}
