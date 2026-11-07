using System;
using Core;
using Il2CppDummyDll;
using Malee;
using UnityEngine;

[Token(Token = "0x2000431")]
public class LevelChallenges : MonoBehaviour
{
	[Token(Token = "0x2000432")]
	public enum gameVersion
	{
		[Token(Token = "0x40016F2")]
		Base = 0,
		[Token(Token = "0x40016F3")]
		OL = 1
	}

	[Serializable]
	[Token(Token = "0x2000433")]
	public class ChallengeList : ReorderableArray<Challenge>
	{
		[Token(Token = "0x60013B9")]
		[Address(RVA = "0x17D14D4", Offset = "0x17D14D4", VA = "0x17D14D4")]
		public ChallengeList()
		{
		}
	}

	[Token(Token = "0x40016EC")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public ChallengeList Challenges;

	[Token(Token = "0x40016ED")]
	[FieldOffset(Offset = "0x20")]
	private bool hasFailedLevel;

	[Token(Token = "0x40016EE")]
	[FieldOffset(Offset = "0x24")]
	public gameVersion failMessages;

	[Token(Token = "0x40016EF")]
	[FieldOffset(Offset = "0x28")]
	private string[] olFailMessages;

	[Token(Token = "0x40016F0")]
	[FieldOffset(Offset = "0x0")]
	private static System.Random random;

	[Token(Token = "0x60013B0")]
	[Address(RVA = "0x152545C", Offset = "0x152545C", VA = "0x152545C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60013B1")]
	[Address(RVA = "0x152588C", Offset = "0x152588C", VA = "0x152588C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60013B2")]
	[Address(RVA = "0x1525AB4", Offset = "0x1525AB4", VA = "0x1525AB4")]
	private void OnChallengeSelected(string id)
	{
	}

	[Token(Token = "0x60013B3")]
	[Address(RVA = "0x1525D58", Offset = "0x1525D58", VA = "0x1525D58")]
	private void Complete(Challenge challenge)
	{
	}

	[Token(Token = "0x60013B4")]
	[Address(RVA = "0x1526128", Offset = "0x1526128", VA = "0x1526128")]
	private void Fail(Challenge challenge)
	{
	}

	[Token(Token = "0x60013B5")]
	[Address(RVA = "0x152624C", Offset = "0x152624C", VA = "0x152624C")]
	public string GenerateId(int length)
	{
		return null;
	}

	[Token(Token = "0x60013B6")]
	[Address(RVA = "0x152637C", Offset = "0x152637C", VA = "0x152637C")]
	public LevelChallenges()
	{
	}

	[Token(Token = "0x60013B8")]
	[Address(RVA = "0x152657C", Offset = "0x152657C", VA = "0x152657C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61F4C", Offset = "0x61F4C")]
	private void _003COnChallengeSelected_003Eb__7_0(GolfBallController c, string s, Level.State s2)
	{
	}
}
