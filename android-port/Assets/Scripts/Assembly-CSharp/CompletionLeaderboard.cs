using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CompletionLeaderboard : MonoBehaviour
{
	public bool doHide;

	public GameObject leaderboard;

	public Image background;

	public GameObject achievementsButton;

	public float transitionTime;

	public int outDy;

	private Vector3 inPos;

	private Vector3 outPos;

	private Color inColor;

	private Color outColor;

	private void OnEnable()
	{
		StartCoroutine(TransitionIn());
	}

	private void Awake()
	{
		if (leaderboard != null)
		{
			inPos = leaderboard.transform.localPosition;
			outPos = new Vector3(inPos.x, inPos.y + (float)outDy, inPos.z);
		}
		if (background != null)
		{
			inColor = background.color;
			outColor = new Color(0f, 0f, 0f, 0f);
		}
		if (achievementsButton != null)
		{
			achievementsButton.SetActive(value: false);
		}
	}

	public IEnumerator TransitionIn()
	{
		if (background != null)
		{
			Image component = background.GetComponent<Image>();
			if (component != null)
			{
				component.enabled = true;
			}
		}
		yield return StartCoroutine(pTween.ToRealTime(transitionTime, delegate(float t)
		{
			if (leaderboard != null)
			{
				float t2 = Mathf.Clamp01(TweenFunctions.EaseOut(t));
				leaderboard.transform.localPosition = Vector3.Lerp(outPos, inPos, t2);
			}
			if (background != null)
			{
				background.color = Color.Lerp(outColor, inColor, Mathf.Pow(t, 1.2f));
			}
		}));
	}

	public IEnumerator CoTransOutAndDisable()
	{
		if (background != null)
		{
			Image component = background.GetComponent<Image>();
			if (component != null)
			{
				component.enabled = false;
			}
		}
		yield return StartCoroutine(pTween.ToRealTime(transitionTime, delegate(float t)
		{
			if (leaderboard != null)
			{
				float t2 = Mathf.Clamp01(t);
				leaderboard.transform.localPosition = Vector3.Lerp(inPos, outPos, t2);
			}
			if (background != null)
			{
				background.color = Color.Lerp(inColor, outColor, Mathf.Pow(t, 1.2f));
			}
		}));
	}

	public void TransOutAndDisable()
	{
		StartCoroutine(CoTransOutAndDisable());
	}

	private void Update()
	{
		if (doHide)
		{
			StartCoroutine(CoTransOutAndDisable());
			doHide = false;
		}
	}

	public CompletionLeaderboard()
	{
		transitionTime = 0.5f;
		outDy = 600;
	}
}
