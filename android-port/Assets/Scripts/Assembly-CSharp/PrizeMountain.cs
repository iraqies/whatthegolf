using System;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F19")]
public class PrizeMountain : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000F1A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x456A0", Offset = "0x456A0")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4005182")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4005183")]
		[FieldOffset(Offset = "0x8")]
		public static Func<MeshRenderer, bool> _003C_003E9__2_0;

		[Token(Token = "0x60046A3")]
		[Address(RVA = "0x182B25C", Offset = "0x182B25C", VA = "0x182B25C")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60046A4")]
		[Address(RVA = "0x182B264", Offset = "0x182B264", VA = "0x182B264")]
		internal bool _003CAwake_003Eb__2_0(MeshRenderer r)
		{
			return default;
		}
	}

	[Token(Token = "0x4005180")]
	[FieldOffset(Offset = "0x18")]
	public DailyPrize prize;

	[Token(Token = "0x4005181")]
	[FieldOffset(Offset = "0x20")]
	public GolfBallController controller;

	[Token(Token = "0x60046A0")]
	[Address(RVA = "0x1621F9C", Offset = "0x1621F9C", VA = "0x1621F9C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60046A1")]
	[Address(RVA = "0x16223FC", Offset = "0x16223FC", VA = "0x16223FC")]
	public PrizeMountain()
	{
	}
}
