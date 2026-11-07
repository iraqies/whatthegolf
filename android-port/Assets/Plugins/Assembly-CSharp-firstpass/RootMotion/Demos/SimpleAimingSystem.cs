using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x20001E5")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x4000CB0")]
		[FieldOffset(Offset = "0x18")]
		public AimPoser aimPoser;

		[Token(Token = "0x4000CB1")]
		[FieldOffset(Offset = "0x20")]
		public AimIK aim;

		[Token(Token = "0x4000CB2")]
		[FieldOffset(Offset = "0x28")]
		public LookAtIK lookAt;

		[Token(Token = "0x4000CB3")]
		[FieldOffset(Offset = "0x30")]
		public Animator animator;

		[Token(Token = "0x4000CB4")]
		[FieldOffset(Offset = "0x38")]
		public float crossfadeTime;

		[Token(Token = "0x4000CB5")]
		[FieldOffset(Offset = "0x3C")]
		public float minAimDistance;

		[Token(Token = "0x4000CB6")]
		[FieldOffset(Offset = "0x40")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x4000CB7")]
		[FieldOffset(Offset = "0x48")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x6000DA1")]
		[Address(RVA = "0x13FA058", Offset = "0x13FA058", VA = "0x13FA058")]
		private void Start()
		{
		}

		[Token(Token = "0x6000DA2")]
		[Address(RVA = "0x13FA09C", Offset = "0x13FA09C", VA = "0x13FA09C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000DA3")]
		[Address(RVA = "0x13FA210", Offset = "0x13FA210", VA = "0x13FA210")]
		private void Pose()
		{
		}

		[Token(Token = "0x6000DA4")]
		[Address(RVA = "0x13FA3A0", Offset = "0x13FA3A0", VA = "0x13FA3A0")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x6000DA5")]
		[Address(RVA = "0x13FA4DC", Offset = "0x13FA4DC", VA = "0x13FA4DC")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x6000DA6")]
		[Address(RVA = "0x13FA558", Offset = "0x13FA558", VA = "0x13FA558")]
		public SimpleAimingSystem()
		{
		}
	}
}
