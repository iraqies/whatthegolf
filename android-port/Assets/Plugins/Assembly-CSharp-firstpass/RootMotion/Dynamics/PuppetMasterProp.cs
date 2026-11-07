using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Dynamics
{
	[Token(Token = "0x200012B")]
	public class PuppetMasterProp : MonoBehaviour
	{
		[Token(Token = "0x4000728")]
		[FieldOffset(Offset = "0x18")]
		public Transform meshRoot;

		[Token(Token = "0x4000729")]
		[FieldOffset(Offset = "0x20")]
		public Muscle.Props muscleProps;

		[Token(Token = "0x400072A")]
		[FieldOffset(Offset = "0x28")]
		public bool forceLayers;

		[Token(Token = "0x400072B")]
		[FieldOffset(Offset = "0x2C")]
		public float mass;

		[Token(Token = "0x400072C")]
		[FieldOffset(Offset = "0x30")]
		public int propType;

		[Token(Token = "0x400072D")]
		[FieldOffset(Offset = "0x38")]
		public PhysicMaterial pickedUpMaterial;

		[Token(Token = "0x400072E")]
		[FieldOffset(Offset = "0x40")]
		public Vector3 additionalPinOffsetAdd;

		[Token(Token = "0x400072F")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x35A0C", Offset = "0x35A0C")]
		public float additionalPinWeight;

		[Token(Token = "0x4000730")]
		[FieldOffset(Offset = "0x50")]
		public float additionalPinMass;

		[Token(Token = "0x4000731")]
		[FieldOffset(Offset = "0x54")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x35A24", Offset = "0x35A24")]
		private bool isPickedUp__BackingField;

		[Token(Token = "0x4000732")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x35A34", Offset = "0x35A34")]
		private Muscle propMuscle__BackingField;

		[Token(Token = "0x4000733")]
		[FieldOffset(Offset = "0x60")]
		private int defaultLayer;

		[Token(Token = "0x4000734")]
		[FieldOffset(Offset = "0x68")]
		private Transform defaultParent;

		[Token(Token = "0x4000735")]
		[FieldOffset(Offset = "0x70")]
		private Collider[] colliders;

		[Token(Token = "0x4000736")]
		[FieldOffset(Offset = "0x78")]
		private PhysicMaterial[] droppedMaterials;

		[Token(Token = "0x4000737")]
		[FieldOffset(Offset = "0x80")]
		private Rigidbody r;

		[Token(Token = "0x4000738")]
		[FieldOffset(Offset = "0x88")]
		private float _mass;

		[Token(Token = "0x4000739")]
		[FieldOffset(Offset = "0x8C")]
		private float _drag;

		[Token(Token = "0x400073A")]
		[FieldOffset(Offset = "0x90")]
		private float _angularDrag;

		[Token(Token = "0x400073B")]
		[FieldOffset(Offset = "0x94")]
		private bool _useGravity;

		[Token(Token = "0x400073C")]
		[FieldOffset(Offset = "0x95")]
		private bool _isKinematic;

		[Token(Token = "0x400073D")]
		[FieldOffset(Offset = "0x98")]
		private RigidbodyInterpolation _interpolation;

		[Token(Token = "0x400073E")]
		[FieldOffset(Offset = "0x9C")]
		private CollisionDetectionMode _collisionDetectionMode;

		[Token(Token = "0x400073F")]
		[FieldOffset(Offset = "0xA0")]
		private RigidbodyConstraints _constraints;

		[Token(Token = "0x4000740")]
		[FieldOffset(Offset = "0xA8")]
		private Collider[] emptyColliders;

		[Token(Token = "0x1700011B")]
		public bool isPickedUp
		{
			[Token(Token = "0x6000834")]
			[Address(RVA = "0x13D3FD0", Offset = "0x13D3FD0", VA = "0x13D3FD0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x38CE4", Offset = "0x38CE4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000835")]
			[Address(RVA = "0x13D3FD8", Offset = "0x13D3FD8", VA = "0x13D3FD8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x38CF4", Offset = "0x38CF4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700011C")]
		protected Muscle propMuscle
		{
			[Token(Token = "0x6000839")]
			[Address(RVA = "0x13D4098", Offset = "0x13D4098", VA = "0x13D4098")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x38D04", Offset = "0x38D04")]
			get
			{
				return null;
			}
			[Token(Token = "0x600083A")]
			[Address(RVA = "0x13D40A0", Offset = "0x13D40A0", VA = "0x13D40A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x38D14", Offset = "0x38D14")]
			private set
			{
			}
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0x13D3FE0", Offset = "0x13D3FE0", VA = "0x13D3FE0")]
		public Rigidbody GetRigidbody()
		{
			return null;
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0x13D4090", Offset = "0x13D4090", VA = "0x13D4090", Slot = "4")]
		protected virtual void OnPickUp(PuppetMaster puppetMaster, int propMuscleIndex)
		{
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0x13D4094", Offset = "0x13D4094", VA = "0x13D4094", Slot = "5")]
		protected virtual void OnDrop(PuppetMaster puppetMaster, int propMuscleIndex)
		{
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0x13D40A8", Offset = "0x13D40A8", VA = "0x13D40A8")]
		public void PickUp(PuppetMaster puppetMaster, int propMuscleIndex)
		{
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0x13D45AC", Offset = "0x13D45AC", VA = "0x13D45AC")]
		public void Drop(PuppetMaster puppetMaster, int propMuscleIndex)
		{
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0x13D4AF0", Offset = "0x13D4AF0", VA = "0x13D4AF0", Slot = "6")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0x13D4C58", Offset = "0x13D4C58", VA = "0x13D4C58", Slot = "7")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0x13D4E94", Offset = "0x13D4E94", VA = "0x13D4E94", Slot = "8")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0x13D4448", Offset = "0x13D4448", VA = "0x13D4448")]
		private void RemoveRigidbody()
		{
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0x13D4990", Offset = "0x13D4990", VA = "0x13D4990")]
		private void ReattachRigidbody()
		{
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0x13D4F14", Offset = "0x13D4F14", VA = "0x13D4F14")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0x13D5080", Offset = "0x13D5080", VA = "0x13D5080")]
		public PuppetMasterProp()
		{
		}
	}
}
