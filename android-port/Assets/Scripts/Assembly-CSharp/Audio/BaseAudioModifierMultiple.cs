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

		public float Gain { get; set; }

		private void Awake()
		{
		}

		public virtual void Initialize()
		{
		}

		public void SetOutput()
		{
		}

		private void Update()
		{
		}

		protected virtual void UpdateModifier()
		{
		}
	}
}
