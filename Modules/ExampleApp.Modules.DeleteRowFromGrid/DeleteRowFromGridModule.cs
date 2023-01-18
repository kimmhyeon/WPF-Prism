using ExampleApp.Modules.DeleteRowFromGrid.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System.Globalization;
using System.Threading;

namespace ExampleApp.Modules.DeleteRowFromGrid {
    public class DeleteRowFromGridModule : IModule {

        private readonly IRegionManager _regionManager;

        public DeleteRowFromGridModule(IRegionManager regionManager) {
            _regionManager = regionManager;

        }

        public void OnInitialized(IContainerProvider containerProvider) {
            _regionManager.RegisterViewWithRegion("ContentRegion", typeof(DeleteRowFromGridPage));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry) {

        }
    }
}