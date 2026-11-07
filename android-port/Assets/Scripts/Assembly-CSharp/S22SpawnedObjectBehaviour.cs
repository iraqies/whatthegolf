using Audio;
using UnityEngine;

public class S22SpawnedObjectBehaviour : MonoBehaviour
{
	[SerializeField]
	private ClipSettingsCollection OnEnableAudio;

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

	private void Start()
	{
	}

	private void BeforeDestry()
	{
	}
}
