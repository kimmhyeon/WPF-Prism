using ExampleApp.Modules.ShowingDialogs.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ExampleApp.Modules.ShowingDialogs
{

    public interface IDialogService {

        void ShowDialog(String name, Action<String> callback);
        void ShowDialog<ViewModel>(Action<String> callback);
    }



    class DialogService : IDialogService {
   
        static Dictionary<Type, Type> _mappings = new Dictionary<Type, Type>();

        public static void RegisterDialog<TView, TViewModel>() {
            _mappings.Add(typeof(TViewModel), typeof(TView));
        }

        public void ShowDialog(String name, Action<String> callback) {
            var type = Type.GetType($"ExampleApp.Modules.ShowingDialogs.Views.{name}");
            ShowDialogInternal(type, callback, null);
        }

        public void ShowDialog<TViewModel>(Action<string> callback) {
            var type = _mappings[typeof(TViewModel)];
            ShowDialogInternal(type, callback, typeof(TViewModel));
        }

        public void ShowDialogInternal(Type type, Action<String> callback, Type vmType) {

            var dialog = new DialogWindow();

            EventHandler closeEventHandler = null;
            closeEventHandler = (s, e) => {
                callback(dialog.DialogResult.ToString());
                dialog.Closed -= closeEventHandler;
            };
            dialog.Closed += closeEventHandler;
          
            var content = Activator.CreateInstance(type);
            if (vmType != null) {
                var vm = Activator.CreateInstance(vmType);
                (content as FrameworkElement).DataContext = vm;
            }
            

            dialog.Content = Activator.CreateInstance(type);

            dialog.ShowDialog();
        }

        
    }
}
