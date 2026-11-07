using Il2CppDummyDll;
using UnityEngine;

namespace Menu.QuickMenu
{
	[Token(Token = "0x2001070")]
	public abstract class MissingComponent<T> : MonoBehaviour where T : MonoBehaviour
	{
		[Token(Token = "0x400569C")]
		[FieldOffset(Offset = "0x0")]
		protected T Component;

		[Token(Token = "0x60049B7")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60049B8")]
		protected abstract bool NullCheck();

		[Token(Token = "0x60049B9")]
		protected abstract void Replace();

		[Token(Token = "0x60049BA")]
		protected MissingComponent()
		{
		}
	}
}
