﻿using ExampleApp.Modules.LocalizeEnums.Views;
using ExampleApp.Views;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
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
        private String _sSearchKeyword = String.Empty;
        public String sSearchKeyword {
            get { return _sSearchKeyword; }
            set {
                SetProperty(ref _sSearchKeyword, value);

                // 키워드에 따라 메뉴 리스트 변동
                if (value == null || value.Equals(String.Empty))
                    lMenuList = lOriginMenuList;
                else
                    lMenuList = (from name in lOriginMenuList
                                 where name.IndexOf(sSearchKeyword, StringComparison.OrdinalIgnoreCase) >= 0
                                 select name).ToList<String>();
            }
        }

        // 메뉴 리스트 (원본)
        private List<String> _lOriginMenuList = new List<String>();
        public List<String> lOriginMenuList {
            get { return _lOriginMenuList; }
            set { SetProperty(ref _lOriginMenuList, value); }
        }
        // 메뉴 리스트 (유동적 변경)
        private List<String> _lMenuList = new List<String>();
        public List<String> lMenuList {
            get { return _lMenuList; }
            set { SetProperty(ref _lMenuList, value); }
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

            InitMenuList();
        }

        // 페이지 이동 후 메뉴 닫기
        private void ChangePage(String pageName) {
            if (pageName != null) {
                _regionManager.RequestNavigate("ContentRegion", pageName);
                bIsMenuOpen = false;
            }
        }

        private void InitMenuList() {
            lOriginMenuList.Add("Home");
            lOriginMenuList.Add("LocalizeEnumsPage");
            lOriginMenuList.Add("DeleteRowFromGridPage");
            lOriginMenuList.Add("ShowingDialogsPage");

            lMenuList = lOriginMenuList;
        }
    }
}
