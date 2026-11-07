using Il2CppDummyDll;
using UnityEngine;

namespace Core
{
	[Token(Token = "0x200145F")]
	public class FPGShooter : GolfBallShooterBase
	{
		[Token(Token = "0x4006F52")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		public float minShootVelocity;

		[Token(Token = "0x4006F53")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		public float fullShootVelocity;

		[Token(Token = "0x4006F54")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		public float pitch;

		[Token(Token = "0x4006F55")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		public bool zeroPitchIfNotGrouneded;

		[Token(Token = "0x4006F56")]
		[FieldOffset(Offset = "0x70")]
		private Quaternion startForward;

		[Token(Token = "0x4006F57")]
		[FieldOffset(Offset = "0x80")]
		private float lastShotTime;

		[Token(Token = "0x6005FC0")]
		[Address(RVA = "0x14598B8", Offset = "0x14598B8", VA = "0x14598B8", Slot = "11")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6005FC1")]
		[Address(RVA = "0x1459944", Offset = "0x1459944", VA = "0x1459944", Slot = "4")]
		public override void OnActivate()
		{
		}

		[Token(Token = "0x6005FC2")]
		[Address(RVA = "0x145997C", Offset = "0x145997C", VA = "0x145997C", Slot = "7")]
		public override void OnShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x6005FC3")]
		[Address(RVA = "0x14599D4", Offset = "0x14599D4", VA = "0x14599D4")]
		private void Shoot(Vector3 boost, bool comingFromUpdate)
		{
		}

		[Token(Token = "0x6005FC4")]
		[Address(RVA = "0x1459BB8", Offset = "0x1459BB8", VA = "0x1459BB8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6005FC5")]
		[Address(RVA = "0x1459D84", Offset = "0x1459D84", VA = "0x1459D84", Slot = "9")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6005FC6")]
		[Address(RVA = "0x1459DC8", Offset = "0x1459DC8", VA = "0x1459DC8")]
		public FPGShooter()
		{
		}
	}
}
