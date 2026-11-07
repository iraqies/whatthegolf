using Il2CppDummyDll;
using UnityEngine;

namespace NaughtyAttributes.Test
{
	[Token(Token = "0x2000031")]
	public class RequiredTest : MonoBehaviour
	{
		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x18")]
		public Transform trans0;

		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x20")]
		public RequiredNest1 nest1;

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x22ABC7C", Offset = "0x22ABC7C", VA = "0x22ABC7C")]
		public RequiredTest()
		{
		}
	}
}
