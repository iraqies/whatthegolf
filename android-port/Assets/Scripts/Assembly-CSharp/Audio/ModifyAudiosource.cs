using UnityEngine;

namespace Audio
{
	public abstract class ModifyAudiosource : BaseAudioModifierMultiple
	{
		public AudioSource source;

		public override void Initialize()
		{
			if (source == null)
				source = GetComponent<AudioSource>();
		}
	}
}
