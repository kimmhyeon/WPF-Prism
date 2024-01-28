using ExampleApp.Modules.DeleteRowFromGrid.Models;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace ExampleApp.Modules.DeleteRowFromGrid.ViewModels {

    public class DeleteRowFromGridPageViewModel : BindableBase {

        // [ Property ]
        private ObservableCollection<TestDataModel> _testDataModel;
        public ObservableCollection<TestDataModel> testDataModel {
            get { return _testDataModel; } 
            set { SetProperty(ref _testDataModel, value); }  
        }
        int idx = 0;


        // Command
        private DelegateCommand<TestDataModel> _deleteCommand;
        public DelegateCommand<TestDataModel> DeleteCommand =>
            _deleteCommand ?? (_deleteCommand = new DelegateCommand<TestDataModel>(ExecuteDeleteCommand));

        void ExecuteDeleteCommand(TestDataModel parameter) {
            testDataModel.Remove(parameter);
        }

        private DelegateCommand _addNewLine;
        public DelegateCommand AddNewLine =>
            _addNewLine ?? (_addNewLine = new DelegateCommand(Execute_AddNewLine));

        void Execute_AddNewLine() {
            testDataModel.Add(new TestDataModel() {
                idx = (++this.idx).ToString()
                , name = "Name..." + this.idx
                , content = "This is New Line..." + this.idx
                , date = DateTime.Now
            });
            ;
        }

        // init
        public DeleteRowFromGridPageViewModel() {
            testDataModel = new ObservableCollection<TestDataModel>(InitData());
        }

        // Input Test Data
        private List<TestDataModel> InitData() {
            List<TestDataModel> testData = new List<TestDataModel>();

            for (int i=0; i<25; i++) {
                var data = new TestDataModel() {
                    idx = (++this.idx).ToString()
                    , name = "Name..." + this.idx
                    , content = "This is Content..." + this.idx
                    , date = DateTime.Now.AddDays(this.idx)
                };

                testData.Add(data);
            }

            return testData;
        }
    }
}
