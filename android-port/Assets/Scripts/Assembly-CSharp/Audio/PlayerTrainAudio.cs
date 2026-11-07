using Core;
using UnityEngine;

namespace Audio
{
	public class PlayerTrainAudio : MonoBehaviour
	{
		public GolfBallController golfBallController;

		public ClipSettingsCollection _soundOnFirstShot;

		public Metronome metronome;

		public int minTempo;

		public int maxTempo;

		public float minVelocity;

		public float maxVelocity;

		private TrainShooter trainShooter;

		private Rigidbody2D trainRigidbody2D;

		private bool playedInitialSound;

		private int lastTempo;

		private void Start()
		{
		}

		private void Train_OnShoot(Vector3 boost)
		{
		}

		private void Update()
		{
		}
	}
}
