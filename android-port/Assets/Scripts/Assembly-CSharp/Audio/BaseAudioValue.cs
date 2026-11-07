using System;
using UnityEngine;

namespace Audio
{
	public abstract class BaseAudioValue : MonoBehaviour
	{
		public bool alwaysSetValue;

		public bool forcePositiveValue;

		public bool transmitDelta;

		protected float value;

		protected float lastValue;

		protected float delta;

		private bool stopTransmitting;

		private bool isStopped;

		public Action<float> onValueChange;

		public float GetValue => 0f;

		protected abstract bool Use2D { get; }

		public virtual string ValueInputName()
		{
			return null;
		}

		private void Awake()
		{
		}

		protected virtual void Initialize()
		{
		}

		private void OnDisable()
		{
		}

		protected virtual void SetValue()
		{
		}
	}
}
