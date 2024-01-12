using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MA07.Helpers;
using MA07.Services;

namespace MA07.ViewModels;

public partial class ServiceLocatorPageViewModel : ObservableObject
{
    private readonly IServiceProvider serviceProvider;
    [ObservableProperty]
    string name = string.Empty;
    [ObservableProperty]
    string echoEmailMessage = string.Empty;
    [ObservableProperty]
    string echoSmsMessage = string.Empty;
    [ObservableProperty]
    string echoLineMessage = string.Empty;
    [ObservableProperty]
    bool needSendEmail = false;
    [ObservableProperty]
    bool needSendSms = false;
    [ObservableProperty]
    bool needSendLine = false;

    public ServiceLocatorPageViewModel(IServiceProvider serviceProvider)
    {
        this.serviceProvider = serviceProvider;
    }

    [RelayCommand]
    public void SayHello()
    {
        EchoEmailMessage = string.Empty;
        EchoSmsMessage = string.Empty;
        EchoLineMessage = string.Empty;

        ISendMessageService sendHelloMessageService;
        if (NeedSendEmail)
        {
            //sendHelloMessageService = serviceProvider.GetService<SendEmailService>();
            sendHelloMessageService = SendMessageFactory.Get(Enums.SendMessageTypeEnum.Email);
            this.EchoEmailMessage = sendHelloMessageService.SayHello(Name, "今日天氣晴");
        }

        if (NeedSendSms)
        {
            //sendHelloMessageService = serviceProvider.GetService<SendSmsService>();
            sendHelloMessageService = SendMessageFactory.Get(Enums.SendMessageTypeEnum.Sms);
            this.EchoSmsMessage = sendHelloMessageService.SayHello(Name, "今日天氣晴");
        }

        if (NeedSendLine)
        {
            //sendHelloMessageService = serviceProvider.GetService<SendLineService>();
            sendHelloMessageService = SendMessageFactory.Get(Enums.SendMessageTypeEnum.Line);
            this.EchoLineMessage = sendHelloMessageService.SayHello(Name, "今日天氣晴");
        }

    }
}
