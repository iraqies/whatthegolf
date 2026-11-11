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

		public float FOVIncrease = 3f;

		public float TimeToIncrease = 1f;

		public float TimeToDecrease = 1f;

		public AnimationCurve IncreaseCurve = AnimationCurve.Linear(0f, 0f, 1f, 1f);

		public void Setup(Camera camera)
		{
			CheckStatus(camera);
			Camera = camera;
			if (Camera != null)
			{
				originalFov = Camera.fieldOfView;
			}
		}

		private void CheckStatus(Camera camera)
		{
		}

		public IEnumerator FOVKickUp()
		{
			if (Camera == null)
			{
				yield break;
			}
			float t = Mathf.Abs((Camera.fieldOfView - originalFov) / Mathf.Max(0.01f, FOVIncrease));
			while (t < TimeToIncrease)
			{
				float norm = t / Mathf.Max(0.01f, TimeToIncrease);
				float eval = IncreaseCurve != null && IncreaseCurve.length > 0 ? IncreaseCurve.Evaluate(norm) : norm;
				Camera.fieldOfView = originalFov + eval * FOVIncrease;
				t += Time.deltaTime;
				yield return new WaitForEndOfFrame();
			}
		}

		public IEnumerator FOVKickDown()
		{
			if (Camera == null)
			{
				yield break;
			}
			float t = Mathf.Abs((Camera.fieldOfView - originalFov) / Mathf.Max(0.01f, FOVIncrease));
			while (t > 0f)
			{
				float norm = t / Mathf.Max(0.01f, TimeToDecrease);
				float eval = IncreaseCurve != null && IncreaseCurve.length > 0 ? IncreaseCurve.Evaluate(norm) : norm;
				Camera.fieldOfView = originalFov + eval * FOVIncrease;
				t -= Time.deltaTime;
				yield return new WaitForEndOfFrame();
			}
			Camera.fieldOfView = originalFov;
		}
	}
}
