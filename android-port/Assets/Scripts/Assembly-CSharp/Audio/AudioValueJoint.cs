using UnityEngine;

namespace Audio
{
	public class AudioValueJoint : BaseAudioValue
	{
		public enum JointValueListenType
		{
			ANCHOR_X = 0,
			ANCHOR_Y = 1,
			ANCHOR_Z = 2,
			ANCHOR_MAGNITUDE = 3
		}

		public Joint component3D;

		public Joint2D component2D;

		public JointValueListenType listenType;

		public bool useDelta;

		protected override bool Use2D => false;

		private void Update()
		{
		}

		protected override void SetValue()
		{
		}
	}
}
