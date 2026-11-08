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
	private TransitionType defaultT = new TransitionType { duration = 0.25f, ease = EasingFunction.Ease.EaseOutQuad };
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
		if (instant)
		{
			RectState state = s ? ShowState : HideState;
			SetInstant(state);
			if (!s && disableOnHide && gameObject != null)
				gameObject.SetActive(false);
			return 0f;
		}
		return s ? Show() : Hide();
	}

	private void Deactivate()
	{
		if (disableOnHide && gameObject != null)
			gameObject.SetActive(false);
	}

	public float Show()
	{
		StopAllCoroutines();
		SetInstant(HideState);
		if (gameObject != null)
			gameObject.SetActive(true);
		if (gameObject != null && gameObject.activeInHierarchy)
		{
			SetProps(ShowState);
			float dur = GetLongestTransition(ShowState);
			if (alternate)
				StartCoroutine(AlternateAfter(dur));
			return dur;
		}
		SetInstant(ShowState);
		return 0f;
	}

	private IEnumerator AlternateAfter(float a)
	{
		if (a > 0f)
			yield return new WaitForSecondsRealtime(a);
		Alternate();
	}

	public float Hide()
	{
		StopAllCoroutines();
		if (gameObject != null && gameObject.activeInHierarchy)
		{
			float dur = GetLongestTransition(HideState);
			SetProps(HideState);
			StartCoroutine(DeactiveAfter(dur));
			return dur;
		}
		SetInstant(HideState);
		return 0f;
	}

	private void SetProps(RectState s)
	{
		if (s.useColor)
			SetProp(Property.color, s.color);
		if (s.usePos)
			SetProp(Property.position, s.anchoredPos);
		if (s.useSize)
			SetProp(Property.sizeDelta, s.sizeDelta);
		if (s.useScale)
			SetProp(Property.scale, s.scale);
	}

	private void SetInstant(RectState s)
	{
		var rt = RectTransform;
		if (rt != null)
		{
			if (s.useSize) rt.sizeDelta = s.sizeDelta;
			if (s.usePos) rt.anchoredPosition = s.anchoredPos;
			if (s.useScale) rt.localScale = new Vector3(s.scale.x, s.scale.y, 1f);
		}
		if (s.useColor)
		{
			var g = GetComponent<Graphic>();
			if (g != null) g.color = s.color;
		}
	}

	private IEnumerator DeactiveAfter(float t)
	{
		if (t > 0f)
			yield return new WaitForSecondsRealtime(t);
		Deactivate();
	}

	public float GetLongestTransition(RectState s)
	{
		float max = 0f;
		if (s.useColor)
			max = Mathf.Max(GetTransitionLength(Property.color).duration, max);
		if (s.usePos)
			max = Mathf.Max(GetTransitionLength(Property.position).duration, max);
		if (s.useSize)
			max = Mathf.Max(GetTransitionLength(Property.sizeDelta).duration, max);
		if (s.useScale)
			max = Mathf.Max(GetTransitionLength(Property.scale).duration, max);
		return max <= 0f ? 0.25f : max;
	}

	private TransitionType GetTransitionLength(Property p)
	{
		if (overrideTransition != null)
		{
			for (int i = 0; i < overrideTransition.Count; i++)
			{
				if (overrideTransition[i].prop == p)
					return overrideTransition[i];
			}
		}
		return new TransitionType { duration = 0.25f, ease = EasingFunction.Ease.EaseOutQuad, prop = p };
	}

	private void SetProp(Property p, Vector2 end)
	{
		var rt = RectTransform;
		if (rt == null || !isActiveAndEnabled)
			return;
		var tr = GetTransitionLength(p);
		float dur = tr.duration > 0f ? tr.duration : 0.2f;
		var easeFn = EasingFunction.GetEasingFunction(tr.ease);
		if (p == Property.sizeDelta)
		{
			Vector2 start = rt.sizeDelta;
			StartCoroutine(pTween.ToRealTime(dur, t =>
			{
				if (rt != null)
				{
					float et = easeFn != null ? easeFn(0f, 1f, t) : t;
					rt.sizeDelta = Vector2.LerpUnclamped(start, end, et);
				}
			}));
		}
		else if (p == Property.position)
		{
			Vector2 start = rt.anchoredPosition;
			StartCoroutine(pTween.ToRealTime(dur, t =>
			{
				if (rt != null)
				{
					float et = easeFn != null ? easeFn(0f, 1f, t) : t;
					rt.anchoredPosition = Vector2.LerpUnclamped(start, end, et);
				}
			}));
		}
		else if (p == Property.scale)
		{
			Vector2 start = rt.localScale;
			StartCoroutine(pTween.ToRealTime(dur, t =>
			{
				if (rt != null)
				{
					float et = easeFn != null ? easeFn(0f, 1f, t) : t;
					Vector2 cur = Vector2.LerpUnclamped(start, end, et);
					rt.localScale = new Vector3(cur.x, cur.y, 1f);
				}
			}));
		}
	}

	private void SetProp(Property p, Color c)
	{
		if (!isActiveAndEnabled)
			return;
		var tr = GetTransitionLength(p);
		var g = Graphic(tr);
		if (g == null)
			return;
		float dur = tr.duration > 0f ? tr.duration : 0.2f;
		var easeFn = EasingFunction.GetEasingFunction(tr.ease);
		Color start = g.color;
		StartCoroutine(pTween.ToRealTime(dur, t =>
		{
			if (g != null)
			{
				float et = easeFn != null ? easeFn(0f, 1f, t) : t;
				g.color = Color.LerpUnclamped(start, c, et);
			}
		}));
	}

	private void Alternate()
	{
		if (AlternateStates != null && AlternateStates.Count > 0 && isActiveAndEnabled)
			StartCoroutine(AlternateCR());
	}

	private IEnumerator AlternateCR()
	{
		int idx = 0;
		while (AlternateStates != null && AlternateStates.Count > 0)
		{
			var st = AlternateStates[idx % AlternateStates.Count];
			SetProps(st);
			float d = GetLongestTransition(st);
			yield return new WaitForSecondsRealtime(Mathf.Max(0.1f, d));
			idx++;
		}
	}
}
