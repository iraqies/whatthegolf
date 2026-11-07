using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	[Token(Token = "0x20000D6")]
	public class TQ
	{
		[Token(Token = "0x4000476")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 t;

		[Token(Token = "0x4000477")]
		[FieldOffset(Offset = "0x1C")]
		public Quaternion q;

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x1318154", Offset = "0x1318154", VA = "0x1318154")]
		public TQ(Vector3 translation, Quaternion rotation)
		{
		}
	}
}
