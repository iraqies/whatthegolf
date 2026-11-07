using Il2CppDummyDll;

namespace WwiseData
{
	[Token(Token = "0x2000FBA")]
	public class MusicCueElement
	{
		[Token(Token = "0x40053C7")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x54924", Offset = "0x54924")]
		private MusicCueName Name__BackingField;

		[Token(Token = "0x40053C8")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x54934", Offset = "0x54934")]
		private string Id__BackingField;

		[Token(Token = "0x40053C9")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x54944", Offset = "0x54944")]
		private MusicCuePropertyList PropertyList__BackingField;

		[Token(Token = "0x17000784")]
		[Attribute(Name = "JsonPropertyAttribute", RVA = "0x736A4", Offset = "0x736A4")]
		public MusicCuePropertyList PropertyList
		{
			[Token(Token = "0x60047E5")]
			[Address(RVA = "0x1585EA8", Offset = "0x1585EA8", VA = "0x1585EA8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED64", Offset = "0x6ED64")]
			get
			{
				return null;
			}
		}
	}
}
