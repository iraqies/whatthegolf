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

		public MinMax In;

		public MinMax Out;

		public bool outputZeroBelowMin;

		public float value;

		public ValueOperation valueOperation;

		public Action OnChange;

		public void Init()
		{
		}

		private void SetValue(float _input)
		{
		}
	}
}
