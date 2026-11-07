using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x20001E7")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Token(Token = "0x4000CC0")]
		[FieldOffset(Offset = "0x18")]
		public Animator animator;

		[Token(Token = "0x4000CC1")]
		[FieldOffset(Offset = "0x20")]
		public BipedIK bipedIK;

		[Token(Token = "0x4000CC2")]
		[FieldOffset(Offset = "0x28")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x4000CC3")]
		[FieldOffset(Offset = "0x30")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x4000CC4")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "RangeAttribute", RVA = "0x36B5C", Offset = "0x36B5C")]
		public float lookAtWeight;

		[Token(Token = "0x4000CC5")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x36B74", Offset = "0x36B74")]
		public float lookAtBodyWeight;

		[Token(Token = "0x4000CC6")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "RangeAttribute", RVA = "0x36B8C", Offset = "0x36B8C")]
		public float lookAtHeadWeight;

		[Token(Token = "0x4000CC7")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "RangeAttribute", RVA = "0x36BA4", Offset = "0x36BA4")]
		public float lookAtEyesWeight;

		[Token(Token = "0x4000CC8")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "RangeAttribute", RVA = "0x36BBC", Offset = "0x36BBC")]
		public float lookAtClampWeight;

		[Token(Token = "0x4000CC9")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x36BD4", Offset = "0x36BD4")]
		public float lookAtClampWeightHead;

		[Token(Token = "0x4000CCA")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "RangeAttribute", RVA = "0x36BEC", Offset = "0x36BEC")]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x4000CCB")]
		[FieldOffset(Offset = "0x58")]
		public Transform footTargetBiped;

		[Token(Token = "0x4000CCC")]
		[FieldOffset(Offset = "0x60")]
		public Transform footTargetAnimator;

		[Token(Token = "0x4000CCD")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "RangeAttribute", RVA = "0x36C04", Offset = "0x36C04")]
		public float footPositionWeight;

		[Token(Token = "0x4000CCE")]
		[FieldOffset(Offset = "0x6C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x36C1C", Offset = "0x36C1C")]
		public float footRotationWeight;

		[Token(Token = "0x4000CCF")]
		[FieldOffset(Offset = "0x70")]
		public Transform handTargetBiped;

		[Token(Token = "0x4000CD0")]
		[FieldOffset(Offset = "0x78")]
		public Transform handTargetAnimator;

		[Token(Token = "0x4000CD1")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "RangeAttribute", RVA = "0x36C34", Offset = "0x36C34")]
		public float handPositionWeight;

		[Token(Token = "0x4000CD2")]
		[FieldOffset(Offset = "0x84")]
		[Attribute(Name = "RangeAttribute", RVA = "0x36C4C", Offset = "0x36C4C")]
		public float handRotationWeight;

		[Token(Token = "0x6000DAA")]
		[Address(RVA = "0x13021F0", Offset = "0x13021F0", VA = "0x13021F0")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x6000DAB")]
		[Address(RVA = "0x1302688", Offset = "0x1302688", VA = "0x1302688")]
		public BipedIKvsAnimatorIK()
		{
		}
	}
}
