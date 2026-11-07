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

		public double Time => 0.0;

		public DanceMove DanceMove => null;

		public Transform Transform => null;

		public void Initialize(double time, DanceMove danceMove)
		{
		}
	}
}
