using Il2CppDummyDll;
using UnityEngine;
using ZXing.Common;
using ZXing.Rendering;

namespace ZXing
{
	[Token(Token = "0x2000014")]
	public class Color32Renderer : IBarcodeRenderer<Color32[]>
	{
		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x21EF40", Offset = "0x21EF40")]
		private Color32 Foreground__BackingField;

		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x21EF50", Offset = "0x21EF50")]
		private Color32 Background__BackingField;

		[Token(Token = "0x1700000A")]
		public Color32 Foreground
		{
			[Token(Token = "0x600007F")]
			[Address(RVA = "0x2EAF444", Offset = "0x2EAF444", VA = "0x2EAF444")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x21F140", Offset = "0x21F140")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000080")]
			[Address(RVA = "0x2EAF44C", Offset = "0x2EAF44C", VA = "0x2EAF44C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x21F150", Offset = "0x21F150")]
			set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public Color32 Background
		{
			[Token(Token = "0x6000081")]
			[Address(RVA = "0x2EAF454", Offset = "0x2EAF454", VA = "0x2EAF454")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x21F160", Offset = "0x21F160")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000082")]
			[Address(RVA = "0x2EAF45C", Offset = "0x2EAF45C", VA = "0x2EAF45C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x21F170", Offset = "0x21F170")]
			set
			{
			}
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x2E9FF7C", Offset = "0x2E9FF7C", VA = "0x2E9FF7C")]
		public Color32Renderer()
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x2EAF464", Offset = "0x2EAF464", VA = "0x2EAF464", Slot = "4")]
		public Color32[] Render(BitMatrix matrix, BarcodeFormat format, string content, EncodingOptions options)
		{
			return null;
		}
	}
}
