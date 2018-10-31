using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace CWapp
{
    public class Program
    {
        static void Main(string[] args)
        {


            //var container = new WindsorContainer();

            ////// Register the CompositionRoot type with the container
            //container.Register(Component.For<ICompositionRoot>().ImplementedBy<CompositionRoot>());

            ////// Resolve an object of type ICompositionRoot (ask the container for an instance)
            ////// This is analagous to calling new() in a non-IoC application.
            //var root = container.Resolve<ICompositionRoot>();

            ////root.LogMessage("Hello from my very first resolved class!");

            BuildWebHost(args).Run();

        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
