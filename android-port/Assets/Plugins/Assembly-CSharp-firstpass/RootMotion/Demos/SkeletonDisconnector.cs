using Il2CppDummyDll;
using RootMotion.Dynamics;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x2000248")]
	public class SkeletonDisconnector : MonoBehaviour
	{
		[Token(Token = "0x4000ED1")]
		[FieldOffset(Offset = "0x18")]
		public BehaviourPuppet puppet;

		[Token(Token = "0x4000ED2")]
		[FieldOffset(Offset = "0x20")]
		public Skeleton skeleton;

		[Token(Token = "0x4000ED3")]
		[FieldOffset(Offset = "0x28")]
		public MuscleDisconnectMode disconnectMuscleMode;

		[Token(Token = "0x4000ED4")]
		[FieldOffset(Offset = "0x2C")]
		public LayerMask layers;

		[Token(Token = "0x4000ED5")]
		[FieldOffset(Offset = "0x30")]
		public float unpin;

		[Token(Token = "0x4000ED6")]
		[FieldOffset(Offset = "0x34")]
		public float force;

		[Token(Token = "0x4000ED7")]
		[FieldOffset(Offset = "0x38")]
		public ParticleSystem particles;

		[Token(Token = "0x4000ED8")]
		[FieldOffset(Offset = "0x40")]
		public PropMuscle propMuscle;

		[Token(Token = "0x4000ED9")]
		[FieldOffset(Offset = "0x48")]
		public PuppetMasterProp prop;

		[Token(Token = "0x6000F27")]
		[Address(RVA = "0x13FB540", Offset = "0x13FB540", VA = "0x13FB540")]
		private void Update()
		{
		}

		[Token(Token = "0x6000F28")]
		[Address(RVA = "0x13FB8F0", Offset = "0x13FB8F0", VA = "0x13FB8F0")]
		public SkeletonDisconnector()
		{
		}
	}
}
