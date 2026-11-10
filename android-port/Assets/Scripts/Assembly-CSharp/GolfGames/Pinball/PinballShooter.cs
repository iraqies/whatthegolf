using System.Collections.Generic;
using Core;
using UnityEngine;

namespace GolfGames.Pinball
{
	public class PinballShooter : GolfBall2DShooterBase
	{
		[SerializeField]
		private float shootVelocity = 100f;

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
			balls = new List<Pinball>();
			balls.Add(ball);
		}

		public override void OnShoot(Vector3 boost)
		{
			if (balls != null)
			{
				foreach (Pinball b in balls)
				{
					if (b != null && b.BallInStarterPosition && ball != null && ball.Rigidbody != null && pinballStartShooter != null)
					{
						ball.Rigidbody.AddForce(pinballStartShooter.transform.forward * shootVelocity, ForceMode2D.Impulse);
						if (startShotAudio != null)
						{
							startShotAudio.Play();
						}
					}
				}
			}
			shootTimer = 0.1f;
			if (flipperAudio != null)
			{
				flipperAudio.Play();
			}
			if (flippers != null)
			{
				for (int i = 0; i < flippers.Length; i++)
				{
					if (flippers[i] != null)
					{
						flippers[i].Toggle(true);
					}
				}
			}
		}

		private void Update()
		{
			if (shootTimer <= 0f)
				return;

			shootTimer = Mathf.Max(0f, shootTimer - Time.deltaTime);
			if (shootTimer == 0f && flippers != null)
			{
				for (int i = 0; i < flippers.Length; i++)
				{
					if (flippers[i] != null && flippers[i].Joint != null)
					{
						JointMotor2D motor = flippers[i].Joint.motor;
						motor.motorSpeed = flippers[i].startMotorSpeed;
						flippers[i].Joint.motor = motor;
					}
				}
			}
		}

		public void AddBall(Pinball ball)
		{
			balls?.Add(ball);
		}
	}
}
