﻿using System.ComponentModel;
using System.Diagnostics;

namespace MA14;

public partial class MainPage : ContentPage
{
    int count = 0;
    MainPageViewModel mainPageViewModel = new MainPageViewModel();
    public MainPage()
    {
        InitializeComponent();
        BindingContext = mainPageViewModel;

        UserNameEntry.PropertyChanged += UserNameEntry_PropertyChanged;
        AgeEntry.PropertyChanged += (s, e) =>
        {
            Debug.WriteLine($"[View] Age Entry 的 Text 屬性已經有變動 (PropertyChanged) : {e.PropertyName}");
        };
        //UserNameEntry.PropertyChanging += UserNameEntry_PropertyChanging;
        mainPageViewModel.PropertyChanged += (s, e) =>
        {
            Debug.WriteLine($"訂閱 [ViewModel] 的 PropertyChanged 事件被觸發 : {e.PropertyName}");
        };
    }

    private void UserNameEntry_PropertyChanging(object sender, Microsoft.Maui.Controls.PropertyChangingEventArgs e)
    {
        #region 消除除厝噪音
        if (e.PropertyName == "IsFocused" || e.PropertyName == "CursorPosition")
        {
            return;
        }
        #endregion

        Debug.WriteLine($"[View] UserName Entry 的 Text 屬性即將有變動 (PropertyChanging) : {e.PropertyName}");
    }

    private void UserNameEntry_PropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        #region 消除除厝噪音
        if (e.PropertyName == "IsFocused" || e.PropertyName == "CursorPosition"
            || e.PropertyName == "SelectionLength")
        {
            return;
        }
        #endregion

        Debug.WriteLine($"[View] UserName Entry 的 Text 屬性已經有變動 (PropertyChanged) : {e.PropertyName}");
    }

    private void SayHiBtnClicked(object sender, EventArgs e)
    {
        mainPageViewModel.UserName = DateTime.Now.ToString();
    }
}
