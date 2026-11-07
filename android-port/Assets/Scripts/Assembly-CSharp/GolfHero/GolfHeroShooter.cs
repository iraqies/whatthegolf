using Core;
using UnityEngine;

namespace GolfHero
{
	public class GolfHeroShooter : ShooterBase
	{
		[SerializeField]
		private int lane;

		[SerializeField]
		private GolfHeroSequencer sequencer;

		[SerializeField]
		private AnimationCurve bounceCurve;

		private float laneSpacing;

		private int numberOfLanes;

		private float horizontalSpeed;

		private int lane_target;

		private float pos_x_target;

		private Vector3 pos;

		private float beatPerBounce;

		private float bounceHeight;

		public int Lane => 0;

		public void SetSequencer(GolfHeroSequencer _sequencer)
		{
		}

		private void Awake()
		{
		}

		public override void OnShoot(Vector3 boost)
		{
		}

		public void Update()
		{
		}

		public float LaneToX(int index)
		{
			return 0f;
		}
	}
}
