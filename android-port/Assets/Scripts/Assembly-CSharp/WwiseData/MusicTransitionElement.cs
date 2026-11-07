using Il2CppDummyDll;

namespace WwiseData
{
	[Token(Token = "0x2000FB4")]
	public class MusicTransitionElement
	{
		[Token(Token = "0x40053B6")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x54814", Offset = "0x54814")]
		private TransitionInfoUnion TransitionInfo__BackingField;

		[Token(Token = "0x40053B7")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x54824", Offset = "0x54824")]
		private MusicTransitionName Name__BackingField;

		[Token(Token = "0x40053B8")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x54834", Offset = "0x54834")]
		private string Id__BackingField;

		[Token(Token = "0x40053B9")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x54844", Offset = "0x54844")]
		private MusicClipPropertyList PropertyList__BackingField;

		[Token(Token = "0x40053BA")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x54854", Offset = "0x54854")]
		private MusicTransitionReferenceList ReferenceList__BackingField;

		[Token(Token = "0x1700077C")]
		[Attribute(Name = "JsonPropertyAttribute", RVA = "0x734C4", Offset = "0x734C4")]
		public TransitionInfoUnion TransitionInfo
		{
			[Token(Token = "0x60047DD")]
			[Address(RVA = "0x158BCE0", Offset = "0x158BCE0", VA = "0x158BCE0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ECE4", Offset = "0x6ECE4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700077D")]
		[Attribute(Name = "JsonPropertyAttribute", RVA = "0x734FC", Offset = "0x734FC")]
		public MusicTransitionName Name
		{
			[Token(Token = "0x60047DE")]
			[Address(RVA = "0x158BCEC", Offset = "0x158BCEC", VA = "0x158BCEC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ECF4", Offset = "0x6ECF4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700077E")]
		[Attribute(Name = "JsonPropertyAttribute", RVA = "0x73534", Offset = "0x73534")]
		public MusicClipPropertyList PropertyList
		{
			[Token(Token = "0x60047DF")]
			[Address(RVA = "0x158BCF4", Offset = "0x158BCF4", VA = "0x158BCF4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED04", Offset = "0x6ED04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700077F")]
		[Attribute(Name = "JsonPropertyAttribute", RVA = "0x7357C", Offset = "0x7357C")]
		public MusicTransitionReferenceList ReferenceList
		{
			[Token(Token = "0x60047E0")]
			[Address(RVA = "0x158BCFC", Offset = "0x158BCFC", VA = "0x158BCFC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED14", Offset = "0x6ED14")]
			get
			{
				return null;
			}
		}
	}
}
