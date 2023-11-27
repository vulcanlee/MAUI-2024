using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MX01
{
    public partial class MainPageViewModel : ObservableObject
    {
        [RelayCommand]
        void ChangeStatuBarColor()
        {
            CommunityToolkit.Maui.Core.Platform
                .StatusBar.SetColor(Colors.Green);
            CommunityToolkit.Maui.Core.Platform
                .StatusBar.SetStyle(CommunityToolkit.Maui.Core.StatusBarStyle.LightContent);
        }
    }
}
