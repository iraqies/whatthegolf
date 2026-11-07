using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20001A9")]
public class MainMenu2Navigator : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20001AA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DF90", Offset = "0x3DF90")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x400078B")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x400078C")]
		[FieldOffset(Offset = "0x8")]
		public static Func<Selectable, bool> _003C_003E9__4_0;

		[Token(Token = "0x400078D")]
		[FieldOffset(Offset = "0x10")]
		public static Func<Selectable, bool> _003C_003E9__5_0;

		[Token(Token = "0x400078E")]
		[FieldOffset(Offset = "0x18")]
		public static Func<Selectable, bool> _003C_003E9__6_0;

		[Token(Token = "0x400078F")]
		[FieldOffset(Offset = "0x20")]
		public static Func<Selectable, bool> _003C_003E9__7_0;

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x17F1AA0", Offset = "0x17F1AA0", VA = "0x17F1AA0")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x17F1AA8", Offset = "0x17F1AA8", VA = "0x17F1AA8")]
		internal bool _003CFindSelectableOnLeft_003Eb__4_0(Selectable s)
		{
			return default;
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0x17F1B50", Offset = "0x17F1B50", VA = "0x17F1B50")]
		internal bool _003CFindSelectableOnRight_003Eb__5_0(Selectable s)
		{
			return default;
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0x17F1BF8", Offset = "0x17F1BF8", VA = "0x17F1BF8")]
		internal bool _003CFindSelectableOnTop_003Eb__6_0(Selectable s)
		{
			return default;
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x17F1CA0", Offset = "0x17F1CA0", VA = "0x17F1CA0")]
		internal bool _003CFindSelectableOnBottom_003Eb__7_0(Selectable s)
		{
			return default;
		}
	}

	[Token(Token = "0x4000787")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<Selectable> left;

	[Token(Token = "0x4000788")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<Selectable> right;

	[Token(Token = "0x4000789")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private List<Selectable> up;

	[Token(Token = "0x400078A")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private List<Selectable> down;

	[Token(Token = "0x6000763")]
	[Address(RVA = "0x1557A08", Offset = "0x1557A08", VA = "0x1557A08")]
	public Selectable FindSelectableOnLeft()
	{
		return null;
	}

	[Token(Token = "0x6000764")]
	[Address(RVA = "0x1557E04", Offset = "0x1557E04", VA = "0x1557E04")]
	public Selectable FindSelectableOnRight()
	{
		return null;
	}

	[Token(Token = "0x6000765")]
	[Address(RVA = "0x1558110", Offset = "0x1558110", VA = "0x1558110")]
	public Selectable FindSelectableOnTop()
	{
		return null;
	}

	[Token(Token = "0x6000766")]
	[Address(RVA = "0x155841C", Offset = "0x155841C", VA = "0x155841C")]
	public Selectable FindSelectableOnBottom()
	{
		return null;
	}

	[Token(Token = "0x6000767")]
	[Address(RVA = "0x1558838", Offset = "0x1558838", VA = "0x1558838")]
	public void SortDown(Comparison<Selectable> comparer)
	{
	}

	[Token(Token = "0x6000768")]
	[Address(RVA = "0x155889C", Offset = "0x155889C", VA = "0x155889C")]
	public MainMenu2Navigator()
	{
	}
}
