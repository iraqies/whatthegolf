namespace UnityEngine.ProBuilder
{
	[DisallowMultipleComponent]
	internal sealed class Entity : MonoBehaviour
	{
		[SerializeField]
		private EntityType m_EntityType;

		public EntityType entityType => EntityType.Detail;

		public void Awake()
		{
		}

		public void SetEntity(EntityType t)
		{
		}
	}
}
