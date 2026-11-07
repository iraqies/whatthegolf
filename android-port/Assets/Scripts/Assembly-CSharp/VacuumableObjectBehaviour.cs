using System.Collections.Generic;
using Audio;
using UnityEngine;

public class VacuumableObjectBehaviour : MonoBehaviour
{
	[SerializeField]
	private ClipSettingsCollection OnDestroyAudio;

	[SerializeField]
	private ParticleSystem OnDestroyParticles;

	[SerializeField]
	private float ChangeScale;

	[SerializeField]
	private float InDuraction;

	[SerializeField]
	private float OutDuration;

	[SerializeField]
	private AnimationCurve curve;

	private Vector3 OrgSize;

	private List<Collider> colliders;

	private void Start()
	{
	}

	private void BeforeDestroy()
	{
	}

	private void DisableAllColliders()
	{
	}
}
