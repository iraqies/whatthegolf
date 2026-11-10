using System;
using UnityEngine;

namespace Audio
{
	[Serializable]
	public class AudioValueMapper
	{
		public enum ValueOperation
		{
			Add = 0,
			Multiply = 1,
			Divide = 2
		}

		[SerializeField]
		private BaseAudioValue audioValue;

		public float inputValue;

		public MinMax In = new MinMax(0f, 1f);

		public MinMax Out = new MinMax(0f, 1f);

		public bool outputZeroBelowMin;

		public float value;

		public ValueOperation valueOperation;

		public Action OnChange;

		public void Init()
		{
			if (audioValue != null)
			{
				audioValue.onValueChange -= SetValue;
				audioValue.onValueChange += SetValue;
			}
		}

		private void SetValue(float _input)
		{
			inputValue = _input;
			float mapped = 0f;
			if (!outputZeroBelowMin || In == null || _input >= In.min)
			{
				if (In != null && Out != null)
				{
					float t = (In.max != In.min) ? Mathf.Clamp01((_input - In.min) / (In.max - In.min)) : 0f;
					mapped = Mathf.Lerp(Out.min, Out.max, t);
				}
			}
			value = mapped;
			OnChange?.Invoke();
		}
	}
}
