using UnityEngine;

namespace Chronos
{
	[DisallowMultipleComponent]
	public class AreaClock2D : AreaClock<Collider2D, Vector2>
	{
		protected virtual void OnTriggerEnter2D(Collider2D other)
		{
		}

		protected virtual void OnTriggerExit2D(Collider2D collider)
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
