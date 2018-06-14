using Cape_Senior_Center_Inventory_System.Implementations;
using Cape_Senior_Center_Inventory_System.Interfaces;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace Cape_Senior_Center_Inventory_System
{
    public class WindsorConfiguration : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Castle.MicroKernel.Registration.Component.For<IController>().ImplementedBy<Controller>());
            container.Register(Castle.MicroKernel.Registration.Component.For<IInventoryService>().ImplementedBy<InventoryService>());

            container.Register(Castle.MicroKernel.Registration.Component.For<IUnitOfWork>()
                        .ImplementedBy<UnitOfWork>()
                        .DependsOn(Dependency.OnValue("DataContext", new DataContext.DataContext())));

            container.Register(Castle.MicroKernel.Registration.Component.For<ICategoryRepository>()
                .ImplementedBy<CategoryRepository>());

            container.Register(Castle.MicroKernel.Registration.Component.For<IInventoryRepository>()
                    .ImplementedBy<InventoryRepository>());
        }
    }
}