using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MA09.ViewModel;

public partial class Number2PageViewModel : ObservableObject
{
    [RelayCommand]
    void GoNextPage()
    {
        Shell.Current.GoToAsync("///Number3");
    }
}
