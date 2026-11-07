using Il2CppDummyDll;
using UnityEngine;
using ZXing.Rendering;

namespace ZXing
{
	[Token(Token = "0x2000009")]
	public class BarcodeWriter : BarcodeWriter<Color32[]>
	{
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x2E9FEC4", Offset = "0x2E9FEC4", VA = "0x2E9FEC4")]
		public BarcodeWriter()
		{
		}
	}
	[Token(Token = "0x200000A")]
	public class BarcodeWriter<TOutput> : BarcodeWriterGeneric
	{
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x21EF10", Offset = "0x21EF10")]
		private IBarcodeRenderer<TOutput> Renderer__BackingField;

		[Token(Token = "0x17000004")]
		public IBarcodeRenderer<TOutput> Renderer
		{
			[Token(Token = "0x600004E")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x21F0E0", Offset = "0x21F0E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600004F")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x21F0F0", Offset = "0x21F0F0")]
			set
			{
			}
		}

		[Token(Token = "0x6000050")]
		public TOutput Write(string contents)
		{
			return (TOutput)null;
		}

		[Token(Token = "0x6000051")]
		public BarcodeWriter()
		{
		}
	}
}
