using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20008E9")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x41E30", Offset = "0x41E30")]
public class PlatformDependentCanvasScaling : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20008EA")]
	private struct CanvasSettings
	{
		[Token(Token = "0x40030C6")]
		[FieldOffset(Offset = "0x0")]
		public EPlatformType platform;

		[Token(Token = "0x40030C7")]
		[FieldOffset(Offset = "0x4")]
		public int canvasWidth;

		[Token(Token = "0x40030C8")]
		[FieldOffset(Offset = "0x8")]
		public int canvasHeigt;
	}

	[Token(Token = "0x20008EB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41E98", Offset = "0x41E98")]
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		[Token(Token = "0x40030C9")]
		[FieldOffset(Offset = "0x10")]
		public EPlatformType platform;

		[Token(Token = "0x600293C")]
		[Address(RVA = "0x1827574", Offset = "0x1827574", VA = "0x1827574")]
		public _003C_003Ec__DisplayClass3_0()
		{
		}

		[Token(Token = "0x600293D")]
		[Address(RVA = "0x182757C", Offset = "0x182757C", VA = "0x182757C")]
		internal bool _003CAwake_003Eb__1(CanvasSettings s)
		{
			return default;
		}
	}

	[Serializable]
	[Token(Token = "0x20008EC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41EA8", Offset = "0x41EA8")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40030CA")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40030CB")]
		[FieldOffset(Offset = "0x8")]
		public static Func<CanvasSettings, EPlatformType> _003C_003E9__3_0;

		[Token(Token = "0x600293F")]
		[Address(RVA = "0x1827564", Offset = "0x1827564", VA = "0x1827564")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002940")]
		[Address(RVA = "0x182756C", Offset = "0x182756C", VA = "0x182756C")]
		internal EPlatformType _003CAwake_003Eb__3_0(CanvasSettings s)
		{
			return default;
		}
	}

	[Token(Token = "0x40030C4")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<CanvasSettings> settings;

	[Token(Token = "0x40030C5")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private RectTransform childRectTransform;

	[Token(Token = "0x600293A")]
	[Address(RVA = "0x15E6D20", Offset = "0x15E6D20", VA = "0x15E6D20")]
	private void Awake()
	{
	}

	[Token(Token = "0x600293B")]
	[Address(RVA = "0x15E721C", Offset = "0x15E721C", VA = "0x15E721C")]
	public PlatformDependentCanvasScaling()
	{
	}
}
