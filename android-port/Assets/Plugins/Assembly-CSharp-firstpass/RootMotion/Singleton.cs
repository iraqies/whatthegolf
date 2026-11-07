using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	[Token(Token = "0x20000EE")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x400052D")]
		[FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x170000D4")]
		public static T instance
		{
			[Token(Token = "0x6000607")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000608")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000609")]
		protected Singleton()
		{
		}
	}
}
