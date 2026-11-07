using UnityEngine;

namespace Chronos
{
	public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
	{
		private static T _instance;

		private static object _lock;

		private static bool destroyed;

		private static bool persistent;

		private static bool automatic;

		private static bool missing;

		public static bool instantiated => false;

		public static T instance => null;

		protected virtual void OnDestroy()
		{
		}

		protected Singleton(bool persistent, bool automatic)
		{
		}
	}
}
