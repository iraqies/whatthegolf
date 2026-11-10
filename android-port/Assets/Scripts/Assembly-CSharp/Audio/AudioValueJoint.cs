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

		protected override bool Use2D => component3D == null;

		private void Update()
		{
			if (component3D == null && component2D == null)
				return;
			SetValue();
		}

		protected override void SetValue()
		{
			switch (listenType)
			{
			case JointValueListenType.ANCHOR_X:
				value = (!Use2D && component3D != null) ? component3D.anchor.x : (component2D != null ? component2D.anchor.x : 0f);
				break;
			case JointValueListenType.ANCHOR_Y:
				value = (!Use2D && component3D != null) ? component3D.anchor.y : (component2D != null ? component2D.anchor.y : 0f);
				break;
			case JointValueListenType.ANCHOR_Z:
				value = (!Use2D && component3D != null) ? component3D.anchor.z : 0f;
				break;
			case JointValueListenType.ANCHOR_MAGNITUDE:
				value = (!Use2D && component3D != null) ? component3D.anchor.magnitude : (component2D != null ? component2D.anchor.magnitude : 0f);
				break;
			}
			transmitDelta = useDelta;
			base.SetValue();
		}
	}
}
