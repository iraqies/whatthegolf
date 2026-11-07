using System;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.ResourceManagement.Util
{
	[Serializable]
	public struct ObjectInitializationData
	{
		[SerializeField]
		private string m_Id;

		[SerializeField]
		private SerializedType m_ObjectType;

		[SerializeField]
		private string m_Data;

		public string Id => null;

		public SerializedType ObjectType => default;

		public string Data => null;

		public override string ToString()
		{
			return null;
		}

		public TObject CreateInstance<TObject>(string idOverride = null)
		{
			return default;
		}

		public AsyncOperationHandle GetAsyncInitHandle(ResourceManager rm, string idOverride = null)
		{
			return default;
		}
	}
}
