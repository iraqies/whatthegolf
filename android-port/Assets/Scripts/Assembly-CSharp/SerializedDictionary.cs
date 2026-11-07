using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
internal class SerializedDictionary<TKey, TValue> : Dictionary<TKey, TValue>, ISerializationCallbackReceiver
{
	[Serializable]
	private struct SerializedDictItem
	{
		public TKey key;

		public TValue value;

		public SerializedDictItem(TKey key, TValue value)
		{
			this.key = default;
			this.value = default;
		}
	}

	[SerializeField]
	private List<SerializedDictItem> items;

	public virtual void OnBeforeSerialize()
	{
	}

	public virtual void OnAfterDeserialize()
	{
	}
}
