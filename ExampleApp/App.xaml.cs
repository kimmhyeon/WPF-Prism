using ExampleApp.Modules.DeleteRowFromGrid;
using ExampleApp.Modules.LocalizeEnums;
using ExampleApp.Modules.ShowingDialogs;
using ExampleApp.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System.Globalization;
using System.Threading;
using System.Windows;

namespace ExampleApp {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App {

        protected override Window CreateShell() {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry) {

        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog) {
            moduleCatalog.AddModule<LocalizeEnumsModule>();
            moduleCatalog.AddModule<DeleteRowFromGridModule>();
            moduleCatalog.AddModule<ShowingDialogsModule>();
        }

    }
}
