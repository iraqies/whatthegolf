using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DailyChallengePagination : MonoBehaviour
{
	[SerializeField]
	private List<SVGImage> icons;

	[SerializeField]
	private AnimateRectTransform container;

	[SerializeField]
	private Color on;

	[SerializeField]
	private Color off;

	private Coroutine ShowBarRoutine;

	public void Enable(int numberOfLevels)
	{
	}

	private IEnumerator ShowBar()
	{
		return null;
	}

	public void Disable()
	{
	}

	public void DisableInstantly()
	{
	}

	private void Start()
	{
	}

	private void SetIcons()
	{
	}

	public void CompleteIcon(int i)
	{
	}

	public void ActivateIcon(int i)
	{
	}

	private IEnumerator ActivateIconCR(SVGImage svg)
	{
		return null;
	}

	private void TweenColor(SVGImage img, Color c, float duration = 1f)
	{
	}
}
