using System.Collections.Generic;
using UnityEngine;

namespace Audio
{
	public class IceSlideSimple : MonoBehaviour
	{
		public AudioSource audioSourcePrefab;

		public AudioClip[] loopClips;

		public List<AudioMaterial> slideForMaterial;

		public int maxSources;

		public List<string> debugVelocity;

		private Vector3 top;

		private AudioSource[] audioSources;

		private Dictionary<Rigidbody, AudioMaterialSettings> onIceDict;

		private List<Rigidbody> m_sortedRigids;

		private void Awake()
		{
		}

		private void FixedUpdate()
		{
		}

		private void OnCollisionEnter(Collision collision)
		{
		}

		private void OnCollisionExit(Collision collision)
		{
		}

		private void DoSort()
		{
		}

		private static int CompareByVelocity(Rigidbody x, Rigidbody y)
		{
			return 0;
		}
	}
}
