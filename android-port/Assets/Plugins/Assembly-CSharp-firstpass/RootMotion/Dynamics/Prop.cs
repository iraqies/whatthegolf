using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Dynamics
{
	[Token(Token = "0x2000116")]
	public abstract class Prop : MonoBehaviour
	{
		[Token(Token = "0x4000670")]
		[FieldOffset(Offset = "0x18")]
		public int propType;

		[Token(Token = "0x4000671")]
		[FieldOffset(Offset = "0x20")]
		public ConfigurableJoint muscle;

		[Token(Token = "0x4000672")]
		[FieldOffset(Offset = "0x28")]
		public Muscle.Props muscleProps;

		[Token(Token = "0x4000673")]
		[FieldOffset(Offset = "0x30")]
		public bool forceLayers;

		[Token(Token = "0x4000674")]
		[FieldOffset(Offset = "0x38")]
		public ConfigurableJoint additionalPin;

		[Token(Token = "0x4000675")]
		[FieldOffset(Offset = "0x40")]
		public Transform additionalPinTarget;

		[Token(Token = "0x4000676")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "RangeAttribute", RVA = "0x3583C", Offset = "0x3583C")]
		public float additionalPinWeight;

		[Token(Token = "0x4000677")]
		[FieldOffset(Offset = "0x50")]
		public PhysicMaterial pickedUpMaterial;

		[Token(Token = "0x4000678")]
		[FieldOffset(Offset = "0x58")]
		public PhysicMaterial droppedMaterial;

		[Token(Token = "0x4000679")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x35854", Offset = "0x35854")]
		private PropRoot propRoot__BackingField;

		[Token(Token = "0x400067A")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x35864", Offset = "0x35864")]
		private bool initiated__BackingField;

		[Token(Token = "0x400067B")]
		[FieldOffset(Offset = "0x6C")]
		private ConfigurableJointMotion xMotion;

		[Token(Token = "0x400067C")]
		[FieldOffset(Offset = "0x70")]
		private ConfigurableJointMotion yMotion;

		[Token(Token = "0x400067D")]
		[FieldOffset(Offset = "0x74")]
		private ConfigurableJointMotion zMotion;

		[Token(Token = "0x400067E")]
		[FieldOffset(Offset = "0x78")]
		private ConfigurableJointMotion angularXMotion;

		[Token(Token = "0x400067F")]
		[FieldOffset(Offset = "0x7C")]
		private ConfigurableJointMotion angularYMotion;

		[Token(Token = "0x4000680")]
		[FieldOffset(Offset = "0x80")]
		private ConfigurableJointMotion angularZMotion;

		[Token(Token = "0x4000681")]
		[FieldOffset(Offset = "0x88")]
		private Collider[] colliders;

		[Token(Token = "0x170000FC")]
		public bool isPickedUp
		{
			[Token(Token = "0x6000744")]
			[Address(RVA = "0x13C1108", Offset = "0x13C1108", VA = "0x13C1108")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000FD")]
		public PropRoot propRoot
		{
			[Token(Token = "0x6000745")]
			[Address(RVA = "0x13C1184", Offset = "0x13C1184", VA = "0x13C1184")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x387B4", Offset = "0x387B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000746")]
			[Address(RVA = "0x13C118C", Offset = "0x13C118C", VA = "0x13C118C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x387C4", Offset = "0x387C4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000FE")]
		public bool initiated
		{
			[Token(Token = "0x600074A")]
			[Address(RVA = "0x13C1454", Offset = "0x13C1454", VA = "0x13C1454")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x387D4", Offset = "0x387D4")]
			get
			{
				return default;
			}
			[Token(Token = "0x600074B")]
			[Address(RVA = "0x13C145C", Offset = "0x13C145C", VA = "0x13C145C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x387E4", Offset = "0x387E4")]
			private set
			{
			}
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x13C1194", Offset = "0x13C1194", VA = "0x13C1194")]
		public void PickUp(PropRoot propRoot)
		{
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x13C1418", Offset = "0x13C1418", VA = "0x13C1418")]
		public void Drop()
		{
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x13C144C", Offset = "0x13C144C", VA = "0x13C144C")]
		public void StartPickedUp(PropRoot propRoot)
		{
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0x13C1464", Offset = "0x13C1464", VA = "0x13C1464", Slot = "4")]
		protected virtual void OnPickUp(PropRoot propRoot)
		{
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x13C1468", Offset = "0x13C1468", VA = "0x13C1468", Slot = "5")]
		protected virtual void OnDrop()
		{
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x13C146C", Offset = "0x13C146C", VA = "0x13C146C", Slot = "6")]
		protected virtual void OnStart()
		{
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x13C1470", Offset = "0x13C1470", VA = "0x13C1470")]
		private void Start()
		{
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x13C16EC", Offset = "0x13C16EC", VA = "0x13C16EC")]
		private void ReleaseJoint()
		{
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0x13C1344", Offset = "0x13C1344", VA = "0x13C1344")]
		private void SetMaterial(PhysicMaterial material)
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x13C17F4", Offset = "0x13C17F4", VA = "0x13C17F4")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x13C19B0", Offset = "0x13C19B0", VA = "0x13C19B0")]
		protected Prop()
		{
		}
	}
}
