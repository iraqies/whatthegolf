using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200002F")]
public class UpdateInfo : ScriptableObject
{
	[Token(Token = "0x40000A7")]
	[FieldOffset(Offset = "0x18")]
	public string updateID;

	[Token(Token = "0x40000A8")]
	[FieldOffset(Offset = "0x20")]
	public string headerTextID;

	[Token(Token = "0x40000A9")]
	[FieldOffset(Offset = "0x28")]
	public string titleID;

	[Token(Token = "0x40000AA")]
	[FieldOffset(Offset = "0x30")]
	public string taglineID;

	[Token(Token = "0x40000AB")]
	[FieldOffset(Offset = "0x38")]
	public string descriptionID;

	[Token(Token = "0x40000AC")]
	[FieldOffset(Offset = "0x40")]
	public Sprite banner;

	[Token(Token = "0x40000AD")]
	[FieldOffset(Offset = "0x48")]
	public ContentPack contentPack;

	[Token(Token = "0x40000AE")]
	[FieldOffset(Offset = "0x50")]
	public int MinMainCampaignCompletionPct;

	[Token(Token = "0x40000AF")]
	[FieldOffset(Offset = "0x54")]
	public int daysUntilActive;

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x173D614", Offset = "0x173D614", VA = "0x173D614")]
	public UpdateInfo()
	{
	}
}
