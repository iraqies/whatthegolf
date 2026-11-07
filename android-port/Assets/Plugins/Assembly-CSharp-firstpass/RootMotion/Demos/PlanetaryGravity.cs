using UnityEngine;

namespace RootMotion.Demos
{
	public class PlanetaryGravity : MonoBehaviour
	{
		public Planet planet;

		private const float G = 6.672E-11f;

		private Rigidbody _r;

		private Rigidbody r => null;

		private void FixedUpdate()
		{
		}

		private void ApplyGravity(Rigidbody r)
		{
		}
	}
}
