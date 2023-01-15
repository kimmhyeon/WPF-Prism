using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace ExampleApp.Modules.LocalizeEnums.ViewModels {
    public class LocalizeEnumsPageViewModel : BindableBase {
        public LocalizeEnumsPageViewModel() {

        }

        private string _comboboxValue = String.Empty;
        public string comboboxValue {
            get { return _comboboxValue; }
            set { SetProperty(ref _comboboxValue, value); }
        }


        private DelegateCommand _CheckValue;
        public DelegateCommand CheckValue =>
            _CheckValue ?? (_CheckValue = new DelegateCommand(ExecuteCheckValue));

        void ExecuteCheckValue() {
            MessageBox.Show(comboboxValue);        
        }
    }
}
