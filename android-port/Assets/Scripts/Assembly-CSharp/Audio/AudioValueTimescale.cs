using UnityEngine;

namespace Audio
{
	public class AudioValueTimescale : BaseAudioValue
	{
		protected override bool Use2D => true;

		private void Update()
		{
			SetValue();
		}

		protected override void SetValue()
		{
			value = 1f - Time.timeScale;
			base.SetValue();
		}

		public override string ValueInputName()
		{
			return "Timescale";
		}
	}
}
