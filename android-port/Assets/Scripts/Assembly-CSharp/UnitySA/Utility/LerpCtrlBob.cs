using System;
using System.Collections;

namespace UnitySA.Utility
{
	[Serializable]
	public class LerpCtrlBob
	{
		public float BobDuration;

		public float BobAmount;

		private float m_Offset;

		public float Offset()
		{
			return 0f;
		}

		public IEnumerator DoBobCycle()
		{
			return null;
		}
	}
}
