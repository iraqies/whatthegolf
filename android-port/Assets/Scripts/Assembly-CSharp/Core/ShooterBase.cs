using Il2CppDummyDll;
using UnityEngine;

namespace Core
{
	[Token(Token = "0x200145A")]
	public abstract class ShooterBase : MonoBehaviour
	{
		[Token(Token = "0x4006F1F")]
		[FieldOffset(Offset = "0x18")]
		protected GolfBallController GolfBallController;

		[Token(Token = "0x6005F98")]
		[Address(RVA = "0x16A37FC", Offset = "0x16A37FC", VA = "0x16A37FC", Slot = "4")]
		public virtual void OnActivate()
		{
		}

		[Token(Token = "0x6005F99")]
		[Address(RVA = "0x16A3808", Offset = "0x16A3808", VA = "0x16A3808", Slot = "5")]
		public virtual void OnAimStart()
		{
		}

		[Token(Token = "0x6005F9A")]
		[Address(RVA = "0x169E40C", Offset = "0x169E40C", VA = "0x169E40C", Slot = "6")]
		public virtual void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
		}

		[Token(Token = "0x6005F9B")]
		[Address(RVA = "0x169E570", Offset = "0x169E570", VA = "0x169E570", Slot = "7")]
		public virtual void OnShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x6005F9C")]
		[Address(RVA = "0x16A1B14", Offset = "0x16A1B14", VA = "0x16A1B14", Slot = "8")]
		public virtual void OnCancel()
		{
		}

		[Token(Token = "0x6005F9D")]
		[Address(RVA = "0x16A380C", Offset = "0x16A380C", VA = "0x16A380C", Slot = "9")]
		public virtual void OnReset()
		{
		}

		[Token(Token = "0x6005F9E")]
		[Address(RVA = "0x16A3810", Offset = "0x16A3810", VA = "0x16A3810", Slot = "10")]
		public virtual void OnGoalReached()
		{
		}

		[Token(Token = "0x6005F9F")]
		[Address(RVA = "0x16A3814", Offset = "0x16A3814", VA = "0x16A3814")]
		public GolfBallController GetOwner()
		{
			return null;
		}

		[Token(Token = "0x6005FA0")]
		[Address(RVA = "0x16A381C", Offset = "0x16A381C", VA = "0x16A381C")]
		protected ShooterBase()
		{
		}
	}
}
