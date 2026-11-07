using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x2000207")]
	public class MotionAbsorbCharacter : MonoBehaviour
	{
		[Token(Token = "0x4000DA3")]
		[FieldOffset(Offset = "0x18")]
		public Animator animator;

		[Token(Token = "0x4000DA4")]
		[FieldOffset(Offset = "0x20")]
		public MotionAbsorb motionAbsorb;

		[Token(Token = "0x4000DA5")]
		[FieldOffset(Offset = "0x28")]
		public Transform cube;

		[Token(Token = "0x4000DA6")]
		[FieldOffset(Offset = "0x30")]
		public float cubeRandomPosition;

		[Token(Token = "0x4000DA7")]
		[FieldOffset(Offset = "0x38")]
		public AnimationCurve motionAbsorbWeight;

		[Token(Token = "0x4000DA8")]
		[FieldOffset(Offset = "0x40")]
		private Vector3 cubeDefaultPosition;

		[Token(Token = "0x4000DA9")]
		[FieldOffset(Offset = "0x4C")]
		private AnimatorStateInfo info;

		[Token(Token = "0x4000DAA")]
		[FieldOffset(Offset = "0x70")]
		private Rigidbody cubeRigidbody;

		[Token(Token = "0x6000E25")]
		[Address(RVA = "0x13B4FE0", Offset = "0x13B4FE0", VA = "0x13B4FE0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000E26")]
		[Address(RVA = "0x13B5054", Offset = "0x13B5054", VA = "0x13B5054")]
		private void Update()
		{
		}

		[Token(Token = "0x6000E27")]
		[Address(RVA = "0x13B5118", Offset = "0x13B5118", VA = "0x13B5118")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x6000E28")]
		[Address(RVA = "0x13B51D8", Offset = "0x13B51D8", VA = "0x13B51D8")]
		public MotionAbsorbCharacter()
		{
		}
	}
}
