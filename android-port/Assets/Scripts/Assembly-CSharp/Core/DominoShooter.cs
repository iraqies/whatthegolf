using Il2CppDummyDll;
using UnityEngine;

namespace Core
{
	[Token(Token = "0x200145E")]
	public class DominoShooter : GolfBallShooterBase
	{
		[Token(Token = "0x4006F45")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		public float minShootVelocity;

		[Token(Token = "0x4006F46")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		public float fullShootVelocity;

		[Token(Token = "0x4006F47")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		public float pitch;

		[Token(Token = "0x4006F48")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		protected float spin;

		[Token(Token = "0x4006F49")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		protected float maxAngVel;

		[Token(Token = "0x4006F4A")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		protected bool lookInAimDirection;

		[Token(Token = "0x4006F4B")]
		[FieldOffset(Offset = "0x75")]
		[SerializeField]
		protected bool lookInShotDirection;

		[Token(Token = "0x4006F4C")]
		[FieldOffset(Offset = "0x76")]
		[SerializeField]
		public bool zeroPitchIfNotGrouneded;

		[Token(Token = "0x4006F4D")]
		[FieldOffset(Offset = "0x78")]
		public Rigidbody initialRigidbody;

		[Token(Token = "0x4006F4E")]
		[FieldOffset(Offset = "0x80")]
		private BoxCollider box;

		[Token(Token = "0x4006F4F")]
		[FieldOffset(Offset = "0x88")]
		private Vector3 look;

		[Token(Token = "0x4006F50")]
		[FieldOffset(Offset = "0x94")]
		public float velocityThreshold;

		[Token(Token = "0x4006F51")]
		[FieldOffset(Offset = "0x98")]
		private Vector3 currentBoost;

		[Token(Token = "0x6005FB7")]
		[Address(RVA = "0x1431194", Offset = "0x1431194", VA = "0x1431194")]
		private void Start()
		{
		}

		[Token(Token = "0x6005FB8")]
		[Address(RVA = "0x1431210", Offset = "0x1431210", VA = "0x1431210")]
		public void SetRigidbody(Rigidbody rb)
		{
		}

		[Token(Token = "0x6005FB9")]
		[Address(RVA = "0x143128C", Offset = "0x143128C", VA = "0x143128C", Slot = "5")]
		public override void OnAimStart()
		{
		}

		[Token(Token = "0x6005FBA")]
		[Address(RVA = "0x1431324", Offset = "0x1431324", VA = "0x1431324", Slot = "6")]
		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
		}

		[Token(Token = "0x6005FBB")]
		[Address(RVA = "0x14314B4", Offset = "0x14314B4", VA = "0x14314B4", Slot = "7")]
		public override void OnShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x6005FBC")]
		[Address(RVA = "0x1430FA8", Offset = "0x1430FA8", VA = "0x1430FA8")]
		public void SetNewRigid(Rigidbody rigid)
		{
		}

		[Token(Token = "0x6005FBD")]
		[Address(RVA = "0x143165C", Offset = "0x143165C", VA = "0x143165C")]
		public Rigidbody GetCurrentRigidbody()
		{
			return null;
		}

		[Token(Token = "0x6005FBE")]
		[Address(RVA = "0x1431664", Offset = "0x1431664", VA = "0x1431664", Slot = "12")]
		protected override void FixedUpdate()
		{
		}

		[Token(Token = "0x6005FBF")]
		[Address(RVA = "0x143181C", Offset = "0x143181C", VA = "0x143181C")]
		public DominoShooter()
		{
		}
	}
}
