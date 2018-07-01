using Autofac;
using XamarinAutofac.XApp.Business.ViewModel;

namespace XamarinAutofac.XApp.Business.Cqrs
{
    /// <summary>
    /// Startup configuration.
    /// </summary>
    public class StartupConfiguration
    {
        /// <summary>
        /// StructureMap Container.
        /// </summary>
        private readonly IContainer container;

        /// <summary>
        /// Consutructor.
        /// </summary>
        public StartupConfiguration()
        {
            // Initialiaze container builder.
            var containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterType<SampleViewModel>().As<ISampleViewModel>();

            // Build container.
            container = containerBuilder.Build();
        }
    }
}
