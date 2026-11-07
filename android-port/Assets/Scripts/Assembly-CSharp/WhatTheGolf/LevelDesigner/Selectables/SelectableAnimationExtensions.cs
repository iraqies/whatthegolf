using System;
using System.Collections;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner.Selectables
{
	public static class SelectableAnimationExtensions
	{
		public static float liftDropAnimSpeed;

		public static float liftAnimElevation;

		public static float scaleAnimDelay;

		public static float scaleAnimSpeed;

		public static float liftAnimDelay;

		private static float s_SwayAmount;

		private static float s_SmoothTime;

		private static Vector3 s_Velocity;

		private static Vector3 s_SmoothSway;

		public static void ApplyLiftAnimation(this Selectable selectable)
		{
		}

		public static void ApplyLiftAnimation(this Selectable selectable, float speed, float targetYOffset, Func<float, float> getYOffset, float delay = 0f)
		{
		}

		private static IEnumerator LiftAnimationProcess(Selectable selectable, float speed, float targetYOffset, Func<float, float> getYOffset, float delay = 0f)
		{
			return null;
		}

		public static void ApplyDropAnimation(this Selectable selectable, bool forceStartOffset)
		{
		}

		public static void ApplyDropAnimation(this Selectable selectable, float speed, Func<float, float> getYOffset, bool forceStartOffset)
		{
		}

		private static IEnumerator DropAnimationProcess(Selectable selectable, float speed, Func<float, float> getYOffset, bool forceStartOffset)
		{
			return null;
		}

		public static void ApplyVertexScaleAnimation(this Selectable selectable)
		{
		}

		public static void ApplyDeleteAnimation(this Selectable selectable, Action onComplete)
		{
		}

		public static void ApplyVertexScaleAnimation(this Selectable selectable, float speed, Func<float, Vector2> getScale, float delay = 0f, Action onComplete = null)
		{
		}

		private static IEnumerator VertexScaleAnimationProcess(Selectable selectable, float speed, Func<float, Vector2> getScale, float delay = 0f, Action onComplete = null)
		{
			return null;
		}

		private static IEnumerator Wait(float delay)
		{
			return null;
		}

		public static void SetSway(this Selectable selectable, Vector3 cursorDeltaWS, Vector3 pivotWS)
		{
		}
	}
}
