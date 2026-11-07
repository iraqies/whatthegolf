using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B30")]
public class SpringBoard : MonoBehaviour
{
	[Token(Token = "0x2000B31")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43720", Offset = "0x43720")]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		[Token(Token = "0x4003E7D")]
		[FieldOffset(Offset = "0x10")]
		public SpringBoard _003C_003E4__this;

		[Token(Token = "0x4003E7E")]
		[FieldOffset(Offset = "0x18")]
		public Collider other;

		[Token(Token = "0x6003548")]
		[Address(RVA = "0x1859C00", Offset = "0x1859C00", VA = "0x1859C00")]
		public _003C_003Ec__DisplayClass14_0()
		{
		}

		[Token(Token = "0x6003549")]
		[Address(RVA = "0x1859C08", Offset = "0x1859C08", VA = "0x1859C08")]
		internal void _003COnTriggerEnter_003Eb__1()
		{
		}

		[Token(Token = "0x600354A")]
		[Address(RVA = "0x1859D64", Offset = "0x1859D64", VA = "0x1859D64")]
		internal void _003COnTriggerEnter_003Eb__2(float t)
		{
		}

		[Token(Token = "0x600354B")]
		[Address(RVA = "0x1859E7C", Offset = "0x1859E7C", VA = "0x1859E7C")]
		internal void _003COnTriggerEnter_003Eb__3(float t)
		{
		}

		[Token(Token = "0x600354C")]
		[Address(RVA = "0x1859FA8", Offset = "0x1859FA8", VA = "0x1859FA8")]
		internal void _003COnTriggerEnter_003Eb__4()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000B32")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43730", Offset = "0x43730")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4003E7F")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4003E80")]
		[FieldOffset(Offset = "0x8")]
		public static Action<float> _003C_003E9__14_0;

		[Token(Token = "0x600354E")]
		[Address(RVA = "0x1859BF4", Offset = "0x1859BF4", VA = "0x1859BF4")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x600354F")]
		[Address(RVA = "0x1859BFC", Offset = "0x1859BFC", VA = "0x1859BFC")]
		internal void _003COnTriggerEnter_003Eb__14_0(float t)
		{
		}
	}

	[Token(Token = "0x4003E70")]
	[FieldOffset(Offset = "0x18")]
	public Rigidbody Spring;

	[Token(Token = "0x4003E71")]
	[FieldOffset(Offset = "0x20")]
	public List<string> AffectTags;

	[Token(Token = "0x4003E72")]
	[FieldOffset(Offset = "0x28")]
	public float SpringDelay;

	[Token(Token = "0x4003E73")]
	[FieldOffset(Offset = "0x2C")]
	public float SpringDuration;

	[Token(Token = "0x4003E74")]
	[FieldOffset(Offset = "0x30")]
	public float SpringHeight;

	[Token(Token = "0x4003E75")]
	[FieldOffset(Offset = "0x34")]
	public float RetractionTime;

	[Token(Token = "0x4003E76")]
	[FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x50888", Offset = "0x50888")]
	public float SpringAngle;

	[Token(Token = "0x4003E77")]
	[FieldOffset(Offset = "0x40")]
	public List<AudioClip> SpringClips;

	[Token(Token = "0x4003E78")]
	[FieldOffset(Offset = "0x48")]
	private bool hasSprung;

	[Token(Token = "0x4003E79")]
	[FieldOffset(Offset = "0x4C")]
	private Vector3 startPos;

	[Token(Token = "0x4003E7A")]
	[FieldOffset(Offset = "0x58")]
	private Quaternion startRot;

	[Token(Token = "0x4003E7B")]
	[FieldOffset(Offset = "0x68")]
	private Quaternion targetRot;

	[Token(Token = "0x4003E7C")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private float ForceMultiplier;

	[Token(Token = "0x6003544")]
	[Address(RVA = "0x16D92C4", Offset = "0x16D92C4", VA = "0x16D92C4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003545")]
	[Address(RVA = "0x16D93AC", Offset = "0x16D93AC", VA = "0x16D93AC")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6003546")]
	[Address(RVA = "0x16D96F4", Offset = "0x16D96F4", VA = "0x16D96F4")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6003547")]
	[Address(RVA = "0x16D9868", Offset = "0x16D9868", VA = "0x16D9868")]
	public SpringBoard()
	{
	}
}
