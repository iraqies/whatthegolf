using System;
using UnityEngine.ResourceManagement.Util;

namespace UnityEngine.AddressableAssets.ResourceLocators
{
	[Serializable]
	public class ResourceLocationData
	{
		[SerializeField]
		private string[] m_Keys;

		[SerializeField]
		private string m_InternalId;

		[SerializeField]
		private string m_Provider;

		[SerializeField]
		private string[] m_Dependencies;

		[SerializeField]
		private SerializedType m_ResourceType;

		[SerializeField]
		private byte[] SerializedData;

		private object _Data;

		public string[] Keys => null;

		public string InternalId => null;

		public string Provider => null;

		public string[] Dependencies => null;

		public Type ResourceType => null;

		public object Data
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ResourceLocationData(string[] keys, string id, Type provider, Type t, string[] dependencies = null)
		{
		}
	}
}
