using UnityEngine;

namespace UnityEngine.ProBuilder
{
	[DisallowMultipleComponent]
	internal sealed class Entity : MonoBehaviour
	{
		[SerializeField]
		private EntityType m_EntityType;

		public EntityType entityType => m_EntityType;

		public void Awake()
		{
			var r = GetComponent<MeshRenderer>();
			if (r != null && (m_EntityType == EntityType.Trigger || m_EntityType == EntityType.Collider))
			{
				r.enabled = false;
			}
		}

		public void SetEntity(EntityType t)
		{
			m_EntityType = t;
		}
	}
}
