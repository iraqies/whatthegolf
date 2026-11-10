using UnityEngine;

namespace Audio
{
	public class AudioValueSkidmark : BaseAudioValue
	{
		public Skidmarks skidmarks;

		public float smoothTime;

		private float lastIntensity;

		private float smoothVelocity;

		protected override bool Use2D => true;

		private void OnEnable()
		{
			if (skidmarks != null)
			{
				skidmarks.OnCreateSkidmark -= OnCreateSkidmark;
				skidmarks.OnCreateSkidmark += OnCreateSkidmark;
			}
		}

		private void OnDisable()
		{
			if (skidmarks != null)
				skidmarks.OnCreateSkidmark -= OnCreateSkidmark;
		}

		public override string ValueInputName()
		{
			return "Skidmark";
		}

		private void OnCreateSkidmark(float v)
		{
			if (smoothTime > 0f)
				value = Mathf.SmoothDamp(value, v, ref smoothVelocity, smoothTime);
			else
				value = v;
			SetValue();
		}

		private void LateUpdate()
		{
			value = Mathf.SmoothDamp(value, 0f, ref smoothVelocity, smoothTime);
			SetValue();
		}

		protected override void SetValue()
		{
			base.SetValue();
		}
	}
}
