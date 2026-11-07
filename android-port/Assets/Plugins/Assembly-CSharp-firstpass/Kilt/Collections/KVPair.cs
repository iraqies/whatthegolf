using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Kilt.Collections
{
	[Serializable]
	[Token(Token = "0x200008F")]
	public class KVPair<TKey, TValue> : FoldOutStruct
	{
		[Token(Token = "0x400025A")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private TKey m_key;

		[Token(Token = "0x400025B")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private TValue m_value;

		[Token(Token = "0x17000056")]
		public TKey Key
		{
			[Token(Token = "0x60002A7")]
			get
			{
				return (TKey)null;
			}
			[Token(Token = "0x60002A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000057")]
		public TValue Value
		{
			[Token(Token = "0x60002A9")]
			get
			{
				return (TValue)null;
			}
			[Token(Token = "0x60002AA")]
			set
			{
			}
		}

		[Token(Token = "0x60002AB")]
		public KVPair()
		{
		}

		[Token(Token = "0x60002AC")]
		public override bool Equals(object p_value)
		{
			return default;
		}

		[Token(Token = "0x60002AD")]
		public override int GetHashCode()
		{
			return default;
		}
	}
}
