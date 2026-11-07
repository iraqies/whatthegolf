using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	[Token(Token = "0x2000172")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Token(Token = "0x4000947")]
		[FieldOffset(Offset = "0x88")]
		public Transform transform;

		[Token(Token = "0x4000948")]
		[FieldOffset(Offset = "0x90")]
		public Vector3 axis;

		[Token(Token = "0x4000949")]
		[FieldOffset(Offset = "0x9C")]
		public Vector3 poleAxis;

		[Token(Token = "0x400094A")]
		[FieldOffset(Offset = "0xA8")]
		public Vector3 polePosition;

		[Token(Token = "0x400094B")]
		[FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x36088", Offset = "0x36088")]
		public float poleWeight;

		[Token(Token = "0x400094C")]
		[FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x400094D")]
		[FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x360A0", Offset = "0x360A0")]
		public float clampWeight;

		[Token(Token = "0x400094E")]
		[FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x360B8", Offset = "0x360B8")]
		public int clampSmoothing;

		[Token(Token = "0x400094F")]
		[FieldOffset(Offset = "0xC8")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000950")]
		[FieldOffset(Offset = "0xD0")]
		private float step;

		[Token(Token = "0x4000951")]
		[FieldOffset(Offset = "0xD4")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x4000952")]
		[FieldOffset(Offset = "0xE0")]
		private RotationLimit transformLimit;

		[Token(Token = "0x4000953")]
		[FieldOffset(Offset = "0xE8")]
		private Transform lastTransform;

		[Token(Token = "0x17000149")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x6000A61")]
			[Address(RVA = "0x1389D58", Offset = "0x1389D58", VA = "0x1389D58")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700014A")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x6000A62")]
			[Address(RVA = "0x1389D94", Offset = "0x1389D94", VA = "0x1389D94")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700014B")]
		protected override int minBones
		{
			[Token(Token = "0x6000A65")]
			[Address(RVA = "0x138A8FC", Offset = "0x138A8FC", VA = "0x138A8FC", Slot = "12")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700014C")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x6000A69")]
			[Address(RVA = "0x138AD4C", Offset = "0x138AD4C", VA = "0x138AD4C", Slot = "15")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000A60")]
		[Address(RVA = "0x1389CC0", Offset = "0x1389CC0", VA = "0x1389CC0")]
		public float GetAngle()
		{
			return default;
		}

		[Token(Token = "0x6000A63")]
		[Address(RVA = "0x1389DD0", Offset = "0x1389DD0", VA = "0x1389DD0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000A64")]
		[Address(RVA = "0x138A030", Offset = "0x138A030", VA = "0x138A030", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000A66")]
		[Address(RVA = "0x138A848", Offset = "0x138A848", VA = "0x138A848")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000A67")]
		[Address(RVA = "0x138A598", Offset = "0x138A598", VA = "0x138A598")]
		private Vector3 GetClampedIKPosition()
		{
			return default;
		}

		[Token(Token = "0x6000A68")]
		[Address(RVA = "0x138A904", Offset = "0x138A904", VA = "0x138A904")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0x138ADC0", Offset = "0x138ADC0", VA = "0x138ADC0")]
		public IKSolverAim()
		{
		}
	}
}
