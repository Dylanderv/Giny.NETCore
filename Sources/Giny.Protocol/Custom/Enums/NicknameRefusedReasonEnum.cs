namespace Giny.Protocol.Custom.Enums;

public enum NicknameRefusedReasonEnum
{
    ALREADY_USED = 1,
    SAME_AS_LOGIN = 2,
    TOO_SIMILAR_TO_LOGIN = 3,
    INVALID_NICK = 4,
    UNKNOWN_NICK_ERROR = 99,
}