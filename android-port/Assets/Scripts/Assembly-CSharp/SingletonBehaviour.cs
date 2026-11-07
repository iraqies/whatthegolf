using UnityEngine;

public abstract class SingletonBehaviour<T> : MonoBehaviour where T : MonoBehaviour
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

	protected static T UnsafeInstance => null;

	public static bool IsCreated => false;

	protected static void InstantiateSingleton()
	{
	}

	protected void Awake()
	{
	}

	protected virtual void OnAwake()
	{
	}
}
