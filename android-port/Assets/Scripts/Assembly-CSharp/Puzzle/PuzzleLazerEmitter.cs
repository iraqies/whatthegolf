using Chronos;
using UnityEngine;

namespace Puzzle
{
	public class PuzzleLazerEmitter : PuzzleObjectBase, ITimedPuzzleObject
	{
		[SerializeField]
		private LazerJoint initialLazer;

		[SerializeField]
		private AudioSource audioSource;

		private ParticleSystem emitterParticles;

		public int jointLimit = 3;

		private LazerJoint[] lazers;

		public LocalClock BallClock { get; private set; }

		public void SetClock(LocalClock clock)
		{
			BallClock = clock;
		}

		public float GetDeltaTime()
		{
			if (BallClock != null)
			{
				return BallClock.deltaTime;
			}
			return Time.deltaTime;
		}

		public override void OnPrePlayOrPreCompile()
		{
			base.OnPrePlayOrPreCompile();
			initialLazer = GetComponentInChildren<LazerJoint>();
			emitterParticles = GetComponentInChildren<ParticleSystem>();
		}

		private void Awake()
		{
			audioSource = GetComponent<AudioSource>();
			Init();
			SetEmission(false);
		}

		public void Init()
		{
			lazers = new LazerJoint[jointLimit];
			if (initialLazer != null && lazers.Length > 0)
			{
				lazers[0] = initialLazer;
			}
		}

		public override void OnBallEnter(OverworldBall2D ball)
		{
			isBallInArea = true;
			SetEmission(true);
		}

		public override void OnBallLeave()
		{
			isBallInArea = false;
			SetEmission(false);
		}

		public void SetEmission(bool emit)
		{
			Active = emit;
			if (emitterParticles != null)
			{
				emitterParticles.gameObject.SetActive(emit);
			}
			if (audioSource != null)
			{
				if (emit)
				{
					audioSource.Play();
				}
				else
				{
					audioSource.Stop();
				}
			}
			if (lazers == null)
			{
				return;
			}
			for (int i = 0; i < lazers.Length; i++)
			{
				if (lazers[i] != null)
				{
					lazers[i].SetJointEmission(emit);
				}
			}
		}

		private void Update()
		{
			if (lazers == null || !Active || jointLimit < 1)
			{
				return;
			}
			for (int i = 0; i < jointLimit; i++)
			{
				LazerJoint lazerJoint = lazers[i];
				if (lazerJoint == null)
				{
					continue;
				}
				if (i != 0 && (lazers[i - 1] == null || lazers[i - 1].exitPortal == null))
				{
					Object.Destroy(lazers[i].gameObject);
					lazers[i] = null;
				}
				else if (i < jointLimit - 1 && lazerJoint.exitPortal != null && lazers[i + 1] == null && lazerJoint.exitPortal.LinkedPortal != null)
				{
					SimplePortal linkedPortal = lazerJoint.exitPortal.LinkedPortal;
					LazerJoint lazerJoint2 = Object.Instantiate(initialLazer, linkedPortal.transform.position, linkedPortal.transform.localRotation);
					lazerJoint2.enterPortal = linkedPortal;
					lazers[i + 1] = lazerJoint2;
				}
			}
		}
	}
}
