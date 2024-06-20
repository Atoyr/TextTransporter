namespace Medoz.KoeKan.Data;

/// <summary>
/// </summary>
public enum ChatMessageType
{
    Command, 
    LogSuccess, 
    LogInfo, 
    LogWarning, 
    LogFatal, 
    Text,
    DiscordText, 
    DiscordVoice, 
    Twitch, 
}