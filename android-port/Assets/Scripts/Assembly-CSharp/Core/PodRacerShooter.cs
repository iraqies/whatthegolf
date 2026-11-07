using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Core
{
	[Token(Token = "0x2001424")]
	public class PodRacerShooter : GolfBallShooterBase
	{
		[Token(Token = "0x4006CA0")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		public float fullShootVelocity;

		[Token(Token = "0x4006CA1")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		public float minShootVelocity;

		[Token(Token = "0x4006CA2")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float targetHeight;

		[Token(Token = "0x4006CA3")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float AdjustRotationSpeedWhileDriving;

		[Token(Token = "0x4006CA4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float AdjustRotationSpeed;

		[Token(Token = "0x4006CA5")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private bool useGravity;

		[Token(Token = "0x4006CA6")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private AudioSource rocketAudioSource;

		[Token(Token = "0x4006CA7")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private PodRacerEngine[] engines;

		[Token(Token = "0x4006CA8")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Rigidbody pilot;

		[Token(Token = "0x4006CA9")]
		[FieldOffset(Offset = "0x90")]
		private bool didExplode;

		[Token(Token = "0x4006CAA")]
		[FieldOffset(Offset = "0x98")]
		public GolfBallController ballController;

		[Token(Token = "0x4006CAB")]
		[FieldOffset(Offset = "0xA0")]
		private bool wasBlocked;

		[Token(Token = "0x4006CAC")]
		[FieldOffset(Offset = "0xA4")]
		private Vector3 lastShootVelocity;

		[Token(Token = "0x4006CAD")]
		[FieldOffset(Offset = "0xB0")]
		private bool isAiming;

		[Token(Token = "0x4006CAE")]
		[FieldOffset(Offset = "0xB1")]
		private bool didAim;

		[Token(Token = "0x4006CAF")]
		[FieldOffset(Offset = "0xB4")]
		private float firstAimTime;

		[Token(Token = "0x4006CB0")]
		[FieldOffset(Offset = "0xB8")]
		private float warmup;

		[Token(Token = "0x4006CB1")]
		[FieldOffset(Offset = "0xBC")]
		public bool failLevelOnExplode;

		[Token(Token = "0x4006CB2")]
		[FieldOffset(Offset = "0xC0")]
		public Action<GameObject> onExplode;

		[Token(Token = "0x6005DB1")]
		[Address(RVA = "0x16037C0", Offset = "0x16037C0", VA = "0x16037C0", Slot = "4")]
		public override void OnActivate()
		{
		}

		[Token(Token = "0x6005DB2")]
		[Address(RVA = "0x1603820", Offset = "0x1603820", VA = "0x1603820")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6005DB3")]
		[Address(RVA = "0x16038CC", Offset = "0x16038CC", VA = "0x16038CC", Slot = "6")]
		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
		}

		[Token(Token = "0x6005DB4")]
		[Address(RVA = "0x16039D0", Offset = "0x16039D0", VA = "0x16039D0", Slot = "5")]
		public override void OnAimStart()
		{
		}

		[Token(Token = "0x6005DB5")]
		[Address(RVA = "0x1603C10", Offset = "0x1603C10", VA = "0x1603C10", Slot = "8")]
		public override void OnCancel()
		{
		}

		[Token(Token = "0x6005DB6")]
		[Address(RVA = "0x1603D64", Offset = "0x1603D64", VA = "0x1603D64")]
		private void AdjustRotation(Vector3 dir, bool isDriving)
		{
		}

		[Token(Token = "0x6005DB7")]
		[Address(RVA = "0x1603E80", Offset = "0x1603E80", VA = "0x1603E80", Slot = "7")]
		public override void OnShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x6005DB8")]
		[Address(RVA = "0x16040B4", Offset = "0x16040B4", VA = "0x16040B4", Slot = "12")]
		protected override void FixedUpdate()
		{
		}

		[Token(Token = "0x6005DB9")]
		[Address(RVA = "0x1604358", Offset = "0x1604358", VA = "0x1604358")]
		public PodRacerShooter()
		{
		}
	}
}
