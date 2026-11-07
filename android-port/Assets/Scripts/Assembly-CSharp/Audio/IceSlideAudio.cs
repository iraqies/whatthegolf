using System.Collections.Generic;
using UnityEngine;

namespace Audio
{
	public class IceSlideAudio : MonoBehaviour
	{
		public class SlideTarget
		{
			public Rigidbody[] allRigids;

			public List<Rigidbody> rigidsOnice;

			public SlideTarget(Rigidbody[] allRigids, Rigidbody initRigid)
			{
			}
		}

		public AudioSource audioSourcePrefab;

		public int maxSources;

		public float minForwardVelocity;

		public float maxForwardVelocity;

		public float maxVolume;

		public float minPitch;

		public float maxPitch;

		public ClipSettingsCollection sfxOneshotOnEnter;

		public AudioClip[] loopClips;

		public int iceCount;

		public int applicableIceCount;

		private AudioSource[] sources;

		private Dictionary<Rigidbody, SlideTarget> targetsOnIce;

		private List<KeyValuePair<Rigidbody, SlideTarget>> s;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void OnCollisionEnter(Collision collision)
		{
		}

		private void DoSort()
		{
		}

		private void OnCollisionExit(Collision collision)
		{
		}

		private static Rigidbody GetParentRigidbody(Rigidbody rigid)
		{
			return null;
		}
	}
}
