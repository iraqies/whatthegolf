using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Util
{
	[Token(Token = "0x20001D7")]
	public class LruList<TKey, TValue>
	{
		[Token(Token = "0x4000724")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27928", Offset = "0x27928")]
		private LruListItem<TKey, TValue> Head__BackingField;

		[Token(Token = "0x4000725")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27938", Offset = "0x27938")]
		private LruListItem<TKey, TValue> Tail__BackingField;

		[Token(Token = "0x170003AA")]
		public LruListItem<TKey, TValue> Head
		{
			[Token(Token = "0x6000E76")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B694", Offset = "0x2B694")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E77")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B6A4", Offset = "0x2B6A4")]
			private set
			{
			}
		}

		[Token(Token = "0x170003AB")]
		public LruListItem<TKey, TValue> Tail
		{
			[Token(Token = "0x6000E78")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B6B4", Offset = "0x2B6B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E79")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B6C4", Offset = "0x2B6C4")]
			private set
			{
			}
		}

		[Token(Token = "0x6000E7A")]
		public void Add(LruListItem<TKey, TValue> item)
		{
		}

		[Token(Token = "0x6000E7B")]
		public void Remove(LruListItem<TKey, TValue> item)
		{
		}

		[Token(Token = "0x6000E7C")]
		public void Touch(LruListItem<TKey, TValue> item)
		{
		}

		[Token(Token = "0x6000E7D")]
		public TKey EvictOldest()
		{
			return (TKey)null;
		}

		[Token(Token = "0x6000E7E")]
		internal void Clear()
		{
		}

		[Token(Token = "0x6000E7F")]
		public LruList()
		{
		}
	}
}
