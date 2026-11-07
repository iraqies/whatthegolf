using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x20013CB")]
	public class AudioValueGrounded : BaseAudioValue
	{
		[Serializable]
		[Token(Token = "0x20013CC")]
		public class Direction
		{
			[Token(Token = "0x4006A6B")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 direction;

			[Token(Token = "0x4006A6C")]
			[FieldOffset(Offset = "0x1C")]
			public bool localAxis;

			[Token(Token = "0x6005C60")]
			[Address(RVA = "0x17703A0", Offset = "0x17703A0", VA = "0x17703A0")]
			public Vector3 GetDirection(Transform transform)
			{
				return default;
			}

			[Token(Token = "0x6005C61")]
			[Address(RVA = "0x1770458", Offset = "0x1770458", VA = "0x1770458")]
			public Direction()
			{
			}
		}

		[Token(Token = "0x4006A63")]
		[FieldOffset(Offset = "0x38")]
		public Transform relativeTransform;

		[Token(Token = "0x4006A64")]
		[FieldOffset(Offset = "0x40")]
		public Transform[] checkTransforms;

		[Token(Token = "0x4006A65")]
		[FieldOffset(Offset = "0x48")]
		public Direction[] directions;

		[Token(Token = "0x4006A66")]
		[FieldOffset(Offset = "0x50")]
		public bool check2DColliders;

		[Token(Token = "0x4006A67")]
		[FieldOffset(Offset = "0x54")]
		public float distanceToGround;

		[Token(Token = "0x4006A68")]
		[FieldOffset(Offset = "0x58")]
		public LayerMask layermask;

		[Token(Token = "0x4006A69")]
		[FieldOffset(Offset = "0x5C")]
		public float raycastFrequency;

		[Token(Token = "0x4006A6A")]
		[FieldOffset(Offset = "0x60")]
		private float nextCheckTime;

		[Token(Token = "0x17000A6F")]
		protected override bool Use2D
		{
			[Token(Token = "0x6005C59")]
			[Address(RVA = "0x150F70C", Offset = "0x150F70C", VA = "0x150F70C", Slot = "6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000A70")]
		private float cooldown
		{
			[Token(Token = "0x6005C5A")]
			[Address(RVA = "0x150F714", Offset = "0x150F714", VA = "0x150F714")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6005C5B")]
		[Address(RVA = "0x150F724", Offset = "0x150F724", VA = "0x150F724")]
		private void Update()
		{
		}

		[Token(Token = "0x6005C5C")]
		[Address(RVA = "0x150F73C", Offset = "0x150F73C", VA = "0x150F73C", Slot = "4")]
		public override string ValueInputName()
		{
			return null;
		}

		[Token(Token = "0x6005C5D")]
		[Address(RVA = "0x150F89C", Offset = "0x150F89C", VA = "0x150F89C", Slot = "7")]
		protected override void SetValue()
		{
		}

		[Token(Token = "0x6005C5E")]
		[Address(RVA = "0x150F900", Offset = "0x150F900", VA = "0x150F900")]
		private bool Grounded()
		{
			return default;
		}

		[Token(Token = "0x6005C5F")]
		[Address(RVA = "0x150FC4C", Offset = "0x150FC4C", VA = "0x150FC4C")]
		public AudioValueGrounded()
		{
		}
	}
}
