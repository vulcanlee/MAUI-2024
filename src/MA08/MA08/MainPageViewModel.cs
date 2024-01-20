using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MA08
{
    public partial class MainPageViewModel :ObservableObject
    {
        [ObservableProperty]
        int value1=0;
        [ObservableProperty]
        int value2=0;
        [ObservableProperty]
        int value3=0;
        private readonly IValueAddService valueAddService;

        public MainPageViewModel(IValueAddService valueAddService)
        {
            this.valueAddService = valueAddService;
        }

        [RelayCommand]
        public void Add()
        {
            Value3 = valueAddService.Add(Value1, Value2);
        }
    }
}
