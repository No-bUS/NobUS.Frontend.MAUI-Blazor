using Autofac;
using Autofac.Extras.CommonServiceLocator;
using NobUS.DataContract.Model.Entity;
using NobUS.DataContract.Reader.OfficialAPI;
using NobUS.Frontend.MAUI_Blazor.Façade;
using NobUS.Frontend.MAUI_Blazor.Repository;

namespace NobUS.Frontend.MAUI_Blazor
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();

            var autofacContainerBuilder = new ContainerBuilder();
            autofacContainerBuilder.RegisterType<CongestedClient>().As<IClient>().SingleInstance();
            autofacContainerBuilder.RegisterType<StaticRepository<Station>>().As<IRepository<Station>>().SingleInstance();
            autofacContainerBuilder.RegisterType<StaticRepository<Route>>().As<IRepository<Route>>().SingleInstance();
            autofacContainerBuilder.RegisterType<DummyFaçade>().As<IFaçade>().SingleInstance();

            var container = autofacContainerBuilder.Build();
            CommonServiceLocator.ServiceLocator.SetLocatorProvider(() => new AutofacServiceLocator(container));
        }
    }
}