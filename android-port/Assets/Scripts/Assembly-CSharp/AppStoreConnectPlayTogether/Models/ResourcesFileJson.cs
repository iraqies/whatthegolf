using System.Collections.Generic;
using Il2CppDummyDll;

namespace AppStoreConnectPlayTogether.Models
{
	[Token(Token = "0x2001484")]
	public class ResourcesFileJson
	{
		[Token(Token = "0x4007145")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CE4C", Offset = "0x5CE4C")]
		private List<ChallengeJson> challenges__BackingField;

		[Token(Token = "0x4007146")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CE5C", Offset = "0x5CE5C")]
		private Dictionary<string, List<ChallengeLocalizationJson>> challengeLocalizations__BackingField;

		[Token(Token = "0x4007147")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CE6C", Offset = "0x5CE6C")]
		private List<GameActivityJson> gameActivities__BackingField;

		[Token(Token = "0x4007148")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CE7C", Offset = "0x5CE7C")]
		private Dictionary<string, List<GameActivityLocalizationJson>> gameActivityLocalizations__BackingField;

		[Token(Token = "0x17000B03")]
		[Attribute(Name = "JsonPropertyAttribute", RVA = "0x73C6C", Offset = "0x73C6C")]
		public List<ChallengeJson> challenges
		{
			[Token(Token = "0x600608C")]
			[Address(RVA = "0x164CC24", Offset = "0x164CC24", VA = "0x164CC24")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x73074", Offset = "0x73074")]
			get
			{
				return null;
			}
			[Token(Token = "0x600608D")]
			[Address(RVA = "0x164CC2C", Offset = "0x164CC2C", VA = "0x164CC2C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x73084", Offset = "0x73084")]
			set
			{
			}
		}

		[Token(Token = "0x17000B04")]
		[Attribute(Name = "JsonPropertyAttribute", RVA = "0x73CA4", Offset = "0x73CA4")]
		public Dictionary<string, List<ChallengeLocalizationJson>> challengeLocalizations
		{
			[Token(Token = "0x600608E")]
			[Address(RVA = "0x164CC34", Offset = "0x164CC34", VA = "0x164CC34")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x73094", Offset = "0x73094")]
			get
			{
				return null;
			}
			[Token(Token = "0x600608F")]
			[Address(RVA = "0x164CC3C", Offset = "0x164CC3C", VA = "0x164CC3C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x730A4", Offset = "0x730A4")]
			set
			{
			}
		}

		[Token(Token = "0x17000B05")]
		[Attribute(Name = "JsonPropertyAttribute", RVA = "0x73CDC", Offset = "0x73CDC")]
		public List<GameActivityJson> gameActivities
		{
			[Token(Token = "0x6006090")]
			[Address(RVA = "0x164CC44", Offset = "0x164CC44", VA = "0x164CC44")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x730B4", Offset = "0x730B4")]
			set
			{
			}
		}

		[Token(Token = "0x17000B06")]
		[Attribute(Name = "JsonPropertyAttribute", RVA = "0x73D14", Offset = "0x73D14")]
		public Dictionary<string, List<GameActivityLocalizationJson>> gameActivityLocalizations
		{
			[Token(Token = "0x6006091")]
			[Address(RVA = "0x164CC4C", Offset = "0x164CC4C", VA = "0x164CC4C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x730C4", Offset = "0x730C4")]
			set
			{
			}
		}

		[Token(Token = "0x6006092")]
		[Address(RVA = "0x164CC54", Offset = "0x164CC54", VA = "0x164CC54")]
		public ResourcesFileJson()
		{
		}
	}
}
