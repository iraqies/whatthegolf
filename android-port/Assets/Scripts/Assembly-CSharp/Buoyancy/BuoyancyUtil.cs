using UnityEngine;

namespace Buoyancy
{
	public static class BuoyancyUtil
	{
		public static void SetColliderValues(Collider col, out Vector3 size, out Vector3 center, out Vector3 offset)
		{
			size = Vector3.zero;
			center = Vector3.zero;
			offset = Vector3.zero;
			if (col == null)
				return;

			BoxCollider boxCollider = col as BoxCollider;
			if (boxCollider != null)
			{
				center = boxCollider.center;
				size = boxCollider.size;
				offset = boxCollider.center;
				return;
			}

			CapsuleCollider capsuleCollider = col as CapsuleCollider;
			if (capsuleCollider != null)
			{
				offset = capsuleCollider.center;
				if (capsuleCollider.direction == 0)
				{
					size = new Vector3(capsuleCollider.height, capsuleCollider.radius, capsuleCollider.radius);
				}
				else if (capsuleCollider.direction == 1)
				{
					size = new Vector3(capsuleCollider.radius, capsuleCollider.height, capsuleCollider.radius);
				}
				else if (capsuleCollider.direction == 2)
				{
					size = new Vector3(capsuleCollider.radius, capsuleCollider.radius, capsuleCollider.height);
				}
				return;
			}

			SphereCollider sphereCollider = col as SphereCollider;
			if (sphereCollider != null)
			{
				offset = sphereCollider.center;
				size = Vector3.one * sphereCollider.radius;
			}
		}
	}
}
