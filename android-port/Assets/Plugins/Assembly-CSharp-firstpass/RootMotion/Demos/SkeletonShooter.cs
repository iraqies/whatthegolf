using Il2CppDummyDll;
using RootMotion.Dynamics;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x2000249")]
	public class SkeletonShooter : MonoBehaviour
	{
		[Token(Token = "0x4000EDA")]
		[FieldOffset(Offset = "0x18")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x4000EDB")]
		[FieldOffset(Offset = "0x20")]
		public Skeleton skeleton;

		[Token(Token = "0x4000EDC")]
		[FieldOffset(Offset = "0x28")]
		public MuscleRemoveMode removeMuscleMode;

		[Token(Token = "0x4000EDD")]
		[FieldOffset(Offset = "0x2C")]
		public LayerMask layers;

		[Token(Token = "0x4000EDE")]
		[FieldOffset(Offset = "0x30")]
		public float unpin;

		[Token(Token = "0x4000EDF")]
		[FieldOffset(Offset = "0x34")]
		public float force;

		[Token(Token = "0x4000EE0")]
		[FieldOffset(Offset = "0x38")]
		public ParticleSystem particles;

		[Token(Token = "0x6000F29")]
		[Address(RVA = "0x13FB904", Offset = "0x13FB904", VA = "0x13FB904")]
		private void Update()
		{
		}

		[Token(Token = "0x6000F2A")]
		[Address(RVA = "0x13FBC44", Offset = "0x13FBC44", VA = "0x13FBC44")]
		public SkeletonShooter()
		{
		}
	}
}
