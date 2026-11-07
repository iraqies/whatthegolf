using Il2CppDummyDll;
using UnityEngine;

namespace NaughtyAttributes.Test
{
	[Token(Token = "0x2000041")]
	public class ShowNonSerializedFieldTest : MonoBehaviour
	{
		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x18")]
		private int myInt;

		[Token(Token = "0x40000A8")]
		private const float PI = 3.14159f;

		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Vector3 CONST_VECTOR;

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x22ABD20", Offset = "0x22ABD20", VA = "0x22ABD20")]
		public ShowNonSerializedFieldTest()
		{
		}
	}
}
