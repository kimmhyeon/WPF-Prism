using System.Windows;
using System.Windows.Controls;

namespace ExampleApp.Modules.ShowingDialogs.Views
{
    /// <summary>
    /// Interaction logic for Notification
    /// </summary>
    public partial class Notification : UserControl
    {
        public Notification()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e) {
            var window = this.Parent as Window;
            window.DialogResult = true;
            window.Close();
        }
    }
}
