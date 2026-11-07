namespace UnityEngine.ResourceManagement.ResourceProviders
{
	public struct InstantiationParameters
	{
		private Vector3 m_Position;

		private Quaternion m_Rotation;

		private Transform m_Parent;

		private bool m_InstantiateInWorldPosition;

		private bool m_SetPositionRotation;

		public Vector3 Position => default;

		public Quaternion Rotation => default;

		public Transform Parent => null;

		public bool InstantiateInWorldPosition => false;

		public bool SetPositionRotation => false;

		public InstantiationParameters(Transform parent, bool instantiateInWorldSpace)
		{
			m_Position = default;
			m_Rotation = default;
			m_Parent = null;
			m_InstantiateInWorldPosition = false;
			m_SetPositionRotation = false;
		}

		public InstantiationParameters(Vector3 position, Quaternion rotation, Transform parent)
		{
			m_Position = default;
			m_Rotation = default;
			m_Parent = null;
			m_InstantiateInWorldPosition = false;
			m_SetPositionRotation = false;
		}

		public TObject Instantiate<TObject>(TObject source) where TObject : Object
		{
			return null;
		}
	}
}
