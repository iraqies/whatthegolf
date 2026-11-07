using UnityEngine;

namespace Audio
{
	public class AudioValueObjectRotation : BaseAudioValue
	{
		[SerializeField]
		private Transform target;

		[SerializeField]
		private Vector3 axis;

		[SerializeField]
		private float smoothTime;

		private Quaternion lastRotation;

		private float smoothVelocity;

		protected override bool Use2D => false;

		public override string ValueInputName()
		{
			return null;
		}

		protected override void Initialize()
		{
		}

		private void Update()
		{
		}

		protected override void SetValue()
		{
		}
	}
}
