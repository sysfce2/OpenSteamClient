//==========================  AUTO-GENERATED FILE  ================================
//
// This file is partially auto-generated.
// If functions are removed, your changes to that function will be lost.
// Parameter types and names however are preserved if the function stays unchanged.
// Feel free to change parameters to be more accurate. 
//=============================================================================

using System;
using OpenSteamworks.Enums;
using OpenSteamworks.NativeTypes;
using OpenSteamworks.Structs;

namespace OpenSteamworks.Generated;

public unsafe interface IClientGameServerInternal
{
    // WARNING: Do not use this function! Unknown behaviour will occur!
    public unknown_ret Unknown_0_DONTUSE();  // argc: -1, index: 1
    // WARNING: Do not use this function! Unknown behaviour will occur!
    public unknown_ret Unknown_1_DONTUSE();  // argc: -1, index: 2
    // WARNING: Arguments are unknown!
    public unknown_ret SetSDRLogin(CUtlBuffer* buf);  // argc: 1, index: 3
    // WARNING: Do not use this function! Unknown behaviour will occur!
    public unknown_ret Unknown_3_DONTUSE();  // argc: -1, index: 4
    // WARNING: Arguments are unknown!
    public unknown_ret InitGameServerSerialized();  // argc: 6, index: 5
    // WARNING: Arguments are unknown!
    public unknown_ret SetProduct(string product);  // argc: 1, index: 6
    // WARNING: Arguments are unknown!
    public unknown_ret SetGameDescription(string desc);  // argc: 1, index: 7
    // WARNING: Arguments are unknown!
    public unknown_ret SetModDir(string dir);  // argc: 1, index: 8
    // WARNING: Arguments are unknown!
    public unknown_ret SetDedicatedServer(bool val);  // argc: 1, index: 9
    // WARNING: Arguments are unknown!
    public unknown_ret LogOn(string unk);  // argc: 1, index: 10
    public unknown_ret LogOnAnonymous();  // argc: 0, index: 11
    public unknown_ret LogOff();  // argc: 0, index: 12
    // WARNING: Arguments are unknown!
    public CSteamID GetSteamID();  // argc: 1, index: 13
    public bool BLoggedOn();  // argc: 0, index: 14
    public bool BSecure();  // argc: 0, index: 15
    public unknown_ret WasRestartRequested();  // argc: 0, index: 16
    // WARNING: Arguments are unknown!
    public unknown_ret SetMaxPlayerCount(int maxPlayerCount);  // argc: 1, index: 17
    // WARNING: Arguments are unknown!
    public unknown_ret SetBotPlayerCount(int maxPlayerCount);  // argc: 1, index: 18
    // WARNING: Arguments are unknown!
    public unknown_ret SetServerName(string name);  // argc: 1, index: 19
    // WARNING: Arguments are unknown!
    public unknown_ret SetMapName(string name);  // argc: 1, index: 20
    // WARNING: Arguments are unknown!
    public unknown_ret SetPasswordProtected(bool isPasswordProtected);  // argc: 1, index: 21
    // WARNING: Arguments are unknown!
    public unknown_ret SetSpectatorPort();  // argc: 1, index: 22
    // WARNING: Arguments are unknown!
    public unknown_ret SetSpectatorServerName();  // argc: 1, index: 23
    public unknown_ret ClearAllKeyValues();  // argc: 0, index: 24
    // WARNING: Arguments are unknown!
    public unknown_ret SetKeyValue();  // argc: 2, index: 25
    // WARNING: Arguments are unknown!
    public unknown_ret SetGameTags();  // argc: 1, index: 26
    // WARNING: Arguments are unknown!
    public unknown_ret SetGameData();  // argc: 1, index: 27
    // WARNING: Arguments are unknown!
    public unknown_ret SetRegion(string region);  // argc: 1, index: 28
    // WARNING: Arguments are unknown!
    public unknown_ret SendUserConnectAndAuthenticate();  // argc: 4, index: 29
    // WARNING: Arguments are unknown!
    public unknown_ret CreateUnauthenticatedUserConnection();  // argc: 1, index: 30
    // WARNING: Arguments are unknown!
    public unknown_ret SendUserDisconnect();  // argc: 2, index: 31
    // WARNING: Arguments are unknown!
    public unknown_ret BUpdateUserData();  // argc: 4, index: 32
    // WARNING: Arguments are unknown!
    public unknown_ret GetAuthSessionTicket();  // argc: 3, index: 33
    // WARNING: Arguments are unknown!
    public unknown_ret GetAuthSessionTicketV2();  // argc: 4, index: 34
    // WARNING: Arguments are unknown!
    public unknown_ret BeginAuthSession();  // argc: 4, index: 35
    // WARNING: Arguments are unknown!
    public unknown_ret EndAuthSession();  // argc: 2, index: 36
    // WARNING: Arguments are unknown!
    public unknown_ret CancelAuthTicket();  // argc: 1, index: 37
    // WARNING: Arguments are unknown!
    public unknown_ret IsUserSubscribedAppInTicket();  // argc: 3, index: 38
    // WARNING: Arguments are unknown!
    public unknown_ret RequestUserGroupStatus();  // argc: 4, index: 39
    public unknown_ret GetGameplayStats();  // argc: 0, index: 40
    public unknown_ret GetServerReputation();  // argc: 0, index: 41
    // WARNING: Arguments are unknown!
    public unknown_ret GetPublicIP();  // argc: 1, index: 42
    // WARNING: Arguments are unknown!
    public unknown_ret EnableHeartbeats();  // argc: 1, index: 43
    // WARNING: Arguments are unknown!
    public unknown_ret SetHeartbeatInterval();  // argc: 1, index: 44
    public unknown_ret ForceHeartbeat();  // argc: 0, index: 45
    public ELogonState GetLogonState();  // argc: 0, index: 46
    public bool BConnected();  // argc: 0, index: 47
    // WARNING: Arguments are unknown!§
    public unknown_ret RaiseConnectionPriority();  // argc: 1, index: 48
    // WARNING: Arguments are unknown!
    public unknown_ret ResetConnectionPriority();  // argc: 1, index: 49
    // WARNING: Arguments are unknown!
    public unknown_ret SetCellID(uint cellid);  // argc: 1, index: 50
    // WARNING: Arguments are unknown!
    public unknown_ret TrackSteamUsageEvent();  // argc: 3, index: 51
    // WARNING: Arguments are unknown!
    public unknown_ret SetCountOfSimultaneousGuestUsersPerSteamAccount();  // argc: 1, index: 52
    // WARNING: Arguments are unknown!
    public unknown_ret EnumerateConnectedUsers();  // argc: 2, index: 53
    // WARNING: Arguments are unknown!
    public unknown_ret AssociateWithClan();  // argc: 2, index: 54
    // WARNING: Arguments are unknown!
    public unknown_ret ComputeNewPlayerCompatibility();  // argc: 2, index: 55
    // WARNING: Arguments are unknown!
    public unknown_ret _BGetUserAchievementStatus();  // argc: 3, index: 56
    // WARNING: Arguments are unknown!
    public unknown_ret _GSSetSpawnCount();  // argc: 1, index: 57
    // WARNING: Arguments are unknown!
    public unknown_ret _GSGetSteam2GetEncryptionKeyToSendToNewClient();  // argc: 3, index: 58
    // WARNING: Arguments are unknown!
    public unknown_ret _GSSendSteam2UserConnect();  // argc: 7, index: 59
    // WARNING: Arguments are unknown!
    public unknown_ret _GSSendSteam3UserConnect();  // argc: 5, index: 60
    // WARNING: Arguments are unknown!
    public unknown_ret _GSSendUserConnect();  // argc: 5, index: 61
    // WARNING: Arguments are unknown!
    public unknown_ret _GSRemoveUserConnect();  // argc: 1, index: 62
    // WARNING: Arguments are unknown!
    public unknown_ret _GSUpdateStatus();  // argc: 6, index: 63
    // WARNING: Arguments are unknown!
    public unknown_ret _GSCreateUnauthenticatedUser();  // argc: 1, index: 64
    // WARNING: Arguments are unknown!
    public unknown_ret _GSSetServerType();  // argc: 9, index: 65
    // WARNING: Arguments are unknown!
    public unknown_ret _SetBasicServerData();  // argc: 7, index: 66
    // WARNING: Arguments are unknown!
    public unknown_ret _GSSendUserDisconnect();  // argc: 3, index: 67
}