using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A9E")]
public class BoatResetTrigger : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000A9F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42ED0", Offset = "0x42ED0")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4003B1C")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4003B1D")]
		[FieldOffset(Offset = "0x8")]
		public static Func<PierTransmogrif, bool> _003C_003E9__2_0;

		[Token(Token = "0x4003B1E")]
		[FieldOffset(Offset = "0x10")]
		public static Func<PierTransmogrif, bool> _003C_003E9__2_1;

		[Token(Token = "0x60032B7")]
		[Address(RVA = "0x1773578", Offset = "0x1773578", VA = "0x1773578")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60032B8")]
		[Address(RVA = "0x1773580", Offset = "0x1773580", VA = "0x1773580")]
		internal bool _003COnTriggerEnter2D_003Eb__2_0(PierTransmogrif p)
		{
			return default;
		}

		[Token(Token = "0x60032B9")]
		[Address(RVA = "0x177359C", Offset = "0x177359C", VA = "0x177359C")]
		internal bool _003COnTriggerEnter2D_003Eb__2_1(PierTransmogrif p)
		{
			return default;
		}
	}

	[Token(Token = "0x4003B1A")]
	[FieldOffset(Offset = "0x18")]
	public List<PierTransmogrif> NorthernPiers;

	[Token(Token = "0x4003B1B")]
	[FieldOffset(Offset = "0x20")]
	public List<PierTransmogrif> SouthernPiers;

	[Token(Token = "0x60032B4")]
	[Address(RVA = "0x16169FC", Offset = "0x16169FC", VA = "0x16169FC")]
	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	[Token(Token = "0x60032B5")]
	[Address(RVA = "0x1616E98", Offset = "0x1616E98", VA = "0x1616E98")]
	public BoatResetTrigger()
	{
	}
}
