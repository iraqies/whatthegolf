using UnityEngine;

namespace Arena
{
	public class ArenaDroppableObject : ArenaDroppable
	{
		public enum OverlapType
		{
			OverlapBox = 0,
			OverlapSphere = 1
		}

		[SerializeField]
		private OverlapType overlapType;

		[SerializeField]
		private Vector3 overlapObjectSize;

		public override Collider[] GetHitColliders()
		{
			return null;
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}
