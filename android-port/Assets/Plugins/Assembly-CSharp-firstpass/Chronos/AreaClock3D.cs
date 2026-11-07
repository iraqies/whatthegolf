using UnityEngine;

namespace Chronos
{
	[DisallowMultipleComponent]
	public class AreaClock3D : AreaClock<Collider, Vector3>
	{
		protected virtual void OnTriggerEnter(Collider other)
		{
		}

		protected virtual void OnTriggerExit(Collider collider)
		{
		}

		protected override float PointToEdgeTimeScale(Vector3 position)
		{
			return 0f;
		}

		public override bool ContainsPoint(Vector3 point)
		{
			return false;
		}

		public override void CacheComponents()
		{
		}
	}
}
