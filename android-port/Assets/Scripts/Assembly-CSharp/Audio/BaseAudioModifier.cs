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
		}

		protected virtual void OnValueChange(float _value)
		{
		}
	}
}
