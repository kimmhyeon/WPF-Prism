using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleApp.Modules.DeleteRowFromGrid.Models {
    public class TestDataModel : BindableBase {

        private String _idx;
        public String idx {
            get { return _idx; }
            set { SetProperty(ref _idx, value); }
        }

        private String _name;
        public String name {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        private String _content;
        public String content {
            get { return _content; }
            set { SetProperty(ref _content, value); }
        }

        private DateTime _date;
        public DateTime date {
            get { return _date; }
            set { SetProperty(ref _date, value); }
        }

    }
}
