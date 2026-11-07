using UnityEngine;

public abstract class WTGSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
	private static T instance;

	public static T Instance
	{
		get
		{
			if (instance == null)
			{
				instance = Object.FindObjectOfType<T>();
				if (instance == null)
				{
					var go = new GameObject(typeof(T).Name);
					instance = go.AddComponent<T>();
					Object.DontDestroyOnLoad(go);
				}
			}
			return instance;
		}
		private set => instance = value;
	}

	public static bool IsCreated => instance != null;

	private void Awake()
	{
		if (instance == null)
		{
			instance = this as T;
			Object.DontDestroyOnLoad(gameObject);
			OnInit();
		}
		else if (instance != this)
		{
			Object.Destroy(gameObject);
		}
	}

	protected virtual void OnInit()
	{
	}
}
