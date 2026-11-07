using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x20001F9")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x4000D4C")]
		[FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000D4D")]
		[FieldOffset(Offset = "0x20")]
		public Transform pin;

		[Token(Token = "0x4000D4E")]
		[FieldOffset(Offset = "0x28")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000D4F")]
		[FieldOffset(Offset = "0x30")]
		public AimIK aim;

		[Token(Token = "0x4000D50")]
		[FieldOffset(Offset = "0x38")]
		public float weight;

		[Token(Token = "0x4000D51")]
		[FieldOffset(Offset = "0x3C")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x4000D52")]
		[FieldOffset(Offset = "0x40")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x4000D53")]
		[FieldOffset(Offset = "0x48")]
		private Animator animator;

		[Token(Token = "0x6000DF1")]
		[Address(RVA = "0x136C9DC", Offset = "0x136C9DC", VA = "0x136C9DC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000DF2")]
		[Address(RVA = "0x136CA38", Offset = "0x136CA38", VA = "0x136CA38")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000DF3")]
		[Address(RVA = "0x136CBE0", Offset = "0x136CBE0", VA = "0x136CBE0")]
		public FBIKBoxing()
		{
		}
	}
}
