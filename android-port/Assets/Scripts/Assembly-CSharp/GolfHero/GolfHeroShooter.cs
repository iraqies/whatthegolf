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
		private AnimationCurve bounceCurve = AnimationCurve.Constant(0f, 1f, 0f);

		public float laneSpacing = 6f;

		public int numberOfLanes = 4;

		private float horizontalSpeed = 30f;

		private int lane_target;

		private float pos_x_target;

		private Vector3 pos;

		private float beatPerBounce = 1f;

		private float bounceHeight = 3f;

		public int Lane => lane;

		public void SetSequencer(GolfHeroSequencer _sequencer)
		{
			sequencer = _sequencer;
		}

		private void Awake()
		{
			lane_target = lane;
			pos_x_target = LaneToX(lane);
			pos = new Vector3(pos_x_target, 0f, 0f);
		}

		public override void OnShoot(Vector3 boost)
		{
			if (Mathf.Abs(boost.x) <= 0.1f)
				return;

			float sign = Mathf.Sign(boost.x);
			int dir = (sign == float.PositiveInfinity) ? 0 : (int)sign;
			float targetSign = Mathf.Sign(lane_target - lane);
			int baseLane = (targetSign == sign) ? lane : lane_target;
			int newTarget = Mathf.Clamp(baseLane + dir, 0, numberOfLanes - 1);
			if (newTarget != lane_target)
			{
				lane_target = newTarget;
				pos_x_target = LaneToX(newTarget);
			}
		}

		public void Update()
		{
			pos.x = Mathf.MoveTowards(pos.x, pos_x_target, horizontalSpeed * Time.deltaTime);
			if (lane != lane_target && pos_x_target == pos.x)
			{
				lane = lane_target;
			}
			if (sequencer != null && bounceCurve != null)
			{
				double elapsed = sequencer.Time;
				float cycleTime = beatPerBounce * sequencer.TimePerBeat;
				if (cycleTime > 0f)
				{
					float t = (float)((elapsed % cycleTime) / cycleTime);
					pos.y = bounceHeight * bounceCurve.Evaluate(t);
				}
			}
			base.transform.localPosition = pos;
		}

		public float LaneToX(int index)
		{
			return laneSpacing * index + laneSpacing * ((numberOfLanes - 1) * -0.5f);
		}
	}
}
