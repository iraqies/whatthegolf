using UnityEngine;

namespace Arena
{
	public class ArenaDroppableRock : ArenaDroppable
	{
		public float sphereCheckRadius = 1.5f;

		public GameObject[] CliffObjects;

		protected override void Awake()
		{
			base.Awake();
		}

		public override Collider[] GetHitColliders()
		{
			return Physics.OverlapSphere(transform.position, Mathf.Max(0.25f, sphereCheckRadius));
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}
