using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x2000050")]
	public class FollowTarget : MonoBehaviour
	{
		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 offset;

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x137357C", Offset = "0x137357C", VA = "0x137357C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x13735D8", Offset = "0x13735D8", VA = "0x13735D8")]
		public FollowTarget()
		{
		}
	}
}
