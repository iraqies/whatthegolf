using Il2CppDummyDll;
using UnityEngine;

namespace Chronos
{
	[Token(Token = "0x20002C2")]
	public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
	{
		[Token(Token = "0x40011B8")]
		[FieldOffset(Offset = "0x0")]
		private static T _instance;

		[Token(Token = "0x40011B9")]
		[FieldOffset(Offset = "0x0")]
		private static object _lock;

		[Token(Token = "0x40011BA")]
		[FieldOffset(Offset = "0x0")]
		private static bool destroyed;

		[Token(Token = "0x40011BB")]
		[FieldOffset(Offset = "0x0")]
		private static bool persistent;

		[Token(Token = "0x40011BC")]
		[FieldOffset(Offset = "0x0")]
		private static bool automatic;

		[Token(Token = "0x40011BD")]
		[FieldOffset(Offset = "0x0")]
		private static bool missing;

		[Token(Token = "0x1700026E")]
		public static bool instantiated
		{
			[Token(Token = "0x6001288")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700026F")]
		public static T instance
		{
			[Token(Token = "0x6001289")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600128A")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600128B")]
		protected Singleton(bool persistent, bool automatic)
		{
		}
	}
}
