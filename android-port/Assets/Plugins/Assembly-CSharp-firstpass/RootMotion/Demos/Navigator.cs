using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

namespace RootMotion.Demos
{
	[Serializable]
	[Token(Token = "0x200025B")]
	public class Navigator
	{
		[Token(Token = "0x200025C")]
		public enum State
		{
			[Token(Token = "0x4000F8C")]
			Idle = 0,
			[Token(Token = "0x4000F8D")]
			Seeking = 1,
			[Token(Token = "0x4000F8E")]
			OnPath = 2
		}

		[Token(Token = "0x4000F7D")]
		[FieldOffset(Offset = "0x10")]
		public bool activeTargetSeeking;

		[Token(Token = "0x4000F7E")]
		[FieldOffset(Offset = "0x14")]
		public float cornerRadius;

		[Token(Token = "0x4000F7F")]
		[FieldOffset(Offset = "0x18")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x4000F80")]
		[FieldOffset(Offset = "0x1C")]
		public float maxSampleDistance;

		[Token(Token = "0x4000F81")]
		[FieldOffset(Offset = "0x20")]
		public float nextPathInterval;

		[Token(Token = "0x4000F82")]
		[FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x36EE8", Offset = "0x36EE8")]
		private Vector3 normalizedDeltaPosition__BackingField;

		[Token(Token = "0x4000F83")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x36EF8", Offset = "0x36EF8")]
		private State state__BackingField;

		[Token(Token = "0x4000F84")]
		[FieldOffset(Offset = "0x38")]
		private Transform transform;

		[Token(Token = "0x4000F85")]
		[FieldOffset(Offset = "0x40")]
		private int cornerIndex;

		[Token(Token = "0x4000F86")]
		[FieldOffset(Offset = "0x48")]
		private Vector3[] corners;

		[Token(Token = "0x4000F87")]
		[FieldOffset(Offset = "0x50")]
		private NavMeshPath path;

		[Token(Token = "0x4000F88")]
		[FieldOffset(Offset = "0x58")]
		private Vector3 lastTargetPosition;

		[Token(Token = "0x4000F89")]
		[FieldOffset(Offset = "0x64")]
		private bool initiated;

		[Token(Token = "0x4000F8A")]
		[FieldOffset(Offset = "0x68")]
		private float nextPathTime;

		[Token(Token = "0x170001E6")]
		public Vector3 normalizedDeltaPosition
		{
			[Token(Token = "0x6000F7F")]
			[Address(RVA = "0x13BA26C", Offset = "0x13BA26C", VA = "0x13BA26C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B3EC", Offset = "0x3B3EC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000F80")]
			[Address(RVA = "0x13BA278", Offset = "0x13BA278", VA = "0x13BA278")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B3FC", Offset = "0x3B3FC")]
			private set
			{
			}
		}

		[Token(Token = "0x170001E7")]
		public State state
		{
			[Token(Token = "0x6000F81")]
			[Address(RVA = "0x13BA284", Offset = "0x13BA284", VA = "0x13BA284")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B40C", Offset = "0x3B40C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000F82")]
			[Address(RVA = "0x13BA28C", Offset = "0x13BA28C", VA = "0x13BA28C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B41C", Offset = "0x3B41C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000F83")]
		[Address(RVA = "0x13BA294", Offset = "0x13BA294", VA = "0x13BA294")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000F84")]
		[Address(RVA = "0x13BA34C", Offset = "0x13BA34C", VA = "0x13BA34C")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000F85")]
		[Address(RVA = "0x13BA78C", Offset = "0x13BA78C", VA = "0x13BA78C")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000F86")]
		[Address(RVA = "0x13BA808", Offset = "0x13BA808", VA = "0x13BA808")]
		private bool Find(Vector3 targetPosition)
		{
			return default;
		}

		[Token(Token = "0x6000F87")]
		[Address(RVA = "0x13BA748", Offset = "0x13BA748", VA = "0x13BA748")]
		private void Stop()
		{
		}

		[Token(Token = "0x6000F88")]
		[Address(RVA = "0x13BA778", Offset = "0x13BA778", VA = "0x13BA778")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default;
		}

		[Token(Token = "0x6000F89")]
		[Address(RVA = "0x13BA950", Offset = "0x13BA950", VA = "0x13BA950")]
		public void Visualize()
		{
		}

		[Token(Token = "0x6000F8A")]
		[Address(RVA = "0x13BAAF8", Offset = "0x13BAAF8", VA = "0x13BAAF8")]
		public Navigator()
		{
		}
	}
}
