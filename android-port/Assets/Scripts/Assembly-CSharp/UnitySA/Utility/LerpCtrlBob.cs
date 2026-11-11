using System;
using System.Collections;
using UnityEngine;

namespace UnitySA.Utility
{
	[Serializable]
	public class LerpCtrlBob
	{
		public float BobDuration = 0.2f;

		public float BobAmount = 0.1f;

		private float m_Offset;

		public float Offset()
		{
			return m_Offset;
		}

		public IEnumerator DoBobCycle()
		{
			float t = 0f;
			float dur = Mathf.Max(0.01f, BobDuration);
			while (t < dur)
			{
				m_Offset = Mathf.Lerp(0f, BobAmount, t / dur);
				t += Time.deltaTime;
				yield return new WaitForFixedUpdate();
			}
			t = 0f;
			while (t < dur)
			{
				m_Offset = Mathf.Lerp(BobAmount, 0f, t / dur);
				t += Time.deltaTime;
				yield return new WaitForFixedUpdate();
			}
			m_Offset = 0f;
		}
	}
}
