using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Token(Token = "0x20001D5")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20001D6")]
		public class RecoilOffset
		{
			[Serializable]
			[Token(Token = "0x20001D7")]
			public class EffectorLink
			{
				[Token(Token = "0x4000C6D")]
				[FieldOffset(Offset = "0x10")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000C6E")]
				[FieldOffset(Offset = "0x14")]
				public float weight;

				[Token(Token = "0x6000D78")]
				[Address(RVA = "0x135AEDC", Offset = "0x135AEDC", VA = "0x135AEDC")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000C67")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 offset;

			[Token(Token = "0x4000C68")]
			[FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x36AD4", Offset = "0x36AD4")]
			public float additivity;

			[Token(Token = "0x4000C69")]
			[FieldOffset(Offset = "0x20")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x4000C6A")]
			[FieldOffset(Offset = "0x28")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000C6B")]
			[FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x4000C6C")]
			[FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x6000D75")]
			[Address(RVA = "0x1354780", Offset = "0x1354780", VA = "0x1354780")]
			public void Start()
			{
			}

			[Token(Token = "0x6000D76")]
			[Address(RVA = "0x13547D0", Offset = "0x13547D0", VA = "0x13547D0")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x6000D77")]
			[Address(RVA = "0x13549A0", Offset = "0x13549A0", VA = "0x13549A0")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001D8")]
		public enum Handedness
		{
			[Token(Token = "0x4000C70")]
			Right = 0,
			[Token(Token = "0x4000C71")]
			Left = 1
		}

		[Token(Token = "0x4000C50")]
		[FieldOffset(Offset = "0x30")]
		public AimIK aimIK;

		[Token(Token = "0x4000C51")]
		[FieldOffset(Offset = "0x38")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x4000C52")]
		[FieldOffset(Offset = "0x3C")]
		public Handedness handedness;

		[Token(Token = "0x4000C53")]
		[FieldOffset(Offset = "0x40")]
		public bool twoHanded;

		[Token(Token = "0x4000C54")]
		[FieldOffset(Offset = "0x48")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x4000C55")]
		[FieldOffset(Offset = "0x50")]
		public float magnitudeRandom;

		[Token(Token = "0x4000C56")]
		[FieldOffset(Offset = "0x54")]
		public Vector3 rotationRandom;

		[Token(Token = "0x4000C57")]
		[FieldOffset(Offset = "0x60")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x4000C58")]
		[FieldOffset(Offset = "0x6C")]
		public float blendTime;

		[Token(Token = "0x4000C59")]
		[FieldOffset(Offset = "0x70")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x4000C5A")]
		[FieldOffset(Offset = "0x78")]
		public Quaternion rotationOffset;

		[Token(Token = "0x4000C5B")]
		[FieldOffset(Offset = "0x88")]
		private float magnitudeMlp;

		[Token(Token = "0x4000C5C")]
		[FieldOffset(Offset = "0x8C")]
		private float endTime;

		[Token(Token = "0x4000C5D")]
		[FieldOffset(Offset = "0x90")]
		private Quaternion handRotation;

		[Token(Token = "0x4000C5E")]
		[FieldOffset(Offset = "0xA0")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x4000C5F")]
		[FieldOffset(Offset = "0xB0")]
		private Quaternion randomRotation;

		[Token(Token = "0x4000C60")]
		[FieldOffset(Offset = "0xC0")]
		private float length;

		[Token(Token = "0x4000C61")]
		[FieldOffset(Offset = "0xC4")]
		private bool initiated;

		[Token(Token = "0x4000C62")]
		[FieldOffset(Offset = "0xC8")]
		private float blendWeight;

		[Token(Token = "0x4000C63")]
		[FieldOffset(Offset = "0xCC")]
		private float w;

		[Token(Token = "0x4000C64")]
		[FieldOffset(Offset = "0xD0")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x4000C65")]
		[FieldOffset(Offset = "0xE0")]
		private bool handRotationsSet;

		[Token(Token = "0x4000C66")]
		[FieldOffset(Offset = "0xE4")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x170001B3")]
		public bool isFinished
		{
			[Token(Token = "0x6000D69")]
			[Address(RVA = "0x13D9288", Offset = "0x13D9288", VA = "0x13D9288")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001B4")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x6000D6F")]
			[Address(RVA = "0x13D9D7C", Offset = "0x13D9D7C", VA = "0x13D9D7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B5")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x6000D70")]
			[Address(RVA = "0x13D9DC4", Offset = "0x13D9DC4", VA = "0x13D9DC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B6")]
		private Transform primaryHand
		{
			[Token(Token = "0x6000D71")]
			[Address(RVA = "0x13D9D3C", Offset = "0x13D9D3C", VA = "0x13D9D3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B7")]
		private Transform secondaryHand
		{
			[Token(Token = "0x6000D72")]
			[Address(RVA = "0x13D9D5C", Offset = "0x13D9D5C", VA = "0x13D9D5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000D6A")]
		[Address(RVA = "0x13D92B8", Offset = "0x13D92B8", VA = "0x13D92B8")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x6000D6B")]
		[Address(RVA = "0x13D92E4", Offset = "0x13D92E4", VA = "0x13D92E4")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x6000D6C")]
		[Address(RVA = "0x13D9424", Offset = "0x13D9424", VA = "0x13D9424", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000D6D")]
		[Address(RVA = "0x13D9E0C", Offset = "0x13D9E0C", VA = "0x13D9E0C")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000D6E")]
		[Address(RVA = "0x13D9EC4", Offset = "0x13D9EC4", VA = "0x13D9EC4")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x6000D73")]
		[Address(RVA = "0x13D9F04", Offset = "0x13D9F04", VA = "0x13D9F04", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000D74")]
		[Address(RVA = "0x13DA0E8", Offset = "0x13DA0E8", VA = "0x13DA0E8")]
		public Recoil()
		{
		}
	}
}
