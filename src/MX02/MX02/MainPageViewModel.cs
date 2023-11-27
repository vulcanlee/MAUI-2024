using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MX02
{
    public partial class MainPageViewModel : ObservableObject
    {
        [RelayCommand]
        public void GoNext()
        {

#if ANDROID
            Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(Entry), (handler, view) =>
            {
                //handler.PlatformView
                //.SetBackgroundColor(Android.Graphics.Color.White);
                handler.PlatformView.BackgroundTintList =
                Android.Content.Res.ColorStateList
                .ValueOf(Android.Graphics.Color.White);
            });
#endif
            App.Current.MainPage = new NewPage(new NewPageViewModel());
        }
    }
}
