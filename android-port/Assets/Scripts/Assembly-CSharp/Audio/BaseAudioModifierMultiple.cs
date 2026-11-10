using System.Collections.Generic;
using UnityEngine;

namespace Audio
{
	public abstract class BaseAudioModifierMultiple : MonoBehaviour
	{
		public List<AudioValueMapper> modifiers;

		public bool smooth;

		public float smoothTime;

		private float chainOutput;

		private float smooth_velocity;

		public float output;

		public float Gain { get; set; } = 1f;

		private void Awake()
		{
			Initialize();
			if (modifiers != null)
			{
				for (int i = 0; i < modifiers.Count; i++)
				{
					if (modifiers[i] != null)
					{
						modifiers[i].Init();
						modifiers[i].OnChange -= SetOutput;
						modifiers[i].OnChange += SetOutput;
					}
				}
			}
			SetOutput();
		}

		public virtual void Initialize()
		{
		}

		public void SetOutput()
		{
			if (modifiers == null) return;
			float accum = 0f;
			for (int i = 0; i < modifiers.Count; i++)
			{
				var m = modifiers[i];
				if (m == null) continue;
				switch (m.valueOperation)
				{
				case AudioValueMapper.ValueOperation.Add:
					accum += m.value;
					break;
				case AudioValueMapper.ValueOperation.Multiply:
					accum *= m.value;
					break;
				case AudioValueMapper.ValueOperation.Divide:
					if (m.value != 0f)
						accum /= m.value;
					break;
				}
			}
			chainOutput = accum * Gain;
		}

		private void Update()
		{
			if (smooth)
				output = Mathf.SmoothDamp(output, chainOutput, ref smooth_velocity, smoothTime);
			else
				output = chainOutput;
			UpdateModifier();
		}

		protected virtual void UpdateModifier()
		{
		}
	}
}
