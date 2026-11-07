using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Buoyancy
{
	[Token(Token = "0x20011E7")]
	public class BuoyancyTarget : MonoBehaviour, IBuoyant
	{
		[Token(Token = "0x4006031")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float buoyancyMultiplier;

		[Token(Token = "0x4006032")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Rigidbody targetRigidbody;

		[Token(Token = "0x4006033")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Vector3[] extraCheckPoints;

		[Token(Token = "0x4006034")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool checkColliderCorners;

		[Token(Token = "0x4006035")]
		[FieldOffset(Offset = "0x31")]
		[SerializeField]
		private bool increaseBuoyancyByDepth;

		[Token(Token = "0x4006036")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float maxDepth;

		[Token(Token = "0x4006037")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool canDoSkip;

		[Token(Token = "0x4006038")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x578DC", Offset = "0x578DC")]
		private float xzFrictionOnSkip;

		[Token(Token = "0x4006039")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5791C", Offset = "0x5791C")]
		[SerializeField]
		private float yFrictionOnSkip;

		[Token(Token = "0x400603A")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float sqrMagnitudeThreshold;

		[Token(Token = "0x400603B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool isRagdoll;

		[Token(Token = "0x400603C")]
		[FieldOffset(Offset = "0x49")]
		[SerializeField]
		private bool sinkAfterDelay;

		[Token(Token = "0x400603D")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float sinkVelocityThreshold;

		[Token(Token = "0x400603E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float sinkDelay;

		[Token(Token = "0x400603F")]
		[FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x579AC", Offset = "0x579AC")]
		private Transform Transform__BackingField;

		[Token(Token = "0x4006040")]
		[FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x579BC", Offset = "0x579BC")]
		private Collider TargetCollider__BackingField;

		[Token(Token = "0x4006041")]
		[FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x579CC", Offset = "0x579CC")]
		private Vector3 ColliderSize__BackingField;

		[Token(Token = "0x4006042")]
		[FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x579DC", Offset = "0x579DC")]
		private Vector3 ColliderCenter__BackingField;

		[Token(Token = "0x4006043")]
		[FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x579EC", Offset = "0x579EC")]
		private Vector3 ColliderOffset__BackingField;

		[Token(Token = "0x4006044")]
		[FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x579FC", Offset = "0x579FC")]
		private float SinkMultiplier__BackingField;

		[Token(Token = "0x4006045")]
		[FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x57A0C", Offset = "0x57A0C")]
		private bool Remove__BackingField;

		[Token(Token = "0x4006046")]
		[FieldOffset(Offset = "0x91")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x57A1C", Offset = "0x57A1C")]
		private bool IsInWater__BackingField;

		[Token(Token = "0x4006047")]
		[FieldOffset(Offset = "0x92")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x57A2C", Offset = "0x57A2C")]
		private bool IsFloatingOnSurface__BackingField;

		[Token(Token = "0x4006048")]
		[FieldOffset(Offset = "0x93")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x57A3C", Offset = "0x57A3C")]
		private bool IsSinking__BackingField;

		[Token(Token = "0x4006049")]
		[FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x57A4C", Offset = "0x57A4C")]
		private Action<Vector3> OnPostSkip__BackingField;

		[Token(Token = "0x400604A")]
		[FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x57A5C", Offset = "0x57A5C")]
		private Action<Vector3> OnEnterWaterNoSkip__BackingField;

		[Token(Token = "0x400604B")]
		[FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x57A6C", Offset = "0x57A6C")]
		private Action OnTargetEnteredWater__BackingField;

		[Token(Token = "0x400604C")]
		[FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x57A7C", Offset = "0x57A7C")]
		private Action OnTargetExitedWater__BackingField;

		[Token(Token = "0x400604D")]
		[FieldOffset(Offset = "0xB8")]
		private List<Rigidbody> ragdollRigidbodies;

		[Token(Token = "0x400604E")]
		[FieldOffset(Offset = "0xC0")]
		private List<Vector3> localBuoyancyPoints;

		[Token(Token = "0x400604F")]
		[FieldOffset(Offset = "0xC8")]
		private float sinkTimer;

		[Token(Token = "0x4006050")]
		[FieldOffset(Offset = "0xCC")]
		public ForceMode rotationForceMode;

		[Token(Token = "0x170008DC")]
		public Transform Transform
		{
			[Token(Token = "0x60051E7")]
			[Address(RVA = "0x170C4C4", Offset = "0x170C4C4", VA = "0x170C4C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70678", Offset = "0x70678")]
			get
			{
				return null;
			}
			[Token(Token = "0x60051E8")]
			[Address(RVA = "0x170C4CC", Offset = "0x170C4CC", VA = "0x170C4CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70688", Offset = "0x70688")]
			private set
			{
			}
		}

		[Token(Token = "0x170008DD")]
		public Collider TargetCollider
		{
			[Token(Token = "0x60051E9")]
			[Address(RVA = "0x170C4D4", Offset = "0x170C4D4", VA = "0x170C4D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70698", Offset = "0x70698")]
			get
			{
				return null;
			}
			[Token(Token = "0x60051EA")]
			[Address(RVA = "0x170C4DC", Offset = "0x170C4DC", VA = "0x170C4DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706A8", Offset = "0x706A8")]
			private set
			{
			}
		}

		[Token(Token = "0x170008DE")]
		public Rigidbody Rigid
		{
			[Token(Token = "0x60051EB")]
			[Address(RVA = "0x170C4E4", Offset = "0x170C4E4", VA = "0x170C4E4", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008DF")]
		public Vector3 ColliderSize
		{
			[Token(Token = "0x60051EC")]
			[Address(RVA = "0x170C4EC", Offset = "0x170C4EC", VA = "0x170C4EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706B8", Offset = "0x706B8")]
			get
			{
				return default;
			}
			[Token(Token = "0x60051ED")]
			[Address(RVA = "0x170C4F8", Offset = "0x170C4F8", VA = "0x170C4F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706C8", Offset = "0x706C8")]
			private set
			{
			}
		}

		[Token(Token = "0x170008E0")]
		public Vector3 ColliderCenter
		{
			[Token(Token = "0x60051EE")]
			[Address(RVA = "0x170C504", Offset = "0x170C504", VA = "0x170C504")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706D8", Offset = "0x706D8")]
			get
			{
				return default;
			}
			[Token(Token = "0x60051EF")]
			[Address(RVA = "0x170C510", Offset = "0x170C510", VA = "0x170C510")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706E8", Offset = "0x706E8")]
			private set
			{
			}
		}

		[Token(Token = "0x170008E1")]
		public Vector3 ColliderOffset
		{
			[Token(Token = "0x60051F0")]
			[Address(RVA = "0x170C51C", Offset = "0x170C51C", VA = "0x170C51C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706F8", Offset = "0x706F8")]
			get
			{
				return default;
			}
			[Token(Token = "0x60051F1")]
			[Address(RVA = "0x170C528", Offset = "0x170C528", VA = "0x170C528")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70708", Offset = "0x70708")]
			private set
			{
			}
		}

		[Token(Token = "0x170008E2")]
		public float SinkMultiplier
		{
			[Token(Token = "0x60051F2")]
			[Address(RVA = "0x170C534", Offset = "0x170C534", VA = "0x170C534")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70718", Offset = "0x70718")]
			get
			{
				return default;
			}
			[Token(Token = "0x60051F3")]
			[Address(RVA = "0x170C53C", Offset = "0x170C53C", VA = "0x170C53C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70728", Offset = "0x70728")]
			private set
			{
			}
		}

		[Token(Token = "0x170008E3")]
		public bool Remove
		{
			[Token(Token = "0x60051F4")]
			[Address(RVA = "0x170C544", Offset = "0x170C544", VA = "0x170C544", Slot = "7")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70738", Offset = "0x70738")]
			get
			{
				return default;
			}
			[Token(Token = "0x60051F5")]
			[Address(RVA = "0x170C54C", Offset = "0x170C54C", VA = "0x170C54C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70748", Offset = "0x70748")]
			private set
			{
			}
		}

		[Token(Token = "0x170008E4")]
		public bool IsInWater
		{
			[Token(Token = "0x60051F6")]
			[Address(RVA = "0x170C554", Offset = "0x170C554", VA = "0x170C554", Slot = "15")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70758", Offset = "0x70758")]
			get
			{
				return default;
			}
			[Token(Token = "0x60051F7")]
			[Address(RVA = "0x170C55C", Offset = "0x170C55C", VA = "0x170C55C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70768", Offset = "0x70768")]
			private set
			{
			}
		}

		[Token(Token = "0x170008E5")]
		public bool IsFloatingOnSurface
		{
			[Token(Token = "0x60051F8")]
			[Address(RVA = "0x170C564", Offset = "0x170C564", VA = "0x170C564")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70778", Offset = "0x70778")]
			get
			{
				return default;
			}
			[Token(Token = "0x60051F9")]
			[Address(RVA = "0x170C56C", Offset = "0x170C56C", VA = "0x170C56C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70788", Offset = "0x70788")]
			private set
			{
			}
		}

		[Token(Token = "0x170008E6")]
		public bool IsSinking
		{
			[Token(Token = "0x60051FA")]
			[Address(RVA = "0x170C574", Offset = "0x170C574", VA = "0x170C574")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70798", Offset = "0x70798")]
			get
			{
				return default;
			}
			[Token(Token = "0x60051FB")]
			[Address(RVA = "0x170C57C", Offset = "0x170C57C", VA = "0x170C57C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x707A8", Offset = "0x707A8")]
			private set
			{
			}
		}

		[Token(Token = "0x170008E7")]
		public Action<Vector3> OnPostSkip
		{
			[Token(Token = "0x60051FC")]
			[Address(RVA = "0x170C584", Offset = "0x170C584", VA = "0x170C584", Slot = "11")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x707B8", Offset = "0x707B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60051FD")]
			[Address(RVA = "0x170C58C", Offset = "0x170C58C", VA = "0x170C58C", Slot = "12")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x707C8", Offset = "0x707C8")]
			set
			{
			}
		}

		[Token(Token = "0x170008E8")]
		public Action<Vector3> OnEnterWaterNoSkip
		{
			[Token(Token = "0x60051FE")]
			[Address(RVA = "0x170C594", Offset = "0x170C594", VA = "0x170C594", Slot = "9")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x707D8", Offset = "0x707D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60051FF")]
			[Address(RVA = "0x170C59C", Offset = "0x170C59C", VA = "0x170C59C", Slot = "10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x707E8", Offset = "0x707E8")]
			set
			{
			}
		}

		[Token(Token = "0x170008E9")]
		public Action OnTargetEnteredWater
		{
			[Token(Token = "0x6005200")]
			[Address(RVA = "0x170C5A4", Offset = "0x170C5A4", VA = "0x170C5A4", Slot = "16")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x707F8", Offset = "0x707F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005201")]
			[Address(RVA = "0x170C5AC", Offset = "0x170C5AC", VA = "0x170C5AC", Slot = "17")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70808", Offset = "0x70808")]
			set
			{
			}
		}

		[Token(Token = "0x170008EA")]
		public Action OnTargetExitedWater
		{
			[Token(Token = "0x6005202")]
			[Address(RVA = "0x170C5B4", Offset = "0x170C5B4", VA = "0x170C5B4", Slot = "13")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70818", Offset = "0x70818")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005203")]
			[Address(RVA = "0x170C5BC", Offset = "0x170C5BC", VA = "0x170C5BC", Slot = "14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70828", Offset = "0x70828")]
			set
			{
			}
		}

		[Token(Token = "0x6005204")]
		[Address(RVA = "0x170C5C4", Offset = "0x170C5C4", VA = "0x170C5C4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005205")]
		[Address(RVA = "0x170C734", Offset = "0x170C734", VA = "0x170C734")]
		public void Initialize()
		{
		}

		[Token(Token = "0x6005206")]
		[Address(RVA = "0x170C9E0", Offset = "0x170C9E0", VA = "0x170C9E0")]
		private int GetTargetPointCount()
		{
			return default;
		}

		[Token(Token = "0x6005207")]
		[Address(RVA = "0x170C814", Offset = "0x170C814", VA = "0x170C814")]
		private void InitializeBuoyancyPoints()
		{
		}

		[Token(Token = "0x6005208")]
		[Address(RVA = "0x170CA04", Offset = "0x170CA04", VA = "0x170CA04")]
		public List<Vector3> GetPointsWorld()
		{
			return null;
		}

		[Token(Token = "0x6005209")]
		[Address(RVA = "0x170CC14", Offset = "0x170CC14", VA = "0x170CC14", Slot = "4")]
		public void HandleFloating(IBuoyantWater water)
		{
		}

		[Token(Token = "0x600520A")]
		[Address(RVA = "0x170D344", Offset = "0x170D344", VA = "0x170D344", Slot = "5")]
		public void OnEnterWater(IBuoyantWater water)
		{
		}

		[Token(Token = "0x600520B")]
		[Address(RVA = "0x170D724", Offset = "0x170D724", VA = "0x170D724", Slot = "6")]
		public void OnExitWater(IBuoyantWater water)
		{
		}

		[Token(Token = "0x600520C")]
		[Address(RVA = "0x170D73C", Offset = "0x170D73C", VA = "0x170D73C")]
		public void OnEnterWater()
		{
		}

		[Token(Token = "0x600520D")]
		[Address(RVA = "0x170D410", Offset = "0x170D410", VA = "0x170D410")]
		private bool DoSkip()
		{
			return default;
		}

		[Token(Token = "0x600520E")]
		[Address(RVA = "0x170D7FC", Offset = "0x170D7FC", VA = "0x170D7FC")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600520F")]
		[Address(RVA = "0x170D974", Offset = "0x170D974", VA = "0x170D974")]
		public BuoyancyTarget()
		{
		}
	}
}
