using UnityEngine;

public abstract class WTGSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
	private static T instance;

	public static T Instance
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public static bool IsCreated => false;

	private void Awake()
	{
	}

	protected virtual void OnInit()
	{
	}
}
