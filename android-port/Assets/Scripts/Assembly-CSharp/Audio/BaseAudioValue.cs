using System;
using UnityEngine;

namespace Audio
{
	public abstract class BaseAudioValue : MonoBehaviour
	{
		public bool alwaysSetValue;

		public bool forcePositiveValue = true;

		public bool transmitDelta;

		protected float value;

		protected float lastValue;

		protected float delta;

		private bool stopTransmitting;

		private bool isStopped;

		public Action<float> onValueChange;

		public float GetValue => value;

		protected abstract bool Use2D { get; }

		public virtual string ValueInputName()
		{
			return name;
		}

		private void Awake()
		{
			Initialize();
		}

		protected virtual void Initialize()
		{
		}

		private void OnDisable()
		{
			value = 0f;
			onValueChange?.Invoke(0f);
		}

		protected virtual void SetValue()
		{
			if (forcePositiveValue)
				value = Mathf.Abs(value);
			delta = value - lastValue;
			if (stopTransmitting && !isStopped && transmitDelta)
			{
				onValueChange?.Invoke(0f);
				isStopped = true;
			}
			if (Mathf.Abs(value - lastValue) > 0.01f || alwaysSetValue)
			{
				stopTransmitting = false;
				isStopped = false;
				if (transmitDelta)
				{
					if (forcePositiveValue)
						delta = Mathf.Abs(delta);
					onValueChange?.Invoke(delta);
				}
				else
				{
					onValueChange?.Invoke(value);
				}
			}
			else
			{
				stopTransmitting = true;
			}
			lastValue = value;
		}
	}
}
