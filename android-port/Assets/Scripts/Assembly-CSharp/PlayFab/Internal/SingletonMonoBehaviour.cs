using Il2CppDummyDll;
using UnityEngine;

namespace PlayFab.Internal
{
	[Token(Token = "0x20011C4")]
	public class SingletonMonoBehaviour<T> : MonoBehaviour where T : SingletonMonoBehaviour<T>
	{
		[Token(Token = "0x4005F79")]
		[FieldOffset(Offset = "0x0")]
		private static T _instance;

		[Token(Token = "0x4005F7A")]
		[FieldOffset(Offset = "0x0")]
		protected bool initialized;

		[Token(Token = "0x170008BC")]
		public static T instance
		{
			[Token(Token = "0x600513B")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600513C")]
		public static void CreateInstance()
		{
		}

		[Token(Token = "0x600513D")]
		public virtual void Awake()
		{
		}

		[Token(Token = "0x600513E")]
		protected virtual void Initialize()
		{
		}

		[Token(Token = "0x600513F")]
		public SingletonMonoBehaviour()
		{
		}
	}
}
