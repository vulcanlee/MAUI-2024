using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MA07.Services
{
    /// <summary>
    /// 實作 簡訊 送出通知
    /// </summary>
    public class SendSmsService : ISendMessageService
    {
        public string SayHello(string name, string message)
        {
            return $"Hello, {name} , 訊息 ({message}) 已經透過 簡訊 送出";
        }
    }
}
