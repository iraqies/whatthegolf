using UnityEngine;

namespace Audio.Rumble
{
	public class PS5HapticsAudioPlayer : MonoBehaviour
	{
		private AudioSource[] m_AudioSources;

		private const int k_AudioSourceCount = 50;

		private int m_AudioSourceIndex;
	}
}
