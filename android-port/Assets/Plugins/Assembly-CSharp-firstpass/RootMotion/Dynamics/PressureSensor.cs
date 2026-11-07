using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Dynamics
{
	[Token(Token = "0x2000115")]
	public class PressureSensor : MonoBehaviour
	{
		[Token(Token = "0x4000667")]
		[FieldOffset(Offset = "0x18")]
		public bool visualize;

		[Token(Token = "0x4000668")]
		[FieldOffset(Offset = "0x1C")]
		public LayerMask layers;

		[Token(Token = "0x4000669")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x357FC", Offset = "0x357FC")]
		private Vector3 center__BackingField;

		[Token(Token = "0x400066A")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3580C", Offset = "0x3580C")]
		private bool inContact__BackingField;

		[Token(Token = "0x400066B")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3581C", Offset = "0x3581C")]
		private Vector3 bottom__BackingField;

		[Token(Token = "0x400066C")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3582C", Offset = "0x3582C")]
		private Rigidbody r__BackingField;

		[Token(Token = "0x400066D")]
		[FieldOffset(Offset = "0x48")]
		private bool fixedFrame;

		[Token(Token = "0x400066E")]
		[FieldOffset(Offset = "0x4C")]
		private Vector3 P;

		[Token(Token = "0x400066F")]
		[FieldOffset(Offset = "0x58")]
		private int count;

		[Token(Token = "0x170000F8")]
		public Vector3 center
		{
			[Token(Token = "0x6000733")]
			[Address(RVA = "0x13C0E10", Offset = "0x13C0E10", VA = "0x13C0E10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x38734", Offset = "0x38734")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000734")]
			[Address(RVA = "0x13C0E1C", Offset = "0x13C0E1C", VA = "0x13C0E1C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x38744", Offset = "0x38744")]
			private set
			{
			}
		}

		[Token(Token = "0x170000F9")]
		public bool inContact
		{
			[Token(Token = "0x6000735")]
			[Address(RVA = "0x13C0E28", Offset = "0x13C0E28", VA = "0x13C0E28")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x38754", Offset = "0x38754")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000736")]
			[Address(RVA = "0x13C0E30", Offset = "0x13C0E30", VA = "0x13C0E30")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x38764", Offset = "0x38764")]
			private set
			{
			}
		}

		[Token(Token = "0x170000FA")]
		public Vector3 bottom
		{
			[Token(Token = "0x6000737")]
			[Address(RVA = "0x13C0E38", Offset = "0x13C0E38", VA = "0x13C0E38")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x38774", Offset = "0x38774")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000738")]
			[Address(RVA = "0x13C0E44", Offset = "0x13C0E44", VA = "0x13C0E44")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x38784", Offset = "0x38784")]
			private set
			{
			}
		}

		[Token(Token = "0x170000FB")]
		public Rigidbody r
		{
			[Token(Token = "0x6000739")]
			[Address(RVA = "0x13C0E50", Offset = "0x13C0E50", VA = "0x13C0E50")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x38794", Offset = "0x38794")]
			get
			{
				return null;
			}
			[Token(Token = "0x600073A")]
			[Address(RVA = "0x13C0E58", Offset = "0x13C0E58", VA = "0x13C0E58")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x387A4", Offset = "0x387A4")]
			private set
			{
			}
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x13C0E60", Offset = "0x13C0E60", VA = "0x13C0E60")]
		private void Awake()
		{
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x13C0EE0", Offset = "0x13C0EE0", VA = "0x13C0EE0")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x13C1038", Offset = "0x13C1038", VA = "0x13C1038")]
		private void OnCollisionStay(Collision c)
		{
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x13C103C", Offset = "0x13C103C", VA = "0x13C103C")]
		private void OnCollisionExit(Collision c)
		{
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x13C1044", Offset = "0x13C1044", VA = "0x13C1044")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x13C1094", Offset = "0x13C1094", VA = "0x13C1094")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x13C0EE4", Offset = "0x13C0EE4", VA = "0x13C0EE4")]
		private void ProcessCollision(Collision c)
		{
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x13C10D4", Offset = "0x13C10D4", VA = "0x13C10D4")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x13C1100", Offset = "0x13C1100", VA = "0x13C1100")]
		public PressureSensor()
		{
		}
	}
}
