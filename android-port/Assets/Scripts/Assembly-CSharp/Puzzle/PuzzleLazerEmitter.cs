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

		public int jointLimit;

		private LazerJoint[] lazers;

		public LocalClock BallClock { get; private set; }

		public void SetClock(LocalClock clock)
		{
		}

		public float GetDeltaTime()
		{
			return 0f;
		}

		public override void OnPrePlayOrPreCompile()
		{
		}

		private void Awake()
		{
		}

		public void Init()
		{
		}

		public override void OnBallEnter(OverworldBall2D ball)
		{
		}

		public override void OnBallLeave()
		{
		}

		public void SetEmission(bool emit)
		{
		}

		private void Update()
		{
		}
	}
}
