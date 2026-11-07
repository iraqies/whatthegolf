using UnityEngine;

namespace Audio
{
	public class OverworldLampSFX : MonoBehaviour
	{
		public float threshold;

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
		}

		private void Col_OnAudioPlay()
		{
		}

		private void Update()
		{
		}

		private void HandleSwing2()
		{
		}
	}
}
