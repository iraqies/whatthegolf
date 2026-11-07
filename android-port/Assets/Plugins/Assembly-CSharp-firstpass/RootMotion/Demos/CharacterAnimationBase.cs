using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x200024C")]
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		[Token(Token = "0x4000EE7")]
		[FieldOffset(Offset = "0x18")]
		public bool smoothFollow;

		[Token(Token = "0x4000EE8")]
		[FieldOffset(Offset = "0x1C")]
		public float smoothFollowSpeed;

		[Token(Token = "0x4000EE9")]
		[FieldOffset(Offset = "0x20")]
		protected bool animatePhysics;

		[Token(Token = "0x4000EEA")]
		[FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000EEB")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 localPosition;

		[Token(Token = "0x4000EEC")]
		[FieldOffset(Offset = "0x3C")]
		private Quaternion localRotation;

		[Token(Token = "0x4000EED")]
		[FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x170001DF")]
		public virtual bool animationGrounded
		{
			[Token(Token = "0x6000F32")]
			[Address(RVA = "0x135B07C", Offset = "0x135B07C", VA = "0x135B07C", Slot = "5")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000F31")]
		[Address(RVA = "0x135B058", Offset = "0x135B058", VA = "0x135B058", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default;
		}

		[Token(Token = "0x6000F33")]
		[Address(RVA = "0x135B084", Offset = "0x135B084", VA = "0x135B084")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default;
		}

		[Token(Token = "0x6000F34")]
		[Address(RVA = "0x135B0EC", Offset = "0x135B0EC", VA = "0x135B0EC", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000F35")]
		[Address(RVA = "0x135B280", Offset = "0x135B280", VA = "0x135B280", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000F36")]
		[Address(RVA = "0x135B49C", Offset = "0x135B49C", VA = "0x135B49C", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000F37")]
		[Address(RVA = "0x135B290", Offset = "0x135B290", VA = "0x135B290")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x6000F38")]
		[Address(RVA = "0x135B4B0", Offset = "0x135B4B0", VA = "0x135B4B0")]
		protected CharacterAnimationBase()
		{
		}
	}
}
