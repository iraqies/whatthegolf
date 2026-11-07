using System.Collections.Generic;
using UnityEngine;

public class CollisionBasedParticles : MonoBehaviour
{
	[SerializeField]
	private List<ParticleSystem> particleSystems;

	[SerializeField]
	private float minImpuleMagnitude;

	[SerializeField]
	private int particlesToEmit;

	[SerializeField]
	private bool rotateWithCollision;

	[SerializeField]
	private bool moveToCollision;

	private void OnCollisionEnter(Collision c)
	{
	}
}
