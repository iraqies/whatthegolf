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
	private float ChangeScale = 1f;

	[SerializeField]
	private float InDuraction = 0.2f;

	[SerializeField]
	private float OutDuration = 0.2f;

	[SerializeField]
	private AnimationCurve curve;

	private Vector3 OrgSize;

	private void Start()
	{
		transform.localScale *= ChangeScale;
		OrgSize = transform.localScale;
		var destroyOob = gameObject.AddComponent<DestroyOnOutOfBounds>();
		if (destroyOob != null)
		{
			destroyOob.OnBeforeDestroy += BeforeDestry;
			destroyOob.DestroyAfter = OutDuration + 0.01f;
		}
		if (OnEnableAudio != null)
		{
			OnEnableAudio.Play(null, transform.position, 1f, 1f);
		}
		StartCoroutine(pTween.To(OutDuration, 0f, 1f, t =>
		{
			float eval = curve != null ? curve.Evaluate(t) : t;
			transform.localScale = Vector3.LerpUnclamped(Vector3.zero, OrgSize, eval);
		}));
	}

	private void BeforeDestry()
	{
		if (OnDestroyAudio != null)
		{
			OnDestroyAudio.Play(null, transform.position, 1f, 1f);
		}
		if (OnDestroyParticles != null)
		{
			OnDestroyParticles.Play();
		}
		StartCoroutine(pTween.To(OutDuration, 0f, 1f, t =>
		{
			float eval = curve != null ? curve.Evaluate(t) : t;
			transform.localScale = Vector3.LerpUnclamped(OrgSize, Vector3.zero, eval);
		}));
	}
}
