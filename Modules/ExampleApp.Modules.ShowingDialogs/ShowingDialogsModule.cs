using ExampleApp.Modules.ShowingDialogs.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System.Globalization;
using System.Threading;

namespace ExampleApp.Modules.ShowingDialogs {
    public class ShowingDialogsModule : IModule {

        private readonly IRegionManager _regionManager;

        public ShowingDialogsModule(IRegionManager regionManager) {
            _regionManager = regionManager;

        }

        public void OnInitialized(IContainerProvider containerProvider) {
            _regionManager.RegisterViewWithRegion("ContentRegion", typeof(ShowingDialogsPage));

        }

        public void RegisterTypes(IContainerRegistry containerRegistry) {

        }
    }
}