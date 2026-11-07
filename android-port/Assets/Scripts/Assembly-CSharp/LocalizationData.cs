using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000026")]
public struct LocalizationData
{
	[Token(Token = "0x400008B")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public NotificationSystemType type;

	[Token(Token = "0x400008C")]
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	public string localizationID;

	[Token(Token = "0x400008D")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public string localizationTitleID;

	[Token(Token = "0x400008E")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public Sprite image;

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x153D41C", Offset = "0x153D41C", VA = "0x153D41C")]
	public LocalizationData(NotificationSystemType type, string locId, string locTitleId, Sprite img)
	{
	}
}
