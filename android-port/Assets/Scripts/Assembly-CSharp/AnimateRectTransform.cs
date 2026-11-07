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

	[SerializeField]
	private List<TransitionType> overrideTransition;

	private TransitionType defaultT;

	[SerializeField]
	public RectState HideState;

	[SerializeField]
	private RectState ShowState;

	[SerializeField]
	private bool alternate;

	[SerializeField]
	private List<RectState> AlternateStates;

	[SerializeField]
	private RectTransform overrideRectTransform;

	private RectTransform RectTransform => null;

	private Graphic Graphic(TransitionType transitionType)
	{
		return null;
	}

	public float SetShow(bool s, bool instant = false)
	{
		return 0f;
	}

	private void Deactivate()
	{
	}

	public float Show()
	{
		return 0f;
	}

	private IEnumerator AlternateAfter(float a)
	{
		return null;
	}

	public float Hide()
	{
		return 0f;
	}

	private void SetProps(RectState s)
	{
	}

	private void SetInstant(RectState s)
	{
	}

	private IEnumerator DeactiveAfter(float t)
	{
		return null;
	}

	public float GetLongestTransition(RectState s)
	{
		return 0f;
	}

	private TransitionType GetTransitionLength(Property p)
	{
		return default;
	}

	private void SetProp(Property p, Vector2 end)
	{
	}

	private void SetProp(Property p, Color c)
	{
	}

	private void Alternate()
	{
	}

	private IEnumerator AlternateCR()
	{
		return null;
	}
}
