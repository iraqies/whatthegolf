using System.Collections;
using UnityEngine;

public class DoorBubble : MonoBehaviour
{
	private DoorBubbleState state;
	private Coroutine scaleCoroutine;
	private bool hasShot;
	private float maxBubbleScale = 1f;

	public DoorBubbleState State
	{
		set
		{
			state = value;
			if (maxBubbleScale <= 0.01f)
				SetBubbleScale();
			if (state == DoorBubbleState.Hidden)
			{
				if (scaleCoroutine != null)
				{
					StopCoroutine(scaleCoroutine);
					scaleCoroutine = null;
				}
				transform.localScale = Vector3.zero;
			}
			else if (state == DoorBubbleState.Visible)
			{
				if (scaleCoroutine != null)
				{
					StopCoroutine(scaleCoroutine);
					scaleCoroutine = null;
				}
				transform.localScale = Vector3.one * maxBubbleScale;
			}
			else if (state == DoorBubbleState.ShowOnHit)
			{
				if (scaleCoroutine == null)
					transform.localScale = Vector3.zero;
			}
		}
	}

	public void Init()
	{
		if (OverworldManager2d.HasInstance && OverworldManager2d.Instance != null)
		{
			OverworldManager2d.Instance.OnShoot += OnOverworldShoot;
		}
		SetBubbleScale();
		state = DoorBubbleState.Hidden;
		transform.localScale = Vector3.zero;
	}

	private void OnOverworldShoot()
	{
		hasShot = true;
	}

	public void UpdateBubbleSize()
	{
		if (state == DoorBubbleState.Visible)
		{
			SetBubbleScale();
			transform.localScale = Vector3.one * maxBubbleScale;
		}
	}

	private void SetBubbleScale()
	{
		var cfg = Core.PlatformSettings.Instance != null ? Core.PlatformSettings.Instance.GetCurrent() : null;
		bool enlarge = cfg != null && cfg.ShouldEnlargeSpeechBubble();
		maxBubbleScale = enlarge ? 2f : 1f;
	}

	public void Hit()
	{
		if (state == DoorBubbleState.Visible)
		{
			SetBubbleScale();
			transform.localScale = Vector3.one * maxBubbleScale;
		}
		else if (state == DoorBubbleState.ShowOnHit && scaleCoroutine == null && gameObject.activeInHierarchy)
		{
			scaleCoroutine = StartCoroutine(BubbleShow());
		}
	}

	private IEnumerator BubbleShow()
	{
		hasShot = false;
		SetBubbleScale();
		yield return StartCoroutine(pTween.To(0.2f, t =>
		{
			float s = Mathf.Lerp(0f, maxBubbleScale, t * t);
			transform.localScale = Vector3.one * s;
		}));
		float timer = 0f;
		while (!hasShot && timer < 2.5f)
		{
			timer += Time.deltaTime;
			yield return null;
		}
		yield return StartCoroutine(pTween.To(0.2f, t =>
		{
			float s = Mathf.Lerp(maxBubbleScale, 0f, t * t);
			transform.localScale = Vector3.one * s;
		}));
		scaleCoroutine = null;
	}

	private void OnEnable()
	{
		State = state;
	}
}
