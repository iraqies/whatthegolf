using System;
using System.Runtime.InteropServices;
using Core;
using Il2CppDummyDll;

[Token(Token = "0x2000B43")]
public class CalculateCompletionPercentageCommand
{
	[Serializable]
	[Token(Token = "0x2000B44")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43760", Offset = "0x43760")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4003EBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4003EBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<LevelData, int> _003C_003E9__5_2;

		[Token(Token = "0x6003595")]
		[Address(RVA = "0x1780944", Offset = "0x1780944", VA = "0x1780944")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6003596")]
		[Address(RVA = "0x178094C", Offset = "0x178094C", VA = "0x178094C")]
		internal int _003CExecute_003Eb__5_2(LevelData l)
		{
			return default;
		}
	}

	[Token(Token = "0x4003EB7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly ECampaignType _campaignType;

	[Token(Token = "0x4003EB8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private readonly int? _saveSlot;

	[Token(Token = "0x4003EB9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private readonly bool _includeChallenges;

	[Token(Token = "0x6003590")]
	[Address(RVA = "0x17E3D84", Offset = "0x17E3D84", VA = "0x17E3D84")]
	public CalculateCompletionPercentageCommand(ECampaignType campaignType, [Optional] int? saveSlot, bool includeChallenges = true)
	{
	}

	[Token(Token = "0x6003591")]
	[Address(RVA = "0x17E3DC8", Offset = "0x17E3DC8", VA = "0x17E3DC8")]
	public int Execute()
	{
		return default;
	}

	[Token(Token = "0x6003592")]
	[Address(RVA = "0x17E4150", Offset = "0x17E4150", VA = "0x17E4150")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6A9B8", Offset = "0x6A9B8")]
	private int _003CExecute_003Eb__5_0(LevelData l)
	{
		return default;
	}

	[Token(Token = "0x6003593")]
	[Address(RVA = "0x17E41F0", Offset = "0x17E41F0", VA = "0x17E41F0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6A9C8", Offset = "0x6A9C8")]
	private int _003CExecute_003Eb__5_1(LevelData l)
	{
		return default;
	}
}
