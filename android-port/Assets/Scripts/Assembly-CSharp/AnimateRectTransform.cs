using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimateRectTransform : MonoBehaviour
{
	public enum Property
	{
		sizeDelta = 0,
		position = 1,
		scale = 2,
		color = 3
	}

	[Serializable]
	public struct TransitionType
	{
		public float duration;
		public EasingFunction.Ease ease;
		public Property prop;
		public Graphic overrideColorGraphic;
	}

	[Serializable]
	[SerializeField]
	public struct RectState
	{
		public bool useSize;
		public Vector2 sizeDelta;
		public bool useScale;
		public Vector2 scale;
		public bool usePos;
		public Vector2 anchoredPos;
		public bool useColor;
		public Color color;
	}

	public bool disableOnHide;
	[SerializeField] private List<TransitionType> overrideTransition;
	private TransitionType defaultT;
	[SerializeField] public RectState HideState;
	[SerializeField] private RectState ShowState;
	[SerializeField] private bool alternate;
	[SerializeField] private List<RectState> AlternateStates;
	[SerializeField] private RectTransform overrideRectTransform;

	private RectTransform RectTransform => overrideRectTransform != null ? overrideRectTransform : GetComponent<RectTransform>();

	private Graphic Graphic(TransitionType transitionType)
	{
		return transitionType.overrideColorGraphic != null ? transitionType.overrideColorGraphic : GetComponent<Graphic>();
	}

	public float SetShow(bool s, bool instant = false)
	{
		if (s) gameObject.SetActive(true);
		RectState state = s ? ShowState : HideState;
		if (instant) SetInstant(state);
		else SetProps(state);
		if (!s && disableOnHide)
		{
			if (instant || !gameObject.activeInHierarchy) gameObject.SetActive(false);
			else StartCoroutine(DeactiveAfter(GetLongestTransition(state)));
		}
		return instant ? 0f : GetLongestTransition(state);
	}

	private void Deactivate() => gameObject.SetActive(false);

	public float Show() => SetShow(true, false);

	private IEnumerator AlternateAfter(float a)
	{
		yield return new WaitForSecondsRealtime(a);
		Alternate();
	}

	public float Hide() => SetShow(false, false);

	private void SetProps(RectState s) => SetInstant(s);

	private void SetInstant(RectState s)
	{
		var rt = RectTransform;
		if (rt != null)
		{
			if (s.useSize) rt.sizeDelta = s.sizeDelta;
			if (s.useScale) rt.localScale = new Vector3(s.scale.x, s.scale.y, 1f);
			if (s.usePos) rt.anchoredPosition = s.anchoredPos;
		}
		if (s.useColor)
		{
			var g = GetComponent<Graphic>();
			if (g != null) g.color = s.color;
		}
	}

	private IEnumerator DeactiveAfter(float t)
	{
		if (t > 0f) yield return new WaitForSecondsRealtime(t);
		if (disableOnHide) gameObject.SetActive(false);
	}

	public float GetLongestTransition(RectState s)
	{
		float max = 0.2f;
		if (overrideTransition != null)
		{
			foreach (var tr in overrideTransition)
				if (tr.duration > max) max = tr.duration;
		}
		return max;
	}

	private TransitionType GetTransitionLength(Property p)
	{
		if (overrideTransition != null)
		{
			foreach (var tr in overrideTransition)
				if (tr.prop == p) return tr;
		}
		return defaultT;
	}

	private void SetProp(Property p, Vector2 end) { }
	private void SetProp(Property p, Color c) { }
	private void Alternate() { }
	private IEnumerator AlternateCR() { yield break; }
}
