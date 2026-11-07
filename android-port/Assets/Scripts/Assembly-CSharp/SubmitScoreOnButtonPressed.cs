using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A69")]
public class SubmitScoreOnButtonPressed : MonoBehaviour
{
	[Token(Token = "0x2000A6A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x42D10", Offset = "0x42D10")]
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		[Token(Token = "0x40039B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool response;

		[Token(Token = "0x60031AE")]
		[Address(RVA = "0x185C0C4", Offset = "0x185C0C4", VA = "0x185C0C4")]
		public _003C_003Ec__DisplayClass7_0()
		{
		}

		[Token(Token = "0x60031AF")]
		[Address(RVA = "0x185C0CC", Offset = "0x185C0CC", VA = "0x185C0CC")]
		internal void _003CSubmitScore_003Eb__0(bool s, int r)
		{
		}
	}

	[Token(Token = "0x40039B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OverworldMainButton button;

	[Token(Token = "0x40039B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public LeaderboardBoard board;

	[Token(Token = "0x40039B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public UnlockAchievement achievement;

	[Token(Token = "0x40039B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string savegameID;

	[Token(Token = "0x40039B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private bool isSubmittedToScore;

	[Token(Token = "0x60031AA")]
	[Address(RVA = "0x16E713C", Offset = "0x16E713C", VA = "0x16E713C")]
	private void Start()
	{
	}

	[Token(Token = "0x60031AB")]
	[Address(RVA = "0x16E7280", Offset = "0x16E7280", VA = "0x16E7280")]
	private void Button_OnInit()
	{
	}

	[Token(Token = "0x60031AC")]
	[Address(RVA = "0x16E73B4", Offset = "0x16E73B4", VA = "0x16E73B4")]
	private void SubmitScore([Optional] OverworldMainButton o)
	{
	}

	[Token(Token = "0x60031AD")]
	[Address(RVA = "0x16E7660", Offset = "0x16E7660", VA = "0x16E7660")]
	public SubmitScoreOnButtonPressed()
	{
	}
}
