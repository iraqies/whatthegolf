using Il2CppDummyDll;
using UnityEngine;

namespace ch.sycoforge.Decal.Demo
{
	[Token(Token = "0x2000F4A")]
	public class ProxyRegister : MonoBehaviour
	{
		[Token(Token = "0x4005295")]
		[FieldOffset(Offset = "0x18")]
		public StaticProxyCollection ProxyCollection;

		[Token(Token = "0x6004770")]
		[Address(RVA = "0x1628808", Offset = "0x1628808", VA = "0x1628808")]
		private void Start()
		{
		}

		[Token(Token = "0x6004771")]
		[Address(RVA = "0x1628880", Offset = "0x1628880", VA = "0x1628880")]
		public ProxyRegister()
		{
		}
	}
}
