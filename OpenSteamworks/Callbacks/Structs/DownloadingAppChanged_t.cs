using System;
using System.Runtime.InteropServices;
using OpenSteamworks.Enums;

namespace OpenSteamworks.Callbacks.Structs;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct DownloadingAppChanged_t
{
	public AppId_t m_nAppID;
};