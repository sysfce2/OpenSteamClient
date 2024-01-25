using OpenSteamworks.Enums;
using OpenSteamworks.Client.Config.Attributes;

namespace OpenSteamworks.Client.Config;

public class UserSettings: IConfigFile {
    static string IConfigFile.ConfigName => "UserSettings_001";
    static bool IConfigFile.PerUser => true;
    static bool IConfigFile.AlwaysSave => false;

    [ConfigName("Language", "#UserSettings_Language")]
    [ConfigDescription("Sets the language of the client.", "#UserSettings_LanguageDesc")]
    public ELanguage Language { get; set; } = ELanguage.None;

    [ConfigName("Auto-login to friends network", "#UserSettings_AutologinFriendsNetwork")]
    [ConfigDescription("Automatically login to the friends network when logging in", "#UserSettings_AutologinFriendsNetworkDesc")]
    public bool LoginToFriendsNetworkAutomatically { get; set; } = true;
}