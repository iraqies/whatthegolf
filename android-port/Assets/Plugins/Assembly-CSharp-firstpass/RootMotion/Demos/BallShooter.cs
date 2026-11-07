using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x2000224")]
	public class BallShooter : MonoBehaviour
	{
		[Token(Token = "0x4000E2D")]
		[FieldOffset(Offset = "0x18")]
		public KeyCode keyCode;

		[Token(Token = "0x4000E2E")]
		[FieldOffset(Offset = "0x20")]
		public GameObject ball;

		[Token(Token = "0x4000E2F")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 spawnOffset;

		[Token(Token = "0x4000E30")]
		[FieldOffset(Offset = "0x34")]
		public Vector3 force;

		[Token(Token = "0x4000E31")]
		[FieldOffset(Offset = "0x40")]
		public float mass;

		[Token(Token = "0x6000E93")]
		[Address(RVA = "0x12F85B8", Offset = "0x12F85B8", VA = "0x12F85B8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000E94")]
		[Address(RVA = "0x12F87D0", Offset = "0x12F87D0", VA = "0x12F87D0")]
		public BallShooter()
		{
		}
	}
}
