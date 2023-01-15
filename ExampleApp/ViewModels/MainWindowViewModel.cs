using ExampleApp.Modules.LocalizeEnums.Views;
using ExampleApp.Views;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Windows.Documents;

namespace ExampleApp.ViewModels {
    public class MainWindowViewModel : BindableBase {

        private readonly IRegionManager _regionManager;

        #region [ Property ]

        // 폼 제목
        private string _title = "Prism Application";
        public string Title {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        // 메뉴 열렸는지 여부
        private Boolean _bIsMenuOpen = false;
        public Boolean bIsMenuOpen {
            get { return _bIsMenuOpen; }
            set { SetProperty(ref _bIsMenuOpen, value); }
        }

        // 검색 키워드
        private String _sSearchKeyword;
        public String sSearchKeyword {
            get { return _sSearchKeyword; }
            set { SetProperty(ref _sSearchKeyword, value); }
        }

        // 선택된 메뉴 아이템
        private String _sSelectedMenuItem = String.Empty;
        public String sSelectedMenuItem {
            get { return _sSelectedMenuItem; }
            set { 
                SetProperty(ref _sSelectedMenuItem, value);
                ChangePage(value);
            }
        }

        #endregion


        public MainWindowViewModel(IRegionManager regionManager) {

            _regionManager = regionManager;
            _regionManager.RegisterViewWithRegion("ContentRegion", typeof(Home));

            _regionManager.RequestNavigate("ContentRegion", "Home");

        }

        private void ChangePage(String pageName) {
            _regionManager.RequestNavigate("ContentRegion", pageName);

            bIsMenuOpen = false;
        }
    }
}
