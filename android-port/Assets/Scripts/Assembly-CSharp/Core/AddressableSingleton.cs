using UnityEngine;

namespace Core
{
	public abstract class AddressableSingleton<T> : MonoBehaviour where T : MonoBehaviour
	{
		private static T _instance;

		public static bool Exists => _instance != null;

		public static T Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = Object.FindObjectOfType<T>();
					if (_instance == null)
					{
						var prefab = Resources.Load<T>(typeof(T).Name) ?? Resources.Load<T>("Prefabs/" + typeof(T).Name);
						if (prefab != null)
						{
							_instance = Object.Instantiate(prefab);
						}
						else
						{
							var go = new GameObject(typeof(T).Name);
							_instance = go.AddComponent<T>();
						}
						Object.DontDestroyOnLoad(_instance.gameObject);
						if (_instance is AddressableSingleton<T> singleton)
							singleton.Initialize();
					}
				}
				return _instance;
			}
			protected set => _instance = value;
		}

		public virtual void Initialize()
		{
		}
	}
}
