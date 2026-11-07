using Il2CppDummyDll;
using RootMotion.Dynamics;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x2000236")]
	[Attribute(Name = "RequireComponent", RVA = "0x33E94", Offset = "0x33E94")]
	public class FXCollisionBlood : MonoBehaviour
	{
		[Token(Token = "0x4000E74")]
		[FieldOffset(Offset = "0x18")]
		public BehaviourPuppet puppet;

		[Token(Token = "0x4000E75")]
		[FieldOffset(Offset = "0x20")]
		public float minCollisionImpulse;

		[Token(Token = "0x4000E76")]
		[FieldOffset(Offset = "0x24")]
		public int emission;

		[Token(Token = "0x4000E77")]
		[FieldOffset(Offset = "0x28")]
		public float emissionImpulseAdd;

		[Token(Token = "0x4000E78")]
		[FieldOffset(Offset = "0x2C")]
		public int maxEmission;

		[Token(Token = "0x4000E79")]
		[FieldOffset(Offset = "0x30")]
		private ParticleSystem particles;

		[Token(Token = "0x6000EE3")]
		[Address(RVA = "0x1370A28", Offset = "0x1370A28", VA = "0x1370A28")]
		private void Start()
		{
		}

		[Token(Token = "0x6000EE4")]
		[Address(RVA = "0x1370B14", Offset = "0x1370B14", VA = "0x1370B14")]
		private void OnCollisionImpulse(MuscleCollision m, float impulse)
		{
		}

		[Token(Token = "0x6000EE5")]
		[Address(RVA = "0x1370D70", Offset = "0x1370D70", VA = "0x1370D70")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000EE6")]
		[Address(RVA = "0x1370E84", Offset = "0x1370E84", VA = "0x1370E84")]
		public FXCollisionBlood()
		{
		}
	}
}
