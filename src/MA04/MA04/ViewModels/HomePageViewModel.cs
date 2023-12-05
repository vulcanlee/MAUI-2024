using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MA04.ViewModels
{
    public partial class HomePageViewModel : ObservableObject
    {
        [ObservableProperty]
        string number1 = "0";
        [ObservableProperty]
        string number2 = "0";
        [ObservableProperty]
        string message = string.Empty;
        [ObservableProperty]
        string summary = string.Empty;

        partial void OnNumber1Changed(string value)
        {
            FullNumberCheck();
        }

        partial void OnNumber2Changed(string value)
        {
            FullNumberCheck();
        }

        void FullNumberCheck()
        {
            Message = string.Empty;
            Summary = string.Empty;

            // 檢查 Number1 是否為合法整數數值，若不成立，將訊息顯示在 Message 內
            if (int.TryParse(Number1, out int num1) == false)
            {
                Message = "Number1 必須為整數數值";
                return ;
            }

            // 檢查 Number2 是否為合法整數數值，若不成立，將訊息顯示在 Message 內
            if (int.TryParse(Number2, out int num2) == false)
            {
                Message = "Number2 必須為整數數值";
                return;
            }

            // 進行 Number1 與 Number2 的加總運算
            int number1 = int.Parse(Number1);
            int number2 = int.Parse(Number2);
            int summary = number1 + number2;

            // 將加總結果顯示在 Summary 內
            GenerateSummary(number1, number2);
        }

        void GenerateSummary(int paraNum1, int paraNum2)
        {
            Summary = $"{paraNum1} + {paraNum2} 加總結果為 {paraNum1 + paraNum2}";
        }
    }
}
