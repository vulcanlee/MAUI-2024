using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MX02
{
    public partial class NewPageViewModel : ObservableObject
    {
        [RelayCommand]
        public void GoBack()
        {
          App.Current.MainPage=  new MainPage(new MainPageViewModel());
        }
    }
}
