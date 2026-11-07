using System.Collections.Generic;
using UnityEngine;

public class DestroyJointsOnCollision : MonoBehaviour
{
	public List<Joint> JointsToDestroy;

	public LayerMask CollisionLayer;

	private void OnCollisionEnter(Collision other)
	{
	}
}
