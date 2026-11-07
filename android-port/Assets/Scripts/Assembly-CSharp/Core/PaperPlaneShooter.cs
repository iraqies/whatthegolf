using Il2CppDummyDll;
using UnityEngine;

namespace Core
{
	[Token(Token = "0x2001460")]
	public class PaperPlaneShooter : GolfBallShooterBase
	{
		[Token(Token = "0x4006F58")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		public float minShootVelocity;

		[Token(Token = "0x4006F59")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		public float fullShootVelocity;

		[Token(Token = "0x4006F5A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		public float pitch;

		[Token(Token = "0x4006F5B")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		protected float spin;

		[Token(Token = "0x4006F5C")]
		[FieldOffset(Offset = "0x70")]
		private ParticleSystem particle;

		[Token(Token = "0x4006F5D")]
		[FieldOffset(Offset = "0x78")]
		private Quaternion targetRotation;

		[Token(Token = "0x4006F5E")]
		[FieldOffset(Offset = "0x88")]
		private Vector3 shootVelocity;

		[Token(Token = "0x6005FC7")]
		[Address(RVA = "0x15D86F0", Offset = "0x15D86F0", VA = "0x15D86F0", Slot = "11")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6005FC8")]
		[Address(RVA = "0x15D877C", Offset = "0x15D877C", VA = "0x15D877C", Slot = "7")]
		public override void OnShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x6005FC9")]
		[Address(RVA = "0x15D8B80", Offset = "0x15D8B80", VA = "0x15D8B80", Slot = "12")]
		protected override void FixedUpdate()
		{
		}

		[Token(Token = "0x6005FCA")]
		[Address(RVA = "0x15D8E8C", Offset = "0x15D8E8C", VA = "0x15D8E8C")]
		private void clampRotation(bool reset)
		{
		}

		[Token(Token = "0x6005FCB")]
		[Address(RVA = "0x15D8914", Offset = "0x15D8914", VA = "0x15D8914")]
		private Quaternion AdjustRotation(Vector3 dir)
		{
			return default;
		}

		[Token(Token = "0x6005FCC")]
		[Address(RVA = "0x15D8948", Offset = "0x15D8948", VA = "0x15D8948")]
		protected void PaperShoot(Vector3 boost, float pitch, float minShootVelocity, float fullShootVelocity, float spin)
		{
		}

		[Token(Token = "0x6005FCD")]
		[Address(RVA = "0x15D8F20", Offset = "0x15D8F20", VA = "0x15D8F20")]
		public PaperPlaneShooter()
		{
		}
	}
}
