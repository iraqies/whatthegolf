using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C2F")]
public static class ScreenResolutions
{
	[Serializable]
	[Token(Token = "0x2000C30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43FF0", Offset = "0x43FF0")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4004320")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4004321")]
		[FieldOffset(Offset = "0x8")]
		public static Func<Resolution, string> _003C_003E9__1_0;

		[Token(Token = "0x4004322")]
		[FieldOffset(Offset = "0x10")]
		public static Func<Resolution, Resolution> _003C_003E9__2_0;

		[Token(Token = "0x6003A3E")]
		[Address(RVA = "0x183EA24", Offset = "0x183EA24", VA = "0x183EA24")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6003A3F")]
		[Address(RVA = "0x183EA2C", Offset = "0x183EA2C", VA = "0x183EA2C")]
		internal string _003CSupportedResolutionsAsString_003Eb__1_0(Resolution r)
		{
			return null;
		}

		[Token(Token = "0x6003A40")]
		[Address(RVA = "0x183EC58", Offset = "0x183EC58", VA = "0x183EC58")]
		internal Resolution _003CSupportedResolutions_003Eb__2_0(Resolution r)
		{
			return default;
		}
	}

	[Token(Token = "0x2000C31")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44000", Offset = "0x44000")]
	private sealed class _003C_003Ec__DisplayClass2_0
	{
		[Token(Token = "0x6003A41")]
		[Address(RVA = "0x183ECA0", Offset = "0x183ECA0", VA = "0x183ECA0")]
		public _003C_003Ec__DisplayClass2_0()
		{
		}
	}

	[Token(Token = "0x2000C32")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44010", Offset = "0x44010")]
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		[Token(Token = "0x4004323")]
		[FieldOffset(Offset = "0x10")]
		public FullScreenMode mode;

		[Token(Token = "0x4004324")]
		[FieldOffset(Offset = "0x14")]
		public Resolution wr;

		[Token(Token = "0x6003A42")]
		[Address(RVA = "0x183ECA8", Offset = "0x183ECA8", VA = "0x183ECA8")]
		public _003C_003Ec__DisplayClass3_0()
		{
		}

		[Token(Token = "0x6003A43")]
		[Address(RVA = "0x183ECB0", Offset = "0x183ECB0", VA = "0x183ECB0")]
		internal _003C_003Ef__AnonymousType1<Resolution, int> _003CClosestMathcingResolution_003Eb__0(Resolution item, int index)
		{
			return null;
		}

		[Token(Token = "0x6003A44")]
		[Address(RVA = "0x183ED6C", Offset = "0x183ED6C", VA = "0x183ED6C")]
		internal int _003CClosestMathcingResolution_003Eb__1(_003C_003Ef__AnonymousType1<Resolution, int> item)
		{
			return default;
		}
	}

	[Token(Token = "0x6003A35")]
	[Address(RVA = "0x167CB9C", Offset = "0x167CB9C", VA = "0x167CB9C")]
	private static Resolution WindowSize()
	{
		return default;
	}

	[Token(Token = "0x6003A36")]
	[Address(RVA = "0x167CBF4", Offset = "0x167CBF4", VA = "0x167CBF4")]
	public static List<string> SupportedResolutionsAsString()
	{
		return null;
	}

	[Token(Token = "0x6003A37")]
	[Address(RVA = "0x167CD54", Offset = "0x167CD54", VA = "0x167CD54")]
	public static IEnumerable<Resolution> SupportedResolutions()
	{
		return null;
	}

	[Token(Token = "0x6003A38")]
	[Address(RVA = "0x167CEC0", Offset = "0x167CEC0", VA = "0x167CEC0")]
	public static Tuple<int, Resolution> ClosestMathcingResolution(FullScreenMode mode)
	{
		return null;
	}

	[Token(Token = "0x6003A39")]
	[Address(RVA = "0x167D204", Offset = "0x167D204", VA = "0x167D204")]
	public static Tuple<int, Resolution> ClosestMathcingResolution()
	{
		return null;
	}

	[Token(Token = "0x6003A3A")]
	[Address(RVA = "0x167D21C", Offset = "0x167D21C", VA = "0x167D21C")]
	public static void ChangeScreenMode(FullScreenMode newScreenMode)
	{
	}

	[Token(Token = "0x6003A3B")]
	[Address(RVA = "0x167D2C0", Offset = "0x167D2C0", VA = "0x167D2C0")]
	public static Resolution SelectedResolutionToActualResolution(Resolution r)
	{
		return default;
	}

	[Token(Token = "0x6003A3C")]
	[Address(RVA = "0x167D1FC", Offset = "0x167D1FC", VA = "0x167D1FC")]
	private static Resolution SelectedResolutionToActualResolution(Resolution r, FullScreenMode mode)
	{
		return default;
	}
}
