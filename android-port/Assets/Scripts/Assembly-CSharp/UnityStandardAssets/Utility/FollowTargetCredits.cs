using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x20010DC")]
	public class FollowTargetCredits : MonoBehaviour
	{
		[Token(Token = "0x40058D8")]
		[FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40058D9")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 offset;

		[Token(Token = "0x40058DA")]
		[FieldOffset(Offset = "0x2C")]
		public Vector3 offsetRotated;

		[Token(Token = "0x40058DB")]
		[FieldOffset(Offset = "0x38")]
		private bool isRoated;

		[Token(Token = "0x6004B85")]
		[Address(RVA = "0x1470008", Offset = "0x1470008", VA = "0x1470008")]
		private void Start()
		{
		}

		[Token(Token = "0x6004B86")]
		[Address(RVA = "0x147008C", Offset = "0x147008C", VA = "0x147008C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6004B87")]
		[Address(RVA = "0x147011C", Offset = "0x147011C", VA = "0x147011C")]
		public FollowTargetCredits()
		{
		}
	}
}
