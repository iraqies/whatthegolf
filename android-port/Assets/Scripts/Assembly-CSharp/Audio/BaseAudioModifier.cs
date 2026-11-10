using UnityEngine;

namespace Audio
{
	public abstract class BaseAudioModifier : MonoBehaviour
	{
		public float value;

		public float highestValue;

		public AudioSource source;

		public BaseAudioValue modifier;

		public float fadeSpeed;

		public float minModifierValue;

		public float maxModifierValue;

		public float minSoundValue;

		public float maxSoundValue;

		protected void Initialize()
		{
			if (source == null)
				source = GetComponent<AudioSource>();
			if (modifier == null)
				modifier = GetComponent<BaseAudioValue>();
			if (modifier != null)
			{
				modifier.onValueChange -= OnValueChange;
				modifier.onValueChange += OnValueChange;
			}
			if (source == null)
				source = GetComponent<AudioSource>();
		}

		protected virtual void OnValueChange(float _value)
		{
		}
	}
}
