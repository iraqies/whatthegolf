using Il2CppDummyDll;
using UnityEngine;

namespace Core
{
	[Token(Token = "0x200144F")]
	public abstract class GolfBallShooterBase : ShooterBase
	{
		[Token(Token = "0x4006E71")]
		[FieldOffset(Offset = "0x20")]
		protected Rigidbody rigidbodyC;

		[Token(Token = "0x4006E72")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected float goalPullForce;

		[Token(Token = "0x4006E73")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		protected float goalPullDistance;

		[Token(Token = "0x4006E74")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected float angleThreshold;

		[Token(Token = "0x4006E75")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GolfBallController golfBallControllerOverride;

		[Token(Token = "0x4006E76")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Rigidbody rigidbodyOverride;

		[Token(Token = "0x4006E77")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		public bool isblockedIfNotGrounded;

		[Token(Token = "0x4006E78")]
		[FieldOffset(Offset = "0x4C")]
		public float sqrVelocityShootingThreshold;

		[Token(Token = "0x4006E79")]
		[FieldOffset(Offset = "0x50")]
		public float shootThresholdMinimumTime;

		[Token(Token = "0x4006E7A")]
		[FieldOffset(Offset = "0x54")]
		protected float lastUnderVelocityShootingThreshold;

		[Token(Token = "0x4006E7B")]
		[FieldOffset(Offset = "0x58")]
		private float currentStillTime;

		[Token(Token = "0x4006E7C")]
		[FieldOffset(Offset = "0x5C")]
		private float stillTimeThreshold;

		[Token(Token = "0x17000ACE")]
		public Rigidbody RigidbodyOverride
		{
			[Token(Token = "0x6005F23")]
			[Address(RVA = "0x1497ADC", Offset = "0x1497ADC", VA = "0x1497ADC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005F22")]
			[Address(RVA = "0x1497AD0", Offset = "0x1497AD0", VA = "0x1497AD0")]
			set
			{
			}
		}

		[Token(Token = "0x6005F19")]
		[Address(RVA = "0x148B1D4", Offset = "0x148B1D4", VA = "0x148B1D4", Slot = "11")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6005F1A")]
		[Address(RVA = "0x1497258", Offset = "0x1497258", VA = "0x1497258")]
		private void GolfBallController_OnShoot(Vector3 obj)
		{
		}

		[Token(Token = "0x6005F1B")]
		[Address(RVA = "0x1497290", Offset = "0x1497290", VA = "0x1497290")]
		public void SetOwner(GolfBallController newOwner)
		{
		}

		[Token(Token = "0x6005F1C")]
		[Address(RVA = "0x1497298", Offset = "0x1497298", VA = "0x1497298", Slot = "12")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6005F1D")]
		[Address(RVA = "0x149766C", Offset = "0x149766C", VA = "0x149766C", Slot = "13")]
		protected virtual bool IsBlocking()
		{
			return default;
		}

		[Token(Token = "0x6005F1E")]
		[Address(RVA = "0x1497744", Offset = "0x1497744", VA = "0x1497744")]
		protected void StandardShoot(Vector3 boost, float pitch, float fullShootVelocity, float spin)
		{
		}

		[Token(Token = "0x6005F1F")]
		[Address(RVA = "0x1497760", Offset = "0x1497760", VA = "0x1497760", Slot = "14")]
		protected virtual void StandardShoot(Vector3 boost, float pitch, float minShootVelocity, float fullShootVelocity, float spin)
		{
		}

		[Token(Token = "0x6005F20")]
		[Address(RVA = "0x1497950", Offset = "0x1497950", VA = "0x1497950")]
		public void StopAndSleep()
		{
		}

		[Token(Token = "0x6005F21")]
		[Address(RVA = "0x1497A2C", Offset = "0x1497A2C", VA = "0x1497A2C")]
		public void StartAndWakeup()
		{
		}

		[Token(Token = "0x6005F24")]
		[Address(RVA = "0x14857AC", Offset = "0x14857AC", VA = "0x14857AC")]
		protected GolfBallShooterBase()
		{
		}
	}
}
