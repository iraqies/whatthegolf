using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000B4B")]
internal class SerializedDictionary<TKey, TValue> : Dictionary<TKey, TValue>, ISerializationCallbackReceiver
{
	[Serializable]
	[Token(Token = "0x2000B4C")]
	private struct SerializedDictItem
	{
		[Token(Token = "0x4003ED5")]
		[FieldOffset(Offset = "0x0")]
		public TKey key;

		[Token(Token = "0x4003ED6")]
		[FieldOffset(Offset = "0x0")]
		public TValue value;

		[Token(Token = "0x60035B2")]
		public SerializedDictItem(TKey key, TValue value)
		{
		}
	}

	[Token(Token = "0x4003ED4")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	private List<SerializedDictItem> items;

	[Token(Token = "0x60035AF")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Token(Token = "0x60035B0")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Token(Token = "0x60035B1")]
	public SerializedDictionary()
	{
	}
}
