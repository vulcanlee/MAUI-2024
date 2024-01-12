namespace MA07.Services;

/// <summary>
/// 送出通知訊息介面
/// </summary>
public interface ISendMessageService
{
    string SayHello(string name, string message);
}