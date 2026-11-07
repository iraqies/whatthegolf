using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DanceOff
{
	[Token(Token = "0x20011F6")]
	public class IndicatorEffects : MonoBehaviour
	{
		[Token(Token = "0x20011F7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48404", Offset = "0x48404")]
		private sealed class _003C_003Ec__DisplayClass12_0
		{
			[Token(Token = "0x4006099")]
			[FieldOffset(Offset = "0x10")]
			public DanceMoveIndicator indicator;

			[Token(Token = "0x400609A")]
			[FieldOffset(Offset = "0x18")]
			public Vector3 vel;

			[Token(Token = "0x400609B")]
			[FieldOffset(Offset = "0x28")]
			public IndicatorEffects _003C_003E4__this;

			[Token(Token = "0x400609C")]
			[FieldOffset(Offset = "0x30")]
			public Vector3 gravityDir;

			[Token(Token = "0x400609D")]
			[FieldOffset(Offset = "0x3C")]
			public Vector3 rotationAxis;

			[Token(Token = "0x6005282")]
			[Address(RVA = "0x17C5AB0", Offset = "0x17C5AB0", VA = "0x17C5AB0")]
			public _003C_003Ec__DisplayClass12_0()
			{
			}

			[Token(Token = "0x6005283")]
			[Address(RVA = "0x17C5AB8", Offset = "0x17C5AB8", VA = "0x17C5AB8")]
			internal void _003CIndicatorHit_003Eb__1()
			{
			}

			[Token(Token = "0x6005284")]
			[Address(RVA = "0x17C5B38", Offset = "0x17C5B38", VA = "0x17C5B38")]
			internal void _003CIndicatorHit_003Eb__2(float t)
			{
			}

			[Token(Token = "0x6005285")]
			[Address(RVA = "0x17C5C70", Offset = "0x17C5C70", VA = "0x17C5C70")]
			internal void _003CIndicatorHit_003Eb__3()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20011F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48414", Offset = "0x48414")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x400609E")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x400609F")]
			[FieldOffset(Offset = "0x8")]
			public static Action<float> _003C_003E9__12_0;

			[Token(Token = "0x6005287")]
			[Address(RVA = "0x17C5AA4", Offset = "0x17C5AA4", VA = "0x17C5AA4")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6005288")]
			[Address(RVA = "0x17C5AAC", Offset = "0x17C5AAC", VA = "0x17C5AAC")]
			internal void _003CIndicatorHit_003Eb__12_0(float t)
			{
			}
		}

		[Token(Token = "0x400608E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform cameraTransform;

		[Token(Token = "0x400608F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AnimationCurve punchOutCurve;

		[Token(Token = "0x4006090")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AnimationCurve rotationCurve;

		[Token(Token = "0x4006091")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float rotationSpeed;

		[Token(Token = "0x4006092")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float initialVel;

		[Token(Token = "0x4006093")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float drag;

		[Token(Token = "0x4006094")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float gravity;

		[Token(Token = "0x4006095")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Vector3 leftPunchOutDir;

		[Token(Token = "0x4006096")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private Vector3 rightPunchOutDir;

		[Token(Token = "0x4006097")]
		[FieldOffset(Offset = "0x58")]
		private float duration;

		[Token(Token = "0x4006098")]
		[FieldOffset(Offset = "0x5C")]
		private float radius;

		[Token(Token = "0x600527E")]
		[Address(RVA = "0x14EC9D4", Offset = "0x14EC9D4", VA = "0x14EC9D4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600527F")]
		[Address(RVA = "0x14EC9D8", Offset = "0x14EC9D8", VA = "0x14EC9D8")]
		public void IndicatorHit(DanceMoveIndicator indicator, Vector2 dir, bool wasCorrect)
		{
		}

		[Token(Token = "0x6005280")]
		[Address(RVA = "0x14ECE54", Offset = "0x14ECE54", VA = "0x14ECE54")]
		public void IndicatorMiss(DanceMoveIndicator indicator)
		{
		}

		[Token(Token = "0x6005281")]
		[Address(RVA = "0x14ECED4", Offset = "0x14ECED4", VA = "0x14ECED4")]
		public IndicatorEffects()
		{
		}
	}
}
