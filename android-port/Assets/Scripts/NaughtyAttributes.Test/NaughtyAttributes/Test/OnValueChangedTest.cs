using UnityEngine;

namespace NaughtyAttributes.Test
{
	public class OnValueChangedTest : MonoBehaviour
	{
		public int int0;

		public OnValueChangedNest1 nest1;

		private void OnValueChangedMethod1(int oldValue, int newValue)
		{
		}

		private void OnValueChangedMethod2(int oldValue, int newValue)
		{
		}
	}
}
