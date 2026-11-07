using UnityEngine;

namespace Kilt
{
	public abstract class BaseSingleton : MonoBehaviour
	{
		private static bool s_enableSingletonCreation;

		public static bool EnableSingletonCreation
		{
			get
			{
				return false;
			}
			private set
			{
			}
		}

		[RuntimeInitializeOnLoadMethod]
		private static void EnableInstanceCreation()
		{
		}
	}
}
