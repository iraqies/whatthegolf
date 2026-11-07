using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x2000151")]
	public abstract class EndpointDiscoveryDataBase
	{
		[Token(Token = "0x4000551")]
		[FieldOffset(Offset = "0x10")]
		private bool _required;

		[Token(Token = "0x4000552")]
		[FieldOffset(Offset = "0x18")]
		private SortedDictionary<string, string> _identifiers;

		[Token(Token = "0x170002D2")]
		public virtual bool Required
		{
			[Token(Token = "0x6000AD7")]
			[Address(RVA = "0x11FBA68", Offset = "0x11FBA68", VA = "0x11FBA68", Slot = "4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000AD8")]
			[Address(RVA = "0x11FBA70", Offset = "0x11FBA70", VA = "0x11FBA70", Slot = "5")]
			protected set
			{
			}
		}

		[Token(Token = "0x170002D3")]
		public virtual SortedDictionary<string, string> Identifiers
		{
			[Token(Token = "0x6000AD9")]
			[Address(RVA = "0x11FBA78", Offset = "0x11FBA78", VA = "0x11FBA78", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000ADA")]
			[Address(RVA = "0x11FBA80", Offset = "0x11FBA80", VA = "0x11FBA80", Slot = "7")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000AD6")]
		[Address(RVA = "0x11FB9D4", Offset = "0x11FB9D4", VA = "0x11FB9D4")]
		protected EndpointDiscoveryDataBase(bool required)
		{
		}
	}
}
