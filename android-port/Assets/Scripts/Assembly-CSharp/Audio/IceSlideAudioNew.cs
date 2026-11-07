using System.Collections.Generic;
using UnityEngine;

namespace Audio
{
	public class IceSlideAudioNew : MonoBehaviour
	{
		public AudioClip[] loopClips;

		public AudioSource audioSourcePrefab;

		public int maxSources;

		public List<string> debugStrings;

		private AudioSource[] audioSources;

		private Dictionary<Rigidbody, RigidbodyHierarchyInfo> OnIceDict;

		private List<RigidbodyHierarchyInfo> m_sortedInfos;

		private void Awake()
		{
		}

		private void FixedUpdate()
		{
		}

		private void OnCollisionEnter(Collision collision)
		{
		}

		private void DoSort()
		{
		}

		private static int CompareByVelocity(RigidbodyHierarchyInfo x, RigidbodyHierarchyInfo y)
		{
			return 0;
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
