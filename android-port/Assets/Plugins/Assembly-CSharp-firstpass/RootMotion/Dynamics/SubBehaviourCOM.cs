using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Dynamics
{
	[Serializable]
	[Token(Token = "0x2000107")]
	public class SubBehaviourCOM : SubBehaviourBase
	{
		[Serializable]
		[Token(Token = "0x2000108")]
		public enum Mode
		{
			[Token(Token = "0x40005DE")]
			FeetCentroid = 0,
			[Token(Token = "0x40005DF")]
			CenterOfPressure = 1
		}

		[Token(Token = "0x40005CB")]
		[FieldOffset(Offset = "0x18")]
		public Mode mode;

		[Token(Token = "0x40005CC")]
		[FieldOffset(Offset = "0x1C")]
		public float velocityDamper;

		[Token(Token = "0x40005CD")]
		[FieldOffset(Offset = "0x20")]
		public float velocityLerpSpeed;

		[Token(Token = "0x40005CE")]
		[FieldOffset(Offset = "0x24")]
		public float velocityMax;

		[Token(Token = "0x40005CF")]
		[FieldOffset(Offset = "0x28")]
		public float centerOfPressureSpeed;

		[Token(Token = "0x40005D0")]
		[FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x40005D1")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x355A4", Offset = "0x355A4")]
		private Vector3 position__BackingField;

		[Token(Token = "0x40005D2")]
		[FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x355B4", Offset = "0x355B4")]
		private Vector3 direction__BackingField;

		[Token(Token = "0x40005D3")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x355C4", Offset = "0x355C4")]
		private float angle__BackingField;

		[Token(Token = "0x40005D4")]
		[FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x355D4", Offset = "0x355D4")]
		private Vector3 velocity__BackingField;

		[Token(Token = "0x40005D5")]
		[FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x355E4", Offset = "0x355E4")]
		private Vector3 centerOfPressure__BackingField;

		[Token(Token = "0x40005D6")]
		[FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x355F4", Offset = "0x355F4")]
		private Quaternion rotation__BackingField;

		[Token(Token = "0x40005D7")]
		[FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x35604", Offset = "0x35604")]
		private Quaternion inverseRotation__BackingField;

		[Token(Token = "0x40005D8")]
		[FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x35614", Offset = "0x35614")]
		private bool isGrounded__BackingField;

		[Token(Token = "0x40005D9")]
		[FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x35624", Offset = "0x35624")]
		private float lastGroundedTime__BackingField;

		[Token(Token = "0x40005DA")]
		[FieldOffset(Offset = "0x98")]
		public bool[] groundContacts;

		[Token(Token = "0x40005DB")]
		[FieldOffset(Offset = "0xA0")]
		public Vector3[] groundContactPoints;

		[Token(Token = "0x40005DC")]
		[FieldOffset(Offset = "0xA8")]
		private LayerMask groundLayers;

		[Token(Token = "0x170000DC")]
		public Vector3 position
		{
			[Token(Token = "0x60006C0")]
			[Address(RVA = "0x1401B10", Offset = "0x1401B10", VA = "0x1401B10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38494", Offset = "0x38494")]
			get
			{
				return default;
			}
			[Token(Token = "0x60006C1")]
			[Address(RVA = "0x1401B1C", Offset = "0x1401B1C", VA = "0x1401B1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x384A4", Offset = "0x384A4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000DD")]
		public Vector3 direction
		{
			[Token(Token = "0x60006C2")]
			[Address(RVA = "0x1401B28", Offset = "0x1401B28", VA = "0x1401B28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x384B4", Offset = "0x384B4")]
			get
			{
				return default;
			}
			[Token(Token = "0x60006C3")]
			[Address(RVA = "0x1401B34", Offset = "0x1401B34", VA = "0x1401B34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x384C4", Offset = "0x384C4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000DE")]
		public float angle
		{
			[Token(Token = "0x60006C4")]
			[Address(RVA = "0x1401B40", Offset = "0x1401B40", VA = "0x1401B40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x384D4", Offset = "0x384D4")]
			get
			{
				return default;
			}
			[Token(Token = "0x60006C5")]
			[Address(RVA = "0x1401B48", Offset = "0x1401B48", VA = "0x1401B48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x384E4", Offset = "0x384E4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000DF")]
		public Vector3 velocity
		{
			[Token(Token = "0x60006C6")]
			[Address(RVA = "0x1401B50", Offset = "0x1401B50", VA = "0x1401B50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x384F4", Offset = "0x384F4")]
			get
			{
				return default;
			}
			[Token(Token = "0x60006C7")]
			[Address(RVA = "0x1401B5C", Offset = "0x1401B5C", VA = "0x1401B5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38504", Offset = "0x38504")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E0")]
		public Vector3 centerOfPressure
		{
			[Token(Token = "0x60006C8")]
			[Address(RVA = "0x1401B68", Offset = "0x1401B68", VA = "0x1401B68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38514", Offset = "0x38514")]
			get
			{
				return default;
			}
			[Token(Token = "0x60006C9")]
			[Address(RVA = "0x1401B74", Offset = "0x1401B74", VA = "0x1401B74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38524", Offset = "0x38524")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E1")]
		public Quaternion rotation
		{
			[Token(Token = "0x60006CA")]
			[Address(RVA = "0x1401B80", Offset = "0x1401B80", VA = "0x1401B80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38534", Offset = "0x38534")]
			get
			{
				return default;
			}
			[Token(Token = "0x60006CB")]
			[Address(RVA = "0x1401B8C", Offset = "0x1401B8C", VA = "0x1401B8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38544", Offset = "0x38544")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E2")]
		private Quaternion inverseRotation
		{
			[Token(Token = "0x60006CC")]
			[Address(RVA = "0x1401B98", Offset = "0x1401B98", VA = "0x1401B98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38554", Offset = "0x38554")]
			set
			{
			}
		}

		[Token(Token = "0x170000E3")]
		public bool isGrounded
		{
			[Token(Token = "0x60006CD")]
			[Address(RVA = "0x1401BA4", Offset = "0x1401BA4", VA = "0x1401BA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38564", Offset = "0x38564")]
			get
			{
				return default;
			}
			[Token(Token = "0x60006CE")]
			[Address(RVA = "0x1401BAC", Offset = "0x1401BAC", VA = "0x1401BAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38574", Offset = "0x38574")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E4")]
		private float lastGroundedTime
		{
			[Token(Token = "0x60006CF")]
			[Address(RVA = "0x1401BB4", Offset = "0x1401BB4", VA = "0x1401BB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38584", Offset = "0x38584")]
			set
			{
			}
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x1401BBC", Offset = "0x1401BBC", VA = "0x1401BBC")]
		public void Initiate(BehaviourBase behaviour, LayerMask groundLayers)
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x1401F24", Offset = "0x1401F24", VA = "0x1401F24")]
		private void OnHierarchyChanged()
		{
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x1401FCC", Offset = "0x1401FCC", VA = "0x1401FCC")]
		private void OnPreMuscleCollision(MuscleCollision c)
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x14021B0", Offset = "0x14021B0", VA = "0x14021B0")]
		private void OnPreMuscleCollisionExit(MuscleCollision c)
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x1402268", Offset = "0x1402268", VA = "0x1402268")]
		private void OnPreActivate()
		{
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x1402514", Offset = "0x1402514", VA = "0x1402514")]
		private void OnPreLateUpdate()
		{
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x1402AE0", Offset = "0x1402AE0", VA = "0x1402AE0")]
		private void OnPreDeactivate()
		{
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x14020BC", Offset = "0x14020BC", VA = "0x14020BC")]
		private Vector3 GetCollisionCOP(Collision collision)
		{
			return default;
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x1402814", Offset = "0x1402814", VA = "0x1402814")]
		private bool IsGrounded()
		{
			return default;
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x1402308", Offset = "0x1402308", VA = "0x1402308")]
		private Vector3 GetCenterOfMass()
		{
			return default;
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x1402958", Offset = "0x1402958", VA = "0x1402958")]
		private Vector3 GetCenterOfMassVelocity()
		{
			return default;
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x1402884", Offset = "0x1402884", VA = "0x1402884")]
		private Vector3 GetCenterOfPressure()
		{
			return default;
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x140242C", Offset = "0x140242C", VA = "0x140242C")]
		private Vector3 GetFeetCentroid()
		{
			return default;
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x1402B0C", Offset = "0x1402B0C", VA = "0x1402B0C")]
		public SubBehaviourCOM()
		{
		}
	}
}
