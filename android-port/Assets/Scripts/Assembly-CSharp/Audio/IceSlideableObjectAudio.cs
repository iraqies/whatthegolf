using System.Collections.Generic;
using UnityEngine;

namespace Audio
{
	public class IceSlideableObjectAudio : MonoBehaviour
	{
		[SerializeField]
		private AudioMaterial m_AudioMaterial;

		[SerializeField]
		private Rigidbody m_Rigidbody;

		[SerializeField]
		private AudioSource m_AudioSource;

		[SerializeField]
		private MinMax m_VelocityRange;

		[SerializeField]
		private MinMax m_VolumeRange;

		[SerializeField]
		private MinMax m_PitchRange;

		private RigidbodyCollisionInfo rigidInfo;

		private List<GameObject> currentSurfaces;

		private List<AudioMaterial> mustIncludeMaterial;

		private float onSurfaceGain;

		private float velocityGain;

		private float targetVolume;

		private float targetPitch;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void OnRigidCollisionEnter(Collision obj)
		{
		}

		private void OnRigidCollisionExit(Collision obj)
		{
		}
	}
}
