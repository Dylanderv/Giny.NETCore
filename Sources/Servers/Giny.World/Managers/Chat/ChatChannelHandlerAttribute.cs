using Giny.Protocol.Enums;

namespace Giny.World.Managers.Chat;

public class ChatChannelHandlerAttribute : Attribute
{
    public ChatActivableChannelsEnum Channel
    {
        get; set;
    }

    public ChatChannelHandlerAttribute(ChatActivableChannelsEnum channel)
    {
        this.Channel = channel;
    }
}