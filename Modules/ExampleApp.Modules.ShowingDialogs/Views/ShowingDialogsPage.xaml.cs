using ExampleApp.Modules.ShowingDialogs.ViewModels;
using System.Windows.Controls;

namespace ExampleApp.Modules.ShowingDialogs.Views {
    /// <summary>
    /// Interaction logic for ShowingDialogsPage
    /// </summary>
    public partial class ShowingDialogsPage : UserControl {
        public ShowingDialogsPage() {
            InitializeComponent();

            DialogService.RegisterDialog<Notification, NotificationViewModel>();
        }
    }
}
