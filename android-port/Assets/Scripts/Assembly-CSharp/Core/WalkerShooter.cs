using Il2CppDummyDll;
using UnityEngine;

namespace Core
{
	[Token(Token = "0x200145C")]
	public class WalkerShooter : GolfBallShooterBase
	{
		[Token(Token = "0x4006F30")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		public float minShootVelocity;

		[Token(Token = "0x4006F31")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		public float maxShootVelocity;

		[Token(Token = "0x4006F32")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		public float minSteeringTargetDistance;

		[Token(Token = "0x4006F33")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		public float maxSteeringTargetDistance;

		[Token(Token = "0x4006F34")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		public AnimationCurve dragCurve;

		[Token(Token = "0x4006F35")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		public float decayDuration;

		[Token(Token = "0x4006F36")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		public float dragScale;

		[Token(Token = "0x4006F37")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		public float maxAngVel;

		[Token(Token = "0x4006F38")]
		[FieldOffset(Offset = "0x84")]
		private Vector3 target;

		[Token(Token = "0x4006F39")]
		[FieldOffset(Offset = "0x90")]
		private float shootTime;

		[Token(Token = "0x4006F3A")]
		[FieldOffset(Offset = "0x94")]
		private float startSpeed;

		[Token(Token = "0x6005FAA")]
		[Address(RVA = "0x174FAE8", Offset = "0x174FAE8", VA = "0x174FAE8", Slot = "11")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6005FAB")]
		[Address(RVA = "0x174FB50", Offset = "0x174FB50", VA = "0x174FB50", Slot = "4")]
		public override void OnActivate()
		{
		}

		[Token(Token = "0x6005FAC")]
		[Address(RVA = "0x174FB88", Offset = "0x174FB88", VA = "0x174FB88", Slot = "7")]
		public override void OnShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x6005FAD")]
		[Address(RVA = "0x174FCB8", Offset = "0x174FCB8", VA = "0x174FCB8", Slot = "12")]
		protected override void FixedUpdate()
		{
		}

		[Token(Token = "0x6005FAE")]
		[Address(RVA = "0x174FED8", Offset = "0x174FED8", VA = "0x174FED8")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6005FAF")]
		[Address(RVA = "0x174FF24", Offset = "0x174FF24", VA = "0x174FF24")]
		public WalkerShooter()
		{
		}
	}
}
