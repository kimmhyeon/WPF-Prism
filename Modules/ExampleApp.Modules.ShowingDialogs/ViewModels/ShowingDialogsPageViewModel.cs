using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExampleApp.Modules.ShowingDialogs.ViewModels {
    public class ShowingDialogsPageViewModel : BindableBase {

        private DelegateCommand _showDialog;
        public DelegateCommand ShowDialog =>
            _showDialog ?? (_showDialog = new DelegateCommand(ExecuteShowDialog));

        IDialogService _dialogService = new DialogService();

        public ShowingDialogsPageViewModel() {

        }

        void ExecuteShowDialog() {

            //_dialogService.ShowDialog("Notification", result => {
            //    var test = result;
            //});

            _dialogService.ShowDialog<NotificationViewModel>(result => {
                var test = result;
            });
        }
    }
}
