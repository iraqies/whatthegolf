using System.Collections;
using Triband.Core;
using UnityEngine;
using UnityEngine.UI;

public class KeepSelectionVisible : MonoBehaviour
{
	[SerializeField]
	private ScrollRect _scrollRect;

	[SerializeField]
	private AnimationCurveScriptableObj _animCurve;

	[SerializeField]
	private bool _isHorizontal;

	private GameObject _selected;

	private Coroutine _animateToPositionCR;

	private int _layoutWaitHack;

	private void Update()
	{
	}

	public void SnapToHorizontal(RectTransform target)
	{
	}

	private float GetOffset()
	{
		return 0f;
	}

	public void SnapToVertical(RectTransform target)
	{
	}

	private IEnumerator AnimateToPositionCR(Vector2 targetPos)
	{
		return null;
	}
}
