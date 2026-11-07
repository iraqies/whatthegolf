using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Buoyancy
{
	[Token(Token = "0x20011EC")]
	[ExecuteAlways]
	public class RealisticFloatingProp : MonoBehaviour, IBuoyant
	{
		[Token(Token = "0x400605A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float drag;

		[Token(Token = "0x400605B")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float angularDrag;

		[Token(Token = "0x400605C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float buoyancyMultiplier;

		[Token(Token = "0x400605D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Rigidbody targetRigidbody;

		[Token(Token = "0x400605E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Vector3[] extraCheckPoints;

		[Token(Token = "0x400605F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool checkColliderCorners;

		[Token(Token = "0x4006060")]
		[FieldOffset(Offset = "0x39")]
		[SerializeField]
		private bool increaseBuoyancyByDepth;

		[Token(Token = "0x4006061")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private MinMax depthRange;

		[Token(Token = "0x4006062")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x57B7C", Offset = "0x57B7C")]
		private Transform Transform__BackingField;

		[Token(Token = "0x4006063")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x57B8C", Offset = "0x57B8C")]
		private Collider TargetCollider__BackingField;

		[Token(Token = "0x4006064")]
		[FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x57B9C", Offset = "0x57B9C")]
		private Vector3 ColliderSize__BackingField;

		[Token(Token = "0x4006065")]
		[FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x57BAC", Offset = "0x57BAC")]
		private Vector3 ColliderCenter__BackingField;

		[Token(Token = "0x4006066")]
		[FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x57BBC", Offset = "0x57BBC")]
		private Vector3 ColliderOffset__BackingField;

		[Token(Token = "0x4006067")]
		[FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x57BCC", Offset = "0x57BCC")]
		private float SinkMultiplier__BackingField;

		[Token(Token = "0x4006068")]
		[FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x57BDC", Offset = "0x57BDC")]
		private bool Remove__BackingField;

		[Token(Token = "0x4006069")]
		[FieldOffset(Offset = "0x81")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x57BEC", Offset = "0x57BEC")]
		private bool IsInWater__BackingField;

		[Token(Token = "0x400606A")]
		[FieldOffset(Offset = "0x82")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x57BFC", Offset = "0x57BFC")]
		private bool IsFloatingOnSurface__BackingField;

		[Token(Token = "0x400606B")]
		[FieldOffset(Offset = "0x83")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x57C0C", Offset = "0x57C0C")]
		private bool IsSinking__BackingField;

		[Token(Token = "0x400606C")]
		[FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x57C1C", Offset = "0x57C1C")]
		private Action<Vector3> OnPostSkip__BackingField;

		[Token(Token = "0x400606D")]
		[FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x57C2C", Offset = "0x57C2C")]
		private Action<Vector3> OnEnterWaterNoSkip__BackingField;

		[Token(Token = "0x400606E")]
		[FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x57C3C", Offset = "0x57C3C")]
		private Action OnTargetEnteredWater__BackingField;

		[Token(Token = "0x400606F")]
		[FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x57C4C", Offset = "0x57C4C")]
		private Action OnTargetExitedWater__BackingField;

		[Token(Token = "0x4006070")]
		[FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x57C5C", Offset = "0x57C5C")]
		private bool IsActive__BackingField;

		[Token(Token = "0x4006071")]
		[FieldOffset(Offset = "0xB0")]
		private Vector3[] localBuoyancyPoints;

		[Token(Token = "0x4006072")]
		[FieldOffset(Offset = "0xB8")]
		private Vector3[] worldPoints;

		[Token(Token = "0x4006073")]
		[FieldOffset(Offset = "0xC0")]
		public ForceMode rotationForceMode;

		[Token(Token = "0x170008F9")]
		public Transform Transform
		{
			[Token(Token = "0x6005232")]
			[Address(RVA = "0x16436FC", Offset = "0x16436FC", VA = "0x16436FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708D8", Offset = "0x708D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005233")]
			[Address(RVA = "0x1643704", Offset = "0x1643704", VA = "0x1643704")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708E8", Offset = "0x708E8")]
			private set
			{
			}
		}

		[Token(Token = "0x170008FA")]
		public Collider TargetCollider
		{
			[Token(Token = "0x6005234")]
			[Address(RVA = "0x164370C", Offset = "0x164370C", VA = "0x164370C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708F8", Offset = "0x708F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005235")]
			[Address(RVA = "0x1643714", Offset = "0x1643714", VA = "0x1643714")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70908", Offset = "0x70908")]
			private set
			{
			}
		}

		[Token(Token = "0x170008FB")]
		public Rigidbody Rigid
		{
			[Token(Token = "0x6005236")]
			[Address(RVA = "0x164371C", Offset = "0x164371C", VA = "0x164371C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008FC")]
		public Vector3 ColliderSize
		{
			[Token(Token = "0x6005237")]
			[Address(RVA = "0x1643724", Offset = "0x1643724", VA = "0x1643724")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70918", Offset = "0x70918")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005238")]
			[Address(RVA = "0x1643730", Offset = "0x1643730", VA = "0x1643730")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70928", Offset = "0x70928")]
			private set
			{
			}
		}

		[Token(Token = "0x170008FD")]
		public Vector3 ColliderCenter
		{
			[Token(Token = "0x6005239")]
			[Address(RVA = "0x164373C", Offset = "0x164373C", VA = "0x164373C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70938", Offset = "0x70938")]
			get
			{
				return default;
			}
			[Token(Token = "0x600523A")]
			[Address(RVA = "0x1643748", Offset = "0x1643748", VA = "0x1643748")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70948", Offset = "0x70948")]
			private set
			{
			}
		}

		[Token(Token = "0x170008FE")]
		public Vector3 ColliderOffset
		{
			[Token(Token = "0x600523B")]
			[Address(RVA = "0x1643754", Offset = "0x1643754", VA = "0x1643754")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70958", Offset = "0x70958")]
			get
			{
				return default;
			}
			[Token(Token = "0x600523C")]
			[Address(RVA = "0x1643760", Offset = "0x1643760", VA = "0x1643760")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70968", Offset = "0x70968")]
			private set
			{
			}
		}

		[Token(Token = "0x170008FF")]
		public float SinkMultiplier
		{
			[Token(Token = "0x600523D")]
			[Address(RVA = "0x164376C", Offset = "0x164376C", VA = "0x164376C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70978", Offset = "0x70978")]
			get
			{
				return default;
			}
			[Token(Token = "0x600523E")]
			[Address(RVA = "0x1643774", Offset = "0x1643774", VA = "0x1643774")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70988", Offset = "0x70988")]
			private set
			{
			}
		}

		[Token(Token = "0x17000900")]
		public bool Remove
		{
			[Token(Token = "0x600523F")]
			[Address(RVA = "0x164377C", Offset = "0x164377C", VA = "0x164377C", Slot = "7")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70998", Offset = "0x70998")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005240")]
			[Address(RVA = "0x1643784", Offset = "0x1643784", VA = "0x1643784")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x709A8", Offset = "0x709A8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000901")]
		public bool IsInWater
		{
			[Token(Token = "0x6005241")]
			[Address(RVA = "0x164378C", Offset = "0x164378C", VA = "0x164378C", Slot = "15")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x709B8", Offset = "0x709B8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005242")]
			[Address(RVA = "0x1643794", Offset = "0x1643794", VA = "0x1643794")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x709C8", Offset = "0x709C8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000902")]
		public bool IsFloatingOnSurface
		{
			[Token(Token = "0x6005243")]
			[Address(RVA = "0x164379C", Offset = "0x164379C", VA = "0x164379C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x709D8", Offset = "0x709D8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005244")]
			[Address(RVA = "0x16437A4", Offset = "0x16437A4", VA = "0x16437A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x709E8", Offset = "0x709E8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000903")]
		public bool IsSinking
		{
			[Token(Token = "0x6005245")]
			[Address(RVA = "0x16437AC", Offset = "0x16437AC", VA = "0x16437AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x709F8", Offset = "0x709F8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005246")]
			[Address(RVA = "0x16437B4", Offset = "0x16437B4", VA = "0x16437B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70A08", Offset = "0x70A08")]
			private set
			{
			}
		}

		[Token(Token = "0x17000904")]
		public Action<Vector3> OnPostSkip
		{
			[Token(Token = "0x6005247")]
			[Address(RVA = "0x16437BC", Offset = "0x16437BC", VA = "0x16437BC", Slot = "11")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70A18", Offset = "0x70A18")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005248")]
			[Address(RVA = "0x16437C4", Offset = "0x16437C4", VA = "0x16437C4", Slot = "12")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70A28", Offset = "0x70A28")]
			set
			{
			}
		}

		[Token(Token = "0x17000905")]
		public Action<Vector3> OnEnterWaterNoSkip
		{
			[Token(Token = "0x6005249")]
			[Address(RVA = "0x16437CC", Offset = "0x16437CC", VA = "0x16437CC", Slot = "9")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70A38", Offset = "0x70A38")]
			get
			{
				return null;
			}
			[Token(Token = "0x600524A")]
			[Address(RVA = "0x16437D4", Offset = "0x16437D4", VA = "0x16437D4", Slot = "10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70A48", Offset = "0x70A48")]
			set
			{
			}
		}

		[Token(Token = "0x17000906")]
		public Action OnTargetEnteredWater
		{
			[Token(Token = "0x600524B")]
			[Address(RVA = "0x16437DC", Offset = "0x16437DC", VA = "0x16437DC", Slot = "16")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70A58", Offset = "0x70A58")]
			get
			{
				return null;
			}
			[Token(Token = "0x600524C")]
			[Address(RVA = "0x16437E4", Offset = "0x16437E4", VA = "0x16437E4", Slot = "17")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70A68", Offset = "0x70A68")]
			set
			{
			}
		}

		[Token(Token = "0x17000907")]
		public Action OnTargetExitedWater
		{
			[Token(Token = "0x600524D")]
			[Address(RVA = "0x16437EC", Offset = "0x16437EC", VA = "0x16437EC", Slot = "13")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70A78", Offset = "0x70A78")]
			get
			{
				return null;
			}
			[Token(Token = "0x600524E")]
			[Address(RVA = "0x16437F4", Offset = "0x16437F4", VA = "0x16437F4", Slot = "14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70A88", Offset = "0x70A88")]
			set
			{
			}
		}

		[Token(Token = "0x17000908")]
		public bool IsActive
		{
			[Token(Token = "0x600524F")]
			[Address(RVA = "0x16437FC", Offset = "0x16437FC", VA = "0x16437FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70A98", Offset = "0x70A98")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005250")]
			[Address(RVA = "0x1643804", Offset = "0x1643804", VA = "0x1643804")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70AA8", Offset = "0x70AA8")]
			set
			{
			}
		}

		[Token(Token = "0x6005251")]
		[Address(RVA = "0x164380C", Offset = "0x164380C", VA = "0x164380C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005252")]
		[Address(RVA = "0x1643810", Offset = "0x1643810", VA = "0x1643810")]
		public void Initialize()
		{
		}

		[Token(Token = "0x6005253")]
		[Address(RVA = "0x1643B7C", Offset = "0x1643B7C", VA = "0x1643B7C")]
		private int GetTargetPointCount()
		{
			return default;
		}

		[Token(Token = "0x6005254")]
		[Address(RVA = "0x1643968", Offset = "0x1643968", VA = "0x1643968")]
		private void InitializeBuoyancyPoints()
		{
		}

		[Token(Token = "0x6005255")]
		[Address(RVA = "0x1643BA0", Offset = "0x1643BA0", VA = "0x1643BA0")]
		public void SetBuoyancy(float b)
		{
		}

		[Token(Token = "0x6005256")]
		[Address(RVA = "0x1643BA8", Offset = "0x1643BA8", VA = "0x1643BA8")]
		public void SetWorldPoints()
		{
		}

		[Token(Token = "0x6005257")]
		[Address(RVA = "0x1643C60", Offset = "0x1643C60", VA = "0x1643C60", Slot = "4")]
		public void HandleFloating(IBuoyantWater water)
		{
		}

		[Token(Token = "0x6005258")]
		[Address(RVA = "0x16441B8", Offset = "0x16441B8", VA = "0x16441B8", Slot = "5")]
		public void OnEnterWater(IBuoyantWater water)
		{
		}

		[Token(Token = "0x6005259")]
		[Address(RVA = "0x1644248", Offset = "0x1644248", VA = "0x1644248", Slot = "6")]
		public void OnExitWater(IBuoyantWater water)
		{
		}

		[Token(Token = "0x600525A")]
		[Address(RVA = "0x1644260", Offset = "0x1644260", VA = "0x1644260")]
		public void OnEnterWater()
		{
		}

		[Token(Token = "0x600525B")]
		[Address(RVA = "0x16442E4", Offset = "0x16442E4", VA = "0x16442E4")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600525C")]
		[Address(RVA = "0x16443A0", Offset = "0x16443A0", VA = "0x16443A0")]
		public RealisticFloatingProp()
		{
		}
	}
}
