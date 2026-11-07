using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	[Token(Token = "0x2000190")]
	public class InteractionEffector
	{
		[Token(Token = "0x4000ABC")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x366F4", Offset = "0x366F4")]
		private FullBodyBipedEffector effectorType__BackingField;

		[Token(Token = "0x4000ABD")]
		[FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x36704", Offset = "0x36704")]
		private bool isPaused__BackingField;

		[Token(Token = "0x4000ABE")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x36714", Offset = "0x36714")]
		private InteractionObject interactionObject__BackingField;

		[Token(Token = "0x4000ABF")]
		[FieldOffset(Offset = "0x20")]
		private Poser poser;

		[Token(Token = "0x4000AC0")]
		[FieldOffset(Offset = "0x28")]
		private IKEffector effector;

		[Token(Token = "0x4000AC1")]
		[FieldOffset(Offset = "0x30")]
		private float timer;

		[Token(Token = "0x4000AC2")]
		[FieldOffset(Offset = "0x34")]
		private float length;

		[Token(Token = "0x4000AC3")]
		[FieldOffset(Offset = "0x38")]
		private float weight;

		[Token(Token = "0x4000AC4")]
		[FieldOffset(Offset = "0x3C")]
		private float fadeInSpeed;

		[Token(Token = "0x4000AC5")]
		[FieldOffset(Offset = "0x40")]
		private float defaultPositionWeight;

		[Token(Token = "0x4000AC6")]
		[FieldOffset(Offset = "0x44")]
		private float defaultRotationWeight;

		[Token(Token = "0x4000AC7")]
		[FieldOffset(Offset = "0x48")]
		private float defaultPull;

		[Token(Token = "0x4000AC8")]
		[FieldOffset(Offset = "0x4C")]
		private float defaultReach;

		[Token(Token = "0x4000AC9")]
		[FieldOffset(Offset = "0x50")]
		private float defaultPush;

		[Token(Token = "0x4000ACA")]
		[FieldOffset(Offset = "0x54")]
		private float defaultPushParent;

		[Token(Token = "0x4000ACB")]
		[FieldOffset(Offset = "0x58")]
		private float defaultBendGoalWeight;

		[Token(Token = "0x4000ACC")]
		[FieldOffset(Offset = "0x5C")]
		private float resetTimer;

		[Token(Token = "0x4000ACD")]
		[FieldOffset(Offset = "0x60")]
		private bool positionWeightUsed;

		[Token(Token = "0x4000ACE")]
		[FieldOffset(Offset = "0x61")]
		private bool rotationWeightUsed;

		[Token(Token = "0x4000ACF")]
		[FieldOffset(Offset = "0x62")]
		private bool pullUsed;

		[Token(Token = "0x4000AD0")]
		[FieldOffset(Offset = "0x63")]
		private bool reachUsed;

		[Token(Token = "0x4000AD1")]
		[FieldOffset(Offset = "0x64")]
		private bool pushUsed;

		[Token(Token = "0x4000AD2")]
		[FieldOffset(Offset = "0x65")]
		private bool pushParentUsed;

		[Token(Token = "0x4000AD3")]
		[FieldOffset(Offset = "0x66")]
		private bool bendGoalWeightUsed;

		[Token(Token = "0x4000AD4")]
		[FieldOffset(Offset = "0x67")]
		private bool pickedUp;

		[Token(Token = "0x4000AD5")]
		[FieldOffset(Offset = "0x68")]
		private bool defaults;

		[Token(Token = "0x4000AD6")]
		[FieldOffset(Offset = "0x69")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x4000AD7")]
		[FieldOffset(Offset = "0x6C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x4000AD8")]
		[FieldOffset(Offset = "0x78")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x4000AD9")]
		[FieldOffset(Offset = "0x84")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x4000ADA")]
		[FieldOffset(Offset = "0x94")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x4000ADB")]
		[FieldOffset(Offset = "0xA8")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x4000ADC")]
		[FieldOffset(Offset = "0xB0")]
		private Transform target;

		[Token(Token = "0x4000ADD")]
		[FieldOffset(Offset = "0xB8")]
		private List<bool> triggered;

		[Token(Token = "0x4000ADE")]
		[FieldOffset(Offset = "0xC0")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x4000ADF")]
		[FieldOffset(Offset = "0xC8")]
		private bool started;

		[Token(Token = "0x17000186")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x6000BBB")]
			[Address(RVA = "0x139E314", Offset = "0x139E314", VA = "0x139E314")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A22C", Offset = "0x3A22C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000BBC")]
			[Address(RVA = "0x139E31C", Offset = "0x139E31C", VA = "0x139E31C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A23C", Offset = "0x3A23C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000187")]
		public bool isPaused
		{
			[Token(Token = "0x6000BBD")]
			[Address(RVA = "0x139E324", Offset = "0x139E324", VA = "0x139E324")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A24C", Offset = "0x3A24C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000BBE")]
			[Address(RVA = "0x139E32C", Offset = "0x139E32C", VA = "0x139E32C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A25C", Offset = "0x3A25C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000188")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x6000BBF")]
			[Address(RVA = "0x139E334", Offset = "0x139E334", VA = "0x139E334")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A26C", Offset = "0x3A26C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BC0")]
			[Address(RVA = "0x139E33C", Offset = "0x139E33C", VA = "0x139E33C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A27C", Offset = "0x3A27C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000189")]
		public bool inInteraction
		{
			[Token(Token = "0x6000BC1")]
			[Address(RVA = "0x139E344", Offset = "0x139E344", VA = "0x139E344")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700018A")]
		public float progress
		{
			[Token(Token = "0x6000BCA")]
			[Address(RVA = "0x13A07A8", Offset = "0x13A07A8", VA = "0x13A07A8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000BC2")]
		[Address(RVA = "0x139E3C0", Offset = "0x139E3C0", VA = "0x139E3C0")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x6000BC3")]
		[Address(RVA = "0x139E454", Offset = "0x139E454", VA = "0x139E454")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x6000BC4")]
		[Address(RVA = "0x139E4F4", Offset = "0x139E4F4", VA = "0x139E4F4")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x6000BC5")]
		[Address(RVA = "0x139E66C", Offset = "0x139E66C", VA = "0x139E66C")]
		public bool ResetToDefaults(float speed)
		{
			return default;
		}

		[Token(Token = "0x6000BC6")]
		[Address(RVA = "0x139EA44", Offset = "0x139EA44", VA = "0x139EA44")]
		public bool Pause()
		{
			return default;
		}

		[Token(Token = "0x6000BC7")]
		[Address(RVA = "0x139EB5C", Offset = "0x139EB5C", VA = "0x139EB5C")]
		public bool Resume()
		{
			return default;
		}

		[Token(Token = "0x6000BC8")]
		[Address(RVA = "0x139EC14", Offset = "0x139EC14", VA = "0x139EC14")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default;
		}

		[Token(Token = "0x6000BC9")]
		[Address(RVA = "0x139F2A8", Offset = "0x139F2A8", VA = "0x139F2A8")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x6000BCB")]
		[Address(RVA = "0x139FE0C", Offset = "0x139FE0C", VA = "0x139FE0C")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x6000BCC")]
		[Address(RVA = "0x13A0060", Offset = "0x13A0060", VA = "0x13A0060")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x6000BCD")]
		[Address(RVA = "0x13A05F4", Offset = "0x13A05F4", VA = "0x13A05F4")]
		public bool Stop()
		{
			return default;
		}

		[Token(Token = "0x6000BCE")]
		[Address(RVA = "0x13A08E4", Offset = "0x13A08E4", VA = "0x13A08E4")]
		public void OnPostFBBIK()
		{
		}
	}
}
