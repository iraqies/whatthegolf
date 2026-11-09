using UnityEngine;

namespace Arena
{
	public class ArenaDroppableRock : ArenaDroppable
	{
		public float sphereCheckRadius;

		public GameObject[] CliffObjects;

		protected override void Awake()
	{
		base.Awake();
	}

		public override Collider[] GetHitColliders()
		{
			return null;
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}
