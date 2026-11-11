using UnityEngine;

namespace DanceOff
{
	public class DanceMoveIndicator : MonoBehaviour
	{
		private double time;

		private DanceMove danceMove;

		private Transform _transform;

		public AudioClip hitClip;

		private Sequencer sequencer;

		public double Time => time;

		public DanceMove DanceMove => danceMove;

		public Transform Transform => _transform != null ? _transform : (_transform = transform);

		public void Initialize(double time, DanceMove danceMove)
		{
			this.time = time;
			this.danceMove = danceMove;
			_transform = transform;
		}
	}
}
