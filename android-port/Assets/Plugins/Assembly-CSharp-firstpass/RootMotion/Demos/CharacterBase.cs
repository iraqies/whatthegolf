using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x200024F")]
	[Attribute(Name = "RequireComponent", RVA = "0x34054", Offset = "0x34054")]
	[Attribute(Name = "RequireComponent", RVA = "0x34054", Offset = "0x34054")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x4000F05")]
		[FieldOffset(Offset = "0x18")]
		public Transform gravityTarget;

		[Token(Token = "0x4000F06")]
		[FieldOffset(Offset = "0x20")]
		public float gravityMultiplier;

		[Token(Token = "0x4000F07")]
		[FieldOffset(Offset = "0x24")]
		public float airborneThreshold;

		[Token(Token = "0x4000F08")]
		[FieldOffset(Offset = "0x28")]
		public float slopeStartAngle;

		[Token(Token = "0x4000F09")]
		[FieldOffset(Offset = "0x2C")]
		public float slopeEndAngle;

		[Token(Token = "0x4000F0A")]
		[FieldOffset(Offset = "0x30")]
		public float spherecastRadius;

		[Token(Token = "0x4000F0B")]
		[FieldOffset(Offset = "0x34")]
		public LayerMask groundLayers;

		[Token(Token = "0x4000F0C")]
		[FieldOffset(Offset = "0x38")]
		private PhysicMaterial zeroFrictionMaterial;

		[Token(Token = "0x4000F0D")]
		[FieldOffset(Offset = "0x40")]
		private PhysicMaterial highFrictionMaterial;

		[Token(Token = "0x4000F0E")]
		[FieldOffset(Offset = "0x48")]
		protected Rigidbody r;

		[Token(Token = "0x4000F0F")]
		protected const float half = 0.5f;

		[Token(Token = "0x4000F10")]
		[FieldOffset(Offset = "0x50")]
		protected float originalHeight;

		[Token(Token = "0x4000F11")]
		[FieldOffset(Offset = "0x54")]
		protected Vector3 originalCenter;

		[Token(Token = "0x4000F12")]
		[FieldOffset(Offset = "0x60")]
		protected CapsuleCollider capsule;

		[Token(Token = "0x6000F46")]
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		[Token(Token = "0x6000F47")]
		[Address(RVA = "0x135C6F0", Offset = "0x135C6F0", VA = "0x135C6F0")]
		protected Vector3 GetGravity()
		{
			return default;
		}

		[Token(Token = "0x6000F48")]
		[Address(RVA = "0x135C830", Offset = "0x135C830", VA = "0x135C830", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000F49")]
		[Address(RVA = "0x135C9E4", Offset = "0x135C9E4", VA = "0x135C9E4", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default;
		}

		[Token(Token = "0x6000F4A")]
		[Address(RVA = "0x135CB88", Offset = "0x135CB88", VA = "0x135CB88")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default;
		}

		[Token(Token = "0x6000F4B")]
		[Address(RVA = "0x135CBF0", Offset = "0x135CBF0", VA = "0x135CBF0")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x6000F4C")]
		[Address(RVA = "0x135CD10", Offset = "0x135CD10", VA = "0x135CD10")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x6000F4D")]
		[Address(RVA = "0x135CE34", Offset = "0x135CE34", VA = "0x135CE34")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x6000F4E")]
		[Address(RVA = "0x135CE58", Offset = "0x135CE58", VA = "0x135CE58")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x6000F4F")]
		[Address(RVA = "0x135CE7C", Offset = "0x135CE7C", VA = "0x135CE7C")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default;
		}

		[Token(Token = "0x6000F50")]
		[Address(RVA = "0x135CEDC", Offset = "0x135CEDC", VA = "0x135CEDC")]
		protected CharacterBase()
		{
		}
	}
}
