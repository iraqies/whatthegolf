using UnityEngine;

namespace Audio
{
	public class OverworldLampSFX : MonoBehaviour
	{
		public float threshold = 15f;

		public OnCollisionAudioBase col;

		public PlayClipOnAudioEvent SFX;

		public float averageValue;

		private HingeJoint2D hinge;

		private float postCollisionCheckTime;

		private float collisionTime;

		public float lastJointAngle;

		private bool canCheck;

		private bool isGoingLeft;

		public bool crossedMiddle;

		private void Awake()
		{
			hinge = GetComponent<HingeJoint2D>();
			if (col != null)
			{
				col.OnAudioPlay -= Col_OnAudioPlay;
				col.OnAudioPlay += Col_OnAudioPlay;
			}
		}

		private void Col_OnAudioPlay()
		{
			collisionTime = Time.time;
			canCheck = true;
		}

		private void Update()
		{
			if (!canCheck || hinge == null)
				return;
			HandleSwing2();
		}

		private void HandleSwing2()
		{
			float angle = hinge.jointAngle;
			if ((lastJointAngle < 0f && angle >= 0f) || (lastJointAngle > 0f && angle <= 0f))
			{
				if (Mathf.Abs(hinge.jointSpeed) >= threshold && SFX != null)
				{
					SFX.Play(transform.position);
				}
				if (Mathf.Abs(hinge.jointSpeed) < threshold * 0.5f)
					canCheck = false;
			}
			lastJointAngle = angle;
		}
	}
}
