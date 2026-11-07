using Core;
using UnityEngine;

namespace Audio.Rumble
{
	public class GenericImpactRumble : MonoBehaviour
	{
		private float minVelocity;

		private float maxVelocity;

		private float nextPlayTime;

		private GolfBallController ballController;

		private void Awake()
		{
		}

		private void OnCollisionEnter(Collision collision)
		{
		}

		private void OnCollisionEnter2D(Collision2D collision)
		{
		}

		private void HandleHit(float velocityMagnitude)
		{
		}
	}
}
