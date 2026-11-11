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
	private float ChangeScale = 1f;

	[SerializeField]
	private float InDuraction = 0.2f;

	[SerializeField]
	private float OutDuration = 0.2f;

	[SerializeField]
	private AnimationCurve curve;

	private Vector3 OrgSize;

	private List<Collider> colliders;

	private void Start()
	{
		transform.localScale *= ChangeScale;
		OrgSize = transform.localScale;
		var destroyOob = gameObject.AddComponent<DestroyOnOutOfBounds>();
		if (destroyOob != null)
		{
			destroyOob.OnBeforeDestroy += BeforeDestroy;
			destroyOob.DestroyAfter = OutDuration + 0.01f;
		}
		colliders = new List<Collider>(GetComponentsInChildren<Collider>(true));
	}

	private void BeforeDestroy()
	{
		if (OnDestroyAudio != null)
		{
			OnDestroyAudio.Play(null, transform.position, 1f, 1f);
		}
		DisableAllColliders();
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

	private void DisableAllColliders()
	{
		if (colliders == null) return;
		for (int i = 0; i < colliders.Count; i++)
		{
			if (colliders[i] != null)
				colliders[i].enabled = false;
		}
	}
}
