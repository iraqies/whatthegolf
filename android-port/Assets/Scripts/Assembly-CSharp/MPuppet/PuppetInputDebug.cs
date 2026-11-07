using Il2CppDummyDll;
using UnityEngine;

namespace MPuppet
{
	[Token(Token = "0x20011E0")]
	public class PuppetInputDebug : MonoBehaviour
	{
		[Token(Token = "0x4006005")]
		[FieldOffset(Offset = "0x18")]
		public MPuppetController puppet;

		[Token(Token = "0x4006006")]
		[FieldOffset(Offset = "0x20")]
		public MPuppetGrabBehaviour grab;

		[Token(Token = "0x60051C9")]
		[Address(RVA = "0x162C144", Offset = "0x162C144", VA = "0x162C144")]
		private void Awake()
		{
		}

		[Token(Token = "0x60051CA")]
		[Address(RVA = "0x162C248", Offset = "0x162C248", VA = "0x162C248")]
		public void Update()
		{
		}

		[Token(Token = "0x60051CB")]
		[Address(RVA = "0x162C3B8", Offset = "0x162C3B8", VA = "0x162C3B8")]
		public PuppetInputDebug()
		{
		}
	}
}
