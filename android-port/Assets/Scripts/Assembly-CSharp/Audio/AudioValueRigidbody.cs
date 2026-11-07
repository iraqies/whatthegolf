using UnityEngine;

namespace Audio
{
	public class AudioValueRigidbody : BaseAudioValue
	{
		public enum RigidbodyValueListenType
		{
			VELOCITY_MAGNITUDE = 0,
			VELOCITY_X = 1,
			VELOCITY_Y = 2,
			VELOCITY_Z = 3,
			VELOCITY_XY_MAGNITUDE = 4,
			VELOCITY_XZ_MAGNITUDE = 5,
			ANGULAR_VELOCITY = 6,
			ANGULAR_VELOCITY_X = 7,
			ANGULAR_VELOCITY_Y = 8,
			ANGULAR_VELOCITY_Z = 9
		}

		public Rigidbody component3D;

		public Rigidbody2D component2D;

		public RigidbodyValueListenType listenType;

		protected override bool Use2D => false;

		private void Update()
		{
		}

		public override string ValueInputName()
		{
			return null;
		}

		protected override void SetValue()
		{
		}
	}
}
