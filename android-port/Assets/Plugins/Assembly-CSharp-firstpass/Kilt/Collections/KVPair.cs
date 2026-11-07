using System;
using UnityEngine;

namespace Kilt.Collections
{
	[Serializable]
	public class KVPair<TKey, TValue> : FoldOutStruct
	{
		[SerializeField]
		private TKey m_key;

		[SerializeField]
		private TValue m_value;

		public TKey Key
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public TValue Value
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public override bool Equals(object p_value)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
