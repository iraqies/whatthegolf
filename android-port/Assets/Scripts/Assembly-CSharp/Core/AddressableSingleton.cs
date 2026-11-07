using UnityEngine;

namespace Core
{
	public abstract class AddressableSingleton<T> : MonoBehaviour where T : MonoBehaviour
	{
		private static T _instance;

		public static bool Exists => false;

		public static T Instance
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public virtual void Initialize()
		{
		}
	}
}
