using System.Collections;
using Core;
using UnityEngine;
using UnityEngine.Events;

public class ResetOnOutOfBounds : MonoBehaviour
{
	public UnityEvent AdditionalCalls;

	public bool UsePlayerOutOfBounds = true;

	public float Delay;

	public bool FailLevel;

	public Vector3 RandomResetPositionOffsetMin;

	public Vector3 RandomResetPositionOffsetMax;

	public bool doPopInAnimation;

	public Ease.Easing ease = (Ease.Easing)17;

	public float animationTime = 0.25f;

	private Vector3 startPos;

	private Quaternion startRot;

	private Rigidbody rigidbody;

	private bool resetting;

	private Vector3 baseScale;

	private void Start()
	{
		startPos = transform.position;
		startRot = transform.rotation;
		rigidbody = GetComponent<Rigidbody>();
		if (UsePlayerOutOfBounds && Level.HasInstance)
		{
			Level.Instance.OnReset += OnReset;
		}
		baseScale = transform.localScale;
	}

	private void OnReset()
	{
		resetting = false;
		if (FailLevel)
		{
			if (LevelManager.Exists && LevelManager.Instance.getIsReallyInLevel && Level.HasInstance)
			{
				Level.Instance.Fail(true, true, null, 0f, true, "OUT OF BOUNDS");
				return;
			}
			return;
		}
		transform.position = startPos;
		transform.rotation = startRot;
		if (RandomResetPositionOffsetMax.magnitude > 0f || RandomResetPositionOffsetMin.magnitude > 0f)
		{
			Vector3 pos = transform.position;
			float dx = Mathf.Lerp(RandomResetPositionOffsetMin.x, RandomResetPositionOffsetMax.x, Random.value);
			float dy = Mathf.Lerp(RandomResetPositionOffsetMin.y, RandomResetPositionOffsetMax.y, Random.value);
			float dz = Mathf.Lerp(RandomResetPositionOffsetMin.z, RandomResetPositionOffsetMax.z, Random.value);
			transform.position = new Vector3(pos.x + dx, pos.y + dy, pos.z + dz);
		}
		if (rigidbody != null && !rigidbody.isKinematic)
		{
			rigidbody.velocity = Vector3.zero;
			rigidbody.angularVelocity = Vector3.zero;
		}
		AdditionalCalls?.Invoke();
		if (doPopInAnimation && gameObject.activeInHierarchy)
		{
			StartCoroutine(PopInAnimation());
		}
	}

	private IEnumerator PopInAnimation()
	{
		float dur = animationTime > 0f ? animationTime : 0.25f;
		yield return StartCoroutine(pTween.To(dur, 0f, 1f, t =>
		{
			if (this != null)
				transform.localScale = baseScale * Ease.EaseByType(ease, 0f, 1f, t);
		}));
	}

	private void OnTriggerEnter(Collider other)
	{
		if (UsePlayerOutOfBounds || other == null) return;
		if (other.gameObject.CompareTag("OutOfBounds") || other.gameObject.CompareTag("OutOfBoundsReset") || other.gameObject.CompareTag("OutOfBoundsReload"))
		{
			if (Delay <= 0f || resetting)
			{
				OnReset();
			}
			else
			{
				resetting = true;
				StartCoroutine(pTween.To(Delay, 0f, 1f, _ => { }).Then(OnReset));
			}
		}
	}
}
