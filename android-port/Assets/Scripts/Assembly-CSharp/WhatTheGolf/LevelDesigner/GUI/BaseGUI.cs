using System;
using System.Collections;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner.GUI
{
	public abstract class BaseGUI : MonoBehaviour
	{
		[SerializeField]
		private RectTransform inTarget;

		[SerializeField]
		private RectTransform outTarget;

		[SerializeField]
		private RectTransform container;

		private Coroutine animCoroutine;

		private const float animStartOffset = 0.3f;

		private Canvas m_Canvas;

		public Canvas canvas => null;

		public abstract bool isActiveOnOpen { get; }

		public virtual bool hasFocus => false;

		public abstract void Init();

		protected void AnimateIn(Action onDone = null, float animDuration = 0.5f)
		{
		}

		protected void AnimateOut(Action onDone = null, float animDuration = 0.5f)
		{
		}

		private IEnumerator Animate(RectTransform startTarget, RectTransform endTarget, float animDuration, Func<float, float> easingMethod, Action onDone)
		{
			return null;
		}
	}
}
