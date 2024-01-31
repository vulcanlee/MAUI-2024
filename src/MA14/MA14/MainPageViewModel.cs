using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MA14
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        #region 實作 MVVM 的 INotifyPropertyChanged 介面
        public event PropertyChangedEventHandler? PropertyChanged;

        void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region 需要做資料綁定的屬性設計
        string userName = string.Empty;
        public string UserName
        {
            get
            {
                return this.userName;
            }

            set
            {
                if (value != this.userName)
                {
                    this.userName = value;
                    NotifyPropertyChanged();
                    Debug.WriteLine($"[ViewModel] 的 UserName 屬性有變動 : {this.userName}");
                }
            }
        }
        #endregion
    }
}
