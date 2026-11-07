using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x2000223")]
	[Attribute(Name = "RequireComponent", RVA = "0x33DCC", Offset = "0x33DCC")]
	public class AnimatorIKDemo : MonoBehaviour
	{
		[Token(Token = "0x4000E2B")]
		[FieldOffset(Offset = "0x18")]
		public Transform leftHandIKTarget;

		[Token(Token = "0x4000E2C")]
		[FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x6000E90")]
		[Address(RVA = "0x12EFA1C", Offset = "0x12EFA1C", VA = "0x12EFA1C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000E91")]
		[Address(RVA = "0x12EFA78", Offset = "0x12EFA78", VA = "0x12EFA78")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x6000E92")]
		[Address(RVA = "0x12EFAD4", Offset = "0x12EFAD4", VA = "0x12EFAD4")]
		public AnimatorIKDemo()
		{
		}
	}
}
