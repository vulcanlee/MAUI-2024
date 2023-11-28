using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MA01
{
    public partial class MainPageViewModel : ObservableObject
    {
        CancellationTokenSource cts = new CancellationTokenSource();
        int timeInterval = 2000;
        DateTime pressTime;
        [ObservableProperty]
        string message = "Hello, world!";
        [RelayCommand]
        public void Press()
        {
            cts = new CancellationTokenSource();
            pressTime = DateTime.Now;
            Task.Run(async () =>
            {
                await Task.Delay(timeInterval, cts.Token);

                Message = DateTime.Now.ToString();
            });
        }
        [RelayCommand]
        public void Release()
        {
            if ((DateTime.Now - pressTime).TotalMicroseconds < timeInterval)
            {
                cts.Cancel();
                Message = "Cancelled";
            }
        }
    }
}
