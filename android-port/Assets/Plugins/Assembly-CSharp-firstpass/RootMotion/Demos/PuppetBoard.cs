using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x2000241")]
	public class PuppetBoard : MonoBehaviour
	{
		[Token(Token = "0x4000EB1")]
		[FieldOffset(Offset = "0x18")]
		public Rigidbody target;

		[Token(Token = "0x4000EB2")]
		[FieldOffset(Offset = "0x20")]
		public Transform bodyTargetPivot;

		[Token(Token = "0x4000EB3")]
		[FieldOffset(Offset = "0x28")]
		public Transform bodyTarget;

		[Token(Token = "0x4000EB4")]
		[FieldOffset(Offset = "0x30")]
		private Rigidbody r;

		[Token(Token = "0x6000F0B")]
		[Address(RVA = "0x13C5570", Offset = "0x13C5570", VA = "0x13C5570")]
		private void Start()
		{
		}

		[Token(Token = "0x6000F0C")]
		[Address(RVA = "0x13C5618", Offset = "0x13C5618", VA = "0x13C5618")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000F0D")]
		[Address(RVA = "0x13C5798", Offset = "0x13C5798", VA = "0x13C5798")]
		public PuppetBoard()
		{
		}
	}
}
