using System.Collections.Generic;
using Core;
using UnityEngine;

namespace GolfGames.Pinball
{
	public class PinballShooter : GolfBall2DShooterBase
	{
		[SerializeField]
		private float shootVelocity;

		[SerializeField]
		private AudioSource startShotAudio;

		[SerializeField]
		private AudioSource flipperAudio;

		[SerializeField]
		private ParticleSystem winParticles;

		[SerializeField]
		private PinballStartShooter pinballStartShooter;

		[SerializeField]
		private PinballFlipper[] flippers;

		[SerializeField]
		private Pinball ball;

		private float shootTimer;

		private float startMotorSpeed;

		private List<Pinball> balls;

		protected override void Awake()
		{
		}

		public override void OnShoot(Vector3 boost)
		{
		}

		private void Update()
		{
		}

		public void AddBall(Pinball ball)
		{
		}
	}
}
