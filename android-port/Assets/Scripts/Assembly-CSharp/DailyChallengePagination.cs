using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DailyChallengePagination : MonoBehaviour
{
	[SerializeField]
	private List<SVGImage> icons;

	[SerializeField]
	private AnimateRectTransform container;

	[SerializeField]
	private Color on = Color.white;

	[SerializeField]
	private Color off = new Color(1f, 1f, 1f, 0.35f);

	private Coroutine ShowBarRoutine;

	private void Awake()
	{
		if (container != null)
			container.SetShow(false, true);
	}

	private void Start()
	{
		if (container != null)
			container.SetShow(false, true);
	}

	public void Enable(int numberOfLevels)
	{
		if (icons == null) return;
		for (int i = 0; i < icons.Count; i++)
		{
			if (icons[i] != null)
			{
				icons[i].gameObject.SetActive(i < numberOfLevels);
				icons[i].color = off;
			}
		}
		if (gameObject.activeInHierarchy)
			StartCoroutine(ShowBar());
	}

	private IEnumerator ShowBar()
	{
		if (container != null)
			container.SetShow(true, false);
		yield break;
	}

	public void Disable()
	{
		if (container != null)
			container.Hide();
	}

	public void DisableInstantly()
	{
		if (container != null)
		{
			container.gameObject.SetActive(false);
			container.Hide();
		}
	}

	private void SetIcons()
	{
		ActivateIcon(0);
	}

	public void CompleteIcon(int i)
	{
		if (ShowBarRoutine != null)
			StopCoroutine(ShowBarRoutine);
		if (icons == null || icons.Count == 0) return;
		int idx = Mathf.Clamp(i, 0, icons.Count - 1);
		TweenColor(icons[idx], on, 1f);
	}

	public void ActivateIcon(int i)
	{
		if (ShowBarRoutine != null)
			StopCoroutine(ShowBarRoutine);
		if (icons == null || icons.Count == 0) return;
		int idx = Mathf.Clamp(i, 0, icons.Count - 1);
		if (gameObject.activeInHierarchy)
			ShowBarRoutine = StartCoroutine(ActivateIconCR(icons[idx]));
	}

	private IEnumerator ActivateIconCR(SVGImage svg)
	{
		if (svg != null)
			svg.color = on;
		yield break;
	}

	private void TweenColor(SVGImage img, Color c, float duration = 1f)
	{
		if (img == null) return;
		Color start = img.color;
		if (gameObject.activeInHierarchy)
		{
			StartCoroutine(pTween.To(duration, 0f, 1f, t =>
			{
				if (img != null) img.color = Color.Lerp(start, c, t);
			}));
		}
		else
		{
			img.color = c;
		}
	}
}
