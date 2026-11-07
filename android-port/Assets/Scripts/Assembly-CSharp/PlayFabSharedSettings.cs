using Il2CppDummyDll;
using PlayFab;
using UnityEngine;

[Token(Token = "0x20002BA")]
public class PlayFabSharedSettings : ScriptableObject
{
	[Token(Token = "0x4000EBC")]
	[FieldOffset(Offset = "0x18")]
	public string TitleId;

	[Token(Token = "0x4000EBD")]
	[FieldOffset(Offset = "0x20")]
	internal string VerticalName;

	[Token(Token = "0x4000EBE")]
	[FieldOffset(Offset = "0x28")]
	public string ProductionEnvironmentUrl;

	[Token(Token = "0x4000EBF")]
	[FieldOffset(Offset = "0x30")]
	public WebRequestType RequestType;

	[Token(Token = "0x4000EC0")]
	[FieldOffset(Offset = "0x38")]
	public string AdvertisingIdType;

	[Token(Token = "0x4000EC1")]
	[FieldOffset(Offset = "0x40")]
	public string AdvertisingIdValue;

	[Token(Token = "0x4000EC2")]
	[FieldOffset(Offset = "0x48")]
	public bool DisableAdvertising;

	[Token(Token = "0x4000EC3")]
	[FieldOffset(Offset = "0x49")]
	public bool DisableDeviceInfo;

	[Token(Token = "0x4000EC4")]
	[FieldOffset(Offset = "0x4A")]
	public bool DisableFocusTimeCollection;

	[Token(Token = "0x4000EC5")]
	[FieldOffset(Offset = "0x4C")]
	public int RequestTimeout;

	[Token(Token = "0x4000EC6")]
	[FieldOffset(Offset = "0x50")]
	public bool RequestKeepAlive;

	[Token(Token = "0x4000EC7")]
	[FieldOffset(Offset = "0x51")]
	public bool CompressApiData;

	[Token(Token = "0x4000EC8")]
	[FieldOffset(Offset = "0x54")]
	public PlayFabLogLevel LogLevel;

	[Token(Token = "0x4000EC9")]
	[FieldOffset(Offset = "0x58")]
	public string LoggerHost;

	[Token(Token = "0x4000ECA")]
	[FieldOffset(Offset = "0x60")]
	public int LoggerPort;

	[Token(Token = "0x4000ECB")]
	[FieldOffset(Offset = "0x64")]
	public bool EnableRealTimeLogging;

	[Token(Token = "0x4000ECC")]
	[FieldOffset(Offset = "0x68")]
	public int LogCapLimit;

	[Token(Token = "0x6000C86")]
	[Address(RVA = "0x15F0A08", Offset = "0x15F0A08", VA = "0x15F0A08")]
	public PlayFabSharedSettings()
	{
	}
}
