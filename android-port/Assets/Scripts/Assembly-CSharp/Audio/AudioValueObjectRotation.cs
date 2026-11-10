using UnityEngine;

namespace Audio
{
	public class AudioValueObjectRotation : BaseAudioValue
	{
		[SerializeField]
		private Transform target;

		[SerializeField]
		private Vector3 axis = new Vector3(0f, 0f, 1f);

		[SerializeField]
		private float smoothTime = 0.1f;

		private Quaternion lastRotation;

		private float smoothVelocity;

		protected override bool Use2D => false;

		public override string ValueInputName()
		{
			if (target != null)
				return string.Format("Rotation ({0})", target.name);
			return "Rotation";
		}

		protected override void Initialize()
		{
			if (target == null)
				target = transform;
		}

		private void Update()
		{
			if (target != null)
				SetValue();
		}

		protected override void SetValue()
		{
			if (target == null) return;
			float angle = Quaternion.Angle(target.rotation, lastRotation);
			value = Mathf.SmoothDamp(value, angle, ref smoothVelocity, smoothTime);
			base.SetValue();
			lastRotation = target.rotation;
		}
	}
}
