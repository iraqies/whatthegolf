using System;
using Core;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

[Token(Token = "0x2000499")]
public class CreditsInLevel : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200049A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FCAC", Offset = "0x3FCAC")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x400185E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x400185F")]
		[FieldOffset(Offset = "0x8")]
		public static Func<string, Guid> _003C_003E9__12_0;

		[Token(Token = "0x6001553")]
		[Address(RVA = "0x1791B48", Offset = "0x1791B48", VA = "0x1791B48")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6001554")]
		[Address(RVA = "0x1791B50", Offset = "0x1791B50", VA = "0x1791B50")]
		internal Guid _003CBall_OnShoot_003Eb__12_0(string x)
		{
			return default;
		}
	}

	[Token(Token = "0x4001854")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshPro Headline;

	[Token(Token = "0x4001855")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshPro Subline;

	[Token(Token = "0x4001856")]
	[FieldOffset(Offset = "0x28")]
	public GolfBallController ball;

	[Token(Token = "0x4001857")]
	[FieldOffset(Offset = "0x30")]
	public CreditsData creditsData;

	[Token(Token = "0x4001858")]
	[FieldOffset(Offset = "0x38")]
	public float minTimeForCreditToShow;

	[Token(Token = "0x4001859")]
	[FieldOffset(Offset = "0x3C")]
	public float maxTimeForCreditToShow;

	[Token(Token = "0x400185A")]
	[FieldOffset(Offset = "0x40")]
	public bool localizeHeadline;

	[Token(Token = "0x400185B")]
	[FieldOffset(Offset = "0x44")]
	private int index;

	[Token(Token = "0x400185C")]
	[FieldOffset(Offset = "0x48")]
	private float nextCreditTime;

	[Token(Token = "0x400185D")]
	[FieldOffset(Offset = "0x4C")]
	private float nextForcedCreditTime;

	[Token(Token = "0x600154E")]
	[Address(RVA = "0x18C10F8", Offset = "0x18C10F8", VA = "0x18C10F8")]
	private void Start()
	{
	}

	[Token(Token = "0x600154F")]
	[Address(RVA = "0x18C1280", Offset = "0x18C1280", VA = "0x18C1280")]
	private void Ball_OnAimUpdate(Vector3 arg1, bool arg2)
	{
	}

	[Token(Token = "0x6001550")]
	[Address(RVA = "0x18C12D8", Offset = "0x18C12D8", VA = "0x18C12D8")]
	private void Ball_OnShoot(Vector3 obj)
	{
	}

	[Token(Token = "0x6001551")]
	[Address(RVA = "0x18C164C", Offset = "0x18C164C", VA = "0x18C164C")]
	public CreditsInLevel()
	{
	}
}
