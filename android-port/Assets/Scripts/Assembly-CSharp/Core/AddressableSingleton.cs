using Il2CppDummyDll;
using UnityEngine;

namespace Core
{
	[Token(Token = "0x2001426")]
	public abstract class AddressableSingleton<T> : MonoBehaviour where T : MonoBehaviour
	{
		[Token(Token = "0x4006CDD")]
		[FieldOffset(Offset = "0x0")]
		private static T _instance;

		[Token(Token = "0x17000AA1")]
		public static bool Exists
		{
			[Token(Token = "0x6005DC1")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000AA2")]
		public static T Instance
		{
			[Token(Token = "0x6005DC2")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005DC3")]
			protected set
			{
			}
		}

		[Token(Token = "0x6005DC4")]
		public virtual void Initialize()
		{
		}

		[Token(Token = "0x6005DC5")]
		protected AddressableSingleton()
		{
		}
	}
}
