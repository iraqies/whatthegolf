using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x200005A")]
	public class SmoothFollow : MonoBehaviour
	{
		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float distance;

		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float height;

		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float rotationDamping;

		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float heightDamping;

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x13FBD5C", Offset = "0x13FBD5C", VA = "0x13FBD5C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x13FC014", Offset = "0x13FC014", VA = "0x13FC014")]
		public SmoothFollow()
		{
		}
	}
}
