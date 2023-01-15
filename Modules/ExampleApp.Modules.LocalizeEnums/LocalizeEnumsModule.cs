using ExampleApp.Modules.LocalizeEnums.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System.Globalization;
using System.Threading;

namespace ExampleApp.Modules.LocalizeEnums {
    public class LocalizeEnumsModule : IModule {

        private readonly IRegionManager _regionManager;

        public LocalizeEnumsModule(IRegionManager regionManager) {
            _regionManager = regionManager;

            // Localize Enums
            CultureInfo culture = new CultureInfo("ko-KR");
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
        }

        public void OnInitialized(IContainerProvider containerProvider) {
            _regionManager.RegisterViewWithRegion("ContentRegion", typeof(LocalizeEnumsPage));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry) {

        }

    }
}