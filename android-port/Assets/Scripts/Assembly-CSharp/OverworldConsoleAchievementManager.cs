using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000AB6")]
[ExecuteInEditMode]
public class OverworldConsoleAchievementManager : GolfBehaviour
{
	[Token(Token = "0x4003BAE")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private int numberOfUniqueIds;

	[Token(Token = "0x4003BAF")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private UnlockAchievement a;

	[Token(Token = "0x4003BB0")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private List<OverworldConsole> consoles;

	[Token(Token = "0x6003342")]
	[Address(RVA = "0x15B12D0", Offset = "0x15B12D0", VA = "0x15B12D0")]
	private void Start()
	{
	}

	[Token(Token = "0x6003343")]
	[Address(RVA = "0x15B1394", Offset = "0x15B1394", VA = "0x15B1394")]
	private void OnSpeechShown(SpeechbubbleList l)
	{
	}

	[Token(Token = "0x6003344")]
	[Address(RVA = "0x15B14D0", Offset = "0x15B14D0", VA = "0x15B14D0")]
	private string NameToID(string s)
	{
		return null;
	}

	[Token(Token = "0x6003345")]
	[Address(RVA = "0x15B154C", Offset = "0x15B154C", VA = "0x15B154C")]
	public OverworldConsoleAchievementManager()
	{
	}

	[Token(Token = "0x6003346")]
	[Address(RVA = "0x15B15D4", Offset = "0x15B15D4", VA = "0x15B15D4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6A328", Offset = "0x6A328")]
	private void _003CStart_003Eb__3_0(OverworldConsole c)
	{
	}
}
