using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x200049E")]
public class CampaignDef
{
	[Token(Token = "0x400186B")]
	[FieldOffset(Offset = "0x10")]
	public ECampaignType type;

	[Token(Token = "0x400186C")]
	[FieldOffset(Offset = "0x18")]
	public string savePrefix;

	[Token(Token = "0x400186D")]
	[FieldOffset(Offset = "0x20")]
	public Transition.TransitionEffect transition;

	[Token(Token = "0x400186E")]
	[FieldOffset(Offset = "0x28")]
	public string packID;

	[Token(Token = "0x400186F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Dictionary<ECampaignType, CampaignDef> CAMPAIGN_DEFS;

	[Token(Token = "0x600155A")]
	[Address(RVA = "0x1885700", Offset = "0x1885700", VA = "0x1885700")]
	public static Dictionary<ECampaignType, CampaignDef> GetAllDefs()
	{
		return null;
	}

	[Token(Token = "0x600155B")]
	[Address(RVA = "0x1885764", Offset = "0x1885764", VA = "0x1885764")]
	public static CampaignDef GetDef(ECampaignType type)
	{
		return null;
	}

	[Token(Token = "0x600155C")]
	[Address(RVA = "0x18857F8", Offset = "0x18857F8", VA = "0x18857F8")]
	public CampaignDef()
	{
	}
}
