using Core;
using UnityEngine;

namespace Audio
{
	public class HarmonikaDyrAudioV2 : MonoBehaviour
	{
		public HarmonikaDyrShooter harmonika;

		public ADSREnvelope envelope;

		public AudioClip clipOut;

		public AudioClip clipIn;

		public int fullStretchNoteAmount;

		public int baseNote;

		public MusicMathUtils.Scale scale;

		public float maxNoteDuration;

		public float cooldown;

		public float maxSpeed;

		public int queued;

		private int[] m_notes;

		private int m_baseNote;

		private float maxDistance;

		private int randomBase;

		private float currDistance;

		private int lastNote;

		private float speed;

		private double length;

		private AudioSource audioSource;

		private float lastDist;

		private void Start()
		{
		}

		private int ReturnNote(int index)
		{
			return 0;
		}

		private void Update()
		{
		}
	}
}
