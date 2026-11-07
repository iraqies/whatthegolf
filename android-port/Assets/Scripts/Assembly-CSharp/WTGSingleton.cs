using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200058E")]
public abstract class WTGSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
	[Token(Token = "0x4001C67")]
	[FieldOffset(Offset = "0x0")]
	private static T instance;

	[Token(Token = "0x170002C1")]
	public static T Instance
	{
		[Token(Token = "0x600194C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600194D")]
		private set
		{
		}
	}

	[Token(Token = "0x170002C2")]
	public static bool IsCreated
	{
		[Token(Token = "0x600194E")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x600194F")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001950")]
	protected virtual void OnInit()
	{
	}

	[Token(Token = "0x6001951")]
	protected WTGSingleton()
	{
	}
}
