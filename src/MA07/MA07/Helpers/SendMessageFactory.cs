using MA07.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MA07.Helpers
{
    /// <summary>
    /// 依據 SendMessageType 產生對應的 SendMessageService
    /// </summary>
    public static class SendMessageFactory
    {
        public static ISendMessageService Get(Enums.SendMessageTypeEnum sendMessageType)
        {
            switch (sendMessageType)
            {
                case Enums.SendMessageTypeEnum.Line:
                    return ServiceHelper.GetService<SendLineService>();
                case Enums.SendMessageTypeEnum.Sms:
                    return ServiceHelper.GetService<SendSmsService>();
                case Enums.SendMessageTypeEnum.Email:
                    return ServiceHelper.GetService<SendEmailService>();
                default:
                    throw new Exception("未知的 SendMessageType");
            }
        }
    }
}
