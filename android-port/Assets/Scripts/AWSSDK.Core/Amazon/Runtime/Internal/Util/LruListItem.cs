using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Util
{
	[Token(Token = "0x20001D8")]
	public class LruListItem<TKey, TValue>
	{
		[Token(Token = "0x4000726")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27948", Offset = "0x27948")]
		private TValue Value__BackingField;

		[Token(Token = "0x4000727")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27958", Offset = "0x27958")]
		private TKey Key__BackingField;

		[Token(Token = "0x4000728")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27968", Offset = "0x27968")]
		private LruListItem<TKey, TValue> Next__BackingField;

		[Token(Token = "0x4000729")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27978", Offset = "0x27978")]
		private LruListItem<TKey, TValue> Previous__BackingField;

		[Token(Token = "0x170003AC")]
		public TValue Value
		{
			[Token(Token = "0x6000E80")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B6D4", Offset = "0x2B6D4")]
			get
			{
				return (TValue)null;
			}
			[Token(Token = "0x6000E81")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B6E4", Offset = "0x2B6E4")]
			set
			{
			}
		}

		[Token(Token = "0x170003AD")]
		public TKey Key
		{
			[Token(Token = "0x6000E82")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B6F4", Offset = "0x2B6F4")]
			get
			{
				return (TKey)null;
			}
			[Token(Token = "0x6000E83")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B704", Offset = "0x2B704")]
			private set
			{
			}
		}

		[Token(Token = "0x170003AE")]
		public LruListItem<TKey, TValue> Next
		{
			[Token(Token = "0x6000E84")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B714", Offset = "0x2B714")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E85")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B724", Offset = "0x2B724")]
			set
			{
			}
		}

		[Token(Token = "0x170003AF")]
		public LruListItem<TKey, TValue> Previous
		{
			[Token(Token = "0x6000E86")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B734", Offset = "0x2B734")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E87")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B744", Offset = "0x2B744")]
			set
			{
			}
		}

		[Token(Token = "0x6000E88")]
		public LruListItem(TKey key, TValue value)
		{
		}
	}
}
