using CommunityToolkit.Mvvm.Messaging.Messages;
using MA12.Models;

namespace MA12.Events;

public class MyValueChangedMessage : ValueChangedMessage<MyMessage>
{
    public MyValueChangedMessage(MyMessage myMessage) : base(myMessage)
    {
    }
}
