using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MA07.Services
{
    /// <summary>
    /// 實作電子郵件送出通知
    /// </summary>
    public class SendEmailService : ISendMessageService
    {
        public string SayHello(string name, string message)
        {
            return $"Hello, {name} , 訊息 ({message}) 已經透過 電子郵件 送出";
        }
    }
}
