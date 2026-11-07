using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000CDF")]
public class SteamDataSuiteConfig : ScriptableObject
{
	[Token(Token = "0x40045EE")]
	[FieldOffset(Offset = "0x18")]
	public bool Enabled;

	[Token(Token = "0x40045EF")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x5143C", Offset = "0x5143C")]
	public string TrackingKey;

	[Token(Token = "0x40045F0")]
	[FieldOffset(Offset = "0x28")]
	public bool DebugMode;

	[Token(Token = "0x40045F1")]
	[FieldOffset(Offset = "0x29")]
	public bool OpenThankYouPageOnExit;

	[Token(Token = "0x6003CE7")]
	[Address(RVA = "0x16DEA0C", Offset = "0x16DEA0C", VA = "0x16DEA0C")]
	public SteamDataSuiteConfig()
	{
	}
}
