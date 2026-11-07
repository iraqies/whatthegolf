using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B3C")]
public abstract class SingletonBehaviour<T> : MonoBehaviour where T : MonoBehaviour
{
	[Token(Token = "0x4003EA6")]
	[FieldOffset(Offset = "0x0")]
	private static T instance;

	[Token(Token = "0x17000573")]
	public static T Instance
	{
		[Token(Token = "0x6003579")]
		get
		{
			return null;
		}
		[Token(Token = "0x600357A")]
		private set
		{
		}
	}

	[Token(Token = "0x17000574")]
	protected static T UnsafeInstance
	{
		[Token(Token = "0x600357B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000575")]
	public static bool IsCreated
	{
		[Token(Token = "0x600357C")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x600357D")]
	protected static void InstantiateSingleton()
	{
	}

	[Token(Token = "0x600357E")]
	protected void Awake()
	{
	}

	[Token(Token = "0x600357F")]
	protected virtual void OnAwake()
	{
	}

	[Token(Token = "0x6003580")]
	protected SingletonBehaviour()
	{
	}
}
