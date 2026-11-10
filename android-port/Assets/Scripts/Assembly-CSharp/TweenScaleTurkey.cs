using System.Collections;
using UnityEngine;

public class TweenScaleTurkey : MonoBehaviour
{
	[SerializeField]
	private GameObject totween;

	[SerializeField]
	private Vector3 from;

	[SerializeField]
	private AnimationCurve animationCurve;

	[SerializeField]
	private float duration;

	[SerializeField]
	private bool StartOnAwake;

	public ParticleSystem leafPoofParticles;

	public float scaleFactor;

	public GameObject leafAudio;

	public GameObject turkeyAudio;

	private SphereCollider leafStackCollider;

	private Vector3 to;

	private void Start()
	{
		to = Vector3.one * scaleFactor;
		if (totween == null)
		{
			totween = base.gameObject;
		}
		if (to == from)
		{
			from = base.transform.localScale;
		}
		if (StartOnAwake)
		{
			Scale();
		}
		leafStackCollider = GetComponent<SphereCollider>();
	}

	private void Update()
	{
		if (Vector3.Distance(base.transform.localScale, new Vector3(3f, 3f, 3f)) < 0.5f)
		{
			StartCoroutine(ScaleAllDown());
			Object.Destroy(leafPoofParticles);
			Object.Destroy(leafStackCollider);
			if (leafAudio != null)
			{
				leafAudio.SetActive(value: false);
			}
			if (turkeyAudio != null)
			{
				turkeyAudio.SetActive(value: true);
			}
		}
	}

	public void Scale()
	{
		if (totween != null && Vector3.Distance(totween.transform.localScale, Vector3.zero) >= 1f)
		{
			StartCoroutine(StartScaling());
			if (leafPoofParticles != null)
			{
				leafPoofParticles.transform.position = totween.transform.position;
				leafPoofParticles.Play();
			}
		}
	}

	private IEnumerator StartScaling()
	{
		float elapsed = 0f;
		while (elapsed < duration)
		{
			if (totween != null && animationCurve != null)
			{
				float t = Mathf.Clamp01(animationCurve.Evaluate(elapsed));
				totween.transform.localScale = Vector3.Lerp(from, from - to, t);
			}
			elapsed += Time.fixedDeltaTime * 2f;
			yield return null;
		}
		from = base.transform.localScale;
	}

	private IEnumerator ScaleAllDown()
	{
		float elapsed = 0f;
		while (elapsed < duration * 2f)
		{
			if (totween != null && animationCurve != null)
			{
				float t = Mathf.Clamp01(animationCurve.Evaluate(elapsed));
				totween.transform.localScale = Vector3.Lerp(from, Vector3.zero, t);
			}
			elapsed += Time.fixedDeltaTime * 2f;
			yield return null;
		}
	}

	public TweenScaleTurkey()
	{
		scaleFactor = 1f;
	}
}
