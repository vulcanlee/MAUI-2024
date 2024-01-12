namespace MA07.Services;

/// <summary>
/// 實作 Line 送出通知
/// </summary>
public class SendLineService : ISendMessageService
{
    public string SayHello(string name, string message)
    {
        return $"Hello, {name} , 訊息 ({message}) 已經透過 Line 送出";
    }
}
