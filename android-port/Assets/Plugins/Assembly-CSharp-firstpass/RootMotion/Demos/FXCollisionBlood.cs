using RootMotion.Dynamics;
using UnityEngine;

namespace RootMotion.Demos
{
	public class FXCollisionBlood : MonoBehaviour
	{
		public BehaviourPuppet puppet;

		public float minCollisionImpulse;

		public int emission;

		public float emissionImpulseAdd;

		public int maxEmission;

		private ParticleSystem particles;

		private void Start()
		{
		}

		private void OnCollisionImpulse(MuscleCollision m, float impulse)
		{
		}

		private void OnDestroy()
		{
		}
	}
}
