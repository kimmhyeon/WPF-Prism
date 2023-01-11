using ExampleApp.Modules.LocalizeEnums.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace ExampleApp.Modules.LocalizeEnums {
    public class LocalizeEnumsModule : IModule {

        private readonly IRegionManager _regionManager;

        public LocalizeEnumsModule(IRegionManager regionManager) {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider) {
            _regionManager.RegisterViewWithRegion("ContentRegion", typeof(LocalizeEnumsPage));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry) {

        }
    }
}