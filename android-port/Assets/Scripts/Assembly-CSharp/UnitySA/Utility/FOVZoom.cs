using System;
using System.Collections;
using UnityEngine;

namespace UnitySA.Utility
{
	[Serializable]
	public class FOVZoom
	{
		public Camera Camera;

		public float originalFov;

		public float FOVIncrease;

		public float TimeToIncrease;

		public float TimeToDecrease;

		public AnimationCurve IncreaseCurve;

		public void Setup(Camera camera)
		{
		}

		private void CheckStatus(Camera camera)
		{
		}

		public IEnumerator FOVKickUp()
		{
			return null;
		}

		public IEnumerator FOVKickDown()
		{
			return null;
		}
	}
}
