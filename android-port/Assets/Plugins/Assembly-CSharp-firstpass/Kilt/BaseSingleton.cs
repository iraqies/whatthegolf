using UnityEngine;

namespace Kilt
{
	public abstract class BaseSingleton : MonoBehaviour
	{
		private static bool s_enableSingletonCreation = true;

		public static bool EnableSingletonCreation
		{
			get => s_enableSingletonCreation;
			private set => s_enableSingletonCreation = value;
		}

		[RuntimeInitializeOnLoadMethod]
		private static void EnableInstanceCreation()
		{
			s_enableSingletonCreation = true;
		}
	}
}
