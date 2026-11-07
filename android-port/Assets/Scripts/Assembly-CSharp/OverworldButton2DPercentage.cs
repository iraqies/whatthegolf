using System.Collections.Generic;
using System.Text.RegularExpressions;
using CameraStack;
using Il2CppDummyDll;
using UnityEngine.Tilemaps;

[Token(Token = "0x20009F1")]
public class OverworldButton2DPercentage : OverworldButton2D
{
	[Token(Token = "0x40036CC")]
	[FieldOffset(Offset = "0x190")]
	[Attribute(Name = "RangeAttribute", RVA = "0x500EC", Offset = "0x500EC")]
	public float PercentageThreshold;

	[Token(Token = "0x40036CD")]
	[FieldOffset(Offset = "0x198")]
	public List<OverworldGoal> ignoreFlags;

	[Token(Token = "0x40036CE")]
	[FieldOffset(Offset = "0x1A0")]
	private Regex whitespaceRemover;

	[Token(Token = "0x170004D6")]
	private float Threshold
	{
		[Token(Token = "0x6002F19")]
		[Address(RVA = "0x15AD324", Offset = "0x15AD324", VA = "0x15AD324")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x6002F1A")]
	[Address(RVA = "0x15AD338", Offset = "0x15AD338", VA = "0x15AD338", Slot = "5")]
	public override void Init(Tilemap tilemap, List<OverworldGoal> goals, OverworldCamera camera)
	{
	}

	[Token(Token = "0x6002F1B")]
	[Address(RVA = "0x15AD664", Offset = "0x15AD664", VA = "0x15AD664", Slot = "7")]
	public override void UpdateStatus()
	{
	}

	[Token(Token = "0x6002F1C")]
	[Address(RVA = "0x15AD950", Offset = "0x15AD950", VA = "0x15AD950", Slot = "6")]
	public override int GetFlagsLeft()
	{
		return default;
	}

	[Token(Token = "0x6002F1D")]
	[Address(RVA = "0x15AD9E8", Offset = "0x15AD9E8", VA = "0x15AD9E8")]
	public OverworldButton2DPercentage()
	{
	}

	[Token(Token = "0x6002F1E")]
	[Address(RVA = "0x15ADAAC", Offset = "0x15ADAAC", VA = "0x15ADAAC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x68CD8", Offset = "0x68CD8")]
	private void _003CInit_003Eb__5_0(OverworldGoal g)
	{
	}
}
