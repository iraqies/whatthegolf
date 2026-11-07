using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SaloonPiano
{
	public class NoteTarget : MonoBehaviour
	{
		public LayerMask AcceptedLayers;

		[CompilerGenerated]
		private Action m_OnHit;

		public GameObject notHitRoot;

		public GameObject notHitCorrectRoot;

		public GameObject notHitWrongRoot;

		public GameObject hitRoot;

		public ParticleSystem hitParticleSystem;

		private bool hasBeenHit;

		private bool isWrong;

		public event Action OnHit
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void Initialize(bool isWrong)
		{
		}

		private void OnCollisionEnter(Collision collision)
		{
		}
	}
}
