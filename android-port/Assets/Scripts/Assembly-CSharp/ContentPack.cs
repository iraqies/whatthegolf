using System;
using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200001F")]
public class ContentPack : ScriptableObject, IPackWithData
{
	[Serializable]
	[Token(Token = "0x2000020")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D290", Offset = "0x3D290")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x8")]
		public static Func<ContentPackDef, ContentPack> _003C_003E9__33_0;

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x178FC24", Offset = "0x178FC24", VA = "0x178FC24")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x178FC2C", Offset = "0x178FC2C", VA = "0x178FC2C")]
		internal ContentPack _003CIsAvailable_003Eb__33_0(ContentPackDef cpd)
		{
			return null;
		}
	}

	[Token(Token = "0x4000065")]
	[FieldOffset(Offset = "0x18")]
	public string contentPackID;

	[Token(Token = "0x4000066")]
	[FieldOffset(Offset = "0x20")]
	public bool isODRContent;

	[Token(Token = "0x4000067")]
	[FieldOffset(Offset = "0x24")]
	public ECampaignType campaignType;

	[Token(Token = "0x4000068")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public AssetReferenceScene overworldSceneReference;

	[Token(Token = "0x4000069")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public AssetReferenceScene tunnelLoaderSceneReference;

	[Token(Token = "0x400006A")]
	[FieldOffset(Offset = "0x38")]
	public List<UnityEngine.Object> requiredScenes;

	[Token(Token = "0x400006B")]
	[FieldOffset(Offset = "0x40")]
	public LeaderboardBoard leaderboard;

	[Token(Token = "0x400006C")]
	[FieldOffset(Offset = "0x48")]
	public LevelDataContainerBase mainContainer;

	[Token(Token = "0x400006D")]
	[FieldOffset(Offset = "0x50")]
	public LevelDataContainerBase onboardingContainer;

	[Token(Token = "0x400006E")]
	[FieldOffset(Offset = "0x58")]
	public string titleID;

	[Token(Token = "0x400006F")]
	[FieldOffset(Offset = "0x60")]
	public string contentPackOverrideID;

	[Token(Token = "0x4000070")]
	[FieldOffset(Offset = "0x68")]
	public bool ps5ActivityEnable;

	[Token(Token = "0x4000071")]
	[FieldOffset(Offset = "0x69")]
	public bool ps5ActivityTrackProgress;

	[Token(Token = "0x4000072")]
	[FieldOffset(Offset = "0x6A")]
	public bool ps5ActivityHideWhenDone;

	[Token(Token = "0x4000073")]
	[FieldOffset(Offset = "0x6B")]
	public bool HasDownloadableMusic;

	[Token(Token = "0x17000017")]
	public bool IsNew
	{
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x18ADBC0", Offset = "0x18ADBC0", VA = "0x18ADBC0")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x17000018")]
	public bool hasLeaderboard
	{
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x18ADC54", Offset = "0x18ADC54", VA = "0x18ADC54")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x17000019")]
	public string TitleID
	{
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x18ADC64", Offset = "0x18ADC64", VA = "0x18ADC64", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001A")]
	public string ContentID
	{
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x18ADC6C", Offset = "0x18ADC6C", VA = "0x18ADC6C", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001B")]
	public string PackID
	{
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x18ADC74", Offset = "0x18ADC74", VA = "0x18ADC74", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001C")]
	public string PackName
	{
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x18ADCB0", Offset = "0x18ADCB0", VA = "0x18ADCB0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001D")]
	public List<UserCriteria> Criteria
	{
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x18ADDB4", Offset = "0x18ADDB4", VA = "0x18ADDB4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x18ADDBC", Offset = "0x18ADDBC", VA = "0x18ADDBC")]
	public List<LevelData> GetAllLevelDatas()
	{
		return null;
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x18ADF30", Offset = "0x18ADF30", VA = "0x18ADF30")]
	public bool IsFresh()
	{
		return default;
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x18ADFB4", Offset = "0x18ADFB4", VA = "0x18ADFB4")]
	public bool IsConsideredNew()
	{
		return default;
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x18ADD38", Offset = "0x18ADD38", VA = "0x18ADD38")]
	private string Formatted(string s)
	{
		return null;
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x18AE0E4", Offset = "0x18AE0E4", VA = "0x18AE0E4")]
	public bool IsAvailable()
	{
		return default;
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x18AE2B8", Offset = "0x18AE2B8", VA = "0x18AE2B8")]
	public ContentPack()
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x18AE348", Offset = "0x18AE348", VA = "0x18AE348")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5D164", Offset = "0x5D164")]
	private bool _003CIsAvailable_003Eb__33_1(ContentPack c)
	{
		return default;
	}
}
